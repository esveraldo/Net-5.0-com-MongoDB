using Api.Entities;
using Api.Entities.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Mappers
{
    public class ViewModelParaEntity : Profile
    {
        public ViewModelParaEntity()
        {
            CreateMap<News, NewsViewModel>();
        }
    }
}
