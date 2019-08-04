using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace MyCourses.Controls
{
    public partial class panelEtudiants : UserControl
    {
        //test
        static List<Etudiant> listeE = new List<Etudiant>();

        static Etudiant e1 = new Etudiant(1, "nom1", "prenom1", "email1@mail.com", "mdp1", "filiere1", 2);
        static Etudiant e2 = new Etudiant(2, "nom2", "prenom2", "email2@mail.com", "mdp2", "filiere2", 1);
        static Etudiant e3 = new Etudiant(3, "nom3", "prenom3", "email3@mail.com", "mdp3", "filiere3", 2);
        
        
        
        bool passIsShown = false;

        public panelEtudiants()
        {
            InitializeComponent();
        }

        //Afficher
         void Afficher()
        {
            listeE.Clear();
            listeE.Add(e1);
            listeE.Add(e2);
            listeE.Add(e3);

            ListeEtudiants.Rows.Clear();
            for (int i = 0; i < listeE.Count; i++)
            {
                Etudiant et = new Etudiant();
               et = (Etudiant)listeE[i];
               ListeEtudiants.Rows.Add(et.GetId().ToString(), et.GetNom(), et.GetPrenom(), et.GetEmail(), et.GetMdp(), et.GetFiliere(), et.GetAnnee().ToString());
            }
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

        private void PanelEtudiants_Load(object sender, EventArgs e)// load
        {
            this.ListeEtudiants.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            ListeEtudiants.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10,FontStyle.Bold);
            Afficher();
        }

        private void ListeEtudiants_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
