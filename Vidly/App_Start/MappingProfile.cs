using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidly.Models;
using Vidly.Dtos;

namespace Vidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Dto
            //Mapper.Map<Customer, CustomerDto>();
            //Mapper.Map<Movie, MovieDto>();
            //Mapper.Map<MembershipType, MembershipTypeDto>();
            //Mapper.Map<Genre, GenreDto>();



            //Mapper.Map<CustomerDto, Customer>()
            //    .ForMember(c => c.Id, opt => opt.Ignore());
            //Mapper.Map<MovieDto, Movie>()
            //    .ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.Initialize(cfg => {
                // Domain to Dto
                cfg.CreateMap<Customer, CustomerDto>();
                cfg.CreateMap<Movie, MovieDto>();
                cfg.CreateMap<MembershipType, MembershipTypeDto>();
                cfg.CreateMap<Genre, GenreDto>();
                // Dto to Domain
                cfg.CreateMap<CustomerDto, Customer>()
                    .ForMember(c => c.Id, opt => opt.Ignore());
                cfg.CreateMap<MovieDto, Movie>()
                    .ForMember(c => c.Id, opt => opt.Ignore());
            });
        }
    }
}