using AutoMapper;
using SocialQuantum.Application.DTOs;
using SocialQuantum.Domain.Entities;

namespace SocialQuantum.Application.Mappings
{
	public class DomainToDTOMappingProfile : Profile
	{
        public DomainToDTOMappingProfile()
        {
            CreateMap<UserProfile, UserProfileDTO>().ReverseMap();
            CreateMap<UserProfile, UserProfilePersistenceDTO>().ReverseMap();
        }
    }
}
