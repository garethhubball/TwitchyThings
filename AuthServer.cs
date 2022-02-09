using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace TwitchyThings;

public static class AuthServer
{
    public static Task RunServer()
    {
        var builder = WebApplication.CreateBuilder();
        var app = builder.Build();

        app.MapGet("/", () =>
        {
            return "Hello world!";
        });

        return app.RunAsync("https://localhost:3000");
    }
}