
using Microsoft.AspNetCore;
using StudentAPI.Models;
using StudentAPI.Entities;
using Microsoft.AspNetCore.JsonPatch;

namespace StudentAPI.Services


{
    public interface IStudentRepository
        {
            Task<IEnumerable<StudentDeets>> GetStudents();
            Task<StudentDeets> GetStudentByIdAsync(int id);
            Task<StudentDeets> AddStudentAsync(StudentDeets studentData);
            Task<StudentDeets> DeleteStudentAsync(int id);
            Task<StudentDeets> UpdateStudentAsync(int id, StudentDeets studentData);
            Task<StudentDeets> UpdateStudentPatchAysnc(int id, JsonPatchDocument studentPatch);
        }
    }
