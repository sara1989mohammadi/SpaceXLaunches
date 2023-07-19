using API.Controllers;
using Application.Interface;
using Domain;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SpaceXLaunchesTest
{
    public class LauncheControllerTests
    {
        [Fact]
        public void Can_Use_GetAll()
        {
            // Arrange
            Mock<ILaunchesRepository> mock = new Mock<ILaunchesRepository>();
            mock.Setup(m => m.GetAll()).Returns((new Launche[] {
                new Launche {Id = 1, mission_name = "FalconSat"},
                new Launche {Id = 2, mission_name = "DemoSat"}
            }).ToList<Launche>());

            LauncheController controller = new LauncheController(mock.Object);

            // Act
            var result =
                controller.GetAll().Value;

            // Assert

            Assert.True(result.Count == 2);
            Assert.Equal("FalconSat", result[0].mission_name);
            Assert.Equal("DemoSat", result[1].mission_name);
        }


        [Fact]
        public void Can_Use_GetById()
        {
            // Arrange
            Mock<ILaunchesRepository> mock = new Mock<ILaunchesRepository>();
            mock.Setup(m => m.GetById(1)).Returns(
                new Launche { Id = 1, mission_name = "FalconSat" });

            LauncheController controller = new LauncheController(mock.Object);

            // Act
            var result =
                controller.GetById(1).Value;

            // Assert           
            Assert.Equal("FalconSat", result.mission_name);
        }


    }
}
