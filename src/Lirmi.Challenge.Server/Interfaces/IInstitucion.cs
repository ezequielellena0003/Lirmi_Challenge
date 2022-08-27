using Lirmi.Challenge.Server.Dtos;

namespace Lirmi.Challenge.Server.Interfaces
{
    public interface IInstitucion
    {
        public Task<List<InstitucionDto>> GetInstitucion();   
    }
}
