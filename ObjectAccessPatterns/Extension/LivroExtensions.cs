namespace ObjectAccessPatterns.Extension;

internal static class LivroExtensions
{
    public static bool FoiPublicadoNoSeculoXXI(this Livro livro) =>
        livro.AnoPublicacao > 2000;
}
