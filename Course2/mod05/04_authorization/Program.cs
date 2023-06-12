using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StarterM.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(options=>
    options.UseSqlServer(builder.Configuration.GetConnectionString("default")));
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 1;
    options.Password.RequireDigit = false;
    options.Password.RequiredUniqueChars = 0;
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = false;
});

builder.Services.ConfigureApplicationCookie(options => {
    options.ExpireTimeSpan = TimeSpan.FromDays(3);
    //options.LoginPath = "/xxxx";
    //options.AccessDeniedPath = "/yyyy";
});
//=================================
var app = builder.Build();
app.UseStaticFiles();
app.UseAuthentication();
app.UseAuthorization();
app.MapDefaultControllerRoute();
//using (var scope = app.Services.CreateScope())
//{
//    CreateRoles(scope.ServiceProvider).Wait();
//}

app.Run();

async Task CreateRoles(IServiceProvider serviceProvider) //local function
{
    var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    var UserManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
    string[] roleNames = { "admin", "user" };

    foreach (var roleName in roleNames)
    {
        var exist = await RoleManager.RoleExistsAsync(roleName);
        if (!exist)
        {
            await RoleManager.CreateAsync(new IdentityRole(roleName));
        }
    }
    var admin = new ApplicationUser { UserName = "admin", Email = "admin@uuu.com.tw" };
    var user = await UserManager.FindByEmailAsync("admin@uuu.com.tw");
    if (user == null)
    {
        await UserManager.CreateAsync(admin, "Pa$$w0rd");
        await UserManager.AddToRoleAsync(admin, "admin");
    }
}
