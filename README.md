# 📦 .NET Core Web API - TechStore Project

Welcome to the **TechStore** .NET Core Web API! This project is designed to help you practice and learn the fundamentals of creating a Web API using .NET Core. It's built for educational purposes and includes essential features like user authentication, data validation, and CRUD operations for managing data.

---

## 📋 Table of Contents

- [About the Project](#-about-the-project)
- [Features](#-features)
- [Getting Started](#-getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Usage](#-usage)
  - [Available Endpoints](#available-endpoints)
  - [API Documentation](#api-documentation)
- [Technologies Used](#-technologies-used)
- [Contributing](#-contributing)
- [License](#-license)
- [Contact](#-contact)

---

## 📖 About the Project

The **TechStore** Web API project is designed to simulate a store backend. It supports functionality to manage user accounts, products, and orders. You’ll find standard RESTful practices implemented along with an emphasis on clean code and maintainable structure.

### 🌟 Features

- 🔐 **Authentication & Authorization**: Secure access using JWT.
- 📄 **CRUD Operations**: For managing resources like users, products, and orders.
- 📈 **Data Validation**: Ensures input data consistency and security.
- 📝 **Logging**: Built-in logging for better debugging and maintenance.
- 📂 **Modular Architecture**: Designed to be extendable and easy to maintain.

---

## 🚀 Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version 5.0 or higher)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or MySQL for database
- [Postman](https://www.postman.com/) (optional, for testing API endpoints)

### Installation

1. **Clone the repository:**
   ```bash
   git clone https://github.com/Zainulabdeenoffical/.net-core-web-api-Restful-api-.git
   cd .net-core-web-api-Restful-api-
   ```

2. **Install dependencies:**
   ```bash
   dotnet restore
   ```

3. **Configure the Database:**
   - Set up a local database and update the connection string in `appsettings.json`.

4. **Run the API:**
   ```bash
   dotnet run
   ```

5. The API will be accessible at `http://localhost:5000`.

---

## 🛠 Usage

### Available Endpoints

| Endpoint           | Method | Description                |
|--------------------|--------|----------------------------|
| `/api/auth/login`  | POST   | Login a user              |
| `/api/auth/signup` | POST   | Register a new user       |
| `/api/products`    | GET    | Retrieve all products     |
| `/api/products`    | POST   | Add a new product         |
| `/api/orders`      | GET    | Get all orders            |

### API Documentation

To generate API documentation and make it easier to explore the API endpoints, Swagger is integrated into the project. You can learn more about setting up Swagger for ASP.NET Core by following [Microsoft’s tutorial on Web API help pages with Swagger](https://learn.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-8.0).

To access the Swagger UI, open your browser and go to `http://localhost:5000/swagger` after running the API. This will provide a detailed, interactive interface to test the API endpoints.

---

## 🛠️ Technologies Used

- **ASP.NET Core 5.0** - Web API framework
- **Entity Framework Core** - ORM for database management
- **SQL Server / MySQL** - Database management system
- **JWT Authentication** - Secure authentication

---

## 🤝 Contributing

1. **Fork** the repository.
2. **Create a branch** for any feature or bug fixes.
3. **Commit** your changes.
4. **Push** to your fork and submit a **pull request**.

Contributions, issues, and feature requests are welcome! 💡

---

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

## 📬 Contact

- **Author**: M Zain Ul Abideen
- **GitHub**: [Zainulabdeenoffical](https://github.com/Zainulabdeenoffical)
- **Email**: zu4425@example.com

---

🌟 If you like this project, please give it a star! 🌟

