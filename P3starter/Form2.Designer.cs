namespace P3starter
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.aboutTab = new System.Windows.Forms.TabPage();
            this.quoterlbl = new System.Windows.Forms.Label();
            this.quotetb = new System.Windows.Forms.TextBox();
            this.aboutText = new System.Windows.Forms.TextBox();
            this.aboutTitle = new System.Windows.Forms.Label();
            this.programTab = new System.Windows.Forms.TabPage();
            this.programsTC = new System.Windows.Forms.TabControl();
            this.ugTab = new System.Windows.Forms.TabPage();
            this.ugTitle = new System.Windows.Forms.Label();
            this.gradTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.minorsTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.employTab = new System.Windows.Forms.TabPage();
            this.studLocTab = new System.Windows.Forms.TabPage();
            this.studentLocBrowser = new System.Windows.Forms.WebBrowser();
            this.pplTab = new System.Windows.Forms.TabPage();
            this.researchTab = new System.Windows.Forms.TabPage();
            this.resourceTab = new System.Windows.Forms.TabPage();
            this.resourceTitle = new System.Windows.Forms.Label();
            this.newsTab = new System.Windows.Forms.TabPage();
            this.contactTab = new System.Windows.Forms.TabPage();
            this.contactBrowser = new System.Windows.Forms.WebBrowser();
            this.tabControl.SuspendLayout();
            this.aboutTab.SuspendLayout();
            this.programTab.SuspendLayout();
            this.programsTC.SuspendLayout();
            this.ugTab.SuspendLayout();
            this.gradTab.SuspendLayout();
            this.minorsTab.SuspendLayout();
            this.studLocTab.SuspendLayout();
            this.resourceTab.SuspendLayout();
            this.contactTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.aboutTab);
            this.tabControl.Controls.Add(this.programTab);
            this.tabControl.Controls.Add(this.employTab);
            this.tabControl.Controls.Add(this.studLocTab);
            this.tabControl.Controls.Add(this.pplTab);
            this.tabControl.Controls.Add(this.researchTab);
            this.tabControl.Controls.Add(this.resourceTab);
            this.tabControl.Controls.Add(this.newsTab);
            this.tabControl.Controls.Add(this.contactTab);
            this.tabControl.Location = new System.Drawing.Point(-4, 5);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1398, 776);
            this.tabControl.TabIndex = 0;
            // 
            // aboutTab
            // 
            this.aboutTab.Controls.Add(this.quoterlbl);
            this.aboutTab.Controls.Add(this.quotetb);
            this.aboutTab.Controls.Add(this.aboutText);
            this.aboutTab.Controls.Add(this.aboutTitle);
            this.aboutTab.Location = new System.Drawing.Point(4, 29);
            this.aboutTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aboutTab.Name = "aboutTab";
            this.aboutTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aboutTab.Size = new System.Drawing.Size(1390, 743);
            this.aboutTab.TabIndex = 0;
            this.aboutTab.Text = "About";
            this.aboutTab.UseVisualStyleBackColor = true;
            // 
            // quoterlbl
            // 
            this.quoterlbl.AutoSize = true;
            this.quoterlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoterlbl.Location = new System.Drawing.Point(696, 511);
            this.quoterlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quoterlbl.Name = "quoterlbl";
            this.quoterlbl.Size = new System.Drawing.Size(147, 20);
            this.quoterlbl.TabIndex = 8;
            this.quoterlbl.Text = "Quoter Goes Here";
            // 
            // quotetb
            // 
            this.quotetb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quotetb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotetb.Location = new System.Drawing.Point(390, 346);
            this.quotetb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quotetb.Multiline = true;
            this.quotetb.Name = "quotetb";
            this.quotetb.ReadOnly = true;
            this.quotetb.Size = new System.Drawing.Size(819, 160);
            this.quotetb.TabIndex = 7;
            this.quotetb.Text = "Quote Goes here";
            // 
            // aboutText
            // 
            this.aboutText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aboutText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutText.Location = new System.Drawing.Point(356, 202);
            this.aboutText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aboutText.Multiline = true;
            this.aboutText.Name = "aboutText";
            this.aboutText.ReadOnly = true;
            this.aboutText.Size = new System.Drawing.Size(910, 100);
            this.aboutText.TabIndex = 6;
            // 
            // aboutTitle
            // 
            this.aboutTitle.AutoSize = true;
            this.aboutTitle.Font = new System.Drawing.Font("Sitka Banner", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutTitle.Location = new System.Drawing.Point(450, 86);
            this.aboutTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aboutTitle.Name = "aboutTitle";
            this.aboutTitle.Size = new System.Drawing.Size(95, 59);
            this.aboutTitle.TabIndex = 1;
            this.aboutTitle.Text = "Title\r\n";
            // 
            // programTab
            // 
            this.programTab.Controls.Add(this.programsTC);
            this.programTab.Location = new System.Drawing.Point(4, 29);
            this.programTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.programTab.Name = "programTab";
            this.programTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.programTab.Size = new System.Drawing.Size(1390, 743);
            this.programTab.TabIndex = 1;
            this.programTab.Text = "Programs";
            this.programTab.UseVisualStyleBackColor = true;
            // 
            // programsTC
            // 
            this.programsTC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.programsTC.Controls.Add(this.ugTab);
            this.programsTC.Controls.Add(this.gradTab);
            this.programsTC.Controls.Add(this.minorsTab);
            this.programsTC.Location = new System.Drawing.Point(4, 9);
            this.programsTC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.programsTC.Name = "programsTC";
            this.programsTC.SelectedIndex = 0;
            this.programsTC.Size = new System.Drawing.Size(1372, 696);
            this.programsTC.TabIndex = 3;
            // 
            // ugTab
            // 
            this.ugTab.Controls.Add(this.ugTitle);
            this.ugTab.Location = new System.Drawing.Point(4, 29);
            this.ugTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ugTab.Name = "ugTab";
            this.ugTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ugTab.Size = new System.Drawing.Size(1364, 663);
            this.ugTab.TabIndex = 0;
            this.ugTab.Text = "Undergraduate Programs";
            this.ugTab.UseVisualStyleBackColor = true;
            // 
            // ugTitle
            // 
            this.ugTitle.AutoSize = true;
            this.ugTitle.Location = new System.Drawing.Point(450, 46);
            this.ugTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ugTitle.Name = "ugTitle";
            this.ugTitle.Size = new System.Drawing.Size(223, 20);
            this.ugTitle.TabIndex = 2;
            this.ugTitle.Text = "Our UnderGraduate Programs";
            // 
            // gradTab
            // 
            this.gradTab.Controls.Add(this.label1);
            this.gradTab.Location = new System.Drawing.Point(4, 29);
            this.gradTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gradTab.Name = "gradTab";
            this.gradTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gradTab.Size = new System.Drawing.Size(1364, 663);
            this.gradTab.TabIndex = 1;
            this.gradTab.Text = "Graduate Programs";
            this.gradTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Our Graduate Programs";
            // 
            // minorsTab
            // 
            this.minorsTab.AutoScroll = true;
            this.minorsTab.BackColor = System.Drawing.Color.White;
            this.minorsTab.Controls.Add(this.label2);
            this.minorsTab.Location = new System.Drawing.Point(4, 29);
            this.minorsTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.minorsTab.Name = "minorsTab";
            this.minorsTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.minorsTab.Size = new System.Drawing.Size(1364, 663);
            this.minorsTab.TabIndex = 2;
            this.minorsTab.Text = "Minors";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Our Minors";
            // 
            // employTab
            // 
            this.employTab.Location = new System.Drawing.Point(4, 29);
            this.employTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.employTab.Name = "employTab";
            this.employTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.employTab.Size = new System.Drawing.Size(1390, 743);
            this.employTab.TabIndex = 2;
            this.employTab.Text = "Employment";
            this.employTab.UseVisualStyleBackColor = true;
            // 
            // studLocTab
            // 
            this.studLocTab.Controls.Add(this.studentLocBrowser);
            this.studLocTab.Location = new System.Drawing.Point(4, 29);
            this.studLocTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.studLocTab.Name = "studLocTab";
            this.studLocTab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.studLocTab.Size = new System.Drawing.Size(1390, 743);
            this.studLocTab.TabIndex = 3;
            this.studLocTab.Text = "Student Location";
            this.studLocTab.UseVisualStyleBackColor = true;
            // 
            // studentLocBrowser
            // 
            this.studentLocBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentLocBrowser.Location = new System.Drawing.Point(4, 5);
            this.studentLocBrowser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.studentLocBrowser.MinimumSize = new System.Drawing.Size(30, 31);
            this.studentLocBrowser.Name = "studentLocBrowser";
            this.studentLocBrowser.ScriptErrorsSuppressed = true;
            this.studentLocBrowser.Size = new System.Drawing.Size(1382, 733);
            this.studentLocBrowser.TabIndex = 0;
            this.studentLocBrowser.Url = new System.Uri("http://ist.rit.edu/api/map", System.UriKind.Absolute);
            // 
            // pplTab
            // 
            this.pplTab.Location = new System.Drawing.Point(4, 29);
            this.pplTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pplTab.Name = "pplTab";
            this.pplTab.Size = new System.Drawing.Size(1390, 743);
            this.pplTab.TabIndex = 4;
            this.pplTab.Text = "Our People";
            this.pplTab.UseVisualStyleBackColor = true;
            // 
            // researchTab
            // 
            this.researchTab.Location = new System.Drawing.Point(4, 29);
            this.researchTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.researchTab.Name = "researchTab";
            this.researchTab.Size = new System.Drawing.Size(1390, 743);
            this.researchTab.TabIndex = 5;
            this.researchTab.Text = "Research";
            this.researchTab.UseVisualStyleBackColor = true;
            // 
            // resourceTab
            // 
            this.resourceTab.Controls.Add(this.resourceTitle);
            this.resourceTab.Location = new System.Drawing.Point(4, 29);
            this.resourceTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resourceTab.Name = "resourceTab";
            this.resourceTab.Size = new System.Drawing.Size(1390, 743);
            this.resourceTab.TabIndex = 6;
            this.resourceTab.Text = "Resources";
            this.resourceTab.UseVisualStyleBackColor = true;
            // 
            // resourceTitle
            // 
            this.resourceTitle.AutoSize = true;
            this.resourceTitle.Location = new System.Drawing.Point(96, 34);
            this.resourceTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resourceTitle.Name = "resourceTitle";
            this.resourceTitle.Size = new System.Drawing.Size(38, 20);
            this.resourceTitle.TabIndex = 0;
            this.resourceTitle.Text = "Title";
            // 
            // newsTab
            // 
            this.newsTab.Location = new System.Drawing.Point(4, 29);
            this.newsTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newsTab.Name = "newsTab";
            this.newsTab.Size = new System.Drawing.Size(1390, 743);
            this.newsTab.TabIndex = 7;
            this.newsTab.Text = "News";
            this.newsTab.UseVisualStyleBackColor = true;
            // 
            // contactTab
            // 
            this.contactTab.Controls.Add(this.contactBrowser);
            this.contactTab.Location = new System.Drawing.Point(4, 29);
            this.contactTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.contactTab.Name = "contactTab";
            this.contactTab.Size = new System.Drawing.Size(1390, 743);
            this.contactTab.TabIndex = 8;
            this.contactTab.Text = "Contact Us";
            this.contactTab.UseVisualStyleBackColor = true;
            // 
            // contactBrowser
            // 
            this.contactBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactBrowser.Location = new System.Drawing.Point(0, 5);
            this.contactBrowser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.contactBrowser.MinimumSize = new System.Drawing.Size(30, 31);
            this.contactBrowser.Name = "contactBrowser";
            this.contactBrowser.ScriptErrorsSuppressed = true;
            this.contactBrowser.Size = new System.Drawing.Size(1606, 955);
            this.contactBrowser.TabIndex = 0;
            this.contactBrowser.Url = new System.Uri("http://www.ist.rit.edu/api/contactForm/", System.UriKind.Absolute);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 744);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tabControl.ResumeLayout(false);
            this.aboutTab.ResumeLayout(false);
            this.aboutTab.PerformLayout();
            this.programTab.ResumeLayout(false);
            this.programsTC.ResumeLayout(false);
            this.ugTab.ResumeLayout(false);
            this.ugTab.PerformLayout();
            this.gradTab.ResumeLayout(false);
            this.gradTab.PerformLayout();
            this.minorsTab.ResumeLayout(false);
            this.minorsTab.PerformLayout();
            this.studLocTab.ResumeLayout(false);
            this.resourceTab.ResumeLayout(false);
            this.resourceTab.PerformLayout();
            this.contactTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage aboutTab;
        private System.Windows.Forms.TabPage programTab;
        private System.Windows.Forms.TabPage employTab;
        private System.Windows.Forms.TabPage studLocTab;
        private System.Windows.Forms.TabPage pplTab;
        private System.Windows.Forms.TabPage researchTab;
        private System.Windows.Forms.TabPage resourceTab;
        private System.Windows.Forms.TabPage newsTab;
        private System.Windows.Forms.Label aboutTitle;
        private System.Windows.Forms.TextBox aboutText;
        private System.Windows.Forms.TextBox quotetb;
        private System.Windows.Forms.Label quoterlbl;
        private System.Windows.Forms.TabControl programsTC;
        private System.Windows.Forms.TabPage ugTab;
        private System.Windows.Forms.Label ugTitle;
        private System.Windows.Forms.TabPage gradTab;
        private System.Windows.Forms.TabPage minorsTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resourceTitle;
        private System.Windows.Forms.WebBrowser studentLocBrowser;
        private System.Windows.Forms.TabPage contactTab;
        private System.Windows.Forms.WebBrowser contactBrowser;
    }
}