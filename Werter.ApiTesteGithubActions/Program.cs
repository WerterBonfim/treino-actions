var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/info", () =>
{
    var info = new
    {
        Environment.MachineName,
        OperatingSystem = Environment.OSVersion.ToString(),
        ProcessorCount = Environment.ProcessorCount.ToString(),
        Environment.SystemDirectory,
        EnvironmentVariables = Environment.GetEnvironmentVariables()
    };
    return info;
});
app.Run();