# User List Application

## Overview

This project consists of two parts: 
1. An Ionic-based frontend application that displays a list of users.
2. An ASP.NET Web API that provides user data.

The frontend application fetches the data from the backend API and dynamically updates the displayed list of users.

## Technologies

### Frontend
- **Ionic 6+**
- **Angular**
- **TypeScript**
- **HTML/CSS**

### Backend
- **ASP.NET Core Web API**
- **C#**

## Features

### Ionic App (Frontend)
- Fetches user data from the backend using HTTP requests.
- Displays the list of users in a user-friendly format.
- Automatically updates the list of users when new data is available.

### ASP.NET Core API (Backend)
- Provides user data via a RESTful API.
- Supports GET requests to retrieve user information.
- Supports POST requests to add new users.

## Installation

### Prerequisites

- **Node.js**: You need to have Node.js installed to run the Ionic application.
- **.NET Core SDK**: Required for running the ASP.NET Web API.

### Frontend Setup

1. Clone the repository.
   ```bash
   git clonegit clone https://github.com/FernandoMares/user-list.git
   cd user-list
2. Install dependencies:
 ```bash
   npm install
```
4. Run the application.
   ```bash
    ionic serve

### Backend Setup

1. Navigate to the userListAPI folder in your project.
```bash
cd userListAPI
```
2. Restore the dependencies.
```bash
dotnet restore
```
3. Run the Web API.
```bash
dotnet run
```
4. The API will be available at https://localhost:7138/api/users.

### API Endpoints
```bash
GET /api/user/getUsers
```
Retrieves the list of users.
```bash
POST /api/user/addUsers
```
Adds a new user. The request body should contain the user’s information in the following format:
```bash
{
  "id": 1,
  "name": "Fernando Garcia",
  "email": "fernandogarcia@email.com"
}
```

### Project Structure

## Ionic Frontend
src/app/components/user-list-component: Contains the UserListComponent which displays the list of users.
src/app/services/user-service.service.ts: Fetches data from the backend API.

## ASP.NET Backend
Controllers/UserController.cs: Handles HTTP requests for user data.
Models/User.cs: Defines the structure of a User object.


### Troubleshooting
If you encounter any issues, try the following:

Ensure both the frontend and backend servers are running.
Check the API URL in the UserService to ensure it's correct.
Verify that you have installed all necessary dependencies.




