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


        public override string ToString() {
            return "";
        }


    }
}
