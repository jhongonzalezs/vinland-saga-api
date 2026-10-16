using Microsoft.AspNetCore.Mvc;
using MiPrimeraApi.Data;
using MiPrimeraApi.Models;

namespace MiPrimeraApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PersonajesController : ControllerBase
{
    // GET: api/personajes - Obtener todos los personajes
    [HttpGet]
    public ActionResult<IEnumerable<Personaje>> GetAll()
    {
        return Ok(VinlandDb.Personajes);
    }

    // GET: api/personajes/1 - Obtener un personaje por ID
    [HttpGet("{id}")]
    public ActionResult<Personaje> GetById(int id)
    {
        var personaje = VinlandDb.Personajes.FirstOrDefault(p => p.Id == id);
        if (personaje == null)
            return NotFound(new { mensaje = $"No se encontró personaje con ID {id}" });

        return Ok(personaje);
    }

    // GET: api/personajes/buscar?nombre=Thorfinn - Buscar por nombre
    [HttpGet("buscar")]
    public ActionResult<IEnumerable<Personaje>> Buscar([FromQuery] string nombre)
    {
        var resultados = VinlandDb.Personajes
            .Where(p => p.Nombre.Contains(nombre, StringComparison.OrdinalIgnoreCase))
            .ToList();

        if (resultados.Count == 0)
            return NotFound(new { mensaje = $"No hay personajes que contengan '{nombre}'" });

        return Ok(resultados);
    }

    // GET: api/personajes/vivos - Solo personajes vivos
    [HttpGet("vivos")]
    public ActionResult<IEnumerable<Personaje>> Vivos()
    {
        return Ok(VinlandDb.Personajes.Where(p => p.EstaVivo).ToList());
    }

    // GET: api/personajes/top-kills - Top 3 asesinos
    [HttpGet("top-kills")]
    public ActionResult<IEnumerable<Personaje>> TopKills()
    {
        return Ok(VinlandDb.Personajes.OrderByDescending(p => p.Kills).Take(3).ToList());
    }

    // POST: api/personajes - Crear un nuevo personaje
    [HttpPost]
    public ActionResult<Personaje> Crear([FromBody] Personaje nuevoPersonaje)
    {
        if (string.IsNullOrWhiteSpace(nuevoPersonaje.Nombre))
            return BadRequest(new { mensaje = "El nombre es obligatorio" });

        // Generar ID automático
        var nuevoId = VinlandDb.Personajes.Max(p => p.Id) + 1;
        nuevoPersonaje.Id = nuevoId;

        VinlandDb.Personajes.Add(nuevoPersonaje);

        return CreatedAtAction(nameof(GetById), new { id = nuevoId }, nuevoPersonaje);
    }

    // PUT: api/personajes/1 - Actualizar un personaje existente
    [HttpPut("{id}")]
    public IActionResult Actualizar(int id, [FromBody] Personaje personajeActualizado)
    {
        var personaje = VinlandDb.Personajes.FirstOrDefault(p => p.Id == id);
        if (personaje == null)
            return NotFound(new { mensaje = $"No se encontró personaje con ID {id}" });

        personaje.Nombre = personajeActualizado.Nombre;
        personaje.Apellido = personajeActualizado.Apellido;
        personaje.Edad = personajeActualizado.Edad;
        personaje.Kills = personajeActualizado.Kills;
        personaje.Bando = personajeActualizado.Bando;
        personaje.Arma = personajeActualizado.Arma;
        personaje.EstaVivo = personajeActualizado.EstaVivo;

        return Ok(new { mensaje = "Personaje actualizado", personaje });
    }

    // DELETE: api/personajes/1 - Eliminar un personaje
    [HttpDelete("{id}")]
    public IActionResult Eliminar(int id)
    {
        var personaje = VinlandDb.Personajes.FirstOrDefault(p => p.Id == id);
        if (personaje == null)
            return NotFound(new { mensaje = $"No se encontró personaje con ID {id}" });

        VinlandDb.Personajes.Remove(personaje);
        return Ok(new { mensaje = $"Personaje {personaje.Nombre} eliminado" });
    }
}