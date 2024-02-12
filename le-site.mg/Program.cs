using Domaine.Context;
using Mediateur.Commandes;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Repository.PersonneRepositoryFolder;
using Repository.UnitOfWork;
using Service.MappingHelpers.PersonneMappingHelpers;
using Service.PersonneServiceFolder;
using System.Net.NetworkInformation;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<leSiteDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped(typeof(IPersonneService), typeof(PersonneService));
builder.Services.AddScoped<IPersonneRepository, PersonneRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWorkImplementation>();
builder.Services.AddAutoMapper(typeof(PersonneMapping));

builder.Services.AddMediatR(cfg => 
    { 
        cfg.RegisterServicesFromAssemblies([typeof(Program).Assembly, typeof(CreatePersonneCommand).Assembly]); 
    });

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
