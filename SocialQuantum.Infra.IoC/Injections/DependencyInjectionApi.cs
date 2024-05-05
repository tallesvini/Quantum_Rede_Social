using FluentValidation;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SocialQuantum.Application.Interfaces;
using SocialQuantum.Application.Mappings;
using SocialQuantum.Application.Services;
using SocialQuantum.Domain.Entities;
using SocialQuantum.Domain.Interfaces;
using SocialQuantum.Domain.Validation;
using SocialQuantum.Infra.Data.Context;
using SocialQuantum.Infra.Data.Repositories;

namespace SocialQuantum.Infra.IoC.Injections
{
	public static class DependencyInjectionApi
	{
		public static IServiceCollection AddDbConnection(
				this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<AppDbContext>(options =>
			{
				options.UseOracle(configuration.GetConnectionString("DefaultConnectionApi"));
				options.UseLazyLoadingProxies(); // Ativar carregamento preguiçoso
			});

			return services;
		}

		public static IServiceCollection AddInfrastructure(this IServiceCollection services)
		{
			var handles = AppDomain.CurrentDomain.Load("SocialQuantum.Application");
			services.AddMediatR(handles);

			services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

			return services;
		}

		public static IServiceCollection AddDependencies(this IServiceCollection services)
		{
			services.AddScoped<IUserProfileRepository, UserProfileRepository>();
			services.AddScoped<IUserProfileService, UserProfileService>();

			services.AddScoped<IStatusAccountRepository, StatusAccountRepository>();
			services.AddScoped<IStatusAccountService, StatusAccountService>();

			services.AddScoped<IVisibilityRepository, VisibilityRepository>();
			services.AddScoped<IVisibilityService, VisibilityService>();

			services.AddScoped<IFollowRepository, FollowRepository>();
			services.AddScoped<IFollowService, FollowService>();

			return services;
		}

		public static IServiceCollection AddFluentValidation(this IServiceCollection services)
		{
			services.AddFluentValidationAutoValidation();
			services.AddTransient<IValidator<User>, UserProfileValidator>();
			services.AddTransient<IValidator<StatusAccount>, StatusAccountValidator>();
			services.AddTransient<IValidator<Follow>, FollowValidator>();
			return services;
		}
	}
}
