using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiNews.Models;
using ApiNews.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiNews.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly ServicesNews _servicesnews;
        public NewsController(ServicesNews servicesnews)
        {
            _servicesnews = servicesnews;
        }

        //para saber la ruta = noticia/obtener
        [HttpGet]
        [Route("Prueba")]
        public IActionResult prueba()
        {
            var resultado = _servicesnews.Obtener();

            return Ok(resultado);
        }
        //para saber la ruta = noticia/agregar
        [HttpPost]
        [Route("Agregar")]
        public IActionResult Agregar([FromBody] News _news)
        {
            var resultado = _servicesnews.Addnews(_news);
            if (resultado)
            {
                return Ok(resultado);
            }
            else
            {
                return BadRequest();
            }

        }
        //para saber la ruta = noticia/agregar
        [HttpPut]
        [Route("Editar")]
        public IActionResult Editar([FromBody] News _news)
        {
            var resultado = _servicesnews.EditNews(_news);
            if (resultado)
            {
                return Ok(resultado);
            }
            else
            {
                return BadRequest();
            }

        }
        //para saber la ruta = noticia/eliminar
        [HttpDelete]
        [Route("Eliminar/{IdNews}")]
        public IActionResult Eliminar(int IdNews)
        {
            var resultado = _servicesnews.DeleteNews(IdNews);
            if (resultado)
            {
                return Ok(resultado);
            }
            else
            {
                return BadRequest();
            }
        }

    }
 }