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
				.NotEmpty().WithMessage(CreateStatusAccountErrors.Required)
					.NotNull().WithMessage(CreateStatusAccountErrors.Required);

			RuleFor(x => x.Name)
				.NotEmpty().WithMessage(CreateStatusAccountErrors.Required)
					.NotNull().WithMessage(CreateStatusAccountErrors.Required);
		}
    }
}
