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
    public partial class admin_login : Form
    {
        public admin_login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            home ss = new home();
            ss.Show();
        }

        private void admin_login_button_Click(object sender, EventArgs e)
        {
            MySqlConnection acon = new MySqlConnection(@"server=localhost; user id=root; password=; database=bank");
            String query = "select * from admin where admin_id='"+admin_login_txt.Text.Trim()+"'and admin_password='"+admin_login_pass.Text.Trim()+"'";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, acon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if(dtbl.Rows.Count== 1)
            {
                MessageBox.Show("Welcome !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                admin_main ss = new admin_main();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Invalid Account!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
