﻿using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using SocialQuantum.Application.CQRS.Status.Commands;
using SocialQuantum.Domain.Entities;
using SocialQuantum.Domain.Interfaces;

namespace SocialQuantum.Application.CQRS.Status.Handles
{
	public class StatusAccountCreateCommandHandler : IRequestHandler<StatusAccountCreateCommand, StatusAccount>
	{
		private readonly IStatusAccountRepository _statusAccountRepository;
		private readonly IValidator<StatusAccount> _validator;
		private readonly IMapper _mapper;

		public StatusAccountCreateCommandHandler(IStatusAccountRepository statusAccountRepository, IValidator<StatusAccount> validator, IMapper mapper)
		{
			_statusAccountRepository = statusAccountRepository;
			_validator = validator;
			_mapper = mapper;
		}

		public async Task<StatusAccount> Handle(StatusAccountCreateCommand request, CancellationToken cancellationToken)
		{
			StatusAccount statusAccount = _mapper.Map<StatusAccount>(request);
			
			ValidationResult validationResults = _validator.Validate(statusAccount);
			if (!validationResults.IsValid) throw new ValidationException(validationResults.Errors);

			return await _statusAccountRepository.CreateAsync(statusAccount);
		}
	}
}
