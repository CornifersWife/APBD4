using APBD4.Animals;
using APBD4.Visits;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IAnimalService, AnimalService>();
builder.Services.AddScoped<IVisitService, VisitService>();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.RegisterEndpointsForAnimals();
app.RegisterEndpointsForVisits();
app.Run();