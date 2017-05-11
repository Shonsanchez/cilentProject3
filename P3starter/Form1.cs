using Newtonsoft.Json.Linq;
using RESTutil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3starter
{
    public partial class Form1 : Form
    {
        REST istRest = null;
        public Form1()
        {
            InitializeComponent();
            istRest = new REST("http://ist.rit.edu/api");
            Populate();
        }

        public void Populate()
        {
            // Get /about/ information from the API
            string jsonAbout = istRest.getRESTData("/about/");

            //Console.WriteLine(jsonAbout);

            // Need to get the data out of the JSON string into an object form
            // that we can easily use
            About about = JToken.Parse(jsonAbout).ToObject<About>();

            // About title
            lbl_aboutTitle.Text = about.title;
            rtb_desc.Text = about.description;
            lbl_about_quoteAuthor.Text = about.quoteAuthor;
            tb_quote.Text = about.quote;

            ////////////////////////////////////////////////////

            // add the Resources link to the job zone
            string jsonRes = istRest.getRESTData("/resources/");

            Resources resources = JToken.Parse(jsonRes).ToObject<Resources>();
            llbl_zone.Text = resources.tutorsAndLabInformation.tutoringLabHoursLink;
                // coopEnrollment.RITJobZoneGuidelink;
        }


        private void btn_people_Click(object sender, EventArgs e)
        {
            string jsonPeople = istRest.getRESTData("/people/");

            // Cast the objects
            People people = JToken.Parse(jsonPeople).ToObject<People>();

            // Print out all the faculty names
            foreach( Faculty thisFac in people.faculty)
            {
                Console.WriteLine(thisFac.name);
                pictureBox1.Load(thisFac.imagePath);
            }
        }

        private void llbl_zone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(llbl_zone.Text);
            llbl_zone.LinkVisited = true;
        }
    }
}
