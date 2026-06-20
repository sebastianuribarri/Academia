using ApiClient;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Configuración de la autenticación
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Account/Login"; // Ruta para el inicio de sesión
        options.LogoutPath = "/Account/Logout"; // Ruta para cerrar sesión
        options.AccessDeniedPath = "/Account/AccessDenied"; // Ruta para acceso denegado
    });
builder.Services.AddScoped<IUsuarioApiClient, UsuarioApiClient>();
builder.Services.AddScoped<IInscripcionApiClient, InscripcionApiClient>();
builder.Services.AddScoped<ICursoApiClient, CursoApiClient>();
builder.Services.AddScoped<IMateriaApiClient, MateriaApiClient>();
builder.Services.AddHttpContextAccessor();
builder.Services.AddSession();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();
app.UseRouting();

app.UseAuthentication(); // Habilita la autenticación
app.UseAuthorization(); // Habilita la autorización

app.MapRazorPages();

app.Run();
