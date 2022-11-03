using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlConnect
{
    public partial class Form1 : Form
    {
        private SqlConnection conn = new SqlConnection("Server=localhost; Database=Northwind; Integrated Security=true;");
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSqlAction_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                buttonSqlAction.Text = "Disconnect";
                labelConnectionState.Text = "Connection open";
                return;
            }
            conn.Close();
            buttonSqlAction.Text = "Connect";
            labelConnectionState.Text = "Connection closed";
        }
    }
}
