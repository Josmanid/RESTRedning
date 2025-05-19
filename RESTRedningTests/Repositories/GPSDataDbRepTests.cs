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
        //Lav
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
        public void AddGPSDataTest() {
            //Arrange
            var options = CreateInMemoryDatabaseOptions();
            var testData = new GPSData
            {
                Id = 99, // This should be reset to 0 by the repository
                Timestamp = DateTime.Now.AddMinutes(-30),
                Latitude = 56.123456,
                Longitude = 13.654321,
                SpeedKnots = 7.5
            };
            // Act
            using (var context = new GPSDataDbContext(options))
            {
                var repository = new GPSDataDbRep(context);
                var result = repository.AddGPSData(testData);

                // Assert - Check the returned object
                Assert.AreEqual(99, result.Id); // Should have been reset to 1 due to database identity
                Assert.AreEqual(testData.Timestamp, result.Timestamp);
                Assert.AreEqual(testData.Latitude, result.Latitude);
                Assert.AreEqual(testData.Longitude, result.Longitude);
                Assert.AreEqual(testData.SpeedKnots, result.SpeedKnots);
            }
            // Assert - Verify it was saved to the database
            using (var context = new GPSDataDbContext(options))
            {
                Assert.AreEqual(1, context.GPSDataB.Count());
                var savedData = context.GPSDataB.First();
                Assert.AreEqual(testData.Timestamp, savedData.Timestamp);
                Assert.AreEqual(testData.Latitude, savedData.Latitude);
                Assert.AreEqual(testData.Longitude, savedData.Longitude);
                Assert.AreEqual(testData.SpeedKnots, savedData.SpeedKnots);
            }
        }

        [TestMethod()]
        public void GetGPSDataTest() {
            //Arrange
            var options = CreateInMemoryDatabaseOptions();
            var testData1 = new GPSData
            {
                Id = 99, // This should be reset to 0 by the repository
                Timestamp = DateTime.Now.AddMinutes(-30),
                Latitude = 56.123456,
                Longitude = 13.654321,
                SpeedKnots = 7.5
            };
            var testData2 = new GPSData
            {
                Id = 98, // This should be reset to 0 by the repository
                Timestamp = DateTime.Now.AddMinutes(-30),
                Latitude = 56.123456,
                Longitude = 13.654321,
                SpeedKnots = 7.5
            };
            //Act
            using (var context = new GPSDataDbContext(options))
            {
                GPSDataDbRep repository = new GPSDataDbRep(context);
                GPSData add1 = repository.AddGPSData(testData1);
                GPSData add2 = repository.AddGPSData(testData2);
                IEnumerable<GPSData> result = repository.GetGPSData();


                // Assert - Check the returned object
                Assert.AreEqual(2, result.Count()); 
                
            }

        }

    }
}