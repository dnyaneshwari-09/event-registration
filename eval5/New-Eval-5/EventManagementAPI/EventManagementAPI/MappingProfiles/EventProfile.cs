using AutoMapper;
using EventManagementAPI.DTOs;
using EventManagementAPI.Models;
using EventManagementAPI.Models.DTOs;

namespace EventManagementAPI.MappingProfiles
{
    public class EventProfile : Profile
    {
        public EventProfile()
        {
            CreateMap<Event, EventDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Registration, RegistrationDto>().ReverseMap(); 
            CreateMap<TicketType, TicketTypeDTO>().ReverseMap();
            CreateMap<Payment, PaymentDTO>().ReverseMap();

        }
    }
}
