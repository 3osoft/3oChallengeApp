using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using _3oChallengeApp.Services;
using _3oChallengeDomain;

namespace _3oChallengeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChallengesController : ControllerBase
    {
        private readonly ChallengeService _challengeService;

        public ChallengesController(ChallengeService challengeService)
        {
            _challengeService = challengeService;
        }

        // GET: api/challenges
        [HttpGet]
        public IEnumerable<Challenge> GetChallenges()
        {
            return _challengeService.GetAllChallenges();
        }

        
    }
}