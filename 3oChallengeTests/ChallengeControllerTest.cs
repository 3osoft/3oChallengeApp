using _3oChallengeDataAccess;
using _3oChallengeDomain;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace _3oChallengeTests
{
    public class ChallengeControllerTest
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var mockRepo = new Mock<IChallengeRepository>();
            mockRepo.Setup(repo => repo.GetAllChallenges());

            // Act
            var result = mockRepo.Object.GetAllChallenges();

            // Assert
            Assert.Empty(result);
        }
    }
}
