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
    public partial class customer_sigup : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        String GENDER;
        public customer_sigup()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void customer_sigup_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            GENDER = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            GENDER = "Other";
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            customer_sigup ss = new customer_sigup();
            ss.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            customer_login ss = new customer_login();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String insertQuery = "INSERT INTO bank.customer(first_name,last_name,mail,phone,password,gender,present_address,permanent_address,nid) VALUES('"+first_name_txt.Text.Trim()+"','"+surname_txt.Text.Trim()+"','"+email_txt.Text.Trim()+"','" + phone_txt.Text.Trim() + "','" + password_txt.Text.Trim() + "','" + GENDER + "','" + present_address_txt.Text + "','" + permanent_address_txt.Text + "','" + nid_txt.Text + "')";
            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);
            try
            {
                if(command.ExecuteNonQuery()==1)
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
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit_txt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void upload_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg) |*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                string picPath = dlg.FileName.ToString();
                customer_image.ImageLocation = picPath;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            GENDER = "Female";
        }

        private void customer_image_Click(object sender, EventArgs e)
        {

        }
    }
}
