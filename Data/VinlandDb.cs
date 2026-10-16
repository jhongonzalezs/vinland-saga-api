using MiPrimeraApi.Models;

namespace MiPrimeraApi.Data;

public static class VinlandDb
{
    public static List<Personaje> Personajes { get; set; } = new List<Personaje>
    {
        new Personaje
        {
            Id = 1,
            Nombre = "Thorfinn",
            Apellido = "Karlsefni",
            Edad = 19,
            Kills = 47,
            Bando = "Vikingo",
            Arma = "Dagas gemelas",
            EstaVivo = true
        },
        new Personaje
        {
            Id = 2,
            Nombre = "Askeladd",
            Apellido = "Olafsson",
            Edad = 44,
            Kills = 89,
            Bando = "Vikingo",
            Arma = "Espada larga",
            EstaVivo = false
        },
        new Personaje
        {
            Id = 3,
            Nombre = "Canuto",
            Apellido = "Knutsson",
            Edad = 20,
            Kills = 12,
            Bando = "Daneses",
            Arma = "Espada real",
            EstaVivo = true
        },
        new Personaje
        {
            Id = 4,
            Nombre = "Thors",
            Apellido = "Snorrason",
            Edad = 38,
            Kills = 100,
            Bando = "Vikingo",
            Arma = "Espada corta",
            EstaVivo = false
        },
        new Personaje
        {
            Id = 5,
            Nombre = "Bjorn",
            Apellido = "el Berserker",
            Edad = 40,
            Kills = 76,
            Bando = "Vikingo",
            Arma = "Hacha doble",
            EstaVivo = false
        }
    };
}