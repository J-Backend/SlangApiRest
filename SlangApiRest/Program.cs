using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using SlangApiRest.Database;
using SlangApiRest.Repositories;
using SlangApiRest.Repositories.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContextPool<SlangDbContext>(options =>
                                    options.UseSqlServer(builder.Configuration.GetConnectionString("ApiDB")));


builder.Services.AddScoped<ISlangRepository, SlangRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseCors(policy =>
        policy.WithOrigins("http://localhost:7043", "https://localhost:7043")
        .AllowAnyMethod()
        .WithHeaders(HeaderNames.ContentType)
    );

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
