# 🛍️ Product Catalog Application – Practical_6

A simple **Product Catalog Management System** developed using **ASP.NET MVC 5 and C#** as part of my .NET subject practical.

This project demonstrates the MVC architecture and basic product management operations: viewing, adding, editing, and deleting products.

## 📌 Project Overview

The Product Catalog application provides a simple interface to manage product information, including product ID, product name, and price.

### ✨ Features

- 📋 **View Products:** Display all products in a table.
- ➕ **Add Product:** Add a new product with its name and price.
- ✏️ **Edit Product:** Update existing product details.
- 🗑️ **Delete Product:** Remove a product after confirmation.
- 🏗️ **MVC Architecture:** Separate Models, Views, and Controllers.
- 🛣️ **Routing:** Navigate to the appropriate controller actions.

## 🛠️ Technologies Used

- C#
- ASP.NET MVC 5
- .NET Framework
- Razor View Engine
- HTML
- Visual Studio

## 📂 Project Structure

```text
Practical_6/
│
├── Controllers/
│   └── ProductController.cs
│
├── Models/
│   └── Product.cs
│
├── Views/
│   └── Product/
│       ├── Index.cshtml
│       ├── Create.cshtml
│       ├── Edit.cshtml
│       └── Delete.cshtml
│
├── App_Start/
│   └── RouteConfig.cs
│
├── Global.asax
├── Web.config
└── README.md
```

## 🏛️ MVC Architecture

| Component | Purpose |
|---|---|
| Model | Defines product information such as ID, name, and price. |
| View | Displays the product list and forms to add, edit, and delete products. |
| Controller | Handles product operations and connects the Model with the View. |
| Routing | Maps URLs to the appropriate controller actions. |

## 🚀 How to Run the Project

1. Install **Visual Studio** with the ASP.NET and web development workload.
2. Clone or download this repository.
3. Open the `Practical_6.sln` solution file in Visual Studio.
4. Restore the NuGet packages if required.
5. Build the solution using **Build → Build Solution**.
6. Press **F5** to run the application.
7. Open the Product Catalog page in your browser.

## 🔗 Available Pages

| Page | Description |
|---|---|
| `/Product/Index` | Displays all products. |
| `/Product/Create` | Opens the Add Product form. |
| `/Product/Edit/1` | Opens the Edit form for product ID 1. |
| `/Product/Delete/1` | Opens the Delete confirmation page for product ID 1. |

*Note: Replace `1` with an existing product ID when editing or deleting a product.*

## 💾 Data Storage

This practical uses a temporary in-memory list to store products. Product changes are not permanently saved and will be lost when the application process restarts.

## 🎯 Learning Outcomes

- Understand ASP.NET MVC architecture.
- Create Models, Views, and Controllers.
- Configure application routing.
- Implement basic CRUD operations.
- Build a simple web application using C# and ASP.NET MVC.

## 👨‍🎓 Project Information

- **Project Name:** Practical_6
- **Project Type:** .NET Mini-Project
- **Application:** Product Catalog Management System
- **Framework:** ASP.NET MVC 5

## 📝 Conclusion

This project demonstrates a basic Product Catalog application using ASP.NET MVC. It provides practical experience with MVC architecture, routing, Razor views, and CRUD operations.

---

⭐ If you find this project useful for learning ASP.NET MVC, feel free to explore the code and improve it.
