using CSC336FinalMiraFattal.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.addDb(builder.Configuration);
builder.Services.AddAutoMapperConfig();
builder.Services.AddRepository();
builder.Services.AddService();

builder.Services.AddControllers();

//for angular
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", policy =>
    {
        policy.AllowAnyHeader()
        .AllowAnyMethod()
        .AllowAnyOrigin();
    });
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
