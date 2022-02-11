using Microsoft.AspNetCore.Mvc;

namespace api1.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private static readonly HttpClient _client = new HttpClient();
    private string Url;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
        Url = Environment.GetEnvironmentVariable("api2Url") ?? "https://localhost:7028/WeatherForecast";
    }

    [HttpGet(Name = "test")]
    async public Task<string> Get()
    {
        return await _client.GetStringAsync(Url);
    }
}
