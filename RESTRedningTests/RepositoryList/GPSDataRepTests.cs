using Microsoft.VisualStudio.TestTools.UnitTesting;
using RESTRedning.Models;
using RESTRedning.RepositoryList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTRedning.RepositoryList.Tests
{
    [TestClass()]
    public class GPSDataRepTests
    {
        private GPSDataRep rep;

        [TestInitialize()]
        public void setup() {


            rep = new GPSDataRep();

            var mockData1 = new GPSData(1, DateTime.Now.AddMinutes(-10), 55, 112, 4);

            var mockData2 = new GPSData(1, DateTime.Now.AddMinutes(-5), 42, 115, 10);

            rep.GPSDataList.Add(mockData1);
            rep.GPSDataList.Add(mockData2);
        }

        [TestMethod()]
        public void GetGPSDataTest()
        {
            IEnumerable<GPSData> GPSData = rep.GetGPSData();
            Assert.AreEqual(2, GPSData.Count());
        }

        [TestMethod()]
        public void AddGPSDataTest() 
        {
            //Arrange
            GPSData addedLoc = new GPSData(1, DateTime.Now.AddMinutes(-5), 0, 1, 5);
            //Act
            GPSData AddedGPSData = rep.AddGPSData(addedLoc);
            IEnumerable<GPSData> GPSData = rep.GetGPSData();

            //Assert
            Assert.AreEqual(3, GPSData.Count());

        }
    }
}