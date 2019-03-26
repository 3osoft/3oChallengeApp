using _3oChallengeDomain;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace _3oChallengeApp.Services
{
    public class UserService
    {
        private readonly IUserRepository _repository;
        private readonly IConfiguration _configuration;

        public UserService(IUserRepository repository, IConfiguration configuration)
        {
            _repository = repository;
            _configuration = configuration;
        }

        public async Task<HttpResponseMessage> GetUserDetail(string accessToken)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://{_configuration["Auth0:Domain"]}/userinfo");
            request.Headers.Add("Authorization", accessToken);

            var client = new HttpClient();
            var response = await client.SendAsync(request);
            return response;
        }

    }
}
