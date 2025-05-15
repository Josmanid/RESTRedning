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

        [TestMethod()]
        public void GPSDataDbRepTest() {
            Assert.Fail();
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