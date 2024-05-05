using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using SocialQuantum.Application.CQRS.FollowAccount.Commands;
using SocialQuantum.Domain.Entities;
using SocialQuantum.Domain.Interfaces;

namespace SocialQuantum.Application.CQRS.FollowAccount.Handler
{
	public class FollowCreateCommandHandler : IRequestHandler<FollowCreateCommand, Follow>
	{
		private readonly IFollowRepository _followerRepository;
		private readonly IValidator<Follow> _validator;
		private readonly IMapper _mapper;

		public FollowCreateCommandHandler(IFollowRepository followerRepository, IValidator<Follow> validator, IMapper mapper)
		{
			_followerRepository = followerRepository;
			_validator = validator;
			_mapper = mapper;
		}

		public async Task<Follow> Handle(FollowCreateCommand request, CancellationToken cancellationToken)
		{
			Follow follower = _mapper.Map<Follow>(request);

			ValidationResult validationResults = _validator.Validate(follower);
			if (!validationResults.IsValid) throw new ValidationException(validationResults.Errors);

			return await _followerRepository.CreateAsync(follower);
		}
	}
}
