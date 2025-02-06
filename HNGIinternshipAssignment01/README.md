# HNG12 Backend API - Stage 0

## Description
This is a simple public API that returns basic information, including:
- The registered email address.
- The current datetime in ISO 8601 format (UTC).
- The GitHub URL of the project's codebase.

## Technology Stack
- **Programming Language**: C#
- **Framework**: ASP.NET Core Web API

## Installation & Setup
### Prerequisites
- .NET 6 or later installed.
- A development environment like Visual Studio or VS Code.

### Steps to Run the Project Locally
1. Clone the repository:
   ```sh
   git clone https://github.com/0815Kelvin/HNGInternship-Ass0.git
   ```
2. Navigate to the project folder:
   ```sh
   cd HNGInternship-Ass0
   ```
3. Restore dependencies:
   ```sh
   dotnet restore
   ```
4. Run the application:
   ```sh
   dotnet run
   ```

## API Documentation
### Endpoint: GET `/api/hngintern`
#### Response Format (200 OK)
```json
{
    "email": "Kelvinintech399@gmail.com",
    "current_datetime": "2025-01-30T09:30:00Z",
    "github_url": "https://github.com/0815Kelvin/HNGInternship-Ass0"
}
```

### CORS Handling
CORS is configured to allow any origin, method, and header to ensure accessibility from different domains.

## Deployment
The API is deployed to a publicly accessible endpoint.

## Useful Links
- [Hire C# Developers](https://hng.tech/hire/csharp-developers)

