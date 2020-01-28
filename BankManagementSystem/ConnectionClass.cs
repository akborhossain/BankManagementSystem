using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BankManagementSystem
{
    class ConnectionClass
    {
        public string getconnectionstring
        {
            get
            {
                String con = @"server=localhost; user id=root; password=; database=bank";
                return con;
            }
        }
    }
}
