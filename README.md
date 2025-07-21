# MiddlewareBasicConcept – Part 2

This example demonstrates the concept of middleware in ASP.NET Core using three types of middleware:

1. **Inline middleware**
2. **Custom middleware**
3. **Terminal middleware**

---

## 📁 Project Structure
# MiddlewareBasicConcept – Part 2

This example demonstrates the concept of middleware in ASP.NET Core using three types of middleware:

1. **Inline middleware**
2. **Custom middleware**
3. **Terminal middleware**

---

⚙️ Middleware Flow
Order of Execution
csharp
Copy code
app.Use(...);                     // Inline middleware (1)
app.UseMiddleware<MyCustomMiddleware>(); // Custom middleware (2)
app.Run(...);                     // Terminal middleware (3)

Output on Request
css
Copy code
Hello i am middleware 1 
Hello i am middleware 2 (custom) 
Hello again middleware 3 
