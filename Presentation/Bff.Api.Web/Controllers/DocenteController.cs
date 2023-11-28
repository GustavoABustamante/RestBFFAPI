using Bff.Service.LoginService;
using Bff.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Bff.Service.DocenteService;
using Bff.Infrastructure.Authentications;
using Bff.Infrastructure.Const;
using Bff.SharedObjects;
using Microsoft.AspNetCore.Authorization;
using Bff.SharedObjects.Entities;

namespace Bff.Api.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DocenteController : Controller
    {
        private readonly IDocenteService _docenteService;
        public DocenteController(IDocenteService docenteService)
        {
            this._docenteService = docenteService;
        }

        [HttpGet(nameof(GetDocentes))]
        public async Task<List<Docente>> GetDocentes()
        {
            return await _docenteService.GetDocentes();
        }

        [HttpGet(nameof(HealthCheck))]
        [AllowAnonymous]
        public IActionResult HealthCheck() => Ok();
    }
}
