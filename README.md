# Virtual Marketplace Project

Welcome to the **Virtual Marketplace**, a dynamic e-commerce platform developed with **ASP.NET Core MVC and API**. This project demonstrates a comprehensive implementation of an online marketplace with modern UI/UX design, robust backend API integration, and user authentication.

## 🚀 Features

### User Experience
- **Product Listing**: Users can browse through a list of products, view details, and see available stock.
- **Product Images**: Dynamically uploaded product images are displayed in a responsive and consistent layout.
- **Shopping Cart**: Users can add items to the cart, adjust quantities, and view total prices in real-time.
- **Checkout System**: Users can proceed to checkout with all their selected items.

### Admin Features
- **Admin Dashboard**: Dedicated panel for administrators to manage products and monitor transactions.
- **Role-Based Authentication**: Admin access is controlled via JWT token role claims.

### Technical Capabilities
- **Responsive Design**: Optimized for different screen sizes with CSS for consistent layout and usability.
- **Dynamic Cart Sidebar**: Updates quantities, calculates totals, and maintains product details without refreshing the page.
- **Modern Frontend**: Styled with clean and user-friendly components.
- **API Integration**: 
  - `AuthController` for user login and role-based authentication.
  - `ProductController` for CRUD operations on products.
  - `CartController` for managing cart functionalities.

## 🛠️ Technologies Used

### Backend
- **ASP.NET Core MVC**: Handles the frontend views and logic.
- **ASP.NET Core API**: Provides a secure RESTful backend.
- **Entity Framework Core**: Manages database interactions.
- **JWT Authentication**: Ensures secure access with token-based authentication.

### Frontend
- **Razor Pages**: Generates dynamic HTML content.
- **CSS3**: Custom styling for modern UI/UX.
- **JavaScript**: Enhances interactivity, especially for cart management.

## 📂 Folder Structure

```plaintext
/ProjectRoot
│
├── Controllers/           # MVC controllers (e.g., HomeController, LoginController)
├── Models/                # Data models (e.g., ProductModel, AdminLoginModel)
├── Views/                 # Razor views (e.g., Product list, Admin Login)
├── wwwroot/               # Static files (CSS, JS, Images)
├── API/                   # ASP.NET Core API controllers
├── Migrations/            # Entity Framework migrations
└── appsettings.json       # Configuration settings

🌐 API Endpoints
Authentication
Login: POST /api/Auth/login
Request: { "username": "string", "password": "string" }
Response: { "token": "JWT", "isAdmin": true/false }
Product Management
Get All Products: GET /api/Product
Get Product by ID: GET /api/Product/{id}
Create Product: POST /api/Product
Update Product: PUT /api/Product/{id}
Delete Product: DELETE /api/Product/{id}
Cart
Add to Cart: POST /api/Cart/add
Get Cart: GET /api/Cart
Update Cart: PUT /api/Cart/{id}
Checkout: POST /api/Cart/checkout
