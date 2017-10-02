using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class FormProjet : Form
    {
        public FormProjet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AjouteProjet x = new AjouteProjet();
            x.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)//Update
        {
            UpdateProjet x = new UpdateProjet();
            x.Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)//Delete
        {
            DeleteProjet x = new DeleteProjet();
            x.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AfficheProjet x = new AfficheProjet();
            x.Show();
            this.Hide();
        }
    }
}
