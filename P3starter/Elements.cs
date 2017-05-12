﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3starter
{
    // Class to increase cohesion of the project. In charge of easily creating new elements
    class Elements
    {
        // Creates label. The title is self explanatory. 
        public Label createLabel(String text, int x, int y)
        {
            Label label = new Label();
            label.Text = text;
            label.Location = new Point(x, y);
            return label;
        }

        public Label createLabel(String text, int x, int y, int length, int height)
        {
            Label label = new Label();
            label.Text = text;
            label.Location = new Point(x, y);
            label.Size = new Size(length, height);
            return label;
        }

        // Creates a button.
        public Button createButton(String text, int x, int y)
        {
            Button button = new Button();
            button.Text = text;
            button.Location = new Point(x, y);
            return button;
        }

        // Creates a textBox
        public TextBox createTextBox(String text, int x, int y, int length, int height)
        {
            TextBox tb = new TextBox();
            tb.Text = text;
            tb.Location = new Point(x, y);
            tb.Size = new Size(length, height);
            tb.Multiline = true;
            return tb;
        }
    }
}