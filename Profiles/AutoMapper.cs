using AutoMapper;
using StudentAPI.Models;
using StudentAPI.Entities;

namespace StudentAPI.Profiles
{
    public class AutoMapper:Profile
    { 
        public AutoMapper() {
            CreateMap<StudentDeets, StudentDto>();
            CreateMap<StudentDto, StudentDeets>();
       
        }
    }
}
