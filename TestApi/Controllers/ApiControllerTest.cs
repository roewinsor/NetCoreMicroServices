using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Controllers;
using WebApi.Models;
using WebApi.Services;
using Xunit;
using Moq;

namespace TestApi.Controllers
{
    public class ApisControllerTest
    {
        protected ApisController ControllerToTest { get; }
        protected Mock<IApiService> ApiServiceMock { get; }

        public ApisControllerTest()
        {   

            ApiServiceMock = new Mock<IApiService>(); //mock
            ControllerToTest = new ApisController(ApiServiceMock.Object);
        }

        public class ReadAllAsync : ApisControllerTest
        {
            [Fact]
            public async void MustReturnAllApis()
            {
                // Arrange
                var expectedApis = new Api[]
                {
                    new Api { Name = "Testing Api 1" },
                    new Api { Name = "Testing Api 2" },
                    new Api { Name = "Testing Api 3" }
                };
                ApiServiceMock
                   .Setup(x => x.ReadAllAsync())
                   .ReturnsAsync(expectedApis); 
                // Act
                var result = await ControllerToTest.ReadAllAsync();

                // Assert
                var okResult = Assert.IsType<OkObjectResult>(result);
                Assert.Same(expectedApis, okResult.Value);
            }
        }
    }
}
