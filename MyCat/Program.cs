using Microsoft.EntityFrameworkCore;
using MyCat.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MyCatContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyCatContext")
        ?? throw new InvalidOperationException("Connection string 'MyCatContext' not found.")));

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Cats}/{action=Index}/{id?}");

app.Run();
