using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCuaTui.Models
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<HangHoa, HangHoaViewModel>();
            //Map 2 chiều
            //CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
