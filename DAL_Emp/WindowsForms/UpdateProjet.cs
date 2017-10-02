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
    public partial class UpdateProjet : Form
    {
        public UpdateProjet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int OldCodeP = int.Parse(textBox1.Text);
            Projet p = new Projet();
            p.CodeP = int.Parse(textBox2.Text);
            p.NomP = textBox3.Text;
            try
            {
                DALProjet.Update(OldCodeP, p);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Bien !");
            }
        }

        
    }
}
