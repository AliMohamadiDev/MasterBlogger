# MasterBlogger

A blogging web application implemented with **Onion Architecture** to enforce clear separation of concerns and maintainability.

## Features

- Full CRUD operations for blog posts and categories  
- Comment management system for posts  
- User authentication and role-based access (Admin vs. Reader)  

## Architecture & Design

### Follows **Onion Architecture** with layered separation:  
  - **Domain**: Entities and domain logic  
  - **Application**: Service interfaces and business rules  
  - **Infrastructure**: EF Core data access and query implementations  
  - **Presentation**: ASP.NET Core Razor Pages MVC UI  


## Technologies

- ASP.NET Core (Razor Pages MVC)  
- .NET 6  
- Entity Framework Core  
- SQL Server

## Getting Started

1. Clone the repository:  
   ```bash
   git clone https://github.com/AliMohamadiDev/MasterBlogger.git
   ```
2. Open the solution in Visual Studio or VS Code

3. Restore and build:
    ```
    dotnet restore
    dotnet build
    ```

4. Apply EF migrations (from MB.Infrastructure.EFCore project):
    ```
    dotnet ef database update
    ```
5. Run the Presentation project (MB.Presentation.MVCCore):
    ```
    cd MB.Presentation.MVCCore
    dotnet run
    ```
