Here is the step-by-step guide for setting up a new ASP.NET Core project with Entity Framework Core and SQL Server:

Step 1: Open a New Project

        Open Visual Studio.
        
        Go to File > New > Project.
        
        Select ASP.NET Core Web Application.
        
        Choose a suitable name and location for your project, then click Create.
        
        Select the project template (e.g., Web Application), and click Create.

Step 2: Install Required Packages

        You need to install the following NuGet packages for SQL Server and Entity Framework Core:
        
        Open the Package Manager Console (Tools > NuGet Package Manager > Package Manager Console).
        
        Run the following commands one by one:

          Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 8.0.1  
          
          Install-Package Microsoft.EntityFrameworkCore.Tools -Version 8.0.0  
          
          Install-Package Microsoft.EntityFrameworkCore.Design -Version 8.0.0  
  
  
Step 3: Create Connection String in appsettings.json

        Open the appsettings.json file in your project.
        
        Add a new section for your connection string under the existing configuration
        
          {
          
            "ConnectionStrings": {
            
               "InventoryDb": "Server=DESKTOP-
                 
    4BMGUC1\\SQLEXPRESS;Database=inventoryManagement;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;"
               
            }
            
            // Other configurations...
            
          }

          

Step 4: Create DbContext

        Create a new class file (e.g., AppDbContext.cs) in your Models folder (or wherever appropriate).
        
        Define your DbContext class as follows
        
        using Microsoft.EntityFrameworkCore;  
        
        
        public class inventoryDbContext: DbContext  
        
        {  
        
            public inventoryDbContext(inventoryDbContextOptions<inventoryDbContext> options) : base(options) { }  
            
            // Define DbSet for your entities  
            
            public DbSet<YourEntity> YourEntities { get; set; } // Replace with your model  
            
        }  


Step 5: Configure Services in Program.cs

        Open the Program.cs file.
        
        Configure the services to use your DbContext by adding the following code:
        
        
        using Microsoft.EntityFrameworkCore;  
        
        var builder = WebApplication.CreateBuilder(args);  
        
        // Add services to the container.  
        
        builder.Services.inventoryDbContext<inventoryDbContext>(options =>  
        
            options.UseSqlServer(builder.Configuration.GetConnectionString("InventoryDb")));  
            
        // Other services...  


Step 6: Create Model (Entity)

        Create a new class file (e.g., YourEntity.cs) in the Models folder.

Step 7: Create DbSet for New Models

        If you want to create a new model:
        
        Open your AppDbContext class.
        
        Add a new DbSet property for your new entity


Step 8: Run Migration for Code First

        Open the Package Manager Console.
        
        Run the following commands to add and apply the migration:
        
        Add-Migration InitialCreate // Replace "InitialCreate" with a descriptive name for your migration  
        
        Update-Database  


-------------------------------------------------X------------------------------------------------

1. Tittle: BasicInventoryManagementSystem

2. Table of content
   
   i) Executive Summary
   
   ii) Introduction
   
   iii) Project Objectives
   
   iv) System Overview
   
   v) Database Design
   
   vi) Functional Requirements
   
   vii) User Interface Design
   
   viii) Implementation Plan
   
   ix) Testing and Deployment plan
   
   x) Conclusion
   


3. Executive Summary
   
   The Basic Inventory Management System is designed to facilitate efficient management of inventory through a web-based application.
   The system allows users to register, log in, and manage product categories and products with essential CRUD (Create, Read, Update, 
   Delete) functionalities. This project aims to streamline inventory processes, enhancing user experience and operational efficiency.

4. Introduction
   
   The Basic Inventory Management System is designed to help businesses manage their inventory easily and efficiently. This project aims 
   to create a simple, user-friendly application that allows users to register, log in, and manage their inventory without hassle. It 
   makes it easy to keep track of products, monitor stock levels, and handle orders, ensuring smooth operations for the business.

5. Project Objectives
   
   i) Implement a secure registration and login system for users.
   
   ii) Provide functionalities for managing product categories and products.
   
   iii) Enable users to perform CRUD operations on both product categories and products.
   
   iv) Ensure data integrity and security throughout the application.
   

6. System Overview
   
   The system architecture consists of three main components:
   
      i) Presentation Layer: Handles user interaction through web pages.
   
      ii) Service Layer: Contains business logic for processing requests.
   
      iii) Data Access Layer: Interacts with the database to manage data retrieval and storage.
   

7. Database Design
   
   The database for the Basic Inventory Management System consists of three tables:
   
      i) Registration Table
   
          Fields:
   
            ID (Primary Key, Auto-increment)
   
            FirstName (VARCHAR)
   
            LasttName (VARCHAR)
   
            Email (VARCHAR, Unique)
   
            Password (VARCHAR)
   
            PhoneNumber(VARCHAR)
   
            DateOfBirth(DateTime)
   
      ii) Product Category Table
   
          Fields:
   
            ProductCatagoryId (Primary Key, HashCode)
   
            Name (VARCHAR)
   
            IsActive (VARCHAR)
   
            CreatedAt(DateTime)
   
            UpdatedAt(DateTime)
   
      iii) Product Table
   
          Fields:
   
            ID (Primary Key, Auto-increment)
   
            ProductCategoryId(Foreign Key referencing ProductCategory)
            
            Price (DECIMAL)
   
            Description(VARCHAR)
   
            StockQuantity(int)
   
            CreatedAt()
   
            UpdatedAt()
   
     Relation those three tables are: Registration -----> Product Category -------> Product
   
   

8. Functional Requirements
   
   i) User Registration:
   
      Users can create an account by providing their name, email, phone number, date of birth and password.
   
      Validation to ensure unique email addresses.
   
   
   ii) User Login:
   
       Users can log in using their email and password.
   
       The system checks credentials against the Registration table.
   
      
   iii) Product Category Management:
   
        Users can add new product categories.
   
        Users can update existing categories.
   
        Users can delete categories that are no longer needed.
   
        Users can view all product categories.
   
   iv) Product Management:
   
       Users can add products associated with specific categories.
   
       Users can update product details.
   
       Users can delete products from the inventory.
   
       Users can view all products under each category.
   

9. User Interface Design
    
     i) Registration Page:
     
        Fields for FirstName, LastName, Email, Password, Confirm Password, PhoneNumber and DateOfBirth.
     
        Submit button to register.
     
     ii) Login Page:
    
          Fields for Email and Password.
          
          Login button to authenticate users.
          
          Register button for registration.
      
    iii) Product Category Management:
  
        List view of categories with options to add, edit, or delete.
      
    iv) Product Management:
  
        List view of products with options to add, edit, or delete.
      

10. Implementation Plan
    
    i) Technologies Used:
    
        ASP.NET Core for backend development.
    
        NHibernate for data access and ORM (Object-Relational Mapping).
    
        HTML, CSS, JavaScript, JQuery and Ajax for frontend development.
    

11. Testing and Deployment plan
    
    i) Integration Testing: Test interactions between various components (user registration and product management).
    
    ii) Deployment Steps:
    
        Publish the application from Visual Studio.
    
        Set up the database on the server.
    
        Configure IIS(Internet Information Service) to host the application.
    

12. Conclusion
    
    The Basic Inventory Management System provides a robust solution for managing inventory efficiently. With user registration, login, 
    and comprehensive product management capabilities, the system enhances operational effectiveness. Future enhancements could include 
    advanced reporting features, inventory tracking, and integration with external systems.





    

