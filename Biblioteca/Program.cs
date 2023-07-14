using Biblioteca.Models.Contracts.Repositories;
using Biblioteca.Models.Contracts.Services;
using Biblioteca.Models.Repositories;
using Biblioteca.Models.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


// Add Serviços e repositórios (injeção de dependência)
// Definição do serviço e do repositório, da interface e de quem implementa a interface
builder.Services.AddScoped<ILivroRepository, LivroRrepositories>();
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
