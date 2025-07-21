using MiddlewareExample.CustomMiddleware;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<MyCustomMiddleware>();
var app = builder.Build();



//middleware 1
app.Use(async (HttpContext context, RequestDelegate next) => { 
    await context.Response.WriteAsync("Hello i am middleware 1 \n");
    await next(context);//it represent next middleware
});

//app.MapGet("/", () => "Hello World!");
//middleware 2 
app.UseMiddleware<MyCustomMiddleware>();


app.Run(async (HttpContext context) => {
    await context.Response.WriteAsync("Hello again middleware 3 \n");
});


app.Run();
