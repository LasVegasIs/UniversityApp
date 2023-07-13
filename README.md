# University application
The "UniversityApp" project is a web application developed for managing student and teacher information in a university setting. It provides functionality for tracking student enrollment, managing teacher assignments, and generating reports.
The application utilizes a three-layer architecture, separating the presentation layer, business logic layer, and data access layer. This design allows for modularity, maintainability, and separation of concerns.

## Arhitecture
![Architecture](https://github.com/LasVegasIs/UniversityApp/blob/master/Img/Application%20architecture.png)
The project follows a three-layer architecture, comprising the following layers:

### Presentation Layer:
The presentation layer is responsible for handling user interactions and displaying the user interface.
It includes components such as controllers, views, and client-side scripts.
The presentation layer communicates with the business logic layer to retrieve and update data.

### Business Logic Layer:
The business logic layer contains the core application logic and rules.
It implements business operations, such as student enrollment, teacher assignments, and report generation.
The business logic layer interacts with the data access layer to retrieve and store data.

### Data Access Layer:
The data access layer is responsible for handling data persistence and retrieval.
It includes components such as data models, repositories, and the database context.
The data access layer uses Entity Framework to interact with the SQL Server database, providing an abstraction over the database operations.
The three-layer architecture promotes separation of concerns, code reusability, and testability. It allows for easier maintenance and scalability of the application.

The "UniversityApp" project provides an efficient and organized solution for managing student and teacher information in a university environment.

## Database
The project uses a Microsoft SQL Server database to store the university's data. The database schema includes tables such as Students, Teachers, and Student_Teacher_Subject. These tables capture information about students, teachers, and the subjects they are assigned to. The database ensures data integrity and supports efficient data retrieval and manipulation.
![Db diagram](https://github.com/LasVegasIs/UniversityApp/blob/master/Img/DbDiagram.jpg)

## Technical Stack
#### The "UniversityApp" project utilizes the following technologies and tools:
- Programming Language: C# - a versatile programming language widely used for .NET development.
- Framework: .NET Core- a cross-platform framework for building modern applications.
- Web Framework: ASP.NET Core - an open-source web framework for building web applications using .NET Core.
- Database: Microsoft SQL Server - a relational database management system used to store and retrieve data.
- ORM: Entity Framework Core - an object-relational mapping (ORM) framework that simplifies database interactions and provides an abstraction layer for data access.
- API Development: ASP.NET Core Web API - a framework for building RESTful APIs using .NET Core.
- Dependency Injection: Microsoft.Extensions.DependencyInjection - a built-in framework for implementing the dependency injection pattern in .NET Core applications.
- Version Control: Git - a distributed version control system for tracking changes in source code.
- IDE: Visual Studio or Visual Studio Code - popular integrated development environments for .NET development.

This technical stack provides a robust and scalable foundation for developing the "UniversityApp" project. It leverages the capabilities of .NET Core, ASP.NET Core, Entity Framework Core, and other standard web technologies to deliver a modern and efficient web application for managing student and teacher information.
