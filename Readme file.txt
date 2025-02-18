# README FOR THE PROJECT Order Processing System

A robust ASP.NET Core MVC application that processes customer orders and applies discounts based on customer type and order amount. This project demonstrates clean architecture, automated testing, and modern CI/CD practices.

## 🚀 Features

- **Order Processing**
  - Enter order amount
  - Select customer type (New/Loyal)
  - Automatic discount calculation
  - Order summary display

- **Business Rules**
  - 10% discount for Loyal customers with orders ≥ $100
  - No discount for other scenarios

- **Technical Features**
  - Clean Architecture
  - Unit Testing
  - CI/CD Pipeline
  - Responsive UI

## 🛠️ Technology Stack

- **Backend**: ASP.NET Core MVC (.NET 8.0)
- **Testing**: xUnit
- **CI/CD**: GitHub Actions
- **Frontend**: Bootstrap 5
- **Version Control**: Git

## 📋 Prerequisites

- .NET 8.0 SDK
- Visual Studio 2022 or VS Code
- Git

## 🔧 Installation

1. **Clone the Repository**
   ```bash
   git clone https://github.com/yourusername/order-processing.git
   cd order-processing
   ```

2. **Restore Dependencies**
   ```bash
   dotnet restore
   ```

3. **Build the Project**
   ```bash
   dotnet build
   ```

4. **Run the Application**
   ```bash
   dotnet run
   ```

   The application will be available at `https://localhost:7000` (or your configured port)

## 🧪 Running Tests

## 📁 Project Structure

├── Controllers/           # MVC Controllers
├── Models/ # Data Models
├── Services/ # Business Logic
├── Views/ # UI Templates
├── Tests/ # Unit Tests
└── wwwroot/ # Static Files

## 💻 Usage

1. Launch the application
2. Enter the order amount
3. Select customer type (New/Loyal)
4. Submit the form
5. View the calculated discount and final total

## 🔄 Development Workflow

1. **Create Feature Branch**
   ```bash
   git checkout -b feature/your-feature-name
   ```

2. **Make Changes**
   ```bash
   git add .
   git commit -m "Description of changes"
   ```

3. **Push Changes**
   ```bash
   git push origin feature/your-feature-name
   ```

4. Create a Pull Request on GitHub

## 🚦 CI/CD Pipeline

Our GitHub Actions workflow automatically:
- Builds the application
- Runs unit tests
- Validates code quality
- Deploys to staging (on main branch)

## 🤝 Contributing

1. Fork the repository
2. Create your feature branch
3. Commit your changes
4. Push to the branch
5. Open a Pull Request

## ✅ Code Quality Standards

- Follow C# coding conventions
- Write unit tests for new features
- Update documentation as needed
- Use meaningful commit messages

## 🔍 Testing Strategy

- **Unit Tests**: Test business logic and calculations
- **Integration Tests**: Test controller actions and service integration
- **UI Tests**: Test user interface functionality

## 📝 Documentation

Additional documentation can be found in the `/docs` folder:
- API Documentation
- Architecture Overview
- Deployment Guide

## 🔐 Security

- Input validation
- Error handling
- Secure coding practices

## 🚀 Deployment

1. **Build the Application**
   ```bash
   dotnet publish -c Release
   ```

2. **Deploy to Hosting Environment**
   - Follow your hosting provider's deployment guidelines
   - Configure environment variables
   - Set up SSL certificates

## 📈 Version History

- **1.0.0**
  - Initial release
  - Basic order processing
  - Discount calculation

## 👥 Authors

- Shristi Shukla - Initial work

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🙏 Acknowledgments

- ASP.NET Core Documentation
- Bootstrap Documentation
- GitHub Actions Documentation

## 📞 Support

For support, please open an issue in the GitHub repository.

---

**Note**: This project was created as part of an assignment to demonstrate ASP.NET Core MVC development skills, testing practices, and CI/CD implementation.

This README.md provides:
Clear project overview
Detailed setup instructions
Development workflow
Testing information
Contribution guidelines
Deployment instructions
Version history
License information
The format is:
Easy to read with emoji icons
Well-structured with clear sections
Includes all necessary technical details
Provides both basic and advanced information
Remember to:
1. Replace yourusername with your actual GitHub username
2. Update version history as you make changes
Add your name in the Authors section
Customize any specific details for your implementation
Add any additional sections specific to your project needs