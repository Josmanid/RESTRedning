using System.Security.Cryptography.X509Certificates;

namespace RESTRedning.Models
{
    public class GPSData
    {
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
        public DateTime Timestamp { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double SpeedKnots { get; set; }

        public GPSData(int id, DateTime timeStamp,
            double latitude, double longitude, double speedKnot)
        {
            Id = id;
            Timestamp = timeStamp;
            Latitude = latitude;
            Longitude = longitude;
            SpeedKnots = speedKnot;
            
        }

        public override string ToString() {
            return "";
        }


    }
}
