using AutoMapper;

using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Models.Dtos.AboutDto;
using HotelProject.WebUI.Models.Dtos.LoginDto;
using HotelProject.WebUI.Models.Dtos.RegisterDto;
using HotelProject.WebUI.Models.Dtos.ServiceDto;
using HotelProject.WebUI.Models.Dtos.StaffDto;
using HotelProject.WebUI.Models.Dtos.SubscribeDto;

namespace HotelProject.WebUI.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();
            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDto,AppUser>().ReverseMap(); 

            CreateMap<ResultAboutDto, About>().ReverseMap(); 
            CreateMap<UpdateAboutDto, About>().ReverseMap(); 
            CreateMap<ResultStaffDto,Staff>().ReverseMap(); 
            CreateMap<CreateSubscribeDto,Subscribe>().ReverseMap(); 
        }
    }
}
