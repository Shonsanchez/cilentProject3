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

    class Minor
    {
        public String name { set; get; }
        public String title { set; get; }
        public String description { set; get; }
        public List<String> courses { set; get; }
        public String note { set; get; }
    }

    class ugDegrees
    {
        public List<Degree> undergraduate { get; set; }
    }

    class gradDegrees
    {
        public List<Degree> graduate { get; set; }
    }

    class Minors
    {
        public List<Minor> UgMinors { get; set; }
    }
}
