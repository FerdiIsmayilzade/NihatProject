using AutoMapper;
using Domain.Entities;
using Repository.Exceptions;
using Repository.Repositories.Interfaces;
using Service.Helper.DTOs.Features;
using Service.Services.Interfaces;

namespace Service.Services
{
    public class FeatureService : IFeatureService
    {
        private readonly IFeatureRepository _featureRepository;
        private readonly IMapper _mapper;

        public FeatureService(IFeatureRepository featureRepository,
                              IMapper mapper)
        {
            _featureRepository = featureRepository;
            _mapper = mapper;
        }
        public async Task CreateAsync(FeatureCreateDto feature)
        {
            await _featureRepository.CreateAsync(_mapper.Map<Feature>(feature));
        }

        public async Task<IEnumerable<FeatureDto>> GetAllAsync()
        {
            return _mapper.Map<IEnumerable<FeatureDto>>(await _featureRepository.GetAllAsync());
        }

        public async Task<FeatureDto> GetBtIdAsync(int id)
        {
            return _mapper.Map<FeatureDto>(await _featureRepository.GetByIdAsync(id))
                            ?? throw new NotFoundException(ExceptionMessages.NotFoundMessage);
        }
    }
}
