using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using SocialQuantum.Application.CQRS.UserProfiles.Commands;
using SocialQuantum.Domain.Entities;
using SocialQuantum.Domain.Interfaces;

namespace SocialQuantum.Application.CQRS.UserProfiles.Handles
{
	public class UserProfileCreateCommandHandler : IRequestHandler<UserProfileCreateCommand, User>
	{
		private readonly IUserProfileRepository _userProfileRepository;
		private readonly IValidator<User> _validator;
		private readonly IMapper _mapper;

		public UserProfileCreateCommandHandler(IUserProfileRepository userProfileRepository, IValidator<User> validator, IMapper mapper)
		{
			_userProfileRepository = userProfileRepository;
			_validator = validator;
			_mapper = mapper;
		}

		public async Task<User> Handle(UserProfileCreateCommand request, CancellationToken cancellationToken)
		{
			User userProfile = _mapper.Map<User>(request);

			ValidationResult validationResults = _validator.Validate(userProfile);
			if (!validationResults.IsValid) throw new ValidationException(validationResults.Errors);		

			return await _userProfileRepository.CreateAsync(userProfile);
		}		
	}
}
