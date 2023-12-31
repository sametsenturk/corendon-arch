using Corendon.Application.IoC;
using Corendon.CQRS.IoC;
using Corendon.Data.IoC;
using Corendon.Entity.Context;
using Corendon.Factory.IoC;
using Corendon.Repository.IoC;
using System.Reflection;
using Corendon.Mapper.IoC;
using Corendon.Security.IoC;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddBackendDataEF<CorendonDbContext>("CorendonDb", builder.Configuration);

#region Entity Inheritance Registiration

builder.Services.RegisterEntityInheritances();

#endregion

#region Factory Service Registiration

builder.Services.RegisterAnnouncementFactories();
builder.Services.RegisterCompanyFactories();
builder.Services.RegisterUserFactories();
builder.Services.RegisterUserCQRSFactories();
builder.Services.RegisterAnnouncementCQRSFactories();

#endregion

#region Security Service Registiration

builder.Services.RegisterSecurityServices();

#endregion

#region Repository Service Registiration

builder.Services.RegisterAnnouncementRepositories();
builder.Services.RegisterCompanyRepositories();
builder.Services.RegisterUserRepositories();

#endregion

#region Entity Service Registiration

builder.Services.RegisterAnnouncementServices();
builder.Services.RegisterCompanyServices();
builder.Services.RegisterUserServices();

#endregion

#region Application Service Model Registiration

builder.Services.RegisterResultModels();

#endregion

#region CQRS Query Registiration 

builder.Services.RegisterUserQueries();

#endregion

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

#region CQRS Handler Registiration

builder.Services.RegisterUserHandlers();
builder.Services.RegisterAnnouncementHandlers();

#endregion

#region AutoMapper Configuration

builder.Services.ConfigureAutoMapperProfiles();

#endregion

builder.Services.AddCors(opts =>
{
    opts.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});

var app = builder.Build();

app.UseCors();

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
