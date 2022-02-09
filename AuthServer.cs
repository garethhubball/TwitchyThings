using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;

namespace TwitchyThings;

public static class AuthServer
{
    public static Task RunServer()
    {
        var builder = WebApplication.CreateBuilder();
        var app = builder.Build();

        app.MapGet("/", ([FromQuery(Name="code")] string? code) =>
        {
            return $"Hello your code was {code}!";
        });

        return app.RunAsync("https://localhost:3000");
    }
}