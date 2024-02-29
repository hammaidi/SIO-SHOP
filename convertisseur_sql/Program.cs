using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace convertisseur_sql
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path_txt = "data_insert.txt";
                string path_csv = "data.csv";
                string[] lines = File.ReadAllLines(path_csv);
                File.Delete(path_txt);
                StreamWriter sw = new StreamWriter(path_txt, true);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(';');
                    sw.WriteLine($"INSERT INTO produit VALUES ({parts[0]}, '{parts[1]}', '{parts[2]}', {parts[3]}, {parts[4]});");
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur : " + e.Message);
                Console.Read();
            }
            
        }
    }
}
