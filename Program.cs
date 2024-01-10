using Endpoint1.Services.Endpoint1;
using Endpoint1.Services.Endpoint2;
using Endpoint1.Services.Endpoint3;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAddNumService, AddNumService>();
builder.Services.AddScoped<IDosQuestionsService, DosQuestionsService>();
builder.Services.AddScoped<IGreaterLesserService, GreaterLesserService>();

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
