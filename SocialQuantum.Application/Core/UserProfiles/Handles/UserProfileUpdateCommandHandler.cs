using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using SocialQuantum.Application.Core.UserProfiles.Commands;
using SocialQuantum.Domain.Entities;
using SocialQuantum.Domain.Interfaces;

namespace SocialQuantum.Application.Core.UserProfiles.Handles
{
	public class UserProfileUpdateCommandHandler : IRequestHandler<UserProfileUpdateCommand, UserProfile>
	{
		private readonly IUserProfileRepository _userProfileRepository;
		private readonly IValidator<UserProfile> _validator;
		private readonly IMapper _mapper;

		public UserProfileUpdateCommandHandler(IUserProfileRepository userProfileRepository, IValidator<UserProfile> validator, IMapper mapper)
		{
			_userProfileRepository = userProfileRepository;
			_validator = validator;
			_mapper = mapper;
		}

		public async Task<UserProfile> Handle(UserProfileUpdateCommand request, CancellationToken cancellationToken)
		{
			UserProfile userProfileById = await _userProfileRepository.GetByIdAsync(request.Id);
			if (userProfileById == null) throw new ApplicationException("Error: The item could not be found.");

			UserProfile userProfile = _mapper.Map(request, userProfileById);

			ValidationResult validationResults = _validator.Validate(userProfile);
			if (!validationResults.IsValid) throw new ValidationException(validationResults.Errors);

			return await _userProfileRepository.UpdateAsync(userProfile);
		}
	}
}
