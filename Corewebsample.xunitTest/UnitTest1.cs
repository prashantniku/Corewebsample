using Corewebsample.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace Corewebsample.xunitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.NotNull(result);
        }
    }
}
