using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationCoreFirst.Data;

namespace WebApplicationCoreFirst.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudResultsController : ControllerBase
    {
        private readonly StudMarksheetContext _context;

        public StudResultsController(StudMarksheetContext context)
        {
            _context = context;
        }
       // StudResult[] GetResult = new StudResult[]

       /*[HttpGet("{RollNo})")]
        public ActionResult<StudResult> GetStudent(int id)

        {

            var student = GetResult.FirstOrDefault((p) => p.RollNo == id);

            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }*/
        [HttpGet("{Id})")]
        public ActionResult GetStudentRecord(int id)
        {
            //var res = _context.StudResult.Find(id).ToString();
            // var res = _context.StudResult.Where(p => p.RollNo == id);
            var res = _context.StudResult.FirstOrDefault((p) => p.Id == id);
            if (res == null)
            {
                return NotFound();
            }

            return Ok(res);
        }

            /*// GET: api/StudResults
            [HttpGet]
            public async Task<ActionResult<IEnumerable<StudResult>>> GetStudResult()
            {
                return await _context.StudResult.ToListAsync();
            }

            // GET: api/StudResults/5
            [HttpGet("{id}")]
            public async Task<ActionResult<StudResult>> GetStudResult(int id)
            {
                var studResult = await _context.StudResult.FindAsync(id);

                if (studResult == null)
                {
                    return NotFound();
                }

                return studResult;
            }

            // PUT: api/StudResults/5
            // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
            [HttpPut("{id}")]
            public async Task<IActionResult> PutStudResult(int id, StudResult studResult)
            {
                if (id != studResult.Id)
                {
                    return BadRequest();
                }

                _context.Entry(studResult).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudResultExists(id))
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

            // POST: api/StudResults
            // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
            [HttpPost]
            public async Task<ActionResult<StudResult>> PostStudResult(StudResult studResult)
            {
                _context.StudResult.Add(studResult);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetStudResult", new { id = studResult.Id }, studResult);
            }

            // DELETE: api/StudResults/5
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteStudResult(int id)
            {
                var studResult = await _context.StudResult.FindAsync(id);
                if (studResult == null)
                {
                    return NotFound();
                }

                _context.StudResult.Remove(studResult);
                await _context.SaveChangesAsync();

                return NoContent();
            }

            private bool StudResultExists(int id)
            {
                return _context.StudResult.Any(e => e.Id == id);
            }*/
        }
}
