using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCourses.Controls
{
    public partial class panelEtudiants : UserControl
    {
        bool passIsShown = false;

        public panelEtudiants()
        {
            InitializeComponent();
        }


        private void pictureBoxShowMdp_Click(object sender, EventArgs e)
        {
            if (passIsShown)
            {
                textBoxMdp.UseSystemPasswordChar = true;
                passIsShown = false;
            }
            else
            {
                textBoxMdp.UseSystemPasswordChar = false;
                passIsShown = true ;
            }
        }//afficher ou cacher mdp

        private void textBoxRechercheNom_Enter(object sender, EventArgs e)
        {
            if (textBoxRechercheNom.Text == "Nom")
            {
                textBoxRechercheNom.Text = "";
                textBoxRechercheNom.ForeColor = System.Drawing.ColorTranslator.FromHtml("#262626");
            }
        }

        private void textBoxRechercheNom_Leave(object sender, EventArgs e)
        {
            if (textBoxRechercheNom.Text == "")
            {
                textBoxRechercheNom.Text = "Nom";
                textBoxRechercheNom.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }

        private void button4_Click(object sender, EventArgs e)  //clear button 
        {
            textBoxRechercheNom.Text = "Nom";
            textBoxRecherchePrenom.Text = "Prenom";
            textBoxRechercheEmail.Text = "Email";

            textBoxRechercheNom.ForeColor = System.Drawing.SystemColors.GrayText;
            textBoxRecherchePrenom.ForeColor = System.Drawing.SystemColors.GrayText;
            textBoxRechercheEmail.ForeColor = System.Drawing.SystemColors.GrayText;
        }

        private void textBoxRecherchePrenom_Enter(object sender, EventArgs e)
        {
            if (textBoxRecherchePrenom.Text == "Prenom")
            {
                textBoxRecherchePrenom.Text = "";
                textBoxRecherchePrenom.ForeColor = System.Drawing.ColorTranslator.FromHtml("#262626");
            }
        }

        private void textBoxRecherchePrenom_Leave(object sender, EventArgs e)
        {
            if (textBoxRecherchePrenom.Text == "")
            {
                textBoxRecherchePrenom.Text = "Prenom";
                textBoxRecherchePrenom.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }

        private void textBoxRechercheEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxRechercheEmail.Text == "Email")
            {
                textBoxRechercheEmail.Text = "";
                textBoxRechercheEmail.ForeColor = System.Drawing.ColorTranslator.FromHtml("#262626");
            }
        }

        private void textBoxRechercheEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxRechercheEmail.Text == "")
            {
                textBoxRechercheEmail.Text = "Email";
                textBoxRechercheEmail.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }
    }
}
