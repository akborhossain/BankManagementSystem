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
    public partial class balance : Form
    {
        public balance()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection ccon = new MySqlConnection(@"server=localhost; user id=root; password=; database=bank;");
            String query = "select customer.first_name,customer.last_name,customer.phone,account.acc_name,account.balance from customer,account where customer.c_id='" + customer_id.Text.Trim() + "'and account.acc_no='" + acc_no.Text.Trim() + "'";
            MySqlDataAdapter csda = new MySqlDataAdapter(query, ccon);
            DataTable cdtbl = new DataTable();
        }
    }
}
