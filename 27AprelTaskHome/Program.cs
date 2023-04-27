WebApplicationBuilder builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

WebApplication app = builder.Build();


app.MapControllerRoute("default","{controller}/{action}/{id?}");
app.Run();
