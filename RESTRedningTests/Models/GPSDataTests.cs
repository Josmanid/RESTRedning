using RESTRedning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTRedning.Models.Tests
{
    [TestClass()]
    public class GPSDataTests
    {

        [TestMethod()]
        public void MaxSpeedTest() {
            GPSData data = new GPSData { SpeedKnots:23}


        }


        [TestMethod()]
        public void ToStringTest() {
            Assert.Fail();
        }
    }
}