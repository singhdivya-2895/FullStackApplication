﻿using AutoMapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Automapper
{
    public  class Mapperprofile :Profile
    {
        public Mapperprofile()
        {
            CreateMap<Activity,Activity>();
        }
    }
}
