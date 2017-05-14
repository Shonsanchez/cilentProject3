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
    public partial class PopupForm : Form
    {

        Elements e = new Elements();
        public PopupForm(String description)
        {
            InitializeComponent();
            TextBox tb = e.createTextBox(description, 0, 0, 500, 400);
            tb.ReadOnly = true;
            tb.ScrollBars = ScrollBars.Vertical;
            contentPane.Controls.Add(tb);
        }

        public PopupForm(List<String> citations)
        {
            InitializeComponent();
            foreach (String cit in citations)
            {
                Label label = new Label();
                label.Text = "\u2022" +cit + "\n";
                label.AutoSize = true;
                label.MaximumSize = new Size(500,0);
                contentPane.AutoScroll = true;
                contentPane.WrapContents = false;
                contentPane.Controls.Add(label);
            }
        }

        public PopupForm(Faculty f)
        {
            InitializeComponent();
            int x = 50;
            int y = 50;
            PictureBox pb = new PictureBox();
            pb.Size = new Size(150, 150);
            pb.Location = new Point(x, y);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Load(f.imagePath);
            contentPane.Controls.Add(pb);
            contentPane.Controls.Add(e.createLabel("Name: " + f.name, x, y));
            contentPane.Controls.Add(e.createLabel("Username: " + f.username,x,y));     
            contentPane.Controls.Add(e.createLabel("Tagline: " + f.tagline, x, y));
            contentPane.Controls.Add(e.createLabel("Office: " + f.office, x, y));
            contentPane.Controls.Add(e.createLabel("Title: " + f.title, x, y));
            contentPane.Controls.Add(e.createLabel("Interest Area: " + f.interestArea, x, y));
            contentPane.Controls.Add(e.createLabel("Email: " + f.email, x, y));
            contentPane.Controls.Add(e.createLabel("Phone: " + f.phone, x, y));
        }

        public PopupForm(Staff s)
        {
            InitializeComponent();
            int x = 50;
            int y = 50;
            PictureBox pb = new PictureBox();
            pb.Size = new Size(150, 150);
            pb.Location = new Point(x, y);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Load(s.imagePath);
            contentPane.Controls.Add(pb);
            contentPane.Controls.Add(e.createLabel("Name: " + s.name, x, y));
            contentPane.Controls.Add(e.createLabel("Username: " + s.username, x, y));
            contentPane.Controls.Add(e.createLabel("Tagline: " + s.tagline, x, y));
            contentPane.Controls.Add(e.createLabel("Office: " + s.office, x, y));
            contentPane.Controls.Add(e.createLabel("Title: " + s.title, x, y));
            contentPane.Controls.Add(e.createLabel("Interest Area: " + s.interestArea, x, y));
            contentPane.Controls.Add(e.createLabel("Email: " + s.email, x, y));
            contentPane.Controls.Add(e.createLabel("Phone: " + s.phone, x, y));
        }

    }
}
