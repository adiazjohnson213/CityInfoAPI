using AutoMapper;

namespace CityInfoAPI.Profiles
{
    public class PointsOfInterestProfile : Profile
    {
        public PointsOfInterestProfile()
        {
            CreateMap<Entities.PointOfInterest, Model.PointOfInterestDto>();
            CreateMap<Model.PointOfInterestForCreationDto, Entities.PointOfInterest>();
            CreateMap<Model.PointOfInterestForUpdateDto, Entities.PointOfInterest>();
            CreateMap<Entities.PointOfInterest, Model.PointOfInterestForUpdateDto>();
        }
    }
}
