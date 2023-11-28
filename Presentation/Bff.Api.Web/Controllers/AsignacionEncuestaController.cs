using Bff.Service.AsignacionEncuestaService;
using Bff.SharedObjects.DTO;
using Bff.SharedObjects.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bff.Api.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsignacionEncuestaController : ControllerBase
    {
        private readonly IAsignacionEncuestaService _asignacionesService;

        public AsignacionEncuestaController(IAsignacionEncuestaService asignacionesService)
        {
            this._asignacionesService = asignacionesService;
        }
        [HttpGet(nameof(GetAsignaciones))]
        public async Task<List<AsignacionEncuesta>> GetAsignaciones()
        {
            return await _asignacionesService.GetAsignaciones();
        }

        [HttpGet(nameof(HealthCheck))]
        [AllowAnonymous]
        public IActionResult HealthCheck() => Ok();
        [HttpGet(nameof(GetAsignacionesTest))]
        public async Task<List<AsignacionEncuesta>> GetAsignacionesTest(int length)
        {
            var asignaciones = (await _asignacionesService.GetAsignacionesTest(length)).ToList();

            return asignaciones;
        }
    }
}
