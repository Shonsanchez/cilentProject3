using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3starter
{
    class Degree
    {
        public String degreeName { set; get; }
        public String title { get; set; }
        public String description {get; set;}
        public List<String> concentrations { get; set; }
        public List<String> availableCertificates { get; set; }
    }

    class ugDegrees
    {
        public List<Degree> undergraduate { get; set; }
    }

    class gradDegrees
    {
        public List<Degree> graduate { get; set; }
    }
}
