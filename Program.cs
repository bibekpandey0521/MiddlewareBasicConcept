var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


//app.Run method is middleware and it is nature of app.Run() method that it doesnot forward the request to subsequent middleware
//app.Run(async (HttpContext context) => {
//    await context.Response.WriteAsync("Hello");
//});

//middleware 1
app.Use(async (HttpContext context, RequestDelegate next) => { 
    await context.Response.WriteAsync("Hello i am middleware 1 \n");
    await next(context);//it represent next middleware
});

//app.MapGet("/", () => "Hello World!");
//middleware 2 
app.Use(async (HttpContext context,RequestDelegate next) => {
    await context.Response.WriteAsync("hello again middleware 2 \n");
    await next(context);

});


app.Run(async (HttpContext context) => {
    await context.Response.WriteAsync("Hello again middleware 3 \n");
});


app.Run();
