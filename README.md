# Library System

A console-based library management application built with C# and .NET. The project demonstrates fundamental object-oriented programming concepts through a simple interactive system for managing books, members, borrowing, and returns.

## Features

- Interactive console menu controlled with the arrow keys
- Add books to the library catalogue
- Register library members
- Display all books
- Display all registered members
- Borrow available books
- Return borrowed books
- Track whether a book is available or currently borrowed
- Basic exception handling for invalid input

## Technologies

- C#
- .NET 10
- Console application
- `List<T>` collections
- Object-oriented programming

The project currently uses standard loops and conditional statements rather than LINQ.

## Project Structure

```text
LibrarySystem/
├── Menus/
│   └── Menu.cs
├── Models/
│   ├── Book.cs
│   └── Member.cs
├── Services/
│   └── LibraryService.cs
├── Program.cs
└── LibrarySystem.csproj
```

### Main components

- **`Program.cs`** — Starts the application and handles the main menu options.
- **`Menu.cs`** — Displays the interactive menu and processes keyboard navigation.
- **`Book.cs`** — Defines book data and contains book creation and listing operations.
- **`Member.cs`** — Defines member data and contains member registration and listing operations.
- **`LibraryService.cs`** — Contains the borrowing and returning logic.

## Requirements

To build and run the application, install:

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- A terminal or an IDE such as Visual Studio, Visual Studio Code, or JetBrains Rider

## Installation

Clone the repository:

```bash
git clone https://github.com/YOUR-USERNAME/LibrarySystem.git
```

Open the project directory:

```bash
cd LibrarySystem/LibrarySystem
```

Restore the project dependencies:

```bash
dotnet restore
```

Build the application:

```bash
dotnet build
```

Run it:

```bash
dotnet run
```

## How to Use

Use the **Up Arrow** and **Down Arrow** keys to move through the menu. Press **Enter** to select an option.

The available menu options are:

1. Add Book
2. Add Member
3. List Books
4. List Members
5. Borrow Book
6. Return Book
7. Exit

### Example book entry

```text
What is the name of the book?: The Hobbit
What is the name of the author?: J.R.R. Tolkien
What is the year of publication?: 1937
Book added successfully!
```

### Example catalogue output

```text
1 | The Hobbit by J.R.R. Tolkien
2 | 1984 by George Orwell
```

## Data Storage

The application currently stores books and members in memory using `List<T>` collections. Data is reset whenever the program is closed.

No database or external file storage is currently used.

## Current Limitations

- Borrowed books are not yet associated with a specific member.
- Data is not saved between application sessions.
- Input validation can be expanded further.
- The application does not currently support deleting or editing books and members.
- There are no due dates, borrowing limits, or overdue penalties.

## Planned Improvements

- Associate every borrowed book with a registered member
- Display which member currently has each borrowed book
- Validate book and member IDs before completing an operation
- Replace `int.Parse` with `int.TryParse` where appropriate
- Add due dates and loan history
- Allow books and members to be edited or removed
- Save data to JSON files or a database
- Add automated unit tests

## Learning Objectives

This project was created to practise:

- Classes and objects
- Constructors and properties
- Static members
- Lists and iteration
- Conditional logic
- Exception handling
- Separation of responsibilities
- Console input and output
- Basic application architecture

## Contributing

This is a learning project, but suggestions and improvements are welcome. Feel free to fork the repository and open a pull request.

## License

This project is available for educational purposes. Add a licence file if you plan to distribute or reuse it publicly.
