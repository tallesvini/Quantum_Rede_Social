using AutoMapper;
using SocialQuantum.Application.CQRS.FollowAccount.Commands;
using SocialQuantum.Application.CQRS.Status.Commands;
using SocialQuantum.Application.CQRS.UserProfiles.Commands;
using SocialQuantum.Domain.Entities;

namespace SocialQuantum.Application.Mappings
{
	public class CommandToDomainMappingProfile : Profile
	{
        public CommandToDomainMappingProfile()
        {
			CreateMap<UserProfileCreateCommand, User>().ForMember(dest => dest.CreationDate, opt => opt.MapFrom(src => DateTimeOffset.UtcNow));
			CreateMap<UserProfileUpdateCommand, User>();

			CreateMap<StatusAccountCreateCommand, StatusAccount>().ForMember(dest => dest.CreationDate, opt => opt.MapFrom(src => DateTimeOffset.UtcNow));
			CreateMap<StatusAccountUpdateCommand, StatusAccount>();

			CreateMap<FollowCreateCommand, Follow>().ForMember(dest => dest.CreationDate, opt => opt.MapFrom(src => DateTimeOffset.UtcNow));
		}
    }
}
