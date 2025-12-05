using ComponentModel.DataAnnotations;
namespace BibliotecaMagica.Api.Models;

public class Livro
{
    public int Id { get; set; }

    [Required]
    public string Titulo { get; set; } = "";
    public string Autor { get; set; } = "";
    public int Paginas { get; set; }
    public int ValorMedio { get; set; }

}
