using middleware.Middleware;
using Wangkanai.Detection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDetection();    //add detecion

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

app.UseDetection(); //use detection

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Usechecking_the_browser(); //use own middleware to check the browser name

app.Run();
