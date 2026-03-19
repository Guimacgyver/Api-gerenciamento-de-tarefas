using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TarefasApi.Data;
using TarefasApi.Models;
using TarefasApi.DTOs;

namespace TarefasApi.Controllers;

[ApiController]
[Route("tarefas")]  
public class TarefasController : ControllerBase
{
    private readonly AppDbContext _context;

    public TarefasController(AppDbContext context)
    {
        _context = context;
    }

    // GET: api/tarefas
    [HttpGet]
    public async Task<ActionResult<IEnumerable<TarefaDto>>> GetTarefas()
    {
        var tarefas = await _context.Tarefas.ToListAsync();
        var dtos = tarefas.Select(t => new TarefaDto
        {
            Id = t.Id,
            Titulo = t.Titulo,
            Descricao = t.Descricao,
            DataCriacao = t.DataCriacao,
            Concluida = t.Concluida
        });
        return Ok(dtos);
    }

    // GET: api/tarefas/5
    [HttpGet("{id}")]
    public async Task<ActionResult<TarefaDto>> GetTarefa(int id)
    {
        var tarefa = await _context.Tarefas.FindAsync(id);
        if (tarefa == null) return NotFound();
        
        var dto = new TarefaDto
        {
            Id = tarefa.Id,
            Titulo = tarefa.Titulo,
            Descricao = tarefa.Descricao,
            DataCriacao = tarefa.DataCriacao,
            Concluida = tarefa.Concluida
        };
        return Ok(dto);
    }

    // POST: api/tarefas
    [HttpPost]
    public async Task<ActionResult<TarefaDto>> PostTarefa(TarefaCreateDto dto)
    {
        var tarefa = new Tarefa
        {
            Titulo = dto.Titulo,
            Descricao = dto.Descricao,
            DataCriacao = DateTime.Now,
            Concluida = dto.Concluida
        };

        _context.Tarefas.Add(tarefa);
        await _context.SaveChangesAsync();

        var responseDto = new TarefaDto
        {
            Id = tarefa.Id,
            Titulo = tarefa.Titulo,
            Descricao = tarefa.Descricao,
            DataCriacao = tarefa.DataCriacao,
            Concluida = tarefa.Concluida
        };

        return CreatedAtAction(nameof(GetTarefa), new { id = tarefa.Id }, responseDto);
    }

    // PUT: api/tarefas/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutTarefa(int id, TarefaCreateDto dto)
    {
        var tarefa = await _context.Tarefas.FindAsync(id);
        if (tarefa == null) return NotFound();

        tarefa.Titulo = dto.Titulo;
        tarefa.Descricao = dto.Descricao;
        tarefa.Concluida = dto.Concluida;

        _context.Entry(tarefa).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        return NoContent();
    }

    // DELETE: api/tarefas/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTarefa(int id)
    {
        var tarefa = await _context.Tarefas.FindAsync(id);
        if (tarefa == null) return NotFound();

        _context.Tarefas.Remove(tarefa);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}
