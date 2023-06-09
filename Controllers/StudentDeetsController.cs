﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentAPI.Entities;
using StudentAPI.Models;
using StudentAPI.Services;
using System.Linq;
using System.Collections.Generic;


namespace StudentAPI.Controllers
{
    [Route("api/[controller]")] 
    [ApiController]
    public class StudentDeetsController : ControllerBase//as needed a view support for future
    {
        private readonly StudentContext _context;
        private readonly IMapper _mapper;
        private readonly IStudentRepository _studentRepository;
        public StudentDeetsController(StudentContext context, IMapper mapper, IStudentRepository studentRepository)
        {
            _context = context;
            _mapper = mapper;
            _studentRepository = studentRepository;
        }

        // GET: api/StudentDeets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentDto>>> GetStudentDeets()
        {
            if (_context.StudentDeet== null)
            {
                return NotFound();
            }
            var student = await _studentRepository.GetStudents();
          //  var mappeditem = _mapper.Map<StudentDto>(student);
            return Ok(_mapper.Map<IEnumerable<StudentDto>>(student));
           
        }

        

        // GET: api/StudentDeets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StudentDeets>> GetStudentDeet(int id)
        {
            if (_context.StudentDeet == null)
            {
                return NotFound();
            }
            var studentDeet = await _context.StudentDeet.FindAsync(id);
            if (studentDeet == null)
            {
                return NotFound();
            }

           
            var item1 = _mapper.Map<StudentDeets>(id);
            return Ok(item1);

           
        }

        // PUT: api/StudentDeets/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=212375 4
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudentDeet(int id, StudentDeets studentDeet)
        {
            if (id != studentDeet.Id)
            {
                return BadRequest();
            }

            _context.Entry(studentDeet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentDeetExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/StudentDeets
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StudentDto>> PostStudentDeet(StudentDto studentDeet)
        {
           // StudentDto studentDto;
            if (_context.StudentDeet == null)
            {
                return Problem("Entity set 'StudentContext.StudentDeets'  is null.");

            }
            //var students = _mapper.Map<StudentDeet>(studentDto);
            //_context.StudentDeets.Add(students);
            //await _contex
            //
            //
            //
            //
            //t.SaveChangesAsync();

            return CreatedAtAction("GetStudentDeet", new { id = studentDeet.Id }, studentDeet);
        }

        // DELETE: api/StudentDeets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudentDeet(int id)
        {
            if (_context.StudentDeet == null)
            {
                return NotFound();
            }
            var studentDeet = await _context.StudentDeet.FindAsync(id);
            if (studentDeet == null)
            {
                return NotFound();
            }

            _context.StudentDeet.Remove(studentDeet);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StudentDeetExists(int id)
        {
            return (_context.StudentDeet?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
    
}
