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
    public class OCController : ControllerBase
    {
        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            Respuesta<Ordencompra> oRespuesta = new();

            try
            {
                using DiMetalloContext db = new();

                var lst = db.Ordencompras
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

        [HttpGet("insumo/{id:int}")]
        public IActionResult GetByInsumo(int id)
        {
            Respuesta<Ordencompra> oRespuesta = new();

            try
            {
                using DiMetalloContext db = new();

                var lst = db.Ordencompras
                    .Where(x => x.Insumo == id && x.Recepcionada==null)
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
            Respuesta<List<Ordencompra>> oRespuesta = new();

            try
            {
                using DiMetalloContext db = new();

                var lst = db.Ordencompras.ToList();
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
        public IActionResult Add(Ordencompra model)
        {
            Respuesta<Ordencompra> oRespuesta = new();

            try
            {
                using DiMetalloContext db = new();

                Ordencompra oOrdencompra = new();

                db.Ordencompras.Add(model);
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
        public IActionResult Edit(Ordencompra model)
        {
            Respuesta<Ordencompra> oRespuesta = new();

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
            Respuesta<Ordencompra> oRespuesta = new();
            try
            {
                using DiMetalloContext db = new();

                Ordencompra oOrdencompra = db.Ordencompras.Find(Id);
                db.Remove(oOrdencompra);
                db.SaveChanges();
                oRespuesta.Exito = 1;
            }
            catch (Exception ex)
            {
                oRespuesta.Mensaje = ex.Message;

            }
            return Ok(oRespuesta);
        }



    }
}
