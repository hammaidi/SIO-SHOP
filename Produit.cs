using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sio_shop
{
    class Produit
    {
        public string Reference { get; set; }
        public string Marque { get; set; }
        public string Nom { get; set; }
        public double Prix { get; set; }
        public int Stock { get; set; }
        public Produit(string reference, string marque, string nom, double prix, int stock)
        {
            this.Reference = reference;
            this.Marque = marque;
            this.Nom = nom;
            this.Prix = prix;
            this.Stock = stock;
        }
        public Produit()
        {
            this.Reference = null;
            this.Marque = null;
            this.Nom = null;
            this.Prix = 0;
            this.Stock = 0;
        }

        public Produit(DbDataReader reader)
        {
            int iref = reader.GetOrdinal("reference");
            int imarque = reader.GetOrdinal("marque");
            int inom = reader.GetOrdinal("nom");
            int iprix = reader.GetOrdinal("prix");
            int istock = reader.GetOrdinal("stock");
            Reference = reader.GetString(iref);
            Nom = reader.GetString(inom);
            Marque = reader.GetString(imarque);
            Prix = double.Parse(reader.GetString(iprix));
            Stock = int.Parse(reader.GetString(istock));
        }
        public string print()
        {
            return $"{Reference} - {Marque} - {Nom}";
        }

    }
}
