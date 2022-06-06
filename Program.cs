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

<<<<<<< HEAD
app.UseCheckingthebrowser(); //use own middleware to check the browser name
=======
app.Usechecking_the_browser(); //use own middleware to check the browser name
>>>>>>> 6749e132bcfa507347d58167cf60c2b952c6ca2d

app.Run();
