using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Program;
using System.Data.SqlClient;
namespace WindowsForms
{
    public partial class AfficheProjet : Form
    {
        public AfficheProjet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProgramMain.bdconx.Open();
            SqlCommand cmd = new SqlCommand("Select * from Projet",ProgramMain.bdconx);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            ProgramMain.bdconx.Close();
        }
    }
}
