using Estate_Dapper_Project.Context;
using Estate_Dapper_Project.Services.CategoryServices;
using Estate_Dapper_Project.Services.ImagePropertyServices;
using Estate_Dapper_Project.Services.LocationServices;
using Estate_Dapper_Project.Services.PropertyServices;
using Estate_Dapper_Project.Services.ServiceServices;
using Estate_Dapper_Project.Services.StatisticServices;
using Estate_Dapper_Project.Services.TagServices;
using Estate_Dapper_Project.Services.TestimonialServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container. 
builder.Services.AddTransient<DapperContext>();
builder.Services.AddTransient<ICategoryService,CategoryService>();
builder.Services.AddTransient<IServiceService,ServiceService>();
builder.Services.AddTransient<ITestimonialService,TestimonialService>();
builder.Services.AddTransient<ILocationService,LocationService>();
builder.Services.AddTransient<IPropertyService,PropertyService>();
builder.Services.AddTransient<IStatisticService, StatisticService>();
builder.Services.AddTransient<IImagePropertyService, ImagePropertyService>();
builder.Services.AddTransient<ITagService, TagService>();
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




app.UseEndpoints(endpoints =>
{
	endpoints.MapControllerRoute(
	 name: "default",
	 pattern: "{controller=Home}/{action=Index}/{id?}"); 

	endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});


app.Run();
