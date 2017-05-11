using Newtonsoft.Json.Linq;
using RESTutil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3starter
{
    public partial class Form2 : Form
    {
        REST istRest = null;
        public Form2()
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
            aboutTitle.Text = about.title;
            // About Text
            aboutText.Text = about.description;
            // Student Quote
            quotetb.Text = "\"" + about.quote + "\"";
            // Quoter's Name
            quoterlbl.Text = about.quoteAuthor;

            createPPl();
        }

        public void createPPl()
        {
            string jsonPeople = istRest.getRESTData("/people/");

            // Cast the objects
            People people = JToken.Parse(jsonPeople).ToObject<People>();

            Label title = new Label();
            title.Text = people.title;
            title.Location = new Point(10,10);
            pplTab.Controls.Add(title);

            Label subTitle = new Label();
            subTitle.Text = people.subTitle;
            subTitle.Location = new Point(10, 40);
            subTitle.Size = new Size(100,20);
            pplTab.Controls.Add(subTitle);

            // Print out all the faculty names
            int x = 20;
            int y = 90;
            foreach (Faculty thisFac in people.faculty)
            {
                Button button = new Button();
                button.Text = thisFac.name;
                button.Location = new Point(x,y);
               
                pplTab.Controls.Add(button);
                if (x >= 650)
                {
                    x = 20;
                    y += 40;
                }
                else
                {
                    x += 90;
                }
            }
        }

        public void createProgramsTab()
        {

        }
    }
}
