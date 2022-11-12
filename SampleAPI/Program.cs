var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Docker example: ASP.NET Web API running in docker container!");

app.Run();
