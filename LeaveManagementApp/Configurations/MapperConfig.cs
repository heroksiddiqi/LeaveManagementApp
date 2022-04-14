using AutoMapper;
using LeaveManagementApp.Data;
using LeaveManagementApp.Models;

namespace LeaveManagementApp.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            // Syntax: CreateMap<Source_Type, LeaveTypeVM>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
        }
    }
}








