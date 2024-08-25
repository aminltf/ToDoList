# To-Do List Application

## Table of Contents

- [Features](#features)
- [Architecture](#architecture)
- [Technologies Used](#technologies-used)
- [Getting Started](#getting-started)
- [Usage](#usage)
- [Testing](#testing)
- [Contributing](#contributing)
- [License](#license)

## Features

- **Task Management**: Create, update, delete, and list tasks.
- **User Authentication**: Secure user authentication using JWT tokens.
- **Clean Architecture**: Separation of concerns into Core, Application, Infrastructure, and Presentation layers.
- **Unit and Integration Tests**: Comprehensive test coverage with xUnit.
- **Swagger Integration**: API documentation and testing via Swagger UI.

## Architecture

The application follows the Clean Architecture principles, ensuring that business logic is decoupled from implementation details. The architecture is divided into several layers:

- **Core**: Contains the domain entities, exceptions, interfaces, and any business rules.
- **Application**: Includes all business logic and use cases (commands and queries).
- **Infrastructure**: Handles external concerns such as data access and authentication.
- **Presentation**: Exposes the API endpoints to the users and connects the application to the external world.

## Technologies Used

- **C#** and **.NET Core**: The primary programming language and framework.
- **Entity Framework Core**: ORM for data access.
- **xUnit**: Testing framework for unit and integration tests.
- **Moq**: Mocking framework for testing.
- **Swagger**: For API documentation.
- **JWT (JSON Web Tokens)**: For secure authentication.

## Getting Started

### Prerequisites

- **.NET SDK 8.0 or later**: You can download it from [Microsoft's official site](https://dotnet.microsoft.com/download).

### Installation

1. **Clone the repository**:
   ```bash
   git clone https://github.com/yourusername/ToDoListApp.git
