using MyCourses.Controls;
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
    public partial class Accueil : Form
    {
        bool click;
        int movX, movY;
        public Accueil()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            dt = System.DateTime.Now;
            labelDate.Text = dt.ToShortDateString();
            panelEtudiants pEtudiants = new panelEtudiants();
            afficherPanel(pEtudiants);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void afficherPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }
   

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }

        }


        private void buttonProfesseurs_Click(object sender, EventArgs e)//afficher panel etudiant
        {
            panelProfesseurs p = new panelProfesseurs();
            afficherPanel(p);
        }

        private void buttonEtudiants_Click(object sender, EventArgs e)//afficher panel professeurs
        {
            panelEtudiants pEtudiants = new panelEtudiants();
            afficherPanel(pEtudiants);
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void logo_MouseMove(object sender, MouseEventArgs e)
        {
            if(click)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void logo_MouseUp(object sender, MouseEventArgs e)
        {
            click = false;
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Form l = new Login();

            this.Close();
            l.Show();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {

        }

        private void logo_MouseDown(object sender, MouseEventArgs e)
        {
            click = true;
            movY= e.Y;
            movX= e.X;
        }
    }
}
