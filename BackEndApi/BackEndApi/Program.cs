using BackEndApi.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using BackEndApi.Services.Contrato;
using BackEndApi.Services.Implementacion;
using AutoMapper;
using BackEndApi.DTOs;
using BackEndApi.Utilidades;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<DbescuelaContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("cadenaSQL"));
});

builder.Services.AddScoped<IEstudianteService, EstudianteService>();
builder.Services.AddScoped<IMateriaService, MateriaService>();
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

builder.Services.AddCors(options=>
    {
        options.AddPolicy("NuevaPolitica", app => {

            app.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();

        });

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


#region Peticiones Api Rest estudiante
app.MapGet("/Estudiante/lista", async (
    IEstudianteService _estudianteService,
    IMapper _mapper
    
    ) =>
{
    var listaEstudiante = await _estudianteService.GetList();
    var listaEstudianteDTO = _mapper.Map<List<EstudianteDTOs>>(listaEstudiante);

    if (listaEstudianteDTO.Count > 0)
        return Results.Ok(listaEstudianteDTO);
    else
        return Results.NotFound();
});

app.MapPost("/Estudiante/guardar", async (

    EstudianteDTOs modelo,
     IEstudianteService _estudianteService,
    IMapper _mapper

    )=>{

        var _estudiante = _mapper.Map <Estudiante> (modelo);
        var _estidantecreado = await _estudianteService.add(_estudiante);

        if (_estidantecreado.EstudianteId != 0)
            return Results.Ok(_mapper.Map<EstudianteDTOs>(_estidantecreado));
        else return Results.StatusCode(StatusCodes.Status500InternalServerError);
        
        });

app.MapPut("/Estudiante/actuallizar/{EstudianteID}", async(

    int EstudianteID,
    EstudianteDTOs modelo,
     IEstudianteService _estudianteService,
    IMapper _mapper

    ) => {

        var _encontrado = await _estudianteService.Get(EstudianteID);

        if (_encontrado is null) return Results.NotFound();

        var _estudiante = _mapper.Map<Estudiante>(modelo);

        _encontrado.Nombre = _estudiante.Nombre;
        _encontrado.EstudianteId = _estudiante.EstudianteId;

        var Respuesta = await _estudianteService.Update(_encontrado);

        if(Respuesta)
            return Results.Ok(_mapper.Map<EstudianteDTOs>(_encontrado));

        else return Results.StatusCode(StatusCodes.Status500InternalServerError);

    });


app.MapDelete("/Estudiante/eliminar/{EstudianteID}", async (

    int EstudianteID,
     IEstudianteService _estudianteService

    ) =>{

        var _encontrado = await _estudianteService.Get(EstudianteID);

        if (_encontrado is null) return Results.NotFound();

        var respuesta = await _estudianteService.Delete(_encontrado);

        if (respuesta)
            return Results.Ok();
        else return Results.StatusCode(StatusCodes.Status500InternalServerError);

    }); ;

#endregion

#region Peticiones Api Rest materias

app.MapGet("/Materia/lista", async (
    IMateriaService _materiaService,
    IMapper _mapper

    ) =>
{
    var listaMateria = await _materiaService.GetList();
    var listaMateriaDTO = _mapper.Map<List<MateriaDTOs>>(listaMateria);

 

    if (listaMateriaDTO.Count > 0)
        return Results.Ok(listaMateriaDTO);
    else
        return Results.NotFound();
});

app.MapPost("/Materia/guardar", async (

    MateriaDTOs modelo,
     IMateriaService _materiaService,
    IMapper _mapper


    ) => {

        var _Materia = _mapper.Map<Materia>(modelo);
        var _MateriaCreada = await _materiaService.add(_Materia);

        if (_MateriaCreada.MateriaId != 0)
            return Results.Ok(_mapper.Map<MateriaDTOs>(_MateriaCreada));
        else return Results.StatusCode(StatusCodes.Status500InternalServerError);

    });

#endregion

app.UseCors("NuevaPolitica");
app.Run();

