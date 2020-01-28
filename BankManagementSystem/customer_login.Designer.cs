namespace BankManagementSystem
{
    partial class customer_login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.customer_sigup_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.customer_login_pass = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.customer_login_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.customer_login_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.customer_sigup_button);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.customer_login_pass);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.customer_login_button);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.customer_login_txt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(151, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 365);
            this.panel1.TabIndex = 1;
            // 
            // customer_sigup_button
            // 
            this.customer_sigup_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.customer_sigup_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customer_sigup_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_sigup_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.customer_sigup_button.Location = new System.Drawing.Point(193, 322);
            this.customer_sigup_button.Name = "customer_sigup_button";
            this.customer_sigup_button.Size = new System.Drawing.Size(113, 40);
            this.customer_sigup_button.TabIndex = 8;
            this.customer_sigup_button.Text = "Sign Up";
            this.customer_sigup_button.UseVisualStyleBackColor = false;
            this.customer_sigup_button.Click += new System.EventHandler(this.customer_sigup_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "If you don\'t have customer account ";
            // 
            // customer_login_pass
            // 
            this.customer_login_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_login_pass.Location = new System.Drawing.Point(109, 132);
            this.customer_login_pass.Multiline = true;
            this.customer_login_pass.Name = "customer_login_pass";
            this.customer_login_pass.PasswordChar = '*';
            this.customer_login_pass.Size = new System.Drawing.Size(285, 36);
            this.customer_login_pass.TabIndex = 6;
            this.customer_login_pass.TextChanged += new System.EventHandler(this.customer_login_pass_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(109, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // customer_login_button
            // 
            this.customer_login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.customer_login_button.Location = new System.Drawing.Point(281, 239);
            this.customer_login_button.Name = "customer_login_button";
            this.customer_login_button.Size = new System.Drawing.Size(113, 40);
            this.customer_login_button.TabIndex = 4;
            this.customer_login_button.Text = "LogIn";
            this.customer_login_button.UseVisualStyleBackColor = false;
            this.customer_login_button.Click += new System.EventHandler(this.admin_login_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // customer_login_txt
            // 
            this.customer_login_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_login_txt.Location = new System.Drawing.Point(109, 56);
            this.customer_login_txt.Multiline = true;
            this.customer_login_txt.Name = "customer_login_txt";
            this.customer_login_txt.Size = new System.Drawing.Size(285, 36);
            this.customer_login_txt.TabIndex = 1;
            this.customer_login_txt.TextChanged += new System.EventHandler(this.customer_login_txt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // customer_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "customer_login";
            this.Text = "Customer LogIn";
            this.Load += new System.EventHandler(this.customer_login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox customer_login_pass;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button customer_login_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customer_login_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button customer_sigup_button;
        private System.Windows.Forms.Label label3;
    }
}