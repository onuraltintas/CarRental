using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidation:AbstractValidator<Car>
    {
        public CarValidation()
        {
            RuleFor(c => c.Description).NotEmpty();
        }
    }
}
