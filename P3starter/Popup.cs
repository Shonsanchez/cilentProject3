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
    public partial class Popup : Form
    {
        Elements e = new Elements();
        public Popup(String description)
        {
            InitializeComponent();
            TextBox tb = e.createTextBox(description, 0, 0, 500, 400);
            tb.ReadOnly = true;
            tb.ScrollBars = ScrollBars.Vertical;
            contentPane.Controls.Add(tb);
        }

        public Popup(List<String> citations)
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

    }
}
