using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using SocialQuantum.Application.Core.UserProfiles.Commands;
using SocialQuantum.Domain.Entities;
using SocialQuantum.Domain.Interfaces;

namespace SocialQuantum.Application.Core.UserProfiles.Handles
{
	public class UserProfileCreateCommandHandler : IRequestHandler<UserProfileCreateCommand, UserProfile>
	{
		private readonly IUserProfileRepository _userProfileRepository;
		private readonly IValidator<UserProfile> _validator;
		private readonly IMapper _mapper;

		public UserProfileCreateCommandHandler(IUserProfileRepository userProfileRepository, IValidator<UserProfile> validator, IMapper mapper)
		{
			_userProfileRepository = userProfileRepository;
			_validator = validator;
			_mapper = mapper;
		}

		public async Task<UserProfile> Handle(UserProfileCreateCommand request, CancellationToken cancellationToken)
		{
			UserProfile userProfile = _mapper.Map<UserProfile>(request);

			ValidationResult validationResults = _validator.Validate(userProfile);
			if (!validationResults.IsValid) throw new ValidationException(validationResults.Errors);		

			return await _userProfileRepository.CreateAsync(userProfile);
		}		
	}
}
