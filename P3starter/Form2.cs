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

            createAllTabs();
        }

        public void createAllTabs()
        {
            createPPl();
            createUgTab();
            createGradTab();
            createMinors();
            createEmploymentTab();
            createNewsTab();
            createResearchTab();
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
            x = 50;

            //Creates a panel for each Statistic 
            foreach(Statistic stat in employment.degreeStatistics.statistics)
            {
                Panel panel = new Panel();
                panel.Controls.Add(e.createLabel(stat.value, 0, 0));
                panel.Controls.Add(e.createTextBox(stat.Description, 0, 40,300,100));
                panel.Size = new Size(300, 150);
                panel.BackColor = Color.Orange;
                panel.Location = new Point(x, y);
                panel.Font = new Font(panel.Font.FontFamily, 14);
                employTab.Controls.Add(panel);
                if (x>=450)
                {
                    x = 50;
                    y += 175;
                }
                else
                {
                    x += 400;
                }
            }
            Panel panel2 = new Panel();
            panel2.BackColor = Color.Orange;
            panel2.Size = new Size(700, 100);
            panel2.Controls.Add(e.createLabel(employment.employers.title,30,20));
            int panelx = 0;
            int panely = 50;
            foreach(String employer in employment.employers.employerNames)
            {
                panel2.Controls.Add(e.createLabel(employer,panelx, panely));
                panelx += 105;
                if (x >= 600)
                {
                    x = 0;
                    y += 30;
                }
            }
            panel2.Location = new Point(40, 700);
            employTab.Controls.Add(panel2);
            panel2 = new Panel();
            panel2.BackColor = Color.Orange;
            panel2.Size = new Size(700, 100);
            panel2.Controls.Add(e.createLabel(employment.careers.title, 30, 20));
            panelx = 0;
            panely = 50;
            foreach (String career in employment.careers.careerNames)
            {
                panel2.Controls.Add(e.createLabel(career, panelx, panely));
                panelx += 105;
                if (x >= 600)
                {
                    x = 0;
                    y += 30;
                }
            }
            panel2.Location = new Point(40, 800);
            employTab.Controls.Add(panel2);
        }

        public void createNewsTab()
        {
            String jsonEmployment = istRest.getRESTData("/news/");

            // Cast the objects
            News news = JToken.Parse(jsonEmployment).ToObject<News>();
            int x = 50;
            int y = 50;
            foreach (Article article in news.year)
            {
                Panel panel = new Panel();
                panel.Size = new Size(400, 50);
                panel.BackColor = Color.Orange;
                panel.Click += (s, e) =>
                {
                    Popup p = new Popup(article.description);
                    p.ShowDialog();
                };
                Label label = e.createLabel(article.title, 0, 0);
                label.Click += (s, e) =>
                {
                    Popup p = new Popup(article.description);
                    p.ShowDialog();
                };
                panel.Controls.Add(label);
                label = e.createLabel(article.date, 0, 20);
                label.Click += (s, e) =>
                {
                    Popup p = new Popup(article.description);
                    p.ShowDialog();
                };
                panel.Controls.Add(label);
                panel.Location = new Point(x, y);
                newsTab.Controls.Add(panel);
                y += 90;
            }
            x += 400;
            y = 50;
            foreach (Article article in news.older)
            {
                Console.Write(article.title);
                Panel panel = new Panel();
                panel.Size = new Size(400, 50);
                panel.BackColor = Color.Orange;
                panel.Click += (s, e) =>
                {
                    Popup p = new Popup(article.description);
                    p.ShowDialog();
                };
                Label label = e.createLabel(article.title, 0, 0);
                label.Click += (s, e) =>
                {
                    Popup p = new Popup(article.description);
                    p.ShowDialog();
                };
                panel.Controls.Add(label);
                label = e.createLabel(article.date, 0, 20);
                label.Click += (s, e) =>
                {
                    Popup p = new Popup(article.description);
                    p.ShowDialog();
                };
                panel.Controls.Add(label);
                panel.Location = new Point(x, y);
                newsTab.Controls.Add(panel);
                y += 90;
            }
        }

        public void createResearchTab()
        {
            String jsonResearch = istRest.getRESTData("/research/");

            // Cast the objects
            Research research = JToken.Parse(jsonResearch).ToObject<Research>();
            int x = 50;
            int y = 50;
            foreach (ByFaculty fac in research.byFaculty)
            {
                Panel panel = new Panel();
                panel.Size = new Size(400, 50);
                panel.BackColor = Color.Orange;
                panel.Click += (s, e) =>
                {
                    Popup p = new Popup(fac.citations);
                    p.ShowDialog();
                };
                Label label = e.createLabel(fac.facultyName, 0, 0);
                label.Click += (s, e) =>
                {
                    Popup p = new Popup(fac.citations);
                    p.ShowDialog();
                };
                panel.Controls.Add(label);
                panel.Location = new Point(x, y);
                researchTab.Controls.Add(panel);
                y += 90;
            }
            x += 500;
            y = 50;
            foreach (ByInterestArea area in research.byInterestArea)
            {
                Panel panel = new Panel();
                panel.Size = new Size(400, 50);
                panel.BackColor = Color.Orange;
                panel.Click += (s, e) =>
                {
                    Popup p = new Popup(area.citations);
                    p.ShowDialog();
                };
                Label label = e.createLabel(area.areaName, 0, 0);
                label.Click += (s, e) =>
                {
                    Popup p = new Popup(area.citations);
                    p.ShowDialog();
                };
                panel.Controls.Add(label);
                panel.Location = new Point(x, y);
                researchTab.Controls.Add(panel);
                y += 90;
            }

        }
    }
}
