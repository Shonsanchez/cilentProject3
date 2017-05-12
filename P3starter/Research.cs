using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3starter
{
    class Research
    {
        public ByInterestArea byInterestArea { set; get; }
        public ByFaculty byFaculty { set; get; }
    }

    class ByInterestArea
    {
        public String areaName { set; get; }
        public List<String> citations { set; get; }
    }

    class ByFaculty
    {
        public String facultyName { set; get; }
        public String username { set; get; }
        public List<String> citations { set; get; }
    }
        
}
