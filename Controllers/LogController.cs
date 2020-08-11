using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Nlog.Configuration.Yaml
{
    [ApiController]
    [Route("[controller]")]
    public class LogController : ControllerBase
    {
        private readonly ILogger<LogController> _logger;

        public LogController(ILogger<LogController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult CreateLogs()
        {
            _logger.LogTrace("Example Trace log");
            _logger.LogDebug("Example Debug log");
            _logger.LogInformation("Example Information log");
            _logger.LogWarning("Example Warning log");
            _logger.LogError("Example Error log");
            _logger.LogCritical("Example Critical log");

            return Ok();
        }
    }
}