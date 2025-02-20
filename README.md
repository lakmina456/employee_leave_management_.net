# Employee Leave Management System

## Overview

The Employee Leave Management System is a Windows Forms application designed to manage employee leave records. It provides functionalities to retrieve, update, and execute SQL queries on a local database.

## Features

- Retrieve data from the database.
- Update data in the database.
- Execute scalar queries.
- User-friendly Windows Forms interface.

## Prerequisites

- Visual Studio 2022
- .NET 8.0 SDK
- SQL Server LocalDB

## Getting Started

### Clone the Repository


### Open the Project

1. Open Visual Studio 2022.
2. Select `File` -> `Open` -> `Project/Solution`.
3. Navigate to the cloned repository and select `Employee_Leave.sln`.

### Build and Run

1. Build the solution by selecting `Build` -> `Build Solution`.
2. Run the application by pressing `F5` or selecting `Debug` -> `Start Debugging`.

## Project Structure

- **Employee_Leave/Functions.cs**: Contains the `Functions` class for database operations.
- **Employee_Leave/Program.cs**: The main entry point for the application.
- **Employee_Leave/Employee_Leave.csproj**: Project file with configuration and dependencies.

## Database Configuration

The application uses a local SQL Server database. Ensure the database file `EmpLeave.mdf` is located at `C:\Users\Isuru Lakmina\Documents\`.

## Usage

### Functions Class

- **GetData(string Query)**: Retrieves data from the database based on the provided SQL query.
- **SetData(string Query)**: Updates data in the database based on the provided SQL query.
- **ExecuteQuery(string Query)**: Executes a scalar query and returns the result.

### Main Entry Point

The `Program.cs` file initializes the application and runs the `Login` form.


## Dependencies

- `System.Data.SqlClient` (Version 4.9.0)

## Contributing

Contributions are welcome! Please fork the repository and submit a pull request.

## License

This project is licensed under the MIT License.