using Application.Posts.Commands;
using Application.Posts.Queries;
using Domain.Models;
using MediatR;
using MinimalAPI.Extentions;

var builder = WebApplication.CreateBuilder(args);
builder.RegisterServices();

var app = builder.Build();

Console.WriteLine($"Server is listening on: {app.Urls}");

app.UseHttpsRedirection();

app.RegisterEndpointDefinitions();

app.Run();

