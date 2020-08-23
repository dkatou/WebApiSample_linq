using System;
using System.Reflection;
using Xunit;
using Xunit.Abstractions;
using Microsoft.EntityFrameworkCore;
using dk.A1.S1.UserMng.UserMngModel.Models;
using dk.A1.S1.UserMng.UserMngModel.Datas;

namespace dk.A1.S1.UserMng.UserMngModelTest.Tests
{
    public class UserMngContextTest
    {
        private readonly ITestOutputHelper _output;

        public UserMngContextTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void UserMngContextTest01()
        {
            var options = new DbContextOptionsBuilder<UserMngContext>()
                .UseInMemoryDatabase("data")
                .Options;

            using (var context = new UserMngContext(options))
            {
                context.Database.EnsureCreated();
                context.UserMst.Add(new UserMst { UserId = 1, ComId = 2 });
                Assert.True(context.UserMst != null);
            }
        } 
    }
}