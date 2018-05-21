namespace Final_health_care
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.docter_int = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.patient_int = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.emergency_page = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO HEALTH CARE MANAGEMENT SYSTEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Are you a doctor?";
            // 
            // docter_int
            // 
            this.docter_int.Location = new System.Drawing.Point(219, 126);
            this.docter_int.Name = "docter_int";
            this.docter_int.Size = new System.Drawing.Size(177, 34);
            this.docter_int.TabIndex = 2;
            this.docter_int.Text = "Doctor Interface";
            this.docter_int.UseVisualStyleBackColor = true;
            this.docter_int.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Are you a patient?";
            // 
            // patient_int
            // 
            this.patient_int.Location = new System.Drawing.Point(219, 212);
            this.patient_int.Name = "patient_int";
            this.patient_int.Size = new System.Drawing.Size(177, 36);
            this.patient_int.TabIndex = 4;
            this.patient_int.Text = "Patient Interface\r\n";
            this.patient_int.UseVisualStyleBackColor = true;
            this.patient_int.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "In case of Emergency";
            // 
            // emergency_page
            // 
            this.emergency_page.Location = new System.Drawing.Point(219, 294);
            this.emergency_page.Name = "emergency_page";
            this.emergency_page.Size = new System.Drawing.Size(177, 37);
            this.emergency_page.TabIndex = 6;
            this.emergency_page.Text = "Emergency Page";
            this.emergency_page.UseVisualStyleBackColor = true;
            this.emergency_page.Click += new System.EventHandler(this.emergency_page_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 343);
            this.Controls.Add(this.emergency_page);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.patient_int);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.docter_int);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button docter_int;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button patient_int;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button emergency_page;
    }
}

