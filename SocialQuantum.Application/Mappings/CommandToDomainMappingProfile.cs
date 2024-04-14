using AutoMapper;
using SocialQuantum.Application.Core.UserProfiles.Commands;
using SocialQuantum.Domain.Entities;

namespace SocialQuantum.Application.Mappings
{
	public class CommandToDomainMappingProfile : Profile
	{
        public CommandToDomainMappingProfile()
        {
			CreateMap<UserProfileCreateCommand, UserProfile>();
			CreateMap<UserProfileUpdateCommand, UserProfile>();
		}
    }
}
