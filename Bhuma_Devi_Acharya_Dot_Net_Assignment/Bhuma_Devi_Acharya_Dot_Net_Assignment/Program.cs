using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Bhuma_Devi_Acharya_Dot_Net_Assignment.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("Bhuma_Devi_Acharya_Dot_Net_AssignmentContextConnection") ?? throw new InvalidOperationException("Connection string 'Bhuma_Devi_Acharya_Dot_Net_AssignmentContextConnection' not found.");

builder.Services.AddDbContext<Bhuma_Devi_Acharya_Dot_Net_AssignmentContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<Bhuma_Devi_Acharya_Dot_Net_AssignmentContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

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
app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
