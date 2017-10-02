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
    public partial class DeleteEmploye : Form
    {
        public DeleteEmploye()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int matr;
            matr = int.Parse(textBox1.Text);
            try
            {
                DALEmploye.Delete(matr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
