using Microsoft.AspNetCore.Mvc;
using MovieManagementAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace MovieManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[Action]")]
    public class MovieController : ControllerBase
    {

        #region In-Memory Store
        private static readonly List<Movie> _movies = new List<Movie>
        {
            new Movie { Id = 1, Title = "War 2", Director = "Naimish Sir", ReleaseYear = 2025, Genre = "asdf" },
            new Movie { Id = 2, Title = "Coolie", Director = "Madhuresh Sir", ReleaseYear = 2024, Genre = "ghjk" }
        };

        private static int _nextId = _movies.Max(m => m.Id) + 1;
        #endregion

        #region GET All Movies
        [HttpGet]
        public ActionResult<IEnumerable<Movie>> GetMovies()
        {
            try
            {
                return Ok(_movies);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
        #endregion

        #region GET Movie By Id
        [HttpGet("{id}")]
        public ActionResult<Movie> GetMovieById(int id)
        {
            try
            {
                var movie = _movies.FirstOrDefault(m => m.Id == id);
                if (movie == null) return NotFound();
                return Ok(movie);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
        #endregion

        #region POST Create Movie
        [HttpPost]
        public ActionResult<Movie> CreateMovie([FromBody] Movie newMovie)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest(ModelState);

                newMovie.Id = _nextId++;
                _movies.Add(newMovie);

                return CreatedAtAction(nameof(GetMovieById), new { id = newMovie.Id }, newMovie);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
        #endregion

        #region PUT Update Movie
        [HttpPut("{id}")]
        public IActionResult UpdateMovie(int id, [FromBody] Movie movie)
        {
            try
            {
                if (id != movie.Id) return BadRequest("Route id and movie.Id must match.");

                var existing = _movies.FirstOrDefault(m => m.Id == id);
                if (existing == null) return NotFound();

                if (!ModelState.IsValid) return BadRequest(ModelState);

                existing.Title = movie.Title;
                existing.Director = movie.Director;
                existing.ReleaseYear = movie.ReleaseYear;
                existing.Genre = movie.Genre;

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
        #endregion

    }
}