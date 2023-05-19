
   // using Microsoft.AspNetCore.JsonPatch;
    using Microsoft.EntityFrameworkCore;
    using StudentAPI.Models;
    using StudentAPI.Entities;
using Microsoft.AspNetCore.JsonPatch;

namespace StudentAPI.Services
    {
        public class StudentRepository : IStudentRepository
        {
            private readonly StudentContext _context;

            public StudentRepository(StudentContext context)
            {
                _context = context;
            }

            public async Task<IEnumerable<StudentDeet>> GetStudentsAsync()
            {
                return await _context.StudentsDto.ToListAsync();
            }

            public Task<StudentDeet> AddStudentAsync(StudentDeet studentData)
            {
                throw new NotImplementedException();
            }

            public Task<StudentDeet> DeleteStudentAsync(int id)
            {
                throw new NotImplementedException();
            }

            public Task<StudentDeet> GetStudentByIdAsync(int id)
            {
                throw new NotImplementedException();
            }

            public Task<StudentDeet> UpdateStudentAsync(int id, StudentDeet studentData)
            {
                throw new NotImplementedException();
            }

            public Task<StudentDeet> UpdateStudentPatchAysnc(int id, JsonPatchDocument studentPatch)
            {
                throw new NotImplementedException();
            }
        }
    }

