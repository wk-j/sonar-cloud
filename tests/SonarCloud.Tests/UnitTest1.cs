using System;
using Xunit;
using SonarCloud;

namespace SonarCloud.Tests {
    public class UnitTest1 {
        [Theory]
        [InlineData(Color.Green, Color.Blue)]
        public void TestService(Color input, Color expect) {
            var service = new Service();
            var color = service.GetNextColor(input);
            Assert.Equal(expect, color);
        }
    }
}