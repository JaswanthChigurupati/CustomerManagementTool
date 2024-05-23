# Customer Management Tool

This repository contains two projects: an API project (`CustomerManagement.Api`) and a WebApp project (`CustomerManagement.WebApp`) for managing customers. The API provides endpoints for CRUD operations, and the WebApp is a front-end interface for interacting with the API.

## Projects

### CustomerManagement.Api

The API project is built using ASP.NET Core and provides the following endpoints:
- `GET /api/Customer`
- `POST /api/Customer`
- `GET /api/Customer/{id}`
- `PUT /api/Customer/{id}`
- `DELETE /api/Customer/{id}`

![Swagger API](https://github.com/JaswanthChigurupati/CustomerManagementTool/blob/main/images/api_swagger.png)

### CustomerManagement.WebApp

The WebApp project is built using ASP.NET Razor Pages and provides a user interface for managing customers.

![Customer List](https://github.com/JaswanthChigurupati/CustomerManagementTool/blob/main/images/webapp_customer_list.png)
![Create Customer](https://github.com/JaswanthChigurupati/CustomerManagementTool/blob/main/images/webapp_create_customer.png)
![Edit Customer](https://github.com/JaswanthChigurupati/CustomerManagementTool/blob/main/images/webapp_edit_customer.png)
![Delete Customer](https://github.com/JaswanthChigurupati/CustomerManagementTool/blob/main/images/webapp_delete_customer.png)

## Prerequisites

- .NET 8.0 SDK
- Visual Studio 2022 (or any IDE that supports .NET 8.0)
- SQL Server

## Setup

### Clone the Repository

```sh
git clone https://github.com/JaswanthChigurupati/CustomerManagementTool.git
cd CustomerManagementTool
```

### Configure the API
1. Navigate to the CustomerManagement.Api project.
2. Update the appsettings.json with your SQL Server connection string.
3. Run the following commands to apply migrations and start the API:
```sh
cd CustomerManagement.Api
dotnet ef migrations add InitialCreate
dotnet ef database update
dotnet run 
```

### Configure the WebApp
1. Navigate to the CustomerManagement.WebApp project.
2. Ensure the appsettings.json points to the API URL.
3. Run the project:
```sh
cd ../CustomerManagement.WebApp
dotnet run
```
### Running Together

To run both projects together, you can use multiple terminal windows or configure them to run simultaneously in your IDE.

1. Start the API:
```sh
cd CustomerManagement.Api
dotnet run
```
2. Start the WebApp:
```sh
cd ../CustomerManagement.WebApp
dotnet run
```

### Using the Application
1. Navigate to the WebApp URL, typically https://localhost:44376.
2. Use the interface to create, edit, and delete customers. 

