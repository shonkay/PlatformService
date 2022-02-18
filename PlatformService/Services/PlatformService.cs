using AutoMapper;
using PlatformService.DTOs;
using PlatformService.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PlatformService.Services
{
    public class PlatformServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PlatformServices(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ReadPlatformDTO>> GetAllPlatform()
        {
            Console.WriteLine(" --> Getting All Platforms --->");
            var query = await _unitOfWork.Platform.GetAll();

            return _mapper.Map<IEnumerable<ReadPlatformDTO>>(query);
        }
    }

   
}
