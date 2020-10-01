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

namespace AdatbazisKapcsolat
{
    public partial class FrmMain : Form
    {

        SqlConnection conn;


        public FrmMain()
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jager.balazs\source\repos\AdatbazisKapcsolat\AdatbazisKapcsolat\Database1.mdf;Integrated Security=True");

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet2.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.database1DataSet2.Table);

        }

        private void Btn_load_Click(object sender, EventArgs e)
        {

            conn.Open();


            conn.Close();

        }
    }
}
