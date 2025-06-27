using System;
using Movies.Application.Models;

namespace Movies.Application.Repositories;

public interface IMovieRepository
{
    Task<bool> CreateAsync(Movie movie);
    Task<Movie?> GetByIdAsync(Guid id); // Usa nullable para indicar que o filme pode não ser encontrado
    Task<IEnumerable<Movie>> GetAllAsync();
    Task<bool> UpdateAsync(Movie movie);
}
