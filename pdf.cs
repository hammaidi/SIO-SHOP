using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;

namespace sio_shop
{
    class pdf
    {
        public static void GeneratePDF(Client p_cli, Produit p_pdt, Employe p_emp, int p_id)
        {
            string path = $"./factures/facture{p_id}_{p_cli.Nom}.pdf";
            Document facture = new Document();
            FileStream fs = new FileStream(path, FileMode.Create);
            PdfWriter streamPDF = PdfWriter.GetInstance(facture, fs);
            facture.Open();
            //**************** POLICES
            Font titre = new Font(Font.FontFamily.UNDEFINED, 20, Font.BOLD);
            //**************** INFO SIO SHOP
            Paragraph p1 = new Paragraph("SIO-SHOP\n70 Bd de St-Quentin\n80000 Amiens\n");
            p1.Alignment = Element.ALIGN_LEFT;
            facture.Add(p1);
            //**************** INFO CLIENT
            Paragraph p2 = new Paragraph($"{p_cli.Nom} {p_cli.Prenom}\n{p_cli.Adresse}\n{p_cli.Tel}\n");
            p2.Alignment = Element.ALIGN_RIGHT;
            facture.Add(p2);
            //**************** HEURE et DATE
            Paragraph pdate = new Paragraph(DateTime.Today.ToShortDateString() + ' ' +  DateTime.Now.ToShortTimeString());
            pdate.Alignment = Element.ALIGN_LEFT;
            facture.Add(pdate);
            //**************** TITRE
            Paragraph p3 = new Paragraph($"\nFACTURE n°{p_id}\n\n\n", titre);
            p3.Alignment = Element.ALIGN_CENTER;
            facture.Add(p3);
            //*************** Vendeur
            Paragraph p5 = new Paragraph($"\nVendeur : {p_emp.Nom} {p_emp.Prenom}\nContact : {p_emp.Mail}\n{p_emp.Tel}");
            p5.Alignment = Element.ALIGN_LEFT;
            facture.Add(p5);
            //**************** PRODUIT ACHETE
            Paragraph p4 = new Paragraph($"\n\nRéférence véhicule : {p_pdt.Reference}\n" +
                                            $"Marque véhicule : {p_pdt.Marque}\n" +
                                            $"Modèle véhicule : {p_pdt.Nom}\n\n" +
                                            $"Prix HT = {p_pdt.Prix} €\n" +
                                            $"TVA (20%) = {p_pdt.Prix / 5} €\n\n" +
                                            $"Prix à payer = {p_pdt.Prix + p_pdt.Prix / 5} €\n");
            p4.Alignment = Element.ALIGN_LEFT;
            facture.Add(p4);

            facture.Close();
            Process.Start(@"cmd.exe ", @"/c " + path);
        }
    }
}
