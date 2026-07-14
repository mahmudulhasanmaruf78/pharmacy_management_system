# Pharmacy Management System

A Windows Forms desktop application for managing a pharmacy system with admin, cashier, and customer roles.

## Features
- Admin dashboard for managing users, categories, products, and transactions
- Cashier panel for handling orders and transaction records
- Customer registration and login flow
- SQL Server-backed data storage

## Project Structure
- `Form1.cs` - Admin dashboard UI
- `Cashier.cs` - Cashier dashboard UI
- `Loginform.cs` - Login screen
- `signInform.cs` - Sign-up screen
- `adminadduser.cs` - User management
- `adminproduct.cs` - Product management
- `adminaddcategoris.cs` - Category management
- `cashierorder.cs` - Cashier order processing
- `customar.cs` - Customer view
- `pharmacy_management_system.bacpac` - SQL Server database backup file

## Requirements
- Windows OS
- Visual Studio 2019/2022 with .NET desktop development workload
- SQL Server (Express or full version)
- SQL Server Management Studio (optional but recommended)

## Database Setup
This project uses SQL Server. The database backup file is included as:
- `pharmacy_management_system.bacpac`

### Import the database
1. Open SQL Server Management Studio.
2. Connect to your SQL Server instance.
3. Right-click on `Databases` and choose `Import Data-tier Application...`.
4. Select the `.bacpac` file from the project folder.
5. Choose a database name, for example:
   - `pharmacy_management_system`
6. Complete the import.

### Connection string
The application uses a SQL Server connection string in the code and configuration files. If your machine uses a different SQL Server instance name, update the connection string accordingly.

Example:
```text
Data Source=YOUR_SQL_SERVER_NAME;Initial Catalog=pharmacy_management_system;Integrated Security=True;
```

## Running the Project
1. Open `pharmacy_management_system.sln` in Visual Studio.
2. Restore NuGet packages if prompted.
3. Build the solution.
4. Run the application.

## Default Login Notes
After importing the database, you can sign in using the user data stored in the database tables. If no user exists yet, create one through the signup form.

## Notes
- The project targets `.NET Framework 4.7.2`.
- If you see a connection error, verify that SQL Server is running and that the connection string matches your local server name.
