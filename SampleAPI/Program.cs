var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Manjinder - 831695: ASP.NET Web API running in docker container!");

app.Run();
