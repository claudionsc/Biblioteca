using Biblioteca.Models.Contracts.Repositories;
using Biblioteca.Models.Contracts.Services;
using Biblioteca.Models.Repositories;
using Biblioteca.Models.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Biblioteca.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<BibliotecaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BibliotecaContext") ?? throw new InvalidOperationException("Connection string 'BibliotecaContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();


// Add Servi�os e reposit�rios (inje��o de depend�ncia)
// Defini��o do servi�o e do reposit�rio, da interface e de quem implementa a interface
builder.Services.AddScoped<ILivroRepository, LivroRepositories>();
builder.Services.AddScoped<ILivroService, LivroServices>();

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
