# 📚 Library Management System (C#)

A Command-Line Interface (CLI) library management system built with **C# and .NET 10**. This project was developed as part of a continuous learning challenge ("C# Hero Roadmap 56 Days" - Week 2, Day 14) to consolidate Object-Oriented Programming (OOP) concepts.

## 🚀 Features
- **List Books:** View the entire library catalog along with availability status and publication details.
- **Add Book:** Input the title, author, and publication year to add new books to the system.
- **Remove Book:** Delete books from the registry using their unique ID.
- **Borrow Book:** Search for a book and, if available, mark it as "checked out".
- **Return Book:** Mark a checked-out book as "available" back in the inventory.

## 🛠️ Technologies Used
- **Language:** C#
- **Framework:** .NET 10.0
- **Paradigm:** Object-Oriented Programming (OOP)

## 📂 Code Structure
- `Program.cs`: Handles the main UI loop, clearing the console, and processing menu inputs via `switch` statements.
- `Library.cs`: Manages menus and acts as a bridge for user interactions like borrowing and returning books.
- `Book.cs`: The core class defining book properties (Title, Author, Year, Status) and managing the generic `List<Book>` logic for in-memory storage during execution.

## ⚙️ How to Run
Make sure you have the [.NET 10 SDK](https://dotnet.microsoft.com/download) installed.

1. Clone this repository or download the source code.
2. Open a terminal (or command prompt) and navigate to the project's root folder (where the `LibrarySystem.csproj` file is located).
3. Run the following command to build and start the application:
   ```bash
   dotnet run
   ```

## 🧠 Key Learnings
- Using `List<T>` for in-memory data storage.
- Auto-properties and object state management (`Available`).
- Clean console menu interactions using `Console.Clear()` and `Console.ReadLine()`.
- Validation logic to prevent concurrent modification exceptions in `foreach` loops.
