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

            // Get /about/ information from the API
            string jsonFooter = istRest.getRESTData("/footer/");

            //Console.WriteLine(jsonAbout);

            // Need to get the data out of the JSON string into an object form
            // that we can easily use
            Footer footer = JToken.Parse(jsonFooter).ToObject<Footer>();

            int x = 260;
            int y = 400;
            foreach(QuickLink ql in footer.quickLinks)
            {
                Button button = e.createButton(ql.title,x,y);
                button.Click += (s, e) =>
                {
                    System.Diagnostics.Process.Start(ql.href);
                };
                aboutTab.Controls.Add(button);
                x += 150;
            }


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
            createResourcesTab();
        }

        //Creates the content for the people tab
        public void createPPl()
        {
            string jsonPeople = istRest.getRESTData("/people/");

            // Cast the objects
            People people = JToken.Parse(jsonPeople).ToObject<People>();

            pplTab.Controls.Add(e.createLabel(people.title, 10, 10));
            pplTab.Controls.Add(e.createLabel(people.subTitle, 10, 40, 500, 20));

            // Print out all the faculty names
            int x = 20;
            int y = 90;
            pplTab.Controls.Add(e.createLabel("Our Faculty", x, y));
            y += 40;
            foreach (Faculty thisFac in people.faculty)
            {
                PictureBox pb = new PictureBox();
                pb.Size = new Size(150, 150);
                pb.Location = new Point(x, y);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Load(thisFac.imagePath);
                pb.Click += (s, e) =>
                {
                    Popup p = new Popup(thisFac);
                    p.ShowDialog();
                };
                pplTab.Controls.Add(pb);
                y += 160;
                pplTab.Controls.Add(e.createLabel(thisFac.name, x, y));
                y -= 160;
                if (x >= 650)
                {
                    x = 20;
                    y += 210;
                }
                else
                {
                    x += 200;
                }
            }
            y += 240;
            x = 20;
            pplTab.Controls.Add(e.createLabel("Our Staff", x, y));
            y += 30;
            foreach (Staff staff in people.staff)
            {
                PictureBox pb = new PictureBox();
                pb.Size = new Size(150, 150);
                pb.Location = new Point(x, y);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Load(staff.imagePath);
                pb.Click += (s, e) =>
                {
                    Popup p = new Popup(staff);
                    p.ShowDialog();
                };
                pplTab.Controls.Add(pb);
                y += 160;
                pplTab.Controls.Add(e.createLabel(staff.name, x, y));
                y -= 160;
                if (x >= 650)
                {
                    x = 20;
                    y += 210;
                }
                else
                {
                    x += 200;
                }
            }
            y += 240;
            x = 20;
            pplTab.Controls.Add(e.createLabel("Our Staff", x, y));   
        }

        // Creates the content for the Undergrad section of the programs tab
        public void createUgTab()
        {
            string jsonDegrees = istRest.getRESTData("/degrees/undergraduate/");

            // Cast the objects
            ugDegrees degrees = JToken.Parse(jsonDegrees).ToObject<ugDegrees>();
            int x = 50;
            int y = 70;
            foreach (Degree degree in degrees.undergraduate)
            {
                String title = degree.degreeName + " (" + degree.title + ")";
                ugTab.Controls.Add(e.createLabel(title, x, y, 250, 20));
                y += 20;
                ugTab.Controls.Add(e.createTextBox(degree.description, x, y, 200, 75));
                y += 100;
                ugTab.Controls.Add(e.createLabel("Concentrations", x, y));
                foreach (String con in degree.concentrations)
                {
                    y += 22;
                    ugTab.Controls.Add(e.createLabel("     \u2022" + con, x, y));
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

                if (degree.concentrations != null)
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
                        gradTab.Controls.Add(e.createLabel("\u2022" + con, x, y, 250, 20));
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
                x += 320;
                if (x > 1100)
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
            employTab.Controls.Add(e.createLabel(employment.introduction.title, x, y, 250, 20));
            x = 50;
            y += 30;
            foreach (Content cont in employment.introduction.content)
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
            foreach (Statistic stat in employment.degreeStatistics.statistics)
            {
                Panel panel = new Panel();
                panel.Controls.Add(e.createLabel(stat.value, 0, 0));
                panel.Controls.Add(e.createTextBox(stat.Description, 0, 40, 300, 100));
                panel.Size = new Size(300, 150);
                panel.BackColor = Color.Orange;
                panel.Location = new Point(x, y);
                panel.Font = new Font(panel.Font.FontFamily, 14);
                employTab.Controls.Add(panel);
                if (x >= 450)
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
            panel2.Controls.Add(e.createLabel(employment.employers.title, 30, 20));
            int panelx = 0;
            int panely = 50;
            foreach (String employer in employment.employers.employerNames)
            {
                panel2.Controls.Add(e.createLabel(employer, panelx, panely));
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

        public void createResourcesTab()
        {
            String jsonResource = istRest.getRESTData("/resources/");

            // Cast the objects
            Resources resource = JToken.Parse(jsonResource).ToObject<Resources>();
            createSATab(resource.studyAbroad);
            createAdvisingTab(resource.studentServices);
            createInfoTab(resource.tutorsAndLabInformation);
            createAmbassTab(resource.studentAmbassadors);
            createFormsTab(resource.forms);
            createCoopTab(resource.coopEnrollment);
        }

        public void createSATab(StudyAbroad s)
        {
            int x = 50;
            int y = 50;
            studyAbroadTab.Controls.Add(e.createLabel(s.title,x,y));
            y += 30;
            studyAbroadTab.Controls.Add(e.createTextBox(s.description,x,y,400,100));
            foreach(Place p in s.places)
            {
                y += 125;
                studyAbroadTab.Controls.Add(e.createLabel(p.nameOfPlace,x,y));
                y += 20;
                studyAbroadTab.Controls.Add(e.createTextBox(p.description,x,y,400,100));
            }
        }

        public void createAdvisingTab(StudentServices s)
        {
            int x = 50;
            int y = 50;
            advisingTab.Controls.Add(e.createLabel(s.title,x,y));
            y += 30;
            advisingTab.Controls.Add(e.createLabel(s.academicAdvisors.title,x,y));
            y += 20;
            advisingTab.Controls.Add(e.createTextBox(s.academicAdvisors.description, x, y, 400, 100));
            x += 430;
            y = 80;
            advisingTab.Controls.Add(e.createLabel(s.facultyAdvisors.title,x,y));
            y += 20;
            advisingTab.Controls.Add(e.createTextBox(s.facultyAdvisors.description, x, y, 400, 100));
            x = 50;
            y += 130;
            advisingTab.Controls.Add(e.createLabel(s.professonalAdvisors.title,x,y));
            y += 20;
            foreach(AdvisorInformation ai in s.professonalAdvisors.advisorInformation)
            {
                advisingTab.Controls.Add(e.createLabel("   \u2022" + ai.name, x, y));
                y += 15;
                advisingTab.Controls.Add(e.createLabel("   \u2022" + ai.department, x, y));
                y += 15;
                advisingTab.Controls.Add(e.createLabel("   \u2022" + ai.department, x, y));
                y += 30;
            }
            y = 230;
            x += 430;
            advisingTab.Controls.Add(e.createLabel(s.istMinorAdvising.title,x,y));
            y += 20;
            foreach (MinorAdvisorInformation ai in s.istMinorAdvising.minorAdvisorInformation)
            {
                advisingTab.Controls.Add(e.createLabel("   \u2022" + ai.title,x,y));
                y += 15;
                advisingTab.Controls.Add(e.createLabel("   \u2022" + ai.advisor, x, y));
                y += 15;
                advisingTab.Controls.Add(e.createLabel("   \u2022" + ai.email, x, y));
                y += 30;
            }

        }
        
        public void createInfoTab(TutorsAndLabInformation info)
        {
            int x = 50;
            int y = 50;
            tutorTab.Controls.Add(e.createLabel(info.title, x, y));
            y += 20;
            tutorTab.Controls.Add(e.createTextBox(info.description, x, y, 400, 200));
            y += 220;
            Button button = e.createButton("Tutoring Hours", x, y);
            button.AutoSize = true;
            button.Click += (s, e) =>
            {
                System.Diagnostics.Process.Start(info.tutoringLabHoursLink);
            };
            tutorTab.Controls.Add(button);
        }

        public void createAmbassTab(StudentAmbassadors sa)
        {
            int x = 50;
            int y = 50;
            ambassTab.Controls.Add(e.createLabel(sa.title, x, y));
            y += 30;
            PictureBox pb = new PictureBox();
            pb.Size = new Size(400, 225);
            pb.Location = new Point(x,y);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Load(sa.ambassadorsImageSource);
            ambassTab.Controls.Add(pb);
            y += 320;
            foreach(SubSectionContent sc in sa.subSectionContent)
            {
                ambassTab.Controls.Add(e.createLabel(sc.title,x,y));
                y += 20;
                ambassTab.Controls.Add(e.createTextBox(sc.description, x, y, 400, 125));
                y += 150;
            }
        }

        public void createFormsTab(Forms f)
        {
            int x = 50;
            int y = 50;
            foreach(GraduateForm gf in f.graduateForms)
            {
                Button button = e.createButton(gf.formName, x, y);
                button.AutoSize = true;
                button.Click += (s, e) =>
                {
                    System.Diagnostics.Process.Start(gf.href);
                };
                formsTab.Controls.Add(button);
                y += 30;
            }
            y += 30;
            foreach (UndergraduateForm gf in f.undergraduateForms)
            {
                Button button = e.createButton(gf.formName, x, y);
                button.AutoSize = true;
                button.Click += (s, e) =>
                {
                    System.Diagnostics.Process.Start(gf.href);
                };
                formsTab.Controls.Add(button);
            }

        }

        public void createCoopTab(CoopEnrollment CE)
        {
            int x = 50;
            int y = 50;
            coopTab.Controls.Add(e.createLabel(CE.title,x,y));
            y += 30;
            foreach (EnrollmentInformationContent EIC in CE.enrollmentInformationContent)
            {
                coopTab.Controls.Add(e.createLabel(EIC.title, x, y));
                y += 20;
                coopTab.Controls.Add(e.createTextBox(EIC.description, x, y, 400, 150));
                if(x >= 450)
                {
                    x = 50;
                    y += 180;
                }
                else
                {
                    x += 425;
                    y -= 20;
                }
            }
            Button button = e.createButton("Job Zone",50 , y+20);
            button.AutoSize = true;
            button.Click += (s, e) =>
            {
                System.Diagnostics.Process.Start(CE.RITJobZoneGuidelink);
            };
            coopTab.Controls.Add(button);
        }
    }
}
