using Microsoft.AspNetCore.Mvc;
using Movies.Api.Mapping;
using Movies.Application.Services;
using Movies.Contracts.Requests;

namespace Movies.Api.Controllers
{
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieRepository)
        {
            _movieService = movieRepository;
        }

        [HttpPost(ApiEndpoints.Movies.Create)]
        public async Task<IActionResult> Create(
            [FromBody] CreateMovieRequest request,
            CancellationToken cancellationToken)
        {
            var movie = request.MapToMovie();

            await _movieService.CreateAsync(movie, cancellationToken);

            // Retorna a localização do recurso recém-criado no header Location
            return CreatedAtAction(nameof(Get), new { idOrSlug = movie.Id }, movie.MapToResponse());
        }

        [HttpGet(ApiEndpoints.Movies.Get)]
        public async Task<IActionResult> Get(
            [FromRoute] string idOrSlug,
            CancellationToken cancellationToken)
        {
            var movie = Guid.TryParse(idOrSlug, out var id)
                ? await _movieService.GetByIdAsync(id, cancellationToken)
                : await _movieService.GetBySlugAsync(idOrSlug, cancellationToken);

            if (movie is null)
            {
                return NotFound();
            }

            var response = movie.MapToResponse();

            return Ok(response);
        }

        [HttpGet(ApiEndpoints.Movies.GetAll)]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var movies = await _movieService.GetAllAsync(cancellationToken);
            var response = movies.MapToResponse();

            return Ok(response);
        }

        [HttpPut(ApiEndpoints.Movies.Update)]
        public async Task<IActionResult> Update(
            [FromRoute] Guid id,
            [FromBody] UpdateMovieRequest request,
            CancellationToken cancellationToken)
        {
            var movie = request.MapToMovie(id);
            var updatedMovie = await _movieService.UpdateAsync(movie, cancellationToken);

            if (updatedMovie is null)
            {
                return NotFound();
            }

            var response = updatedMovie.MapToResponse();

            return Ok(response);
        }

        [HttpDelete(ApiEndpoints.Movies.Delete)]
        public async Task<IActionResult> Delete(
            [FromRoute] Guid id,
            CancellationToken cancellationToken)
        {
            var deletedMovie = await _movieService.DeleteAsync(id, cancellationToken);

            if (!deletedMovie)
            {
                return NotFound();
            }

            return Ok();
        }
    }
}
