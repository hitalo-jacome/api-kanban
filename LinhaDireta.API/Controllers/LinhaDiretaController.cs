using LinhaDireta.Dados.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LinhaDireta.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LinhaDiretaController : Controller
{
    private readonly IConfiguration _configuration;
    private readonly AppDbContext _context;

    public LinhaDiretaController(IConfiguration configuration, AppDbContext context)
    {
        _configuration = configuration;
        _context = context;
    }

    // GET: api/LinhaDireta
    [HttpGet]
    public async Task<IActionResult> GetAllMessages()
    {
        var messages = await _context.LinhaDireta.ToListAsync();
        return Ok(messages);
    }
        
    // GET: api/LinhaDireta/{id}
    [HttpGet("{id}")]
    public async Task<IActionResult> GetMessageById(int id)
    {
        var message = await _context.LinhaDireta.FindAsync(id);
        if (message == null)
            return NotFound();

        return Ok(message);
    }

    // POST: api/LinhaDireta
    [HttpPost]
    public async Task<IActionResult> CreateMessage([FromBody] Dominio.Entities.LinhaDireta linhaDireta)
    {
        linhaDireta.Protocolo = LinhaDiretaHelper.GerarProtocolo(_context);
        _context.LinhaDireta.Add(linhaDireta);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetMessageById), new { id = linhaDireta.Id }, linhaDireta);
    }

    // PUT: api/LinhaDireta/{id}
    [HttpPut("{id}/{statusId}")]
    public async Task<IActionResult> UpdateMessage(int id, int statusId)
    {
        // Busca a mensagem existente no banco de dados
        var linhaDireta = await _context.LinhaDireta.FindAsync(id);
        if (linhaDireta == null)
            return NotFound();

        // Atualiza apenas o campo necessário (statusId)
        linhaDireta.StatusId = statusId;

        //_context.Entry(statusId).State = EntityState.Modified;

        // Salva as mudanças no banco de dados
        try
        {
            _context.Update(linhaDireta);
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.LinhaDireta.Any(e => e.Id == id))
                return NotFound();
            else
                throw;
        }

        return NoContent();
    }


    // DELETE: api/LinhaDireta/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteMessage(int id)
    {
        var message = await _context.LinhaDireta.FindAsync(id);
        if (message == null)
            return NotFound();

        _context.LinhaDireta.Remove(message);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}
