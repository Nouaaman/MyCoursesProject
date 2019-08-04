using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MyCourses
{
    class Etudiant
    {
        private int id;
        private string nom;
        private string prenom;
        private string email;
        private string mdp;
        private string filiere;
        private int annee;

        //
        public Etudiant() { }

        public Etudiant(int i,string n,string p,string e,string m,string f,int a) {
             id = i;
             nom=n;
             prenom=p;
             email=e;
             mdp=m;
             filiere=f;
             annee=a;
        }

        //set

        public void SetId(int i) { id = i; }
        public void SetNom(string n) { nom = n; }
        public void SetPrenom(string p) { prenom = p; }
        public void SetEmail(string e) { email= e; }
        public void SetMdp(string m) { mdp=m; }
        public void SetFiliere(string f) { filiere = f; }
        public void SetAnnee(int a) { annee = a; }

        //get

        public int GetId() { return id; }
        public string GetNom() { return nom; }
        public string GetPrenom() { return prenom; }
        public string GetEmail() { return email; }
        public string GetMdp() { return mdp; }
        public string GetFiliere() { return filiere; }
        public int GetAnnee() { return annee; }


        //
        
      
    }
}
