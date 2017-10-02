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
    public partial class AjouterEmploye : Form
    {
        public AjouterEmploye()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employe em = new Employe();
            em.Matr=int.Parse(textBox1.Text);
            em.NomE = textBox2.Text;
            em.Post = textBox3.Text;
            em.DateEmb = DateTime.Today;
            em.Sup =int.Parse( textBox4.Text);
            em.Salaire = int.Parse(textBox5.Text);
            em.Comm=int.Parse(textBox6.Text);
            em.NumDep = int.Parse(textBox7.Text);
            DALEmploye.Insert(em);
        }
    }
}
