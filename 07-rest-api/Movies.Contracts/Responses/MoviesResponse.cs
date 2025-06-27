using System;

namespace Movies.Contracts.Responses;

public class MoviesResponse
{
    IEnumerable<MovieResponse> Movies { get; init; } = [];
}
