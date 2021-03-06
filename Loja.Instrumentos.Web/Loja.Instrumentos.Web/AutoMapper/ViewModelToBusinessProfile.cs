﻿using AutoMapper;
using Loja.Instrumentos.Business;
using Loja.Instrumentos.Web.ViewModels.Particulars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Loja.Instrumentos.Web.AutoMapper
{
    public class ViewModelToBusinessProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<ParticularsViewModel, Particulars>();
        }
    }
}