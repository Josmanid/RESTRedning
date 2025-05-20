using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace RESTRedning.Models
{
    public class GPSData
    {

        [Key]
        public int PrimaryKey { get; set; }

        private int _id;
        private DateTime _timeStamp;
        private double _latitude;
        private double _longitude;
        private double _speedKnots;

        public int Id
        {
            get => _id;
            set
            {
                _id = value;

            }

        }
        public DateTime Timestamp
        {
            get => _timeStamp;
            set
            {
                //// Convert to Denmark local time
                //var danishTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Central European Standard Time");
                //var localTime = TimeZoneInfo.ConvertTimeFromUtc(value.ToUniversalTime(), danishTimeZone);

                if (value > DateTime.Now)
                {
                    throw new ArgumentOutOfRangeException("Time must not be in the future");
                }
                _timeStamp = value;
            }


        }
        public double Latitude
        {
            get => _latitude;
            set
            {
                if (value > 90 || value < -90)
                {
                    throw new ArgumentOutOfRangeException("Latitude out of range");
                }
                _latitude = value;
            }
        }

        public double Longitude
        {
            get => _longitude;
            set
            {
                if (value > 180 || value < -180)
                {
                    throw new ArgumentOutOfRangeException("Longitude out of range");
                }
                _longitude = value;
            }
        }

        public double SpeedKnots
        {
            get => _speedKnots;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The velocity is zero!");
                }
                _speedKnots = value;
            }
        }

        public GPSData(int id, DateTime timeStamp,
            double latitude, double longitude, double speedKnots) {
            Id = id;
            Timestamp = timeStamp;
            Latitude = latitude;
            Longitude = longitude;
            SpeedKnots = speedKnots;

        }
        public GPSData() {

        }

        public override string ToString() {
            return "";
        }



    }
}
