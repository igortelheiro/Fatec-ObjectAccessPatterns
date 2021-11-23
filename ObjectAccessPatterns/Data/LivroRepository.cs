namespace ObjectAccessPatterns.Data;

internal class LivroRepository
{
    public void AdicionarLivro(Livro newLivro) =>
        LivrosDb.Livros.Add(newLivro);

    public IEnumerable<Livro> ConsultarLivros() =>
        LivrosDb.Livros;

    public void RemoverLivro(Livro livro) =>
        LivrosDb.Livros.Remove(livro);
}