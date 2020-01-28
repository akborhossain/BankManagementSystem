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
    public partial class customer_login : Form
    {

        public customer_login()
        {
            InitializeComponent();
            
        }

        private void customer_login_Load(object sender, EventArgs e)
        {

        }

        private void customer_login_txt_TextChanged(object sender, EventArgs e)
        {

        }
        private void customer_login_pass_TextChanged(object sender, EventArgs e)
        {

        }
        private void admin_login_button_Click(object sender, EventArgs e)
        {
            MySqlConnection ccon = new MySqlConnection(@"server=localhost; user id=root; password=; database=bank;");
            String query = "select * from customer where mail='" + customer_login_txt.Text.Trim() + "'and password='" + customer_login_pass.Text.Trim() + "'";
            MySqlDataAdapter csda = new MySqlDataAdapter(query, ccon);
            DataTable cdtbl = new DataTable();
            csda.Fill(cdtbl);
            if (cdtbl.Rows.Count == 1)
            {
                MessageBox.Show("Welcome !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                customer_main ss = new customer_main();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Invalid Account!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
               

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            home ss = new home();
            ss.Show();
        }

        private void customer_sigup_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            customer_sigup ss = new customer_sigup();
            ss.Show();
        }
    }
}
