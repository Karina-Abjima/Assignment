
   // using Microsoft.AspNetCore.JsonPatch;
    using Microsoft.EntityFrameworkCore;
    using StudentAPI.Models;
    using StudentAPI.Entities;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace StudentAPI.Services
    {
        public class StudentRepository : IStudentRepository
        {
            private readonly StudentContext _context;

            public StudentRepository(StudentContext context)
            {
                _context = context;
            }

            public async Task<IEnumerable<StudentDeets>> GetStudents()
            {
                return await _context.StudentDeet.ToListAsync();
            }

        public async Task<StudentDeets> AddStudentAsync(StudentDeets studentData)
        {
            throw new NotImplementedException();
            /*_context.StudentDeet.Add(studentData);
            var s = await _context.SaveChangesAsync();
            return CreatedAtAction("GetStudentsDataTable", new { id = studentData.RollNo }, studentData); ;
        */
        }
            public Task<StudentDeets> DeleteStudentAsync(int id)
            {
                throw new NotImplementedException();
            }

            public async Task<StudentDeets> GetStudentByIdAsync(int id)
            {
               var student=await _context.StudentDeet.FindAsync(id);
            return student;
            }

            public Task<StudentDeets> UpdateStudentAsync(int id, StudentDeets studentData)
            {
                throw new NotImplementedException();
            }

            public Task<StudentDeets> UpdateStudentPatchAysnc(int id, JsonPatchDocument studentPatch)
            {
                throw new NotImplementedException();
            }
        }
    }

