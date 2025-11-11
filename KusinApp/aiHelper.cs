
using DotNetEnv;
using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace KusinApp
{
    internal class aiHelper
    {
        private readonly string apiKey;
        private static readonly HttpClient client = new HttpClient();
        private SQLHelper sqlHelper = new SQLHelper();
        LoginPage login = new LoginPage();

        public aiHelper()
        {
            Env.Load();
            apiKey = Environment.GetEnvironmentVariable("key");
            //MessageBox.Show("API Key loaded: " + (string.IsNullOrEmpty(apiKey) ? "No" : "Yes"));
        }

        public async Task<string> GetRecipeSuggestionAI(string availableIngredients)
        {

            string query = "SELECT recipe_name, recipe_ingredient_list FROM kusinapp.recipe_list";
            DataTable dt = sqlHelper.displayRecords(query);

            if (dt.Rows.Count == 0)
            {
                return "No recipes found in the database.";
            }

            var recipes = string.Join("\n", dt.AsEnumerable().Select(row => $"- {row["recipe_name"]}: {row["recipe_ingredient_list"]}"));

            //Debugging info
            //MessageBox.Show(
            //$"=== DEBUG ===\n\nAvailable Ingredients:\n{availableIngredients}\n\nRecipes:\n{recipes.Substring(0, Math.Min(recipes.Length, 1000))}...",
            //"AI Debug Info");


            string prompt =
                $"Here are the recipes from my database:\n{recipes}\n\n" +
                $"Given these available ingredients: {availableIngredients}, " +
                $"suggest up to 6 recipes from the database that can be fully made or are close matches. " +
                $"List the best matches first. Respond only with the recipe names.";

            string endpoint = "https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash:generateContent";
            var requestBody = new
            {
                contents = new[]
                {
                    new
                    {
                        parts = new[]
                        {
                            new { text = prompt }
                        }
                    }
                }
            };

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(requestBody);

            using (var request = new HttpRequestMessage(HttpMethod.Post, endpoint))
            {
                // Add your Gemini API key to the request header
                request.Headers.Add("X-goog-api-key", apiKey); //Works if actual apiKey is used

                // Attach the JSON request body
                request.Content = new StringContent(json, Encoding.UTF8, "application/json");

                // Send request
                var response = await client.SendAsync(request);
                string result = await response.Content.ReadAsStringAsync();

                // Debugging output
                //MessageBox.Show(result, "Gemini Raw Response");

                //  Gemini response
                JObject parsed = JObject.Parse(result);
                string suggestion = parsed["candidates"]?[0]?["content"]?["parts"]?[0]?["text"]?.ToString();

                return suggestion ?? "No suggestions found.";
            }
        }

        public async void aiSuggest(ListView listView)
        {
            try
            {
                int currentUserID = int.Parse(login.GetID());

                //get user id, ingredient name, and ingredient quantity from inventory;
                string invQuery = $"SELECT ingredient_name, ingredient_quantity FROM kusinapp.user_inventory WHERE user_id = {currentUserID}";
                DataTable dt = sqlHelper.displayRecords(invQuery); //puts inventory data into datatable

                List<string> userRecipeIngredients = new List<string>();

                foreach (DataRow row in dt.Rows)
                {
                    string ingredientName = row["ingredient_name"].ToString();
                    string ingredientQuantity = row["ingredient_quantity"].ToString();
                    userRecipeIngredients.Add($"{ingredientName} : {ingredientQuantity}");
                }

                string availableIngredients = string.Join(", ", userRecipeIngredients);

                string result = await GetRecipeSuggestionAI(availableIngredients);

                listView.BeginUpdate();
                listView.Items.Clear();

                listView.View = View.List;
                listView.Scrollable = true;
                listView.AutoArrange = false;
                listView.MultiSelect = false;

                // add the AI results line-by-line
                foreach (string line in result.Split('\n'))
                {
                    if (!string.IsNullOrWhiteSpace(line))
                        listView.Items.Add(line.Trim());
                }

                listView.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting AI recipe suggestions: " + ex.Message);
            }
        }
    }
}
