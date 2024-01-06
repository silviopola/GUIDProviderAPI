using GUIDProviderAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace GUIDProviderAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GUIDProviderAPIController : ControllerBase
    {
        private readonly ILogger<GUIDProviderAPIController> _logger;
        private readonly IGUIDProvider _guidProvider;

        public GUIDProviderAPIController(ILogger<GUIDProviderAPIController> logger, IGUIDProvider guidProvider)
        {
            _logger = logger;
            _guidProvider = guidProvider;
        }

        [HttpGet]
        public Guid Get()
        {
            return _guidProvider.ProvideGUID();
        }
    }
}
