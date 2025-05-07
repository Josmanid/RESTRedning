using System.Security.Cryptography.X509Certificates;

namespace RESTRedning.Models
{
    public class GPSData
    {
        private int _id;
        private int _year;
        private int _month;
        private int _day;
        private int _hour;
        private int _minute;
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
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double SpeedKnots { get; set; }

        public GPSData(int id, int year, int month, int day, int hour, int minut,
            double latitude, double longitude, double speedKnot)
        {
            Id = id;
            Year = year;
            Month = month;
            Day = day;
            Hour = hour;
            Minute = minut;
            Latitude = latitude;
            Longitude = longitude;
            SpeedKnots = speedKnot;
            
        }

        public override string ToString() {
            return "";
        }


    }
}
