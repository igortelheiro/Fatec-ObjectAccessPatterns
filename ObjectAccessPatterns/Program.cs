using ObjectAccessPatterns.Data;
using ObjectAccessPatterns.Extension;

var repository = new LivroRepository();
var livrosDisponiveis = repository.ConsultarLivros();

var titulosLivros = string.Join(", ", livrosDisponiveis.Select(l => l.Titulo));

Console.WriteLine("Livros disponíveis: " + titulosLivros);

var livrosXXI = livrosDisponiveis.Where(livro => livro.FoiPublicadoNoSeculoXXI());
var titulosXXI = string.Join(", ", livrosXXI.Select(l => l.Titulo));

Console.WriteLine("Livros do século XXI: " + titulosXXI);