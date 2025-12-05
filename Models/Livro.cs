using System.ComponentModel.DataAnnotations;
namespace BibliotecaMagica.Api.Models;

public class Livro
{
    public int Id { get; set; }

    [Required (ErrorMessage ="Titulo obrigatorio")]
    [StringLength(60, MinimumLength = 3, ErrorMessage ="Minimo de caracteres 3 e maximo 60")]
    public string Titulo { get; set; } = "";

    [Required(ErrorMessage ="Autor Obrigatorio")]
    [StringLength(30, MinimumLength = 3, ErrorMessage ="Minimo de caracteres 3 e maximo 30")]
    public string Autor { get; set; } = "";

    [Required(ErrorMessage ="Número de paginas obrigatorio")]
    [Range(1,1000, ErrorMessage ="Páginas de 1 até 1000")]
    public int Paginas { get; set; }

    [Required(ErrorMessage ="Valor médio obrigatorio")]
    [Range(1,2000, ErrorMessage="Valores validos R$ 1.00 á R$ 2000.00")]
    public int ValorMedio { get; set; }

}
