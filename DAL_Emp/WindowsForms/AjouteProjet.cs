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
    public partial class AjouteProjet : Form
    {
        public AjouteProjet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Projet p=new Projet();
            p.CodeP=int.Parse(textBox1.Text);
            p.NomP=textBox2.Text;
            try
            {
                DALProjet.Insert(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Bravo !");
            }
            
            
        }

        

        
    }
}
