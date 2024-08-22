#!/bin/bash

# Install .NET Core
sudo apt-get update && sudo apt-get install -y dotnet-sdk-5.0

# Change directory to the project root
cd "$(dirname "$0")"/..

# Restore NuGet packages
dotnet restore OCPPServer.csproj

# Run the project
dotnet run --project OCPPServer.csproj

# Expose files
export RUN_SCRIPT=run.sh
export OCPPSERVER_PROJECT=OCPPServer.csproj

# Expose dependencies
export APPSETTINGS=appsettings.json
export OCPPDATABASE=OCPPDatabase.sqlite
export README=README.md
export GITIGNORE=.gitignore

# Import dependencies
source ./$GITIGNORE
source ./$APPSETTINGS
source ./$README