namespace BankManagementSystem
{
    partial class withdrew
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
            this.button1 = new System.Windows.Forms.Button();
            this.acc_no = new System.Windows.Forms.TextBox();
            this.account_no = new System.Windows.Forms.Label();
            this.customer_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // acc_no
            // 
            this.acc_no.Location = new System.Drawing.Point(414, 129);
            this.acc_no.Name = "acc_no";
            this.acc_no.Size = new System.Drawing.Size(100, 22);
            this.acc_no.TabIndex = 8;
            // 
            // account_no
            // 
            this.account_no.AutoSize = true;
            this.account_no.Location = new System.Drawing.Point(305, 134);
            this.account_no.Name = "account_no";
            this.account_no.Size = new System.Drawing.Size(81, 17);
            this.account_no.TabIndex = 7;
            this.account_no.Text = "Account No";
            // 
            // customer_id
            // 
            this.customer_id.Location = new System.Drawing.Point(414, 91);
            this.customer_id.Name = "customer_id";
            this.customer_id.Size = new System.Drawing.Size(100, 22);
            this.customer_id.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Customer ID";
            // 
            // withdrew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.acc_no);
            this.Controls.Add(this.account_no);
            this.Controls.Add(this.customer_id);
            this.Controls.Add(this.label1);
            this.Name = "withdrew";
            this.Text = "withdrew";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox acc_no;
        private System.Windows.Forms.Label account_no;
        private System.Windows.Forms.TextBox customer_id;
        private System.Windows.Forms.Label label1;
    }
}