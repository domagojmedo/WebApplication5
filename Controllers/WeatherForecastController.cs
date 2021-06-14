using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ITestApi _testApi;

        public WeatherForecastController(ITestApi testApi)
        {
            _testApi = testApi;
        }

        [HttpGet]
        public async Task<string> Get()
        {
            await _testApi.Post(new TestBody { Number = 42 });

            return "OK";
        }
    }
}
