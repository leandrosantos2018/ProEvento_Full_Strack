﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly DataContext context;

        public EventoController(DataContext context)
        {
            this.context = context;

        }


    

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
           return this.context.Eventos;

        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return this.context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
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


