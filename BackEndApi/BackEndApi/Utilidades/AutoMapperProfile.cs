﻿using AutoMapper;
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
        }

    }
}