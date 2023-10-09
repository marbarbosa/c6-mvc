using System.IO.Compression;
using Agenda.Models;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.Controllers
{
    [ApiController]
    [Route("v1")]
    public class HomeController : ControllerBase
    {
        [HttpGet("/")]
        public IActionResult Get([FromServices] AppDbContext context)
            => Ok(context.Tarefas.ToList());

        [HttpGet("/{id:int}")]
        public IActionResult GetById([FromRoute] int id, [FromServices] AppDbContext context)
        {
            var nTarefa = context.Tarefas.FirstOrDefault(x => x.Id == id);
            if (nTarefa == null)
                return NotFound();

            return Ok(nTarefa);
        }

        [HttpPost("/")]
        public IActionResult Post([FromBody] Tarefa tarefa, [FromServices] AppDbContext context)
        {
            context.Tarefas.Add(tarefa);
            context.SaveChanges();
            return Created($"/{tarefa.Id}", tarefa);
        }

        [HttpPut("/{id:int}")]
        public IActionResult Put([FromRoute] int id, [FromBody] Tarefa tarefa, [FromServices] AppDbContext context)
        {
            var nTarefa = context.Tarefas.FirstOrDefault(x => x.Id == id);
            if (nTarefa == null)
                return NotFound();

            nTarefa.Titulo = tarefa.Titulo;
            nTarefa.Feito = tarefa.Feito;
            context.Tarefas.Update(nTarefa);
            context.SaveChanges();
            return Ok(nTarefa);
        }

        [HttpDelete("/{id:int}")]
        public IActionResult Delete([FromRoute] int id, [FromServices] AppDbContext context)
        {
            var nTarefa = context.Tarefas.FirstOrDefault(x => x.Id == id);
            if (nTarefa == null)
                return NotFound();

            context.Tarefas.Remove(nTarefa);
            context.SaveChanges();
            return Ok(nTarefa);
        }
    }
}