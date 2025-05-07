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

        private GPSData _gpsData;

        [TestInitialize()]
        public void Initialize()
        {
           _gpsData = new GPSData(
                speedKnots: 1,
                timeStamp: DateTime.Now,
                latitude: 55.63066666666667,
                longitude: 12.077896666666666,
                id: 1
            );
        }

        [TestMethod()]
        public void MaxSpeedTest()
        {
            // Assert
            Assert.AreEqual(1, _gpsData.SpeedKnots);
            //må ikke have hastighed over 1 knob
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => _gpsData.SpeedKnots = -1);
        }

        [TestMethod()]
        public void TimeStampTest()
        {         
            // Act
            DateTime timestampResult = _gpsData.Timestamp;
           
            // Assert
            Assert.AreEqual(_gpsData.Timestamp.Year, timestampResult.Year);
            Assert.AreEqual(_gpsData.Timestamp.Month, timestampResult.Month);
            Assert.AreEqual(_gpsData.Timestamp.Day, timestampResult.Day);
            Assert.AreEqual(_gpsData.Timestamp.Hour, timestampResult.Hour);
            Assert.AreEqual(_gpsData.Timestamp.Minute, timestampResult.Minute);
        }

        [TestMethod()]
        public void LatitudeTest()
        {
            Assert.are
        }
        
        [TestMethod()]
        public void ToStringTest()
        {
            // Act 
            string result = _gpsData.ToString();
            // Assert 
            Assert.AreEqual("", result);
            
        }


        
    }
}
