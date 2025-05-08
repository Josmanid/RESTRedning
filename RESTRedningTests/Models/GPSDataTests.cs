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
            //må ikke have hastighed under 0
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

            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => _gpsData.Timestamp = DateTime.Now.AddDays(1) );

        }

        [TestMethod()]
        public void LatitudeTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => _gpsData.Latitude = 91);

            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => _gpsData.Latitude = -91);

            Assert.AreEqual(55.63066666666667, _gpsData.Latitude);

            _gpsData.Latitude = 90;
            Assert.AreEqual(90, _gpsData.Latitude);

            _gpsData.Latitude = -90;
            Assert.AreEqual(-90, _gpsData.Latitude);


        }

        [TestMethod()]
        public void LongtitudeTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => _gpsData.Longitude = 181);

            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => _gpsData.Longitude = -181);

            _gpsData.Longitude = 180;
            Assert.AreEqual(180, _gpsData.Longitude);

            _gpsData.Longitude = -180;
            Assert.AreEqual(-180, _gpsData.Longitude);
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
