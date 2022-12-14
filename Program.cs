using Microsoft.EntityFrameworkCore;
using GFL.TestTask.Database;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddMvc(option =>
    option.EnableEndpointRouting = false
    );

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));



var app = builder.Build();

//app.UseMvcWithDefaultRoute();

app.UseMvc(routes =>
{
    routes.MapRoute(
           name: "folderPath",
           template: "{*fullPath}"
       );
});
app.UseStaticFiles();
app.Run();
