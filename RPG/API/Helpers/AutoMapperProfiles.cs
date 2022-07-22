using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;
using AutoMapper;

namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, MemberDTO>().ForMember(dest=>dest.ProfessionName,
            opt=>
            {
                opt.MapFrom(src=>src.Profession.Name);
            });
        }
    }
}