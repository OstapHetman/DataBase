namespace ButtonClass
{
    partial class Page1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page1));
            this.Doctors_btn = new System.Windows.Forms.Button();
            this.Patients_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Doctors_btn
            // 
            this.Doctors_btn.Font = new System.Drawing.Font("Raleway Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Doctors_btn.Location = new System.Drawing.Point(294, 112);
            this.Doctors_btn.Name = "Doctors_btn";
            this.Doctors_btn.Size = new System.Drawing.Size(203, 40);
            this.Doctors_btn.TabIndex = 0;
            this.Doctors_btn.Text = "Doctors";
            this.Doctors_btn.UseVisualStyleBackColor = true;
            this.Doctors_btn.Click += new System.EventHandler(this.Doctors_btn_Click);
            // 
            // Patients_btn
            // 
            this.Patients_btn.Font = new System.Drawing.Font("Raleway Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Patients_btn.Location = new System.Drawing.Point(294, 199);
            this.Patients_btn.Name = "Patients_btn";
            this.Patients_btn.Size = new System.Drawing.Size(203, 40);
            this.Patients_btn.TabIndex = 1;
            this.Patients_btn.Text = "Patients";
            this.Patients_btn.UseVisualStyleBackColor = true;
            this.Patients_btn.Click += new System.EventHandler(this.Patients_btn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Raleway Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(294, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Engineers page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(779, 487);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Patients_btn);
            this.Controls.Add(this.Doctors_btn);
            this.Name = "Page1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Page1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Doctors_btn;
        private System.Windows.Forms.Button Patients_btn;
        private System.Windows.Forms.Button button1;
    }
}

