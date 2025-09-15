using FluentValidation;
using MovieManagementAPI.Models;

namespace MovieManagementAPI.Validators
{
    public class MovieValidator : AbstractValidator<Movie>
    {
        public MovieValidator() {
            RuleFor(m => m.Title)
                .NotEmpty().WithMessage("Title is required.")
                .MaximumLength(200).WithMessage("Title cannot exceed 200 characters.");

            RuleFor(m => m.Director)
                .NotEmpty().WithMessage("Director is required.")
                .MaximumLength(100).WithMessage("Director cannot exceed 100 characters.");

            RuleFor(m => m.ReleaseYear)
                .InclusiveBetween(1888, DateTime.Now.Year).WithMessage($"Release year must be between 1888 and {DateTime.Now.Year}.");

            RuleFor(m => m.Genre)
                .MaximumLength(50).WithMessage("Genre cannot exceed 50 characters.");

        }
    }
}
