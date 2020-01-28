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
    public partial class customer_main : Form
    {
        public customer_main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            deposit ss = new deposit();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            customer_login ss = new customer_login();
            ss.Show();
        }

        private void customer_main_Load(object sender, EventArgs e)
        {

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
    }
}
