using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace FlashGameEmulator
{
    class DatabaseConnection
    {
        public static OleDbConnection openConnection()
        {
            //database connection class
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\_Documents\Visual Studio 2015\Projects\FlashGameEmulator\FlashGameEmulator\GameDB.accdb";

            OleDbConnection cn = new OleDbConnection(connectionString.ToString());

            return cn;

        }
    }
}
