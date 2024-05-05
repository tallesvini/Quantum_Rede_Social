using AutoMapper;
using SocialQuantum.Application.DTOs;
using SocialQuantum.Application.DTOs.Follows;
using SocialQuantum.Application.DTOs.StatusAccount;
using SocialQuantum.Application.DTOs.UserProfile;
using SocialQuantum.Application.DTOs.Visibility;
using SocialQuantum.Domain.Entities;

namespace SocialQuantum.Application.Mappings
{
	public class DomainToDTOMappingProfile : Profile
	{
        public DomainToDTOMappingProfile()
        {
            CreateMap<User, UserProfileDTO>().ReverseMap();
            CreateMap<User, UserProfilePersistenceDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();

            CreateMap<StatusAccount, StatusAccountDTO>().ReverseMap();
            CreateMap<StatusAccount, StatusAccountPersistenceDTO>().ReverseMap();

            CreateMap<Visibility, VisibilityDTO>().ReverseMap();

            CreateMap<Follow, FollowDTO>().ReverseMap();
            CreateMap<Follow, FollowPersistenceDTO>().ReverseMap();
            CreateMap<Follow, FollowingDTO>().ReverseMap();
            CreateMap<Follow, FollowerDTO>().ReverseMap();
        }
    }
}
