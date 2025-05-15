using RESTRedning.DBContext;
using RESTRedning.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTRedning.Repositories
{
    public class GPSDataDbRep 
    {

        private readonly GPSDataDbContext _dbContext;
        public GPSDataDbRep(GPSDataDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public IEnumerable<GPSData> GetGPSData() {
            IEnumerable<GPSData> result = _dbContext.GPSDataB.ToList().AsQueryable();

            return result;
        }


        public GPSData AddGPSData(GPSData GPSData) {
            GPSData.Id = 0;
            if (GPSData == null)
            {
                throw new ArgumentNullException("GPS data cannot be null");
            }
            _dbContext.GPSDataB.Add(GPSData);
            _dbContext.SaveChanges();
            return GPSData;
        }



    }
}
