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
    public partial class employee_login : Form
    {
        public employee_login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            home ss = new home();
            ss.Show();
        }

        private void employee_login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            employee_registration ss = new employee_registration();
            ss.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void admin_login_button_Click(object sender, EventArgs e)
        {
            MySqlConnection ccon = new MySqlConnection(@"server=localhost; user id=root; password=; database=bank;");
            String query = "select * from employee where mail='" + employee_id_txt.Text.Trim() + "'and password='" + password_txt.Text.Trim() + "'";
            MySqlDataAdapter csda = new MySqlDataAdapter(query, ccon);
            DataTable cdtbl = new DataTable();
            csda.Fill(cdtbl);
            if (cdtbl.Rows.Count == 1)
            {
                MessageBox.Show("Welcome !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                employee_main ss = new employee_main();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Invalid Account!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }
    }
}
