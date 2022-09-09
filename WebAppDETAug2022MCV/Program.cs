using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebAppDETAug2022MCV.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<WebAppDETAug2022MCVContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebAppDETAug2022MCVContext") ?? throw new InvalidOperationException("Connection string 'WebAppDETAug2022MCVContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();
//Add service dependancy of IHello
//builder.Services.AddSingleton<IHelo, Helo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Friend}/{action=List}/{id?}");

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
