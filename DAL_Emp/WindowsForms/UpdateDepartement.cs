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
    public partial class UpdateDepartement : Form
    {
        public UpdateDepartement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int NumDep = int.Parse(textBox1.Text);
            Departement d = new Departement();
            d.NumDep = NumDep;
            d.NomDep = textBox2.Text;
            d.Lieu = textBox3.Text;
            DALDepartement.Update(NumDep,d);
        }

        
    }
}
