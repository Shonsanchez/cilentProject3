using Newtonsoft.Json.Linq;
using RESTutil;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace P3starter
{
    public partial class Form2 : Form
    {
        REST istRest = null;
        Elements e;
        public Form2()
        {
            InitializeComponent();
            e = new Elements();
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
            createUgTab();
            createGradTab();
            createMinors();
            createEmploymentTab();
        }

        //Creates the content for the people tab
        public void createPPl()
        {
            string jsonPeople = istRest.getRESTData("/people/");

            // Cast the objects
            People people = JToken.Parse(jsonPeople).ToObject<People>();

            pplTab.Controls.Add(e.createLabel(people.title,10,10));
            pplTab.Controls.Add(e.createLabel(people.subTitle,10,40,500,20));

            // Print out all the faculty names
            int x = 20;
            int y = 90;
            foreach (Faculty thisFac in people.faculty)
            {
                pplTab.Controls.Add(e.createButton(thisFac.name,x,y));
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

        // Creates the content for the Undergrad section of the programs tab
        public void createUgTab()
        {
            string jsonDegrees = istRest.getRESTData("/degrees/undergraduate/");

            // Cast the objects
            ugDegrees degrees = JToken.Parse(jsonDegrees).ToObject<ugDegrees>();
            int x = 50;
            int y = 70;
            foreach(Degree degree in degrees.undergraduate)
            {
                String title = degree.degreeName + " (" + degree.title + ")";
                ugTab.Controls.Add(e.createLabel(title, x, y,250,20));
                y += 20;
                ugTab.Controls.Add(e.createTextBox(degree.description, x,y,200,75 ));
                y += 100;
                ugTab.Controls.Add(e.createLabel("Concentrations",x,y));
                foreach(String con in degree.concentrations)
                {
                    y += 22;
                    ugTab.Controls.Add(e.createLabel("     \u2022" + con,x,y));
                }
                y = 70;
                x += 300;
            }
        }

        // Creates the content for the Undergrad section of the programs tab
        public void createGradTab()
        {
            string jsonDegrees = istRest.getRESTData("/degrees/graduate/");

            // Cast the objects
            gradDegrees degrees = JToken.Parse(jsonDegrees).ToObject<gradDegrees>();
            int x = 50;
            int y = 70;
            foreach (Degree degree in degrees.graduate)
            {

                if(degree.concentrations != null)
                {
                    String title = degree.degreeName + " (" + degree.title + ")";
                    gradTab.Controls.Add(e.createLabel(title, x, y, 230, 20));
                    y += 20;
                    gradTab.Controls.Add(e.createTextBox(degree.description, x, y, 200, 75));
                    y += 100;
                    gradTab.Controls.Add(e.createLabel("Concentrations", x, y));
                    foreach (String con in degree.concentrations)
                    {
                        y += 22;
                        gradTab.Controls.Add(e.createLabel("     \u2022" + con, x, y));
                    }
                }
                else
                {
                    String title = degree.degreeName;
                    gradTab.Controls.Add(e.createLabel(title, x, y, 230, 20));
                    y += 20;
                    foreach (String con in degree.availableCertificates)
                    {
                        y += 22;
                        gradTab.Controls.Add(e.createLabel("\u2022" + con, x, y, 250,20));
                        Console.Write(con + "\n");
                    } 
                }
                y = 70;
                x += 250;

            }
        }

        public void createMinors()
        {
            string jsonMinors = istRest.getRESTData("/minors/UgMinors/");

            // Cast the objects
            Minors minors = JToken.Parse(jsonMinors).ToObject<Minors>();
            int x = 50;
            int y = 70;
            int y2 = 70;
            foreach (Minor minor in minors.UgMinors)
            {
                String title = minor.title;
                minorsTab.Controls.Add(e.createLabel(title, x, y, 230, 20));
                y += 20;
                minorsTab.Controls.Add(e.createTextBox(minor.description, x, y, 230, 75));
                y += 100;
                minorsTab.Controls.Add(e.createLabel("Courses", x, y));
                foreach (String con in minor.courses)
                {
                    y += 22;
                    minorsTab.Controls.Add(e.createLabel("     \u2022" + con, x, y));
                }
                x+=320;
                if(x > 1100)
                {
                    y2 += 350;
                    x = 50;
                }
                y = y2;
            }
        }
        public void createEmploymentTab()
        {
            string jsonEmployment = istRest.getRESTData("/employment/");

            // Cast the objects
            Employment employment = JToken.Parse(jsonEmployment).ToObject<Employment>();
            //Create the intro part of the employment table
            int x = 270;
            int y = 50;
            employTab.Controls.Add(e.createLabel(employment.introduction.title,x,y,250,20));
            x = 50;
            y += 30;
            foreach(Content cont in employment.introduction.content)
            {
                employTab.Controls.Add(e.createLabel(cont.title, x, y));
                y += 30;
                employTab.Controls.Add(e.createTextBox(cont.description, x, y, 300, 120));
                x += 400;
                y = 80;
            }
            y = 300;
            foreach(Statistic stat in employment.degreeStatistics.statistics)
            {

            }
        }

    }
}
