using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    public IEnumerable<Evento> _evento = new Evento[]{
        new Evento{
            EventoId = 1,
            Local = "Belo Horizonte",
            DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
            Tema = "Angular 11 e .NET 5",
            QtdPessoas = 250,
            Lote = "1º Lote",
            ImagemURL = "foto.png"
        },
        new Evento{
            EventoId = 2,
            Local = "São Paulo",
            DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
            Tema = "Angular e suas Novidades",
            QtdPessoas = 350,
            Lote = "2º Lote",
            ImagemURL = "foto1.png"
        }
    };

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _evento;
    }
    
    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id)
    {
        return _evento.Where(evento => evento.EventoId == id);
    }
}
