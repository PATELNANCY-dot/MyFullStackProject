# ⚙️ Backend API - Crafted Treasures (.NET Core)

## 📌 Overview

This backend is built using **.NET Core Web API** and powers the **Crafted Treasures** e-commerce platform.

It handles:

* User authentication
* Product management
* Cart & Wishlist
* Order processing
* Admin operations

---

## 🚀 Key Features

### 🔐 Authentication

* Admin Login
* Client Registration & Login

### 🛍️ Product System

* Get Products
* Search Products
* Add / Update / Delete Products (Admin)
* Image Upload Support

### 🧺 Cart System

* Add to Cart
* Update Quantity
* Remove Items
* View Cart

### ❤️ Wishlist

* Add / Remove Wishlist
* Wishlist with Notes & Tags

### 📦 Order System

* Place Order
* Order History
* Clear / Delete Orders

### 👨‍💼 Admin Panel APIs

* Get Users
* Manage Orders
* Top Selling Products

---

## 🛠️ Tech Stack

* .NET Core Web API
* ADO.NET (SqlConnection, SqlCommand)
* MS SQL Server
* Stored Procedures
* Swagger (API Testing)

---

## 📂 Project Structure

```id="b1"
backend/
│
├── Controllers/
│   ├── AdminController.cs
│   └── TreasureController.cs
│
├── Models/
├── wwwroot/images/   # Uploaded product images
├── appsettings.json
└── Program.cs
```

---

## ⚙️ Setup Instructions

### 1️⃣ Clone Repository

```bash id="b2"
git clone https://github.com/PATELNANCY-dot/CraftedTreasures-Backend
cd backend
```

---

### 2️⃣ Configure Database

Update `appsettings.json`:

```json id="b3"
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=task2;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

---

### 3️⃣ Run Project

```bash id="b4"
dotnet restore
dotnet run
```

---

## 🌐 API Base URL

```id="b5"
https://localhost:7107/api
```

---

## 📸 API Preview (Swagger UI)

<img src="Screenshots/swagger.png" width="800"/>

---

## 📬 API Endpoints Overview

### 🔐 Admin APIs

| Method | Endpoint                         |
| ------ | -------------------------------- |
| GET    | /api/Admin/Login                 |
| GET    | /api/Admin/GetUsers              |
| GET    | /api/Admin/GetProductById/{id}   |
| POST   | /api/Admin/UpdateProduct         |
| GET    | /api/Admin/GetOrdersWithItems    |
| GET    | /api/Admin/GetTopSellingProducts |
| DELETE | /api/Admin/DeleteProduct/{id}    |

---

### 🛍️ Client APIs

| Method | Endpoint                         |
| ------ | -------------------------------- |
| GET    | /api/Treasure/InsertClient       |
| GET    | /api/Treasure/LoginClient        |
| GET    | /api/Treasure/GetProducts        |
| GET    | /api/Treasure/SearchProduct      |
| POST   | /api/Treasure/AddToCart          |
| GET    | /api/Treasure/Cart               |
| GET    | /api/Treasure/RemoveItem         |
| GET    | /api/Treasure/UpdateCartQuantity |

---

### 📦 Order APIs

| Method | Endpoint                   |
| ------ | -------------------------- |
| POST   | /api/Treasure/PlaceOrder   |
| GET    | /api/Treasure/OrderHistory |
| POST   | /api/Treasure/ClearHistory |
| POST   | /api/Treasure/DeleteOrder  |

---

### ❤️ Wishlist APIs

| Method | Endpoint                           |
| ------ | ---------------------------------- |
| POST   | /api/Treasure/AddWishlist          |
| GET    | /api/Treasure/GetWishlist          |
| POST   | /api/Treasure/RemoveWishlist       |
| POST   | /api/Treasure/AddOrUpdateWishlist  |
| GET    | /api/Treasure/GetWishlistWithNotes |

---

## 📁 File Upload (Important)

* Images are stored in:

```id="b6"
wwwroot/images/
```

* Access via:

```id="b7"
https://localhost:7107/images/{filename}
```

---

## ⚠️ Notes

* Uses **Stored Procedures** for all DB operations
* Handles stock validation in SQL
* Supports multipart/form-data for product images
* Error handling included for cart operations

---

## 🚀 Future Improvements

* JWT Authentication
* Payment Gateway Integration
* Role-based Authorization
* API Rate Limiting
* Unit Testing

---

## 👩‍💻 Author

Nancy Patel
