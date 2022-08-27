using AutoMapper;
using Lirmi.Challenge.Server.Dtos;
using Lirmi.Challenge.Server.Interfaces;
using Lirmi.Challenge.Server.Modelos;

namespace Lirmi.Challenge.Server.Servicios
{
    public class InstitucionService : IInstitucion
    {
        private readonly ILogger<InstitucionService> _logger;
        private readonly Lirmi_ChallengeContext _context;

        public InstitucionService(ILogger<InstitucionService> logger, 
            Lirmi_ChallengeContext context)
        {
            _logger = logger;
            _context = context;
        }

        

        public async Task<List<InstitucionDto>> GetInstitucion()
        {
            var Instituciones = await _context.Colegios
                .Include(x => x.IdCursoNavigation)
                .ThenInclude(y => y.IdAsignaturaNavigation).ToListAsync();

            List<InstitucionDto> institucionDtos = new List<InstitucionDto>();

            foreach (var Institucion in Instituciones)
            {
                InstitucionDto institucionDto = new InstitucionDto();
                institucionDto.NombreColegio = Institucion.NombreColegio;
                institucionDto.NombreCurso = Institucion.IdCursoNavigation.NombreCurso;
                institucionDto.NombreAsignatura = Institucion.IdCursoNavigation.IdAsignaturaNavigation.NombreAsignatura;
                institucionDtos.Add(institucionDto);
            }


            return  institucionDtos;
        }
    }
}
