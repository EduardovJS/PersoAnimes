using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PersoAnimes.Data;
using PersoAnimes.Services.PersoAnimes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


// Adiciona o contexto do banco de dados ao contêiner de serviços
builder.Services.AddDbContext<AppDbContext>(options =>
{
    // Configura o DbContext para usar o SQL Server com a string de conexão especificada
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});


builder.Services.AddScoped<IPersoAnimesInterface, PersoAnimesService>();    




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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
