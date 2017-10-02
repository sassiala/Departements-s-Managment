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
    public partial class AjouteDepartement : Form
    {
        public AjouteDepartement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Departement d = new Departement();
            d.NumDep = int.Parse(textBox1.Text);
            d.NomDep = textBox2.Text;
            d.Lieu = textBox3.Text;
            DALDepartement.Insert(d);
        }

        
    }
}
