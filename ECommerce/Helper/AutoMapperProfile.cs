using AutoMapper;
using ECommerce.Data;
using ECommerce.ViewModels;

namespace ECommerce.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() {
        CreateMap<RegisterVM, KhachHang>()
                
                /*.ForMember(kh =>kh.HoTen,options => options.MapFrom(RegisterVM => RegisterVM.HoTen)).ReverseMap()*/; 
        }
    }
}
