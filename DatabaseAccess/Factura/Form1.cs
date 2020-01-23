using DatabaseAccess.UNA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MysqlAccess mysqlAccess = new MysqlAccess();
            //mysqlAccess.ConnectionString = "Server=localhost;Database=mydb;Uid=root;Pwd=1234;";
            mysqlAccess.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
            mysqlAccess.OpenConnection();
            dataGridView1.DataSource = mysqlAccess.QuerySQL("SELECT * FROM mydb.clientes");
            mysqlAccess.CloseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
