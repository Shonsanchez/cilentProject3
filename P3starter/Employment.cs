using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3starter
{
    class Introduction
    {
        public String title { get; set; }
        public List<Content> content { get; set; }
    }

    class Content
    {
        public String title { get; set; }
        public String description { get; set; }
    }

    class DegreeStatistics
    {
        public String title { set; get; }
        public List<Statistic> statistics { set; get; }
    }

    class Statistic
    {
        public String value { set; get; }
        public String Description { set; get; }
    }

    class Employers
    {
        public String title { set; get; }
        public List<String> employerNames { set; get; }
    }

    class Careers
    {
        public String title { set; get; }
        public List<String> careerNames { set; get; }
    }

    class CoopTable
    {
        public String title { set; get; }
        public List<Coop> coopInformation { set; get; }
    }

    class Coop
    {
        public String employer { set; get; }
        public String degree { set; get; }
        public String city { set; get; }
        public String term { set; get; }
    }

    class EmploymentTable
    {
        public String title { set; get; }
        public List<Job> professionalEmploymentInformation { set; get; }
    }

    class Job
    { 
        public String employer { set; get; }
        public String degree { set; get; }
        public String city { set; get; }
        public String title { set; get; }
        public String startDate { set; get; }
    }

    class Employment
    {
        public Introduction introduction { get; set; }
        public DegreeStatistics degreeStatistics { get; set; }
        public Employers employers { get; set; }
        public Careers careers { get; set; }
        public CoopTable coopTable { get; set; }
        public EmploymentTable employmentTable { get; set; }
    }
}
