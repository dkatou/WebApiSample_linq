using System;
using System.Reflection;
using Xunit;
using Xunit.Abstractions;
using dk.A1.S1.UserMng.UserMngModel.Models;

namespace dk.A1.S1.UserMng.UserMngModelTest.Tests
{
    public class UserMstTest
    {
        private readonly ITestOutputHelper _output;

        public UserMstTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void UserIdTest()
        {
            UserMst userMst = new UserMst();
            userMst.UserId = 1;
            userMst.ComId = 2;
        }
    }
}
