namespace Movies.Contracts.Requests;

public class CreateMovieRequest
{
    // Usa required para garantir que as propriedades sejam definidas
    // Usa init para tornar as propriedades somente leitura após a inicialização

    public required string Title { get; init; }
    public required int YearOfRelease { get; init; }
    public required IEnumerable<string> Genres { get; init; } = []; // IEnumerable para listas imutáveis
}
