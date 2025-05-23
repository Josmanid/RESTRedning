﻿using RESTRedning.Models;

namespace RESTRedning.RepositoryList
{
    public class GPSDataRep
    {
        public List<GPSData>? GPSDataList { get; private set; }


        public GPSDataRep()
        {
            GPSDataList = new List<GPSData>();
        }

        public IEnumerable<GPSData> GetGPSData()
        {
            IEnumerable<GPSData> result = new List<GPSData>(GPSDataList);

            return result;
        }


        public GPSData AddGPSData(GPSData GPSData)
        {
            if (GPSData == null)
            {
                throw new ArgumentNullException("GPS data cannot be null");
            }
            GPSDataList.Add(GPSData);
            return GPSData;
        }




    }
}
