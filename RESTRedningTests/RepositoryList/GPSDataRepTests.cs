using Microsoft.VisualStudio.TestTools.UnitTesting;
using RESTRedning.RepositoryList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTRedning.RepositoryList.Tests
{
    [TestClass()]
    public class GPSDataRepTests
    {
        private GPSDataRep rep;

        [TestInitialize()]

        public void setup() { 

        rep = new GPSDataRep();
        
        }

        [TestMethod()]
        public void GPSDataRepTest() {
            Assert.Fail();
        }
    }
}