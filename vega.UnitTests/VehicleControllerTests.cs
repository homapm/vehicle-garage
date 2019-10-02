using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using vega.Controllers;
using vega.Models;
using vega.Persistence;

namespace vega.UnitTests
{
    public class Tests
    {
        protected VehiclesController vehiclesController;
        protected Mock<VegaDbContext> mockContext;
        protected Mock<DbSet<Vehicle>> mockSet;

        [SetUp]
        public void Setup()
        {

            var mapper = new Mock<IMapper>();

            mockContext = new Mock<VegaDbContext>();
            mockContext.Setup(v => v.Vehicles).Returns(mockSet.Object);

            vehiclesController = new VehiclesController(mapper.Object, mockContext.Object);
        }

        // [Test]
        // [TestCase(0)]
        // public async Task GetVehicle_InvalidInput_ReturnsVehicle(int input)
        // {
        //     // Arrange -> Setup 


        //     // Act
        //     var result = await vehiclesController.GetVehicle(input);

        //     // Assert
        //     // Assert.IsInstanceOf<BadRequestObjectResult>(result);
        //     Assert.That(result, Is.InstanceOf<BadRequestObjectResult>());
        //     Assert.Pass();

        // }

        [Test]
        public void MyTest()
        {
            Assert.Pass();
        }
    }
}