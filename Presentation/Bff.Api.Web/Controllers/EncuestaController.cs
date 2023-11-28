using Bff.Service.DocenteService;
using Bff.Service.EncuestaService;
using Bff.SharedObjects.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bff.Api.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EncuestaController : ControllerBase
    {
        private readonly IEncuestaService _encuestaService;

        public EncuestaController(IEncuestaService encuestaService)
        {
            this._encuestaService = encuestaService;
        }
        [HttpGet(nameof(GetEncuestas))]
        public async Task<List<Encuesta>> GetEncuestas()
        {
            return await _encuestaService.GetEncuestas();
        }

        [HttpGet(nameof(HealthCheck))]
        [AllowAnonymous]
        public IActionResult HealthCheck() => Ok();
    }
}
