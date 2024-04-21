using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using SocialQuantum.Application.CQRS.UserProfiles.Commands;
using SocialQuantum.Domain.Entities;
using SocialQuantum.Domain.Interfaces;

namespace SocialQuantum.Application.CQRS.Handles.UserProfile
{
	public class UserProfileUpdateCommandHandler : IRequestHandler<UserProfileUpdateCommand, User>
	{
		private readonly IUserProfileRepository _userProfileRepository;
		private readonly IValidator<User> _validator;
		private readonly IMapper _mapper;

		public UserProfileUpdateCommandHandler(IUserProfileRepository userProfileRepository, IValidator<User> validator, IMapper mapper)
		{
			_userProfileRepository = userProfileRepository;
			_validator = validator;
			_mapper = mapper;
		}

		public async Task<User> Handle(UserProfileUpdateCommand request, CancellationToken cancellationToken)
		{
			User userProfileById = await _userProfileRepository.GetByIdAsync(request.Id);
			if (userProfileById == null) throw new ApplicationException("Error: The item could not be found.");

			User userProfile = _mapper.Map(request, userProfileById);

			ValidationResult validationResults = _validator.Validate(userProfile);
			if (!validationResults.IsValid) throw new ValidationException(validationResults.Errors);

			return await _userProfileRepository.UpdateAsync(userProfile);
		}
	}
}
