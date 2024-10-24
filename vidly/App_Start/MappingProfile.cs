using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;
namespace Vidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {   // Domain to Dto
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();


            // Dto to Domain
            //Mapper.CreateMap<Customer, CustomerDto>()
            //   .ForMember(c => c.Id, opt => opt.Ignore());


        }
    }
}