using Microsoft.AspNetCore.Mvc;
using BibliotecaMagica.Api.Models;
namespace BibliotecaMagica.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LivrosController : ControllerBase
{
    private static List<Livro> _livros = new List<Livro>();

    [HttpGet]
    public ActionResult<IEnumerable<Livro>> GetAll()
    {
        return Ok(_livros);
    }
    [HttpPost]
    public ActionResult<Livro> Cadastar(Livro novoLivro) // aqui a ASP.NET já me da uma especie de instância de Livro algo como Livro novoLivro = new Livro()
    {
        _livros.Add(novoLivro);

        return Ok(novoLivro);
    }

    public ActionResult<Livro> Deletar(Livro Id)
    {
        return Ok(Id);
    }
     
}


