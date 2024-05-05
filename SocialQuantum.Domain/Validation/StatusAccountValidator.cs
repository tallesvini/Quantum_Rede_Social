using FluentValidation;
using SocialQuantum.Domain.Entities;
using SocialQuantum.Domain.Validation.Errors;

namespace SocialQuantum.Domain.Validation
{
	public class StatusAccountValidator : AbstractValidator<StatusAccount>
	{
        public StatusAccountValidator()
        {
			RuleFor(status => status)
				.NotEmpty().WithMessage(GenericErrors.Required)
					.NotNull().WithMessage(GenericErrors.Required);

			RuleFor(x => x.Name)
				.NotEmpty().WithMessage(GenericErrors.Required)
					.NotNull().WithMessage(GenericErrors.Required);
		}
    }
}
