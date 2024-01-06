# Contributing

Contributions are welcome. This document outlines the processes for contribution.

## Installation

Clone the project and open the solution in a .NET-supported IDE (Visual Studio or Rider are fine, I personally use Rider).

[Not yet required] Run `nuget install` to grab the required packages from NuGet.

## Code Structure

Most of the project is self-explanatory when reading through the structure, but a general rundown is here for your convenience.

### Frontend

Frontend files are found in the root of the project solution (one level below the `.sln` file). The frontend is split between the `Components` folder, and the `Pages` folder.
Additional frontend state management is found in the `Startup` and `StateManagement` folders.

### Backend

Backend files are found in `Backend`. The backend is mostly self-explanatory.
Configuration files for the project are delivered on an API level from the [Relictify API](https://github.com/NekoDrone/relictify-api).
C#'s base API client is used to make the requests.

### Testing

Tests are unwritten (as of January 2024). Contributions for unit tests for both frontend and backend would be most welcome.

## Standards and Guidelines

Please write pull requests at your own liberty. You may fork the project at your own behest and submit a pull request to solve specific issues or introduce new features. PRs are subject to approval.

Please follow common C# coding conventions as outlined by [Microsoft](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions).

Commit messages and PR titles should follow the [Conventional Commits](https://www.conventionalcommits.org/en/v1.0.0/) specification. 

