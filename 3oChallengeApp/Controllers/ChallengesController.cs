using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _3oChallenge;
using _3oChallengeApp.Models.Entities;

namespace _3oChallengeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChallengesController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public ChallengesController(ApiDbContext context)
        {
            _context = context;
        }

        // GET: api/Challenges
        [HttpGet]
        public IEnumerable<Challenge> GetChallenges()
        {
            return _context.Challenges;
        }

        // GET: api/Challenges/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetChallenge([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var challenge = await _context.Challenges.FindAsync(id);

            if (challenge == null)
            {
                return NotFound();
            }

            return Ok(challenge);
        }

        // PUT: api/Challenges/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChallenge([FromRoute] int id, [FromBody] Challenge challenge)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != challenge.Id)
            {
                return BadRequest();
            }

            _context.Entry(challenge).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChallengeExists(id))
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

        // POST: api/Challenges
        [HttpPost]
        public async Task<IActionResult> PostChallenge([FromBody] Challenge challenge)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Challenges.Add(challenge);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetChallenge", new { id = challenge.Id }, challenge);
        }

        // DELETE: api/Challenges/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChallenge([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var challenge = await _context.Challenges.FindAsync(id);
            if (challenge == null)
            {
                return NotFound();
            }

            _context.Challenges.Remove(challenge);
            await _context.SaveChangesAsync();

            return Ok(challenge);
        }

        private bool ChallengeExists(int id)
        {
            return _context.Challenges.Any(e => e.Id == id);
        }
    }
}