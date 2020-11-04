using AutoMapper;
using Pegusus.Data.Model;
using Pegusus.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pegusus.Connector.Mapper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserViewModels>();
        }
     
    }
}
