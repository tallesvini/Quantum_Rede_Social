using AutoMapper;
using SocialQuantum.Application.CQRS.FollowAccount.Commands;
using SocialQuantum.Application.CQRS.Status.Commands;
using SocialQuantum.Application.CQRS.UserProfiles.Commands;
using SocialQuantum.Application.DTOs;
using SocialQuantum.Application.DTOs.Follows;
using SocialQuantum.Application.DTOs.StatusAccount;

namespace SocialQuantum.Application.Mappings
{
	public class DTOToCommandMappingProfile : Profile
	{
        public DTOToCommandMappingProfile()
        {
            CreateMap<UserProfilePersistenceDTO, UserProfileCreateCommand>();
            CreateMap<UserProfilePersistenceDTO, UserProfileUpdateCommand>();

			CreateMap<StatusAccountPersistenceDTO, StatusAccountCreateCommand>();
			CreateMap<StatusAccountPersistenceDTO, StatusAccountUpdateCommand>();

			CreateMap<FollowPersistenceDTO, FollowCreateCommand>();
		}
    }
}
