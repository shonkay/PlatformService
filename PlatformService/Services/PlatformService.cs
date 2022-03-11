using AutoMapper;
using PlatformService.DTOs;
using PlatformService.Interface;
using PlatformService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<ResponseModel> GetAllPlatform()
        {
            Console.WriteLine(" --> Getting All Platforms --->");
            var query = await _unitOfWork.Platform.GetAll();

            var map = _mapper.Map<IEnumerable<ReadPlatformDTO>>(query);
            return new ResponseModel
            {
                ResponseMessage = $"Found {query.Count()} Records",
                ResponseObject = map
            };
        }

        public async Task<ResponseModel> GetByPlatformId(Guid Id)
        {
            Console.WriteLine(" --> Getting All Platforms --->");
            var query = await _unitOfWork.Platform.GetById(Id);

            if(query == null)
            {
                throw new Exception("Not Found");
            }

            var map = _mapper.Map<ReadPlatformDTO>(query);
            return new ResponseModel
            {
                ResponseMessage = $"Found Platform With Id {Id}",
                ResponseObject = map
            };
        }

        public async Task<ResponseModel> CreatePlatform(CreatePlatformDTO createPlatform)
        {
            var platformMap = new Platform
            {
                Id = Guid.NewGuid(),
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now,
                Isdeleted = false,
                Cost = createPlatform.Cost,
                PlatformName = createPlatform.PlatformName,
                Publisher = createPlatform.Publisher
            };

            _unitOfWork.Platform.Add(platformMap);
            await _unitOfWork.Complete();

            return new ResponseModel
            {
                ResponseMessage = $"{platformMap.PlatformName} Created Successfully"
            };

        }


    }

   
}
