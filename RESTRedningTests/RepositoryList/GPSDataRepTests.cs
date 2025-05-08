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
        private List<GPSData> rep;

        [TestInitialize()]
        public void setup() {


            rep = new List<GPSData>();

            var mockData1 = new GPSData(1, DateTime.Now.AddMinutes(-10), 55, 112, 4);

            var mockData2 = new GPSData(2, DateTime.Now.AddMinutes(-5), 42, 115, 10);

            rep.Add(mockData1);
            rep.Add(mockData2);
        }

        [TestMethod()]
        public void GetGPSDataTest()
        {
            List<GPSData> GPSData = rep.GetGPSData();
            Assert.AreEqual(2, GPSData.Count());
        }

        [TestMethod()]
        public void AddGPSDataTest() 
        {


            
        }
    }
}