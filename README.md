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

***How To Use***
1. Download the Project from GitHub
To download the project from GitHub:
- Go to the GitHub repository (your project’s GitHub link).
- Click the Code button in the top right corner and select Download ZIP to download the project to your computer.
- Alternatively, you can clone the repository using the terminal:
  git clone https://github.com/username/repository-name.git
  (Note: Replace "username" and "repository-name" with your actual project details.)

2. Edit the Database Connection String
To adapt the project’s database connection to your environment:
- Open the configuration file like appsettings.json or appsettings.Development.json in the project.
- Find the connection string and update it with your database details. For example:
  appsettings.json:
  {
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Database=your_database_name;User Id=your_username;Password=your_password;"
    }
  }
  Here:
  - Server: The address of your database (e.g., localhost or an IP address).
  - Database: Enter the name of your database here.
  - User Id and Password: Provide your database access credentials.
  If you're using a cloud database (e.g., Azure or AWS), adjust the connection details accordingly.

3. Restore the Database Backup (if available)
If the project includes a database backup, restore it to your database:
- SQL Server: You can restore a .bak file using SQL Server Management Studio (SSMS).
- MySQL: Use the following command to restore a .sql dump file:
  mysql -u username -p database_name < backup.sql
- PostgreSQL: Use the following command to restore a .dump file:
  pg_restore -U username -d database_name backup.dump

4. Run the Project
Before running the project:
- Install NuGet Packages: If you opened the project in Visual Studio, make sure NuGet packages are installed. You can use the terminal to run:
  dotnet restore
- Apply Migrations: If the project requires database migrations, apply them using:
  dotnet ef database update
- Run the Project:
  dotnet run
  Or, if you're using Visual Studio, click the Start button to run the project.

5. Admin User Login
If the project has an admin login:
- You might need to log in as an admin after starting the project.
- If the admin user doesn’t exist in the database, you can manually add an admin user to the database with the appropriate privileges.

***Nasıl Kullanabilirsiniz***
1. GitHub Projesini İndirme
Projeyi GitHub'dan indirmek için:
- GitHub repository'sine gidin (projenizin GitHub linki).
- Sağ üstte Code butonuna tıklayın ve Download ZIP seçeneği ile projeyi bilgisayarınıza indirin.
- Alternatif olarak terminal üzerinden clone işlemi yapabilirsiniz:
  git clone https://github.com/username/repository-name.git
  (Not: username ve repository-name'i kendi projenizin bilgileri ile değiştirin.)

2. Veritabanı Bağlantı Dizesini (Connection String) Düzenleme
Projenin veritabanı bağlantısını kendi ortamınıza uyarlamak için:
- Projede appsettings.json veya appsettings.Development.json gibi bir yapılandırma dosyasına gidin.
- Veritabanı bağlantı dizesini (Connection String) bulup kendi veritabanı sunucunuzun bilgileri ile değiştirin. Örneğin:
  appsettings.json:
  {
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Database=your_database_name;User Id=your_username;Password=your_password;"
    }
  }
  Burada:
  - Server: Veritabanınızın adresi (örneğin localhost veya bir IP adresi).
  - Database: Kendi veritabanı adınızı buraya yazın.
  - User Id ve Password: Veritabanı erişim bilgilerinizi girin.
  Eğer Azure veya AWS gibi bulut ortamlarında bir veritabanı kullanıyorsanız, buna göre de bağlantı bilgilerinizi düzenlemelisiniz.

3. Veritabanı Yedeklemesini (Backup) Yükleme
Eğer proje veritabanı yedeği (backup) içeriyorsa, o yedeği veritabanınıza yükleyin:
- SQL Server: .bak dosyasını SQL Server Management Studio (SSMS) üzerinden yükleyebilirsiniz.
- MySQL: .sql dump dosyasını aşağıdaki komutla yükleyebilirsiniz:
  mysql -u username -p database_name < backup.sql
- PostgreSQL: .dump dosyasını aşağıdaki komutla yükleyebilirsiniz:
  pg_restore -U username -d database_name backup.dump

4. Projeyi Çalıştırma
Projeyi çalıştırmadan önce:
- NuGet Paketlerini Yükleyin: Projeyi Visual Studio ile açtıysanız, NuGet paketlerinin yüklendiğinden emin olun. Bunun için terminal üzerinden:
  dotnet restore
- Migrations (Veritabanı Göçleri): Eğer veritabanı migrasyonları (migrations) gerektiriyorsa, terminal üzerinden aşağıdaki komutla migrasyonları uygulayın:
  dotnet ef database update
- Projeyi Çalıştırın:
  dotnet run
  veya Visual Studio üzerinden Start butonuna tıklayarak projeyi çalıştırabilirsiniz.

5. Admin Kullanıcı Girişi
Projede admin girişi varsa, admin kullanıcısı oluşturmak için:
- Projeye giriş yaptıktan sonra admin girişi yapmanız gerekebilir.
- Eğer admin kullanıcısı veritabanında yoksa, admin yetkilerine sahip bir kullanıcıyı veritabanına manuel olarak ekleyebilirsiniz.

