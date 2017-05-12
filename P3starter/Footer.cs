using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3starter
{
    class Footer
    {
        public Info social { set; get; }
        public List<QuickLink> quickLinks { set; get; }
        public Copyright copyright { set; get; }
        public String news { set; get; }
    }

    class Info
    {
        public String title { set; get; }
        public String tweet { set; get; }
        public String by { set; get; }
        public String twitter { set; get; }
        public String facebook { set; get; }
    }

    class QuickLink
    {
        public String title { set; get; }
        public String href { set; get; }
    }

    class Copyright
    {
        public String title { set; get; }
        public String html { set; get; }
    }
}
