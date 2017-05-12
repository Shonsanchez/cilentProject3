using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3starter
{
    class News
    {
        public List<Article> year { set; get; }
        public List<Article> older { set; get; }
    }

    class Article
    {
        public String date { set; get; }
        public String title { set; get; }
        public String description { set; get; }
    }
}
