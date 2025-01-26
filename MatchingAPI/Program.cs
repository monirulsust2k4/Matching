using MatchingAPI.Data;
using MatchingAPI.IServices;
using MatchingAPI.Services;
using MatchingAPI.Services.SignalR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();
builder.Services.AddDbContext<iBOSDDDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("iBOSDDDConnection")));

builder.Services.AddDbContext<PeopleDeskContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PeopleDeskARLConnection")));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IEmployeeService,EmployeeService>();
builder.Services.AddScoped<INotificationService, NotificationService>();


var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
