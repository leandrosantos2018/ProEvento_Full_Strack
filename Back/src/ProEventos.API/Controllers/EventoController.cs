using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
       

        public EventoController(ILogger<EventoController> logger)
        {
            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return new Evento[]{
                new Evento(){
                EventoId = 1,
                Tema = "Angular",
                Local = "São Paulo",
                Lote = "Lote 1",
                QtPessoas = 12,
                DataEvento = "01/01/2020",
                ImagemURL = "http://www.google.com.br"
                }, 
                new Evento(){
                EventoId = 2,
                Tema = "Angular",
                Local = "São Paulo",
                Lote = "Lote 1",
                QtPessoas = 12,
                DataEvento = "01/01/2020",
                ImagemURL = "http://www.google.com.br"
                }
            };
            
          } 
         
            
      
        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
            
        }

        

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put {id}";
            
        }
        [HttpDelete("{id}")]
        public string delete(int id)
        {
            return $"Exemplo de delete {id}";
            
        }
    }
}


 