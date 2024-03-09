using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace SummOOP
{
    class Konek
    {
        SqlConnection conn;
        public SqlConnection getCon()
        {
            // conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Admin\\source\\repos\\SummOOP\\SummOOP\\DTR.mdf;Integrated Security=True;Connect Timeout=30");
            conn = new SqlConnection("Data Source=DESKTOP-JQGODOM;Initial Catalog=DTR;Integrated Security=True");
            return conn;
        }
    }
}
