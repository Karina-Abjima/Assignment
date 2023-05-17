using AutoMapper;
using StudentAPI.Models;
using StudentAPI.Entities;

namespace StudentAPI.Profiles
{
    public class AutoMapper:Profile
    {
        public AutoMapper() {
            CreateMap<StudentDeet, StudentDto>();
            CreateMap<StudentDto, StudentDeet>();
        }
    }
}
