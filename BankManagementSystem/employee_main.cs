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
    public partial class employee_main : Form
    {
        public employee_main()
        {
            InitializeComponent();
        }

        private void deposit_money_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            deposit ss = new deposit();
            ss.Show();
        }

        private void withdrew_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            withdrew ss = new withdrew();
            ss.Show();
        }

        private void balance_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            balance ss = new balance();
            ss.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            customer_information ss = new customer_information();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            employee_login ss = new employee_login();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
