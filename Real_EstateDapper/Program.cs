using Real_EstateDapper.Context;
using Real_EstateDapper.Services.AboutUsService;
using Real_EstateDapper.Services.CategoryService;
using Real_EstateDapper.Services.ImagePropertyService;
using Real_EstateDapper.Services.MovieService;
using Real_EstateDapper.Services.PropertyService;
using Real_EstateDapper.Services.TestimonialService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<Real_EstateDapperContext>();

builder.Services.AddScoped<IAboutUsService, AboutUsService>();
builder.Services.AddScoped<IPropertyService, PropertyService>();
builder.Services.AddScoped<IImagePropertySevice, ImagePropertyService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ITestimonialService, TestimonialService>();
builder.Services.AddScoped<IMovieService, MovieService>();

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.Run();
