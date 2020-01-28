using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BankManagementSystem
{
    public partial class employee_registration : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        String GENDER;
        public employee_registration()
        {
            InitializeComponent();
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            employee_login ss = new employee_login();
            ss.Show();
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            employee_registration ss = new employee_registration();
            ss.Show();
        }

        private void signup_button_Click(object sender, EventArgs e)
        {
            String insertQuery = "INSERT INTO bank.employee(first_name,last_name,mail,phone,password,gender,present_address,permanent_address,branch,nid) VALUES('" + first_name_txt.Text.Trim() + "','" + surname_txt.Text.Trim() + "','" + email_txt.Text.Trim() + "','" + phone_txt.Text.Trim() + "','" + password_txt.Text.Trim() + "','" + GENDER + "','" + present_address_txt.Text + "','" + permanent_address_txt.Text + "','"+branch_txt.Text+"','" + nid_txt.Text + "')";
            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("ok");
                    this.Hide();
                    customer_login ss = new customer_login();
                    ss.Show();
                }
                else
                {
                    MessageBox.Show("not");
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void upload_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg) |*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picPath = dlg.FileName.ToString();
                employee_image.ImageLocation = picPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton_male_CheckedChanged(object sender, EventArgs e)
        {
            GENDER = "MALE";
        }

        private void radioButton_female_CheckedChanged(object sender, EventArgs e)
        {
            GENDER = "FEMALE";
        }

        private void radioButton_other_CheckedChanged(object sender, EventArgs e)
        {
            GENDER = "OTHER";
        }

        private void first_name_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void terms_checkBox_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
