namespace P3starter
{
    partial class PopupForm
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
            this.displayPanel = new System.Windows.Forms.Panel();
            this.contentPane = new System.Windows.Forms.FlowLayoutPanel();
            this.displayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayPanel
            // 
            this.displayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayPanel.AutoScroll = true;
            this.displayPanel.AutoSize = true;
            this.displayPanel.Controls.Add(this.contentPane);
            this.displayPanel.Location = new System.Drawing.Point(0, 0);
            this.displayPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(848, 634);
            this.displayPanel.TabIndex = 0;
            // 
            // contentPane
            // 
            this.contentPane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentPane.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.contentPane.Location = new System.Drawing.Point(2, 3);
            this.contentPane.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.contentPane.Name = "contentPane";
            this.contentPane.Padding = new System.Windows.Forms.Padding(0, 0, 0, 46);
            this.contentPane.Size = new System.Drawing.Size(786, 626);
            this.contentPane.TabIndex = 0;
            // 
            // PopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 638);
            this.Controls.Add(this.displayPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PopupForm";
            this.Text = "Form3";
            this.displayPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel displayPanel;
        private System.Windows.Forms.FlowLayoutPanel contentPane;
    }
}