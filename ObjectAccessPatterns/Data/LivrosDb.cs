namespace ObjectAccessPatterns.Data;

internal static class LivrosDb
{
    public static List<Livro> Livros = new()
    {
        new Livro
        {
            Titulo = "O Homem do Castelo Alto",
            Autor = "Philip K. Dick",
            AnoPublicacao = 1962
        },
        new Livro
        {
            Titulo = "Guerra Mundial Z",
            Autor = "Max Brooks",
            AnoPublicacao = 2006
        }
    };
}