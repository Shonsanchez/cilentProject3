namespace P3starter
{
    partial class Form1
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
            this.lbl_aboutTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_about_quoteAuthor = new System.Windows.Forms.Label();
            this.llbl_zone = new System.Windows.Forms.LinkLabel();
            this.rtb_desc = new System.Windows.Forms.RichTextBox();
            this.tb_quote = new System.Windows.Forms.TextBox();
            this.btn_people = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_aboutTitle
            // 
            this.lbl_aboutTitle.AutoSize = true;
            this.lbl_aboutTitle.Location = new System.Drawing.Point(13, 43);
            this.lbl_aboutTitle.Name = "lbl_aboutTitle";
            this.lbl_aboutTitle.Size = new System.Drawing.Size(121, 13);
            this.lbl_aboutTitle.TabIndex = 0;
            this.lbl_aboutTitle.Text = "{ place About title here }";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quote:";
            // 
            // lbl_about_quoteAuthor
            // 
            this.lbl_about_quoteAuthor.AutoSize = true;
            this.lbl_about_quoteAuthor.Location = new System.Drawing.Point(13, 294);
            this.lbl_about_quoteAuthor.Name = "lbl_about_quoteAuthor";
            this.lbl_about_quoteAuthor.Size = new System.Drawing.Size(165, 13);
            this.lbl_about_quoteAuthor.TabIndex = 2;
            this.lbl_about_quoteAuthor.Text = "{ place About quote author here }";
            // 
            // llbl_zone
            // 
            this.llbl_zone.AutoSize = true;
            this.llbl_zone.Location = new System.Drawing.Point(58, 328);
            this.llbl_zone.Name = "llbl_zone";
            this.llbl_zone.Size = new System.Drawing.Size(94, 13);
            this.llbl_zone.TabIndex = 3;
            this.llbl_zone.TabStop = true;
            this.llbl_zone.Text = "{Place a link here}";
            this.llbl_zone.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_zone_LinkClicked);
            // 
            // rtb_desc
            // 
            this.rtb_desc.Location = new System.Drawing.Point(38, 59);
            this.rtb_desc.Name = "rtb_desc";
            this.rtb_desc.Size = new System.Drawing.Size(288, 96);
            this.rtb_desc.TabIndex = 4;
            this.rtb_desc.Text = "";
            // 
            // tb_quote
            // 
            this.tb_quote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_quote.Location = new System.Drawing.Point(38, 192);
            this.tb_quote.Multiline = true;
            this.tb_quote.Name = "tb_quote";
            this.tb_quote.ReadOnly = true;
            this.tb_quote.Size = new System.Drawing.Size(288, 96);
            this.tb_quote.TabIndex = 5;
            // 
            // btn_people
            // 
            this.btn_people.Location = new System.Drawing.Point(382, 56);
            this.btn_people.Name = "btn_people";
            this.btn_people.Size = new System.Drawing.Size(75, 23);
            this.btn_people.TabIndex = 6;
            this.btn_people.Text = "Get People";
            this.btn_people.UseVisualStyleBackColor = true;
            this.btn_people.Click += new System.EventHandler(this.btn_people_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(362, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 401);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_people);
            this.Controls.Add(this.tb_quote);
            this.Controls.Add(this.rtb_desc);
            this.Controls.Add(this.llbl_zone);
            this.Controls.Add(this.lbl_about_quoteAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_aboutTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_aboutTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_about_quoteAuthor;
        private System.Windows.Forms.LinkLabel llbl_zone;
        private System.Windows.Forms.RichTextBox rtb_desc;
        private System.Windows.Forms.TextBox tb_quote;
        private System.Windows.Forms.Button btn_people;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

