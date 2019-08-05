using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace MyCourses
{
    public partial class Demarrage : Form
    {
        public Demarrage()
        {
            InitializeComponent();
        }

   
        private void Fermer()
        {

            Form f = new Login();
            f.Show();
            this.Hide();
          
        }

        private void Demarrage_Click(object sender, EventArgs e)
        {
            Fermer();
        }

       
    }
}
