using AutoMapper;
using Lirmi.Challenge.Server.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Lirmi.Challenge.Server.Dtos;

namespace Lirmi.Challenge.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InstitucionController : ControllerBase
    {

        private readonly IInstitucion _institucion;
        public InstitucionController(
            IInstitucion intitucion
            )
        {
            _institucion = intitucion;
        }

        [HttpGet]
        public async Task<ActionResult<List<InstitucionDto>>> GetInstitucion()
        {
            return await _institucion.GetInstitucion();
        }
    }
}