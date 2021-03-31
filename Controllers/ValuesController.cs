using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProAgil.api.Data;
using ProAgil.api.Models;

namespace ProAgil.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public DataContext Context { get; }

        public ValuesController(DataContext context)
        {
            Context = context;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Evento>> Get()
        {
            return this.Context.Eventos.ToList();
            // return new Evento[] { 
            //     new Evento() {
            //         EventoId = 1,
            //         Local = "Campina Grande",
            //         Lote = "1º Lote",
            //         QtdPessoas = 350,
            //         Tema = "Porra nenhuma, seu bosta!",
            //         DataEvento = DateTime.Now.AddDays(4).ToString("dd/MM/yyyy")
            //     },
            //     new Evento() {
            //         EventoId = 2,
            //         Local = "João Pessoa",
            //         Lote = "2º Lote",
            //         QtdPessoas = 689,
            //         Tema = "Vai tomar no C* seu bando de fdp!",
            //         DataEvento = DateTime.Now.AddDays(25).ToString("dd/MM/yyyy")
            //     }
            //  };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Evento> Get(int id)
        {
            return this.Context.Eventos.FirstOrDefault(x => x.EventoId == id);
            // return new Evento[] { 
            //     new Evento() {
            //         EventoId = 1,
            //         Local = "Campina Grande",
            //         Lote = "1º Lote",
            //         QtdPessoas = 350,
            //         Tema = "Porra nenhuma, seu bosta!",
            //         DataEvento = DateTime.Now.AddDays(4).ToString("dd/MM/yyyy")
            //     },
            //     new Evento() {
            //         EventoId = 2,
            //         Local = "João Pessoa",
            //         Lote = "2º Lote",
            //         QtdPessoas = 689,
            //         Tema = "Vai tomar no C* seu bando de fdp!",
            //         DataEvento = DateTime.Now.AddDays(25).ToString("dd/MM/yyyy")
            //     }
            //  }.FirstOrDefault(x => x.EventoId == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
