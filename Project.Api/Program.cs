using Microsoft.AspNetCore.Http.Features;
using Microsoft.EntityFrameworkCore;
using Project.Core.Repositories;
using Project.Core.ResponseViewModel;
using Project.EF;
using Project.EF.Repository;
using Project.EF.Services;
using Project.EF.Services_Interface;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<EntityContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("Connection"),
b=>b.MigrationsAssembly(typeof(EntityContext).Assembly.FullName)));
// Add services
builder.Services.AddTransient(typeof(IGenericRepository<>),typeof(Repository<>));
builder.Services.AddTransient(typeof(Iserviceinterface), typeof(service));


//end services
builder.Services.AddCors(corsoption =>
{
    corsoption.AddPolicy("myplicy", corsPolicyBuilder => {
        corsPolicyBuilder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

builder.Services.Configure<FormOptions>(options =>
{
    options.ValueLengthLimit = int.MaxValue;
    options.MultipartBodyLengthLimit = int.MaxValue;

});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("myplicy");
app.UseAuthorization();

app.MapControllers();

app.Run();
