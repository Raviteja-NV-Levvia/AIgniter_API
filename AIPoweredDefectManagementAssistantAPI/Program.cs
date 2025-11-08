using AIPoweredDefectManagementAssistant.Services.AzureService;
using AIPoweredDefectManagementAssistant.Services.OpenAIService;
using Microsoft.Data.SqlClient;
using System.Data;

var builder = WebApplication.CreateBuilder(args);

// Validate and read connection string
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
if (string.IsNullOrWhiteSpace(connectionString))
{
    throw new InvalidOperationException("Connection string 'DefaultConnection' is not configured in appsettings.json.");
}

// Register an IDbConnection factory (MS SQL)
builder.Services.AddTransient<IDbConnection>(_ => new SqlConnection(connectionString));

// Add services to the container.
builder.Services.AddControllers(); // <-- Required to avoid the InvalidOperationException
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IOpenAIService, OpenAIService>();
builder.Services.AddScoped<IAzureServices, AzureServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
