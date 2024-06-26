using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using HundeRally.API.Areas.Identity.Data;
var builder = WebApplication.CreateBuilder(args);
// Instantiating of the connectionstring
var connectionString = builder.Configuration.GetConnectionString("APIDataContextConnection") ?? throw new InvalidOperationException("Connection string 'APIDataContextConnection' not found.");

builder.Services.AddDbContext<APIDataContext>(options => options.UseSqlServer(connectionString));

// Require confirmed account has been disabled for development purposes
builder.Services.AddDefaultIdentity<APIUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<APIDataContext>();

// Enable CORS to allow the client access to the API
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowBlazorApp",
        builder =>
        {
            builder.WithOrigins("https://localhost:7237") // The URL of the consuming application
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});

// Add services to the container

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// For Api Endpoints

// User management endpoints
builder.Services.AddAuthorization();

// Dependency injection for data context for user management - Entity Framework
builder.Services.AddIdentityCore<APIUser>()
    .AddEntityFrameworkStores<APIDataContext>()
    .AddApiEndpoints();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapControllers();

app.UseRouting();


//Enable CORS for development purposes
app.UseCors("AllowBlazorApp");



app.UseAuthorization();


//Map endpoints to UserManagement
app.MapIdentityApi<APIUser>();


app.Run();
