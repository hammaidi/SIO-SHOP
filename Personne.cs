using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sio_shop
{
    public class Personne
    {

        public string Identifiant { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string Mail { get; set; }
        public string Tel { get; set; }
        public Personne(string identifiant, string nom, string prenom, string adresse, string mail, string tel)
        {
            Identifiant = identifiant;
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            Mail = mail;
            Tel = tel;
        }
        public Personne()
        {
            Identifiant = null;
            Nom = null;
            Prenom = null;
            Adresse = null;
            Mail = null;
            Tel = null;
        }
    }
}
