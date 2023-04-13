 using Marketplace.Application.Helpers.Configurations;
 using Marketplace.Persistence.Configuration;
 using Microsoft.OpenApi.Models;

 var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
 builder.Services.AddConfigurationApplicationLayer();
 builder.Services.AddConfigurationRepositories();
 builder.Services.AddSwaggerGen(c =>
 {
     c.SwaggerDoc("v1", new OpenApiInfo { Title = "Marketplace", Version = "v1" });
     c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
 });
 
 builder.Services.AddCors(options =>
 {
     options.AddPolicy(name: "CORSPolicy", policy =>
     {
         policy
             .AllowAnyMethod()
             .AllowAnyHeader()
             .WithOrigins("*");
     });
 });
 var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

 app.UseCors("CORSPolicy");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();