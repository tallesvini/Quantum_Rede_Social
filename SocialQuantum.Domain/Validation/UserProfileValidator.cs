using FluentValidation;
using SocialQuantum.Domain.Entities;
using SocialQuantum.Domain.Validation.Errors;

namespace SocialQuantum.Domain.Validation
{
	public class UserProfileValidator : AbstractValidator<User>
	{
        public UserProfileValidator()
        {
            RuleFor(user => user)
                .NotEmpty().WithMessage(GenericErrors.Required)
                    .NotNull().WithMessage(GenericErrors.Required);

			RuleFor(x => x.UserName)
				.NotEmpty().WithMessage(GenericErrors.Required)
					.NotNull().WithMessage(GenericErrors.Required)
						.MaximumLength(255).WithMessage(GenericErrors.MustBeLessThan255);


			RuleFor(x => x.Photo)
                .NotEmpty().WithMessage(GenericErrors.Required)
                    .NotNull().WithMessage(GenericErrors.Required);

			RuleFor(x => x.Biography)
				.NotEmpty().WithMessage(GenericErrors.Required)
					.NotNull().WithMessage(GenericErrors.Required)
						.MaximumLength(255).WithMessage(GenericErrors.MustBeLessThan255);
		}
    }
}
