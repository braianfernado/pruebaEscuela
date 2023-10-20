using AutoMapper;
using BackEndApi.DTOs;
using BackEndApi.Models;
using System.Globalization;

namespace BackEndApi.Utilidades
{
    public class AutoMapperProfile: Profile
    {

        public AutoMapperProfile()
        {
            #region Estudiante
            CreateMap<Estudiante, EstudianteDTOs>().ReverseMap();
            #endregion

            #region Materia
            CreateMap<Materia, MateriaDTOs>().ReverseMap();
            #endregion

            #region profesor
            CreateMap<Profesore, ProfesorDTOs>().ReverseMap();
            #endregion

            #region EstudianteMateria
            CreateMap<EstudiantesMateria,EstudiantesMateriaDTOs >().ReverseMap();
            #endregion
        }

    }
}
