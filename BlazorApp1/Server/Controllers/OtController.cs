using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlazorApp1.Server.Context;
using BlazorApp1.Shared.Models;
using System;

namespace BlazorApp1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OtController : ControllerBase
    {
        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            Respuesta<Ordentrabajo> oRespuesta = new();

            try
            {
                using DiMetalloContext db = new();

                var lst = db.Ordentrabajos
                    .Where(x => x.Id == id)
                    .First();
                oRespuesta.Exito = 1;
                oRespuesta.List = lst;
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }
            return Ok(oRespuesta);
        }


        [HttpGet("{codigo}")]
        public IActionResult Get(string codigo)
        {
            
            Console.WriteLine(codigo);
            Respuesta<Ordentrabajo> oRespuesta = new();

            try
            {
                using DiMetalloContext db = new();
                var lst = db.Ordentrabajos
                    .Where(x => x.Codigo == codigo)
                    .First();
                oRespuesta.Exito = 1;
                oRespuesta.List = lst;
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }
            return Ok(oRespuesta);
        }

        [HttpGet]
        public IActionResult Get()
        {
            Respuesta<List<Ordentrabajo>> oRespuesta = new();

            try
            {
                using DiMetalloContext db = new();

                var lst = db.Ordentrabajos.ToList();
                oRespuesta.Exito = 1;
                oRespuesta.List = lst;
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
            }
            return Ok(oRespuesta);
        }

        [HttpPost]
        public IActionResult Add(Ordentrabajo model)
        {
            Respuesta<Ordentrabajo> oRespuesta = new();

            try
            {
                using DiMetalloContext db = new();

                Ordentrabajo oOrdentrabajo = new();
                
                db.Ordentrabajos.Add(model);
                db.SaveChanges();
                oRespuesta.Exito = 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                oRespuesta.Mensaje = ex.Message;
            }
            return Ok(oRespuesta);
        }

        [HttpPut]
        public IActionResult Edit(Ordentrabajo model)
        {
            Respuesta<Ordentrabajo> oRespuesta = new();

            try
            {
                using DiMetalloContext db = new();
                db.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
                oRespuesta.Exito = 1;
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;

            }
            return Ok(oRespuesta);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int Id)
        {
            Respuesta<Ordentrabajo> oRespuesta = new();
            try
            {
                using DiMetalloContext db = new();

                Ordentrabajo oOrdentrabajo = db.Ordentrabajos.Find(Id);
                db.Remove(oOrdentrabajo);
                db.SaveChanges();
                oRespuesta.Exito = 1;
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;

            }
            return Ok(oRespuesta);
        }
        [HttpDelete("codigo/{id}")]
        public bool DeleteByCode(string id)
        {
            Console.WriteLine(id);
            Respuesta<Ordentrabajo> oRespuesta = new();
            try
            {
                using DiMetalloContext db = new();

                Ordentrabajo oOrdentrabajo = db.Ordentrabajos.Where(x=> x.Codigo== id).First();
                db.Remove(oOrdentrabajo);
                db.SaveChanges();
                oRespuesta.Exito = 1;
                return true;
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;
                return false;
            }
        }
    }
}
