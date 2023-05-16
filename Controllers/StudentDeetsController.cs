using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentAPI.Models;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentDeetsController : ControllerBase
    {
        private readonly StudentContext _context;

        public StudentDeetsController(StudentContext context)
        {
            _context = context;
        }

        // GET: api/StudentDeets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentDeet>>> GetStudentDeets()
        {
          if (_context.StudentDeets == null)
          {
              return NotFound();
          }
            return await _context.StudentDeets.ToListAsync();
        }

        // GET: api/StudentDeets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StudentDeet>> GetStudentDeet(int id)
        {
          if (_context.StudentDeets == null)
          {
              return NotFound();
          }
            var studentDeet = await _context.StudentDeets.FindAsync(id);

            if (studentDeet == null)
            {
                return NotFound();
            }

            return studentDeet;
        }

        // PUT: api/StudentDeets/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudentDeet(int id, StudentDeet studentDeet)
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
        public async Task<ActionResult<StudentDeet>> PostStudentDeet(StudentDeet studentDeet)
        {
          if (_context.StudentDeets == null)
          {
              return Problem("Entity set 'StudentContext.StudentDeets'  is null.");
          }
            _context.StudentDeets.Add(studentDeet);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudentDeet", new { id = studentDeet.Id }, studentDeet);
        }

        // DELETE: api/StudentDeets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudentDeet(int id)
        {
            if (_context.StudentDeets == null)
            {
                return NotFound();
            }
            var studentDeet = await _context.StudentDeets.FindAsync(id);
            if (studentDeet == null)
            {
                return NotFound();
            }

            _context.StudentDeets.Remove(studentDeet);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StudentDeetExists(int id)
        {
            return (_context.StudentDeets?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
