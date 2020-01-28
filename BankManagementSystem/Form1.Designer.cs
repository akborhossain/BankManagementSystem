namespace BankManagementSystem
{
    partial class home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.admin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exit_button_home = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.customer_button = new System.Windows.Forms.Button();
            this.employee_button = new System.Windows.Forms.Button();
            this.manager_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bangladesh Bank";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(45, 126);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 265);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome to";
            // 
            // admin
            // 
            this.admin.BackColor = System.Drawing.Color.DarkCyan;
            this.admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin.ForeColor = System.Drawing.Color.Yellow;
            this.admin.Location = new System.Drawing.Point(3, 4);
            this.admin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(259, 49);
            this.admin.TabIndex = 2;
            this.admin.Text = "Admin";
            this.admin.UseVisualStyleBackColor = false;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.exit_button_home);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.customer_button);
            this.panel2.Controls.Add(this.employee_button);
            this.panel2.Controls.Add(this.manager_button);
            this.panel2.Controls.Add(this.admin);
            this.panel2.Location = new System.Drawing.Point(875, 57);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 334);
            this.panel2.TabIndex = 7;
            // 
            // exit_button_home
            // 
            this.exit_button_home.BackColor = System.Drawing.Color.DarkCyan;
            this.exit_button_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_button_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button_home.ForeColor = System.Drawing.Color.Yellow;
            this.exit_button_home.Location = new System.Drawing.Point(3, 282);
            this.exit_button_home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit_button_home.Name = "exit_button_home";
            this.exit_button_home.Size = new System.Drawing.Size(259, 49);
            this.exit_button_home.TabIndex = 7;
            this.exit_button_home.Text = "Exit";
            this.exit_button_home.UseVisualStyleBackColor = false;
            this.exit_button_home.Click += new System.EventHandler(this.exit_button_home_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkCyan;
            this.button5.ForeColor = System.Drawing.Color.Yellow;
            this.button5.Location = new System.Drawing.Point(3, 223);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(259, 49);
            this.button5.TabIndex = 6;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // customer_button
            // 
            this.customer_button.BackColor = System.Drawing.Color.DarkCyan;
            this.customer_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customer_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_button.ForeColor = System.Drawing.Color.Yellow;
            this.customer_button.Location = new System.Drawing.Point(3, 167);
            this.customer_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customer_button.Name = "customer_button";
            this.customer_button.Size = new System.Drawing.Size(259, 49);
            this.customer_button.TabIndex = 5;
            this.customer_button.Text = "Customer";
            this.customer_button.UseVisualStyleBackColor = false;
            this.customer_button.Click += new System.EventHandler(this.customer_button_Click);
            // 
            // employee_button
            // 
            this.employee_button.BackColor = System.Drawing.Color.DarkCyan;
            this.employee_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employee_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_button.ForeColor = System.Drawing.Color.Yellow;
            this.employee_button.Location = new System.Drawing.Point(3, 113);
            this.employee_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employee_button.Name = "employee_button";
            this.employee_button.Size = new System.Drawing.Size(259, 49);
            this.employee_button.TabIndex = 4;
            this.employee_button.Text = "Employee";
            this.employee_button.UseVisualStyleBackColor = false;
            this.employee_button.Click += new System.EventHandler(this.employee_button_Click);
            // 
            // manager_button
            // 
            this.manager_button.BackColor = System.Drawing.Color.DarkCyan;
            this.manager_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manager_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manager_button.ForeColor = System.Drawing.Color.Yellow;
            this.manager_button.Location = new System.Drawing.Point(3, 58);
            this.manager_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manager_button.Name = "manager_button";
            this.manager_button.Size = new System.Drawing.Size(259, 49);
            this.manager_button.TabIndex = 3;
            this.manager_button.Text = "Manager";
            this.manager_button.UseVisualStyleBackColor = false;
            this.manager_button.Click += new System.EventHandler(this.manager_button_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1920, 1035);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "home";
            this.Text = "Bangladesh Bank";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button admin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button exit_button_home;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button customer_button;
        private System.Windows.Forms.Button employee_button;
        private System.Windows.Forms.Button manager_button;
    }
}

