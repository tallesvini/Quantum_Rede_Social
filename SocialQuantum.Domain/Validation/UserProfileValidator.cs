using FluentValidation;
using SocialQuantum.Domain.Entities;
using SocialQuantum.Domain.Validation.Errors;

namespace SocialQuantum.Domain.Validation
{
	public class UserProfileValidator : AbstractValidator<UserProfile>
	{
        public UserProfileValidator()
        {
            RuleFor(user => user)
                .NotEmpty().WithMessage(CreateUserProfileErrors.Required)
                    .NotNull().WithMessage(CreateUserProfileErrors.Required);

			RuleFor(x => x.UserName)
				.NotEmpty().WithMessage(CreateUserProfileErrors.Required)
					.NotNull().WithMessage(CreateUserProfileErrors.Required)
						.MaximumLength(255).WithMessage(CreateUserProfileErrors.MustBeLessThan255);


			RuleFor(x => x.Photo)
                .NotEmpty().WithMessage(CreateUserProfileErrors.Required)
                    .NotNull().WithMessage(CreateUserProfileErrors.Required);

			RuleFor(x => x.Biography)
				.NotEmpty().WithMessage(CreateUserProfileErrors.Required)
					.NotNull().WithMessage(CreateUserProfileErrors.Required)
						.MaximumLength(255).WithMessage(CreateUserProfileErrors.MustBeLessThan255);

			RuleFor(x => x.IsActive)
                .NotNull().WithMessage(CreateUserProfileErrors.Required);
		}
    }
}
