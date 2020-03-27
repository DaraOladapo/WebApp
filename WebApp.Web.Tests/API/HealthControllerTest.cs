using System;
using System.Net.Http;
using WebApp.Web.Controllers.API;
using Xunit;

namespace WebAppp.Web.Tests.API
{
    public class HealthControllerTest
    {
        HealthController healthController = new HealthController();
        [Fact]
        public void Ping()
        {
            var actionResuilt = healthController.Ping();
            Assert.NotNull(actionResuilt);
        }
    }
}
