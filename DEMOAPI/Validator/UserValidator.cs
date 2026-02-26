using DEMOAPI.Models;
using FluentValidation;

namespace DEMOAPI.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {

            #region Name

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required")
                .MinimumLength(3).WithMessage("Name must be at least 3 characters")
                .MaximumLength(100);

            #endregion

            #region Email

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required")
                .EmailAddress().WithMessage("Invalid email format");

            #endregion

            #region Password

            RuleFor(x => x.PasswordHash)
                .NotEmpty().WithMessage("Password is required")
                .MinimumLength(6).WithMessage("Password must be at least 6 characters");

            #endregion

            #region Role

            RuleFor(x => x.Role)
                .NotEmpty().WithMessage("Role is required")
                .Must(role => role == "Admin" || role == "User")
                .WithMessage("Role must be Admin or User");

            #endregion

        }
    }
}