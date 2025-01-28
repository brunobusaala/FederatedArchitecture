
# FederatedArchitecture

## Overview

FederatedArchitecture is a project that explores the implementation of a federated system architecture using .NET technologies and hotchocolate graphql. The project is organized into microservices , each responsible for a specific domain, and demonstrates how these services can interact within a federated environment.

## Project Structure

The repository is organized into the following directories:

- **Gateway**: Acts as the entry point for client requests, routing them to the appropriate services.
- **Infrastructure**: Contains shared infrastructure components and configurations.
- **Phoenix.Gateway**: Handles API gateway functionalities, including request routing and aggregation.
- **Phoenix.HumanResource**: Manages human resource-related operations and data.
- **Phoenix.Infrastructure**: Provides foundational services and utilities used across other services.
- **Phoenix.Registry**: Maintains a registry of services and their endpoints for dynamic discovery.

## Getting Started

To set up and run the project locally, follow these steps:

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/brunobusaala/FederatedArchitecture.git
   cd FederatedArchitecture
   ```

2. **Restore Dependencies**:
   ```bash
   dotnet restore
   ```

3. **Build the Solution**:
   ```bash
   dotnet build
   ```

4. **Run the Services**:
   Navigate to each service's directory and run:
   ```bash
   dotnet run
   ```

## Prerequisites

- **.NET SDK**: Ensure that you have the .NET SDK installed. You can download it from the [official .NET website](https://dotnet.microsoft.com/download).

## Contributing

Contributions are welcome! If you have suggestions for improvements or new features, feel free to open an issue or submit a pull request.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

