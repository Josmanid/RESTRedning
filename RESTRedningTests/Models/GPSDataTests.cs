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
        public void MaxSpeedTest()
        {
            //Arrange
            GPSData dataOK = new GPSData(speedKnot: 1,
                timeStamp: DateTime.Now,
                latitude: 55.63066666666667,
                longitude: 12.077896666666666,
                id: 1
            );

            // Act


            // Assert
            Assert.AreEqual(1, dataOK.SpeedKnots);
            //må ikke have hastighed over 1 knob
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => dataOK.SpeedKnots = 2);






        }

        [TestMethod()]
        public void TimeStampTest()
        {
            //Arrange
            DateTime now = DateTime.Now;
            GPSData gpsData = new GPSData(
                speedKnot: 1,
                timeStamp: now,
                latitude: 55.63066666666667,
                longitude: 12.077896666666666,
                id: 1
            );
          
            // Act
            DateTime timestampResult = gpsData.Timestamp;
           
            // Assert
            Assert.AreEqual(now.Year, timestampResult.Year);
            Assert.AreEqual(now.Month, timestampResult.Month);
            Assert.AreEqual(now.Day, timestampResult.Day);
            Assert.AreEqual(now.Hour, timestampResult.Hour);
            Assert.AreEqual(now.Minute, timestampResult.Minute);
            
        }
        
        [TestMethod()]
        public void ToStringTest()
        {
            //Arrange 
            GPSData gpsData = new GPSData(
                speedKnot: 1,
                timeStamp: DateTime.Now,
                latitude: 55.63066666666667,
                longitude: 12.077896666666666,
                id: 1
            ); 
            // Act 
            string result = gpsData.ToString();
            // Assert 
            Assert.AreEqual("", result);
            
        }
        
    }
}
