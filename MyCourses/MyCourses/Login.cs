using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCourses
{
    public partial class Login : Form
    {
        int  movX, movY;
        bool click;
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            click = true;
            movX = e.X;
            movY = e.Y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new Accueil();
            f.Show();
            this.Hide();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(click)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Veuillez contacter l'administration.", "Mot de passe oublié?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            click = false;
        }
    }
}
