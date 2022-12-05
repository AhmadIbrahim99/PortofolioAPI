using AutoMapper;
using Core.Manager;
using Core.Manager.Interface;
using Core.Mapper;
using DAL.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddDbContext<PortifolioDbContext>(
    option=>
    {
        option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    }
    );

var config = new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new Mapping());
});

var mapper = config.CreateMapper();

builder.Services.AddSingleton(mapper);
builder.Services.AddScoped<IPostManager, PostManager>();
builder.Services.AddScoped<IProjectManager, ProjectManager>();
//builder.Services.AddMap();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options => options.AddPolicy(
    "CORS",
    a => a.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()
    ));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("CORS"); 
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
