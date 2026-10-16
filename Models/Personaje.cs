namespace MiPrimeraApi.Models;

public class Personaje
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Apellido { get; set; } = string.Empty;
    public int Edad { get; set; }
    public int Kills { get; set; }
    public string Bando { get; set; } = string.Empty; // "Vikingo", "Inglés", "Frank", etc.
    public string Arma { get; set; } = string.Empty;  // "Espada", "Hacha", etc.
    public bool EstaVivo { get; set; } = true;
}