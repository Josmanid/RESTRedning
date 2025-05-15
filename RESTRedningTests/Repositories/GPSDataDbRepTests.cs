using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RESTRedning.DBContext;
using RESTRedning.Models;
using RESTRedning.Repositories;
using System;
using System.Linq;

namespace RESTRedning.Repositories.Tests
{
    [TestClass()]
    public class GPSDataDbRepTests
    {
        private DbContextOptions<GPSDataDbContext> CreateInMemoryDatabaseOptions() {
            // Create a unique database name to avoid conflicts between tests
            return new DbContextOptionsBuilder<GPSDataDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
        }
        //Laver en instans
        [TestMethod()]
        public void GPSDataDbRepTest() {
            // Arrange
            var options = CreateInMemoryDatabaseOptions();

            // Act
            using (var context = new GPSDataDbContext(options))
            {
                // Create repository with context
                var repository = new GPSDataDbRep(context);

                // Assert
                Assert.IsNotNull(repository);
            }
        }
     
        [TestMethod()]
        public void GetGPSDataTest() {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddGPSDataTest() {
            Assert.Fail();
        }
    }
}