using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace _3oChallengeApp
{
    public class AuthentificationHelper
    {
        public static string GetUserId(ClaimsPrincipal user)
        {
            string userId = null;
            if (user.HasClaim(c => c.Type == ClaimTypes.NameIdentifier))
            {
                userId = user.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value;
            }
            return userId;
        }
    }
}
