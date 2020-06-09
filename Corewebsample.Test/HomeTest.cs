using Corewebsample.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace Corewebsample.Test
{
    public class HomeTest
    {
        [Fact]
        public void Index1()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.NotNull(result);
        }
        [Fact]
        public void Privacy()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Privacy() as ViewResult;

            // Assert
            Assert.NotNull(result);
        }
    }
}

