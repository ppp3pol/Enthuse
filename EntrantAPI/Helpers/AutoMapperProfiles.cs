using AutoMapper;
using EntrantAPI.Entities;
using EntrantAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntrantAPI.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<CreateEntrantDTO, Entrant>();
            CreateMap<Entrant, CreateEntrantDTO>();
        }
    }
}
