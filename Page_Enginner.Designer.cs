namespace ButtonClass
{
    partial class Page_Enginner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_Enginner));
            this.buttn_analysis = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttn_analysis
            // 
            this.buttn_analysis.Font = new System.Drawing.Font("Raleway Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttn_analysis.Location = new System.Drawing.Point(240, 158);
            this.buttn_analysis.Name = "buttn_analysis";
            this.buttn_analysis.Size = new System.Drawing.Size(203, 40);
            this.buttn_analysis.TabIndex = 3;
            this.buttn_analysis.Text = "Analysis";
            this.buttn_analysis.UseVisualStyleBackColor = true;
            this.buttn_analysis.Click += new System.EventHandler(this.buttn_analysis_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Raleway Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(240, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "State of analysis";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Page_Enginner
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(670, 443);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttn_analysis);
            this.Name = "Page_Enginner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Page_Enginner";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttn_analysis;
        private System.Windows.Forms.Button button1;
    }
}