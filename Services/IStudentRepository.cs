
using Microsoft.AspNetCore;
using StudentAPI.Models;
using StudentAPI.Entities;
namespace StudentAPI.Services


{
    public interface IStudentRepository
        {
            Task<IEnumerable<StudentDeet>> GetStudentsAsync();
            Task<StudentDeet> GetStudentByIdAsync(int id);
            Task<StudentDeet> AddStudentAsync(StudentDeet studentData);
            Task<StudentDeet> DeleteStudentAsync(int id);
            Task<StudentDeet> UpdateStudentAsync(int id, StudentDeet studentData);
            Task<StudentDeet> UpdateStudentPatchAysnc(int id, JsonPatchDocument studentPatch);
        }
    }
