using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ColorValidation:AbstractValidator<Color>
    {
        public ColorValidation()
        {
            RuleFor(c => c.Name).MinimumLength(2);
        }
    }
}
