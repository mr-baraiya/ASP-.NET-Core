using DEMOAPI.Models;
using FluentValidation;

namespace DEMOAPI.Validators
{
    public class OrderValidator : AbstractValidator<Order>
    {
        public OrderValidator()
        {

            #region OrderNumber

            RuleFor(x => x.OrderNumber)
                .NotEmpty().WithMessage("Order number is required")
                .MaximumLength(50);

            #endregion


            #region TotalAmount

            RuleFor(x => x.TotalAmount)
                .GreaterThan(0)
                .WithMessage("Total amount must be greater than 0");

            #endregion


            #region UserId

            RuleFor(x => x.UserId)
                .GreaterThan(0)
                .WithMessage("Valid UserId is required");

            #endregion

        }
    }
}