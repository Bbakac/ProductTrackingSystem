# ProductTrackingSystem

ProductTrackingSystem is a web application built using ASP.NET Core MVC to manage product tracking and inventory. The application allows users to perform CRUD operations on products and categories, and it uses SQLite as the database provider.

## Features

- Product management (Create, Read, Update, Delete)
- Category management
- Product photo upload
- Entity Framework Core with SQLite
- ASP.NET Core MVC for web interface

## Requirements

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Visual Studio Code](https://code.visualstudio.com/)
- SQLite

## Setup

1. **Create the project:**
    ```sh
    dotnet new mvc -n ProductTrackingSystem
    cd ProductTrackingSystem
    code .
    ```

2. **Install compatible packages:**
    ```sh
    dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 6.0.0
    dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0.0
    ```

3. **Update the database:**
    Apply the initial migration to create the database schema.
    ```sh
    dotnet ef migrations add InitialCreate
    dotnet ef database update
    ```

4. **Seed the database:**
    Add seed data to the database.
    ```sh
    dotnet ef migrations add SeedData
    dotnet ef database update
    ```

5. **Run the application:**
    Start the application using the following command.
    ```sh
    dotnet run
    ```

6. **Open the application:**
    Navigate to `https://localhost:5001` in your browser to see the running application.

## Useful Commands

- **Add a new migration:**
    ```sh
    dotnet ef migrations add MigrationName
    ```

- **Update the database:**
    ```sh
    dotnet ef database update
    ```

- **Drop the database:**
    If you need to recreate the database from scratch, you can drop the existing database. This will delete all your data but provides a clean start.
    ```sh
    dotnet ef database drop
    dotnet ef database update
    ```

- **Run the application:**
    ```sh
    dotnet run
    ```

## Project Structure

- **Controllers:**
  - `HomeController.cs`: Manages the home page and error handling.
  - `ProductsController.cs`: Manages CRUD operations for products.

- **Models:**
  - `Product.cs`: Represents a product entity.
  - `Category.cs`: Represents a category entity.
  - `ErrorViewModel.cs`: Represents error information for the error view.

- **Views:**
  - `Home`: Contains views for the home page and privacy page.
  - `Products`: Contains views for product operations such as create, edit, delete, and details.

- **Data:**
  - `ProductTrackingContext.cs`: Represents the Entity Framework Core database context.

## Configuration

- **Database Configuration:**
  The application uses SQLite as the database provider. The connection string is configured in the `appsettings.json` file.

  ```json
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=ProductTrackingSystem.db"
  }
