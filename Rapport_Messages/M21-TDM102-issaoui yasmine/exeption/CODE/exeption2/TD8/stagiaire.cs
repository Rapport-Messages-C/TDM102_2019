using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD8
{
    class stagiaire
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string nom;
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        private string prenom;
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        private string cin;
        public string Cin
        {
            get { return cin; }
            set { cin = value; }
        }
        
        public string presentation()
        {
            string presentation = "je suis " + this.Nom + " " + this.Prenom + " avec le CIN " + this.Cin;
            return presentation;
        }
        public  string ToString()
        {
            return this.presentation();
        }
    }
}
