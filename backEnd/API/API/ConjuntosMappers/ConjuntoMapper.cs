using adConjuntos2.Models;
using adConjuntos2.Models.DTO;
using AutoMapper;

namespace adConjuntos2.ConjuntosMappers
{
    public class ConjuntoMapper: Profile
    {
        public ConjuntoMapper()
        {
            CreateMap<Usuario, CrearUsuarioDTO>().ReverseMap();
            CreateMap<Usuario, EditarUsuarioDTO>().ReverseMap();
            CreateMap<Rol, CrearRolDTO>().ReverseMap();
            CreateMap<Conjunto, CrearConjuntoDTO>().ReverseMap();
        }
    }
}
