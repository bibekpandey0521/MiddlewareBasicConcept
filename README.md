# 🧱 ASP.NET Core Middleware - Basic Concept

This repository demonstrates a **basic middleware pipeline** in an ASP.NET Core application. The purpose is to help you understand how middleware works, how it processes HTTP requests, and how the order of middleware affects the flow of execution.

---

## 📁 Project Structure

- **Program.cs** – The main file that configures the middleware pipeline using `app.Use()` and `app.Run()` methods.

---

## 🧠 What is Middleware?

In ASP.NET Core, middleware is a component that:
- Processes HTTP requests and responses.
- Can short-circuit the pipeline (stop passing the request).
- Can perform actions both **before** and **after** the next middleware executes.

Middleware components are executed in the order they're added in `Program.cs`.

---

## ▶️ Middleware Pipeline in This Project

### ✅ Middleware 1
```csharp
app.Use(async (HttpContext context, RequestDelegate next) => { 
    await context.Response.WriteAsync("Hello I am middleware 1 \n");
    await next(context); // Pass control to the next middleware
});

✅ Middleware 2
app.Use(async (HttpContext context, RequestDelegate next) => {
    await context.Response.WriteAsync("Hello again middleware 2 \n");
    await next(context);
});
✅ Terminal Middleware (Middleware 3)
app.Run(async (HttpContext context) => {
    await context.Response.WriteAsync("Hello again middleware 3 \n");
});
 Output Example
When you run the application and send a request (e.g. navigate to / in a browser), the output will be:
Hello I am middleware 1 
Hello again middleware 2 
Hello again middleware 3 
