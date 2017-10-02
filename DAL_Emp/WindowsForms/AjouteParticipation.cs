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
    public partial class AjouteParticipation : Form
    {
        public AjouteParticipation()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Participation p = new Participation();
            p.Matr = int.Parse(textBox1.Text);
            p.CodeP = int.Parse(textBox2.Text);
            p.Fonction = textBox3.Text;
            try
            {
                DALParticipation.Insert(p);
                MessageBox.Show("Bien ! ");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
