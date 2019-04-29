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
            Application.Exit();
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

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "Email")
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = System.Drawing.ColorTranslator.FromHtml("#262626");
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                textBoxEmail.Text = "Email";
                textBoxEmail.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {

            if (textBoxPassword.Text == "Mot de passe")
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = System.Drawing.ColorTranslator.FromHtml("#262626");
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Mot de passe";
                textBoxPassword.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            click = false;
        }
    }
}
