namespace Final_health_care
{
    partial class Form5
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
            this.p_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pwd = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.p_sign_up = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // p_name
            // 
            this.p_name.AutoSize = true;
            this.p_name.Location = new System.Drawing.Point(54, 97);
            this.p_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.p_name.Name = "p_name";
            this.p_name.Size = new System.Drawing.Size(104, 20);
            this.p_name.TabIndex = 4;
            this.p_name.Text = "Patient-name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "password";
            // 
            // pwd
            // 
            this.pwd.Location = new System.Drawing.Point(172, 165);
            this.pwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pwd.Name = "pwd";
            this.pwd.PasswordChar = '*';
            this.pwd.Size = new System.Drawing.Size(148, 26);
            this.pwd.TabIndex = 1;
            this.pwd.TextChanged += new System.EventHandler(this.pwd_TextChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(172, 92);
            this.name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(148, 26);
            this.name.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 254);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Patient Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 6;
            // 
            // p_sign_up
            // 
            this.p_sign_up.Location = new System.Drawing.Point(210, 254);
            this.p_sign_up.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.p_sign_up.Name = "p_sign_up";
            this.p_sign_up.Size = new System.Drawing.Size(112, 35);
            this.p_sign_up.TabIndex = 3;
            this.p_sign_up.Text = "Clear";
            this.p_sign_up.UseVisualStyleBackColor = true;
            this.p_sign_up.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.p_sign_up);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.p_name);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form5";
            this.Text = "Patient Login";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label p_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button p_sign_up;
    }
}