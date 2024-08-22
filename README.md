OCPP Server
==========

Getting Started
---------------

This repository contains the OCPP Server, a .NET Core application implementing the OCPP 2.0.1 protocol.

### Prerequisites

* .NET Core 3.1 or later

### Running the Application

1. Install .NET Core: `sudo apt-get update && sudo apt-get install dotnet-sdk-3.1`
2. Run the application: `dotnet run`

### Configuration

The application configuration is stored in [appsettings.json](appsettings.json). You can modify this file to change the application settings.

### Database

The application uses a SQLite database to store OCPP data. The database file is located at [OCPPDatabase.sqlite](OCPPDatabase.sqlite).

### Project Structure

* [OCPPServer.csproj](OCPPServer.csproj): Main .NET Core project file
* [Program.cs](Program.cs): Main entry point for the OCPP server application
* [Startup.cs](Startup.cs): Configures the OCPP server services and middleware
* [Controllers/OCPPController.cs](Controllers/OCPPController.cs): Handles incoming OCPP requests and dispatches to the OCPP service
* [Services/OCPPService.cs](Services/OCPPService.cs): Implements the OCPP 2.0.1 protocol logic
* [Models/OCPPRequest.cs](Models/OCPPRequest.cs): Defines the data model for OCPP requests
* [Models/OCPPResponse.cs](Models/OCPPResponse.cs): Defines the data model for OCPP responses
* [OCPPDatabaseContext.cs](OCPPDatabaseContext.cs): Database context for storing and retrieving OCPP data

### LICENCE

[Insert licence information here]

### CONTRIBUTING

Contributions are welcome! If you'd like to contribute, please fork this repository, make your changes, and submit a pull request.

### ISSUES

If you encounter any issues, please report them in the issues section of this repository.