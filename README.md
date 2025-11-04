KusinApp
A Smart Recipe Management System for Sustainable Filipino Cooking

-Overview

KusinApp is a desktop-based application developed to assist users in managing personal recipes while promoting sustainable cooking practices. The system allows users to register, log in, create, edit, and delete their own recipes. It aims to help individuals plan healthier meals, reduce food waste, and preserve Filipino culinary culture. The app also demonstrates how various programming paradigms—Object-Oriented, Imperative, Functional, and Logic—can be integrated within a single software system.

-Features

User Authentication – Secure registration and login functionality.
Personal Recipe Management – Add, view, and delete personal recipes stored in a MySQL database.
Search and Filter – Quickly find recipes by title or keyword.
AI Integration (Optional) – Provides intelligent suggestions for recipes or ingredients.
Persistent Storage – Recipes are stored and retrieved through a MySQL database connection.
User-Friendly Interface – Built with Windows Forms for simplicity and accessibility.
Programming Paradigms

-Object-Oriented Programming (OOP)
The application is structured using classes such as LoginPage, PersonalRecipe, SQLHelper, and MainPage, each encapsulating related data and methods. This modularity allows for better maintainability, reusability, and scalability. By employing encapsulation and object interaction, the system models real-world entities like users and recipes through class objects.

-Imperative Programming
KusinApp employs an imperative approach by defining clear, step-by-step instructions for the computer to follow. For example, connecting to the database, executing SQL queries, and displaying the results on the user interface all follow explicit control flow commands. Each function specifies the exact order of operations, reflecting the traditional procedural style of programming.

-Functional Programming
While KusinApp is primarily object-oriented, it also makes limited use of functional programming principles. The application employs functions such as .Trim() for data sanitization. These function-based operations promote cleaner and more readable code, even though functional programming is not the dominant paradigm in the project.

-Logic Programming
The logic paradigm is demonstrated through the use of SQL queries, which define what data to retrieve or manipulate instead of how to perform the operation. By writing queries like SELECT, INSERT, DELETE, and UPDATE, the application declaratively specifies conditions and results, allowing the database management system to determine the execution strategy. This aligns with the declarative nature of logic programming.

-Project Structure
KusinApp/
│
├── SQLHelper.cs           # Handles all database interactions
├── aiHelper.cs            # Handles all AI usage interactions
├── LoginPage.cs           # User login and registration interface
├── PersonalRecipe.cs      # Core form for managing personal recipes
├── MainPage.cs            # Navigation and app control
├── RecipeDisplay.cs       # Displaying recipe details
├── Inventory.cs           # Displaying ingredient details
├── .env                   # Environment variables (AI API, DB CONNECTION STRING)
├── KusinApp.sln           # Visual Studio solution file
└── README.md              # Project documentation

-Significance of the Study

KusinApp serves as a modern solution to common kitchen challenges while preserving Filipino food culture. It promotes sustainability by helping users manage ingredients efficiently and plan meals mindfully. The system encourages healthier eating habits and empowers users to enhance their culinary skills through technology. Moreover, it demonstrates how computer science principles and AI integration can be applied to solve everyday household problems, fostering innovation in digital domestic solutions.
