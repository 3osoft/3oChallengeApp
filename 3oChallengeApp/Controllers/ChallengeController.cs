using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using _3oChallengeApp.Services;
using _3oChallengeDomain;
using Microsoft.AspNetCore.Authorization;
using System;
using Microsoft.AspNetCore.Http;

namespace _3oChallengeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ChallengeController : ControllerBase
    {
        private readonly ChallengeService _challengeService;

        public ChallengeController(ChallengeService challengeService)
        {
            _challengeService = challengeService;
        }

        // GET: api/challenge
        [HttpGet]
        public IEnumerable<Challenge> GetChallenges()
        {
            return _challengeService.GetAllChallenges();
        }

        // POST: api/challenge
        [HttpPost]
        public IActionResult CreateChallenge([FromBody] ChallengeJsonRequest data)
        {
            try
            {
                string creatorId = AuthentificationHelper.GetUserId(HttpContext.User);
                var newChallenge = _challengeService.Create(creatorId, data);
                return Ok(newChallenge);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
            
        }


    }
}