using AutoMapper;
using SocialQuantum.Application.Core.UserProfiles.Commands;
using SocialQuantum.Application.DTOs;

namespace SocialQuantum.Application.Mappings
{
	public class DTOToCommandMappingProfile : Profile
	{
        public DTOToCommandMappingProfile()
        {
            CreateMap<UserProfileDTO, UserProfileDeleteCommand>();
            CreateMap<UserProfilePersistenceDTO, UserProfileCreateCommand>();
            CreateMap<UserProfilePersistenceDTO, UserProfileUpdateCommand>();
        }
    }
}
