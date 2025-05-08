using RESTRedning.Models;

namespace RESTRedning.RepositoryList
{
    public class GPSDataRep
    {
        private List<GPSData>? _GPSDatarep;


        public GPSDataRep()
        {
            _GPSDatarep = new List<GPSData>();
        }

        public IEnumerable<GPSData> GetGPSData()
        {
            IEnumerable<GPSData> result = new List<GPSData>(_GPSDatarep);

            return result;
        }



    }
}
