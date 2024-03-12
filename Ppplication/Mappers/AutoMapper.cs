using Application.UseCases.MediumUser.Comands;
using AutoMapper;
using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappers
{
    public class AutoMapper:Profile
    {
        public AutoMapper()
        {
            CreateMap<UserModel,CreateUserComand>().ReverseMap();
               
        }
    }
}
