using ETicaretAPI.Persistance;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddPersistanceServices(builder.Configuration); // pass IConfiguration
                                                                //extension

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

builder.Services.AddEndpointsApiExplorer(); // Swagger için gerekli
builder.Services.AddSwaggerGen();            // Swagger generator

//builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    //app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
