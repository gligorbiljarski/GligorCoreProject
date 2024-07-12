using AutoMapper;
using GligorCoreProject.Web.Data;
using GligorCoreProject.Web.Models.LeaveTypes;

namespace GligorCoreProject.Web.MappingProfiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<LeaveType, LeaveTypeReadOnlyVM>();
               // .ForMember(dest => dest.NumberOfDays, opt => opt.MapFrom(src => src.NumberOfDays));
            CreateMap<LeaveTypeCreateVM, LeaveType>();
        }
    }
}
