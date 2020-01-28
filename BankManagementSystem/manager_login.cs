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
    public partial class manager_login : Form
    {
        public manager_login()
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
            MySqlConnection ccon = new MySqlConnection(@"server=localhost; user id=root; password=; database=bank;");
            String query = "select * from manager where mail='" + manager_id.Text.Trim() + "'and password='" + manager_password.Text.Trim() + "'";
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
