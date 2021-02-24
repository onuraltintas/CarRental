using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidation:AbstractValidator<User>
    {
        public UserValidation()
        {
            RuleFor(u => u.FirstName).MinimumLength(2);
            RuleFor(u => u.FirstName).MaximumLength(50);
            RuleFor(u => u.LastName).MinimumLength(2);
            RuleFor(u => u.LastName).MaximumLength(50);
            RuleFor(u => u.Email).MaximumLength(50);
        }
    }
}
