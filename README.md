# Blazor Kanban — CRUD with URL Adaptor

A sample Blazor application demonstrating CRUD operations for the Syncfusion Kanban component using the `UrlAdaptor` of the Blazor `DataManager` to communicate with backend endpoints.

## Overview

This repository shows how to wire the Syncfusion Kanban component to a server API using the `UrlAdaptor` for create, read, update, and delete operations. The sample includes dialog editing and server-sync examples.

**Online example**: https://blazor.syncfusion.com/demos/kanban/dialog-editing?theme=bootstrap4

## Features

- Server-backed CRUD via `UrlAdaptor`
- Dialog-based card editing
- Example workflows for create, read, update, delete

## Prerequisites

- Visual Studio 2022 (recommended) or later
- The .NET SDK required by the solution

## Running the project

1. Clone the repository to a local folder.
2. Open the solution in Visual Studio 2022.
3. Restore NuGet packages by rebuilding the solution or running `dotnet restore`.
4. Configure the backend API endpoints or update the database connection string in the project configuration to match your environment.
5. Build and run the project from Visual Studio.

Optional CLI steps:

```powershell
dotnet restore
dotnet build
```

## Troubleshooting & support

If you encounter issues, confirm that packages are restored, the project builds, and the license key is registered correctly. For more details about Syncfusion components consult the Syncfusion Blazor documentation.
