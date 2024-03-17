using AutoMapper;
using OneRecord.Data.Model.Model;
using Tracking.Api.Dto;
using Tracking.Data.DomainModel;
namespace Tracking.Api.Profile
{
    public class MappingProfile : AutoMapper.Profile
    {
        public MappingProfile()
        {
            CreateMap<ShipmentModel,ShipmentDto>()
            .ForAllMembers(opts =>
            {
                opts.AllowNull();
                opts.Condition((src, dest, srcMember) => srcMember != null);
            });
            CreateMap<PieceModel,PieceDto>().ForAllMembers(opts =>
            {
                opts.AllowNull();
                opts.Condition((src, dest, srcMember) => srcMember != null);
            }); ;
            CreateMap<FlightModel,FlightDto>().ForAllMembers(opts =>
            {
                opts.AllowNull();
                opts.Condition((src, dest, srcMember) => srcMember != null);
            }); ;
        }
    }
}
