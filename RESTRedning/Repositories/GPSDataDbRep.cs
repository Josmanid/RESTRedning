using RESTRedning.Models;

namespace RESTRedning.Repositories
{
    public class GPSDataDbRep
    {
        public List<GPSData>? GPSDataList { get; private set; }


        public GPSDataDbRep() {
            GPSDataList = new List<GPSData>();
        }

        public IEnumerable<GPSData> GetGPSData() {
            IEnumerable<GPSData> result = new List<GPSData>(GPSDataList);

            return result;
        }


        public GPSData AddGPSData(GPSData GPSData) {
            if (GPSData == null)
            {
                throw new ArgumentNullException("GPS data cannot be null");
            }
            GPSDataList.Add(GPSData);
            return GPSData;
        }



    }
}
