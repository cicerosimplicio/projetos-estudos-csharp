using System.Text.RegularExpressions;

namespace Movies.Application.Models;

public partial class Movie
{
    public required Guid Id { get; init; }
    public required string Title { get; set; }
    public string Slug => GenerateSlug();
    public required int YearOfRelease { get; set; }
    public required List<string> Genres { get; set; } = []; // Usa List para dados mutáveis

    private string GenerateSlug()
    {
        // var sluggedTitle = Regex.Replace(Title, "[^0-9A-Za-z _-]", string.Empty)
        //     .ToLower()
        //     .Replace(' ', '-');

        var sluggedTitle = SlugRegex().Replace(Title, string.Empty)
            .ToLower()
            .Replace(' ', '-');

        return $"{sluggedTitle}-{YearOfRelease}";
    }

    // Novo recurso regex com mais performance
    // Backtracking é desativado para evitar problemas de performance com entradas grandes
    // O número 5 é o limite de tempo de busca da regex
    /* Classe parcial: é necessário porque o compilador vai gerar automaticamente
       parte da implementação do método SlugRegex() em outro arquivo parcial da mesma classe.
       Se a classe não for partial, o compilador não consegue juntar as partes geradas.
    */
    [GeneratedRegex("[^0-9A-Za-z ._-]", RegexOptions.NonBacktracking, 5)]
    private static partial Regex SlugRegex();
}
