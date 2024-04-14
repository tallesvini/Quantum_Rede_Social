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
				options.UseNpgsql(configuration.GetConnectionString("DefaultConnectionApi"),
					npgsqlOptions => npgsqlOptions.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)));

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

			return services;
		}

		public static IServiceCollection AddFluentValidation(this IServiceCollection services)
		{
			services.AddFluentValidationAutoValidation();
			services.AddTransient<IValidator<UserProfile>, UserProfileValidator>();
			return services;
		}
	}
}
