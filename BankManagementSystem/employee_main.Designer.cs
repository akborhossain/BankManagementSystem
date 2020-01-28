namespace BankManagementSystem
{
    partial class employee_main
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.balance_button = new System.Windows.Forms.Button();
            this.withdrew_button = new System.Windows.Forms.Button();
            this.deposit_money_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.balance_button);
            this.panel1.Controls.Add(this.withdrew_button);
            this.panel1.Controls.Add(this.deposit_money_button);
            this.panel1.Location = new System.Drawing.Point(231, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 369);
            this.panel1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(279, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(279, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(30, 197);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(279, 36);
            this.button4.TabIndex = 4;
            this.button4.Text = "Check Information";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // balance_button
            // 
            this.balance_button.Location = new System.Drawing.Point(30, 136);
            this.balance_button.Name = "balance_button";
            this.balance_button.Size = new System.Drawing.Size(279, 36);
            this.balance_button.TabIndex = 3;
            this.balance_button.Text = "Balance";
            this.balance_button.UseVisualStyleBackColor = true;
            this.balance_button.Click += new System.EventHandler(this.balance_button_Click);
            // 
            // withdrew_button
            // 
            this.withdrew_button.Location = new System.Drawing.Point(30, 76);
            this.withdrew_button.Name = "withdrew_button";
            this.withdrew_button.Size = new System.Drawing.Size(279, 36);
            this.withdrew_button.TabIndex = 2;
            this.withdrew_button.Text = "Withdrew";
            this.withdrew_button.UseVisualStyleBackColor = true;
            this.withdrew_button.Click += new System.EventHandler(this.withdrew_button_Click);
            // 
            // deposit_money_button
            // 
            this.deposit_money_button.Location = new System.Drawing.Point(30, 18);
            this.deposit_money_button.Name = "deposit_money_button";
            this.deposit_money_button.Size = new System.Drawing.Size(279, 36);
            this.deposit_money_button.TabIndex = 1;
            this.deposit_money_button.Text = "Deposit Money";
            this.deposit_money_button.UseVisualStyleBackColor = true;
            this.deposit_money_button.Click += new System.EventHandler(this.deposit_money_button_Click);
            // 
            // employee_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "employee_main";
            this.Text = "employee_main";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button balance_button;
        private System.Windows.Forms.Button withdrew_button;
        private System.Windows.Forms.Button deposit_money_button;
    }
}