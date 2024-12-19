using AutoMapper;
using Domain.Entities;
using Service.Helper.DTOs.Discounts;
using Service.Helper.DTOs.Features;

namespace Api_intro.Helpers.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Feature
            CreateMap<Feature, FeatureDto>();
            CreateMap<FeatureCreateDto, Feature>();
            #endregion

            #region Discount
            CreateMap<Discount, DiscountDto>();
            CreateMap<DiscountCreateDto, Discount>();
            CreateMap<DiscountEditDto, Discount>()
                .ForAllMembers(opts =>
                {
                    opts.AllowNull();
                    opts.Condition((src, dest, srcMember) => srcMember != null);
                });
            #endregion
        }
    }
}
