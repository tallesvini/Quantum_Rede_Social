using FluentValidation;
using SocialQuantum.Domain.Entities;
using SocialQuantum.Domain.Validation.Errors;

namespace SocialQuantum.Domain.Validation
{
	public class FollowValidator : AbstractValidator<Follow>
	{
        public FollowValidator()
        {
			RuleFor(follower => follower)
				.NotEmpty().WithMessage(GenericErrors.Required)
					.NotNull().WithMessage(GenericErrors.Required);

			RuleFor(x => x.UserFollowerId)
				.NotEmpty().WithMessage(GenericErrors.Required)
					.NotNull().WithMessage(GenericErrors.Required);

			RuleFor(x => x.UserFollowingId)
				.NotEmpty().WithMessage(GenericErrors.Required)
					.NotNull().WithMessage(GenericErrors.Required);
		}
    }
}
