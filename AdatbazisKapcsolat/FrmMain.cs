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


        }

        private void Btn_load_Click(object sender, EventArgs e)
        {

            conn.Open();

            var cmd = new SqlCommand("select * from proba", conn);

            var r = cmd.ExecuteReader();

            while (r.Read())
            {
                dgw_adatok.Rows.Add(r[0], r[1]);
            }

            conn.Close();

        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            conn.Open();

            var adapter = new SqlDataAdapter(){
                InsertCommand = new SqlCommand($"insert into proba (nev) VALUES ('{tb_input.Text}');", conn),
        };
            adapter.InsertCommand.ExecuteNonQuery();
            conn.Close();

          

        }
    }
}
