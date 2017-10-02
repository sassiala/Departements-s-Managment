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
namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            FormProjet Projet = new FormProjet();
            Projet.Show();
            //this.Hide();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormDepartement Departement = new FormDepartement();
            Departement.Show();
           // this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormEmploye x = new FormEmploye();
            x.Show();
           // this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormParticipation x = new FormParticipation();
            x.Show();
           // this.Hide();
        }
    }
}
