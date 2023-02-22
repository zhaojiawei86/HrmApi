﻿using Hrm.ApplicationCore.Contract.Repository;
using Hrm.ApplicationCore.Contract.Service;
using Hrm.Infrastructure.Data;
using Hrm.Infrastructure.Repository;
using Hrm.Infrastructure.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddDbContext<HRMDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("HrmApiDb"));
});

builder.Services.AddScoped<ICandidateServiceAsync, CandidateServiceAsync>();
builder.Services.AddScoped<ICandidateRepositoryAsync, CandidateRepositoryAsync>();


var app = builder.Build();
app.UseRouting(); // middlleware allow to use routing
app.UseEndpoints(endpointes => { endpointes.MapControllers(); }); // map request to particular controller

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();

