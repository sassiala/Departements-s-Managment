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
    public partial class FormEmploye : Form
    {
        public FormEmploye()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AjouterEmploye em = new AjouterEmploye();
            try
            {

                em.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteEmploye x = new DeleteEmploye();
            
            try
            {

                x.Show();
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AfficheEmploye x = new AfficheEmploye();
            x.Show();
            this.Hide();
        }
    }
}
