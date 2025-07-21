# MiddlewareBasicConcept (Part 3)

This project demonstrates the core concept of middleware in ASP.NET Core using a custom middleware component along with inline and terminal middleware. It shows how to build a clean middleware pipeline using dependency injection and extension methods.

## 🔧 Getting Started

### Clone and Run

```bash
git clone https://github.com/bibekpandey0521/MiddlewareBasicConcept.git
cd MiddlewareBasicConcept
git checkout Part3
dotnet run

MiddlewareBasicConcept/
├── CustomMiddleware/
│   └── MyCustomMiddleware.cs
├── Program.cs
└── README.md
Hello i am middleware 1 
My Custom Middleware - Starts
Hello again middleware 3 
My Custom Middleware  - Ends
Request
  ↓
Middleware 1
  ↓
MyCustomMiddleware (Start)
  ↓
Middleware 3 (Run)
  ↑
MyCustomMiddleware (End)
