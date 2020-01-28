using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagementSystem
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void exit_button_home_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin_login ss = new admin_login();
            ss.Show();
        }

        private void manager_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            manager_login ss = new manager_login();
            ss.Show();
        }

        private void employee_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            employee_login ss = new employee_login();
            ss.Show();
        }

        private void customer_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            customer_login ss = new customer_login();
            ss.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
