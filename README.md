

# MovieApp

MovieApp is a web application built using **ASP.NET Core MVC** and **Entity Framework Core**. The app allows users to view, create, edit, and delete movies from a database. It's a demonstration of building a CRUD (Create, Read, Update, Delete) application with ASP.NET Core.

## Features

- View a list of movies.
- Create new movies by filling out a form.
- Edit existing movies.
- Delete movies.
- Search for movies based on title or genre.
- Simple user interface with basic navigation.

## Technologies Used

- **ASP.NET Core MVC**: The main framework for building the application.
- **Entity Framework Core**: Used for database operations and migrations.
- **SQL Server**: The relational database used to store movie data.
- **Bootstrap**: For styling the UI.

## Prerequisites

- **.NET 6.0 SDK or later** installed.
- **SQL Server** installed and running.
- **Visual Studio 2022** (or any IDE that supports .NET Core development).

## Setup Instructions

### 1. Clone the Repository
To get started, clone this repository to your local machine:
```bash
git clone https://github.com/yourusername/MovieApp.git
cd MovieApp
```

### 2. Set up the Database
Update your connection string in the `appsettings.json` file:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=ADMINISTRATOR;Database=MovieAppDb;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```

Run the following command to apply database migrations and create the database:
```bash
dotnet ef database update
```

### 3. Build and Run the App
Use the following commands to build and run the application:
```bash
dotnet build
dotnet run
```

The app will be available at `https://localhost:5001` (or as configured).

## Usage

- Navigate to the **Movies** section to see the list of movies.
- Use the **Create New** button to add a new movie.
- Click **Edit** or **Delete** to modify or remove existing movies.
- Search for movies by entering the title or genre in the search bar.

## Project Structure

- **Controllers/MovieController.cs**: Handles requests for viewing, adding, editing, and deleting movies.
- **Models/Movie.cs**: Represents the movie entity.
- **Views/Movie**: Contains Razor views for displaying the movies.
- **Data/MovieContext.cs**: Handles database context and interactions.

## License

This project is open-source and available under the [MIT License](LICENSE).

