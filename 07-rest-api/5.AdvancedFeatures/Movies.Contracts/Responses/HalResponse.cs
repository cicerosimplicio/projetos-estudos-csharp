using System;
using System.Text.Json.Serialization;

namespace Movies.Contracts.Responses;

public abstract class HalResponse // Hipertext Application Language (HAL) é um formato de representação de recursos
                                  // que permite a navegação entre eles através de links.
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<Link> Links { get; set; } = new();
}

public class Link
{
    public required string Href { get; init; }

    public required string Rel { get; init; }

    public required string Type { get; init; }
}