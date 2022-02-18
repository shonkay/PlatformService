using AutoMapper;
using PlatformService.DTOs;
using PlatformService.Models;

namespace PlatformService.Mappings
{
    public class PlatformMapping : Profile
    {
        public PlatformMapping()
        {
            CreateMap<Platform, ReadPlatformDTO>();

            CreateMap<CreatePlatformDTO, Platform>();
        }
    }
}
