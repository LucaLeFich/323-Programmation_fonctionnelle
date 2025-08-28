using System;

public class MarcheItems
{
    public int Emplacement { get; set; }
    public string? Producteur { get; set; }
    public string? Produit { get; set; }
    public double Quantite { get; set; }
    public string? Unite { get; set; }
    public double PrixParUnite { get; set; }
}

class Program
{
    static void Main()
    {
        var marche = new List<MarcheItems>
        {
            new MarcheItems { Emplacement = 1, Producteur = "Bornand", Produit = "Pommes", Quantite = 20, Unite = "kg", PrixParUnite = 6.90 },
            new MarcheItems { Emplacement = 1, Producteur = "Bornand", Produit = "Poires", Quantite = 16, Unite = "kg", PrixParUnite = 3.50 },
            new MarcheItems { Emplacement = 1, Producteur = "Bornand", Produit = "Pastèques", Quantite = 14, Unite = "pièce", PrixParUnite = 6.00 },
            new MarcheItems { Emplacement = 1, Producteur = "Bornand", Produit = "Melons", Quantite = 5, Unite = "kg", PrixParUnite = 7.00 },
            new MarcheItems { Emplacement = 2, Producteur = "Dumont", Produit = "Noix", Quantite = 20, Unite = "sac", PrixParUnite = 8.60 },
            new MarcheItems { Emplacement = 2, Producteur = "Dumont", Produit = "Raisin", Quantite = 6, Unite = "kg", PrixParUnite = 5.60 },
            new MarcheItems { Emplacement = 2, Producteur = "Dumont", Produit = "Pruneaux", Quantite = 13, Unite = "kg", PrixParUnite = 8.10 },
            new MarcheItems { Emplacement = 2, Producteur = "Dumont", Produit = "Myrtilles", Quantite = 12, Unite = "kg", PrixParUnite = 8.90 },
            new MarcheItems { Emplacement = 2, Producteur = "Dumont", Produit = "Groseilles", Quantite = 12, Unite = "kg", PrixParUnite = 5.20 },
            new MarcheItems { Emplacement = 3, Producteur = "Vonlanthen", Produit = "Pêches", Quantite = 8, Unite = "kg", PrixParUnite = 8.70 },
            new MarcheItems { Emplacement = 3, Producteur = "Vonlanthen", Produit = "Haricots", Quantite = 6, Unite = "kg", PrixParUnite = 6.90 },
            new MarcheItems { Emplacement = 3, Producteur = "Vonlanthen", Produit = "Courges", Quantite = 18, Unite = "pièce", PrixParUnite = 4.30 },
            new MarcheItems { Emplacement = 3, Producteur = "Vonlanthen", Produit = "Tomates", Quantite = 12, Unite = "kg", PrixParUnite = 9.40 },
            new MarcheItems { Emplacement = 3, Producteur = "Vonlanthen", Produit = "Pommes", Quantite = 20, Unite = "kg", PrixParUnite = 3.90 },
            new MarcheItems { Emplacement = 4, Producteur = "Barizzi", Produit = "Poires", Quantite = 5, Unite = "kg", PrixParUnite = 6.30 },
            new MarcheItems { Emplacement = 4, Producteur = "Barizzi", Produit = "Pastèques", Quantite = 6, Unite = "pièce", PrixParUnite = 2.50 },
            new MarcheItems { Emplacement = 4, Producteur = "Barizzi", Produit = "Melons", Quantite = 14, Unite = "kg", PrixParUnite = 4.20 },
            new MarcheItems { Emplacement = 4, Producteur = "Barizzi", Produit = "Noix", Quantite = 20, Unite = "sac", PrixParUnite = 7.50 },
            new MarcheItems { Emplacement = 4, Producteur = "Barizzi", Produit = "Raisin", Quantite = 15, Unite = "kg", PrixParUnite = 7.20 },
            new MarcheItems { Emplacement = 5, Producteur = "Blanc", Produit = "Pruneaux", Quantite = 5, Unite = "kg", PrixParUnite = 9.00 },
            new MarcheItems { Emplacement = 5, Producteur = "Blanc", Produit = "Myrtilles", Quantite = 18, Unite = "kg", PrixParUnite = 5.60 },
            new MarcheItems { Emplacement = 5, Producteur = "Blanc", Produit = "Groseilles", Quantite = 10, Unite = "kg", PrixParUnite = 2.10 },
            new MarcheItems { Emplacement = 5, Producteur = "Blanc", Produit = "Pêches", Quantite = 20, Unite = "kg", PrixParUnite = 6.40 },
            new MarcheItems { Emplacement = 5, Producteur = "Blanc", Produit = "Haricots", Quantite = 9, Unite = "kg", PrixParUnite = 2.90 },
            new MarcheItems { Emplacement = 6, Producteur = "Repond", Produit = "Courges", Quantite = 12, Unite = "pièce", PrixParUnite = 7.40 },
            new MarcheItems { Emplacement = 6, Producteur = "Repond", Produit = "Tomates", Quantite = 12, Unite = "kg", PrixParUnite = 4.20 },
            new MarcheItems { Emplacement = 6, Producteur = "Repond", Produit = "Pommes", Quantite = 15, Unite = "kg", PrixParUnite = 6.50 },
            new MarcheItems { Emplacement = 6, Producteur = "Repond", Produit = "Poires", Quantite = 18, Unite = "kg", PrixParUnite = 2.40 },
            new MarcheItems { Emplacement = 6, Producteur = "Repond", Produit = "Pastèques", Quantite = 7, Unite = "pièce", PrixParUnite = 5.70 },
            new MarcheItems { Emplacement = 7, Producteur = "Mancini", Produit = "Pêches", Quantite = 10, Unite = "kg", PrixParUnite = 2.90 },
            new MarcheItems { Emplacement = 7, Producteur = "Mancini", Produit = "Haricots", Quantite = 11, Unite = "kg", PrixParUnite = 6.70 },
            new MarcheItems { Emplacement = 7, Producteur = "Mancini", Produit = "Courges", Quantite = 10, Unite = "pièce", PrixParUnite = 6.40 },
            new MarcheItems { Emplacement = 7, Producteur = "Mancini", Produit = "Tomates", Quantite = 13, Unite = "kg", PrixParUnite = 1.50 },
            new MarcheItems { Emplacement = 7, Producteur = "Mancini", Produit = "Pommes", Quantite = 14, Unite = "kg", PrixParUnite = 7.00 },
            new MarcheItems { Emplacement = 8, Producteur = "Favre", Produit = "Poires", Quantite = 5, Unite = "kg", PrixParUnite = 8.40 },
            new MarcheItems { Emplacement = 8, Producteur = "Favre", Produit = "Pastèques", Quantite = 5, Unite = "pièce", PrixParUnite = 1.70 },
            new MarcheItems { Emplacement = 8, Producteur = "Favre", Produit = "Haricots", Quantite = 5, Unite = "kg", PrixParUnite = 3.00 },
            new MarcheItems { Emplacement = 8, Producteur = "Favre", Produit = "Courges", Quantite = 17, Unite = "pièce", PrixParUnite = 2.00 },
            new MarcheItems { Emplacement = 8, Producteur = "Favre", Produit = "Tomates", Quantite = 9, Unite = "kg", PrixParUnite = 5.20 },
            new MarcheItems { Emplacement = 9, Producteur = "Bovay", Produit = "Pommes", Quantite = 13, Unite = "kg", PrixParUnite = 7.70 },
            new MarcheItems { Emplacement = 9, Producteur = "Bovay", Produit = "Poires", Quantite = 5, Unite = "kg", PrixParUnite = 3.80 },
            new MarcheItems { Emplacement = 9, Producteur = "Bovay", Produit = "Pastèques", Quantite = 20, Unite = "pièce", PrixParUnite = 2.10 },
            new MarcheItems { Emplacement = 9, Producteur = "Bovay", Produit = "Melons", Quantite = 20, Unite = "kg", PrixParUnite = 6.40 },
            new MarcheItems { Emplacement = 9, Producteur = "Bovay", Produit = "Noix", Quantite = 13, Unite = "sac", PrixParUnite = 8.80 },
            new MarcheItems { Emplacement = 10, Producteur = "Cherix", Produit = "Raisin", Quantite = 8, Unite = "kg", PrixParUnite = 7.10 },
            new MarcheItems { Emplacement = 10, Producteur = "Cherix", Produit = "Pruneaux", Quantite = 19, Unite = "kg", PrixParUnite = 7.90 },
            new MarcheItems { Emplacement = 10, Producteur = "Cherix", Produit = "Myrtilles", Quantite = 9, Unite = "kg", PrixParUnite = 4.20 },
            new MarcheItems { Emplacement = 10, Producteur = "Cherix", Produit = "Groseilles", Quantite = 10, Unite = "kg", PrixParUnite = 4.40 },
            new MarcheItems { Emplacement = 10, Producteur = "Cherix", Produit = "Pêches", Quantite = 9, Unite = "kg", PrixParUnite = 4.40 },
            new MarcheItems { Emplacement = 11, Producteur = "Beaud", Produit = "Haricots", Quantite = 19, Unite = "kg", PrixParUnite = 8.40 },
            new MarcheItems { Emplacement = 11, Producteur = "Beaud", Produit = "Courges", Quantite = 16, Unite = "pièce", PrixParUnite = 8.70 },
            new MarcheItems { Emplacement = 11, Producteur = "Beaud", Produit = "Tomates", Quantite = 18, Unite = "kg", PrixParUnite = 5.30 },
            new MarcheItems { Emplacement = 11, Producteur = "Beaud", Produit = "Pommes", Quantite = 8, Unite = "kg", PrixParUnite = 7.30 },
            new MarcheItems { Emplacement = 11, Producteur = "Beaud", Produit = "Poires", Quantite = 13, Unite = "kg", PrixParUnite = 9.20 },
            new MarcheItems { Emplacement = 12, Producteur = "Corbaz", Produit = "Pastèques", Quantite = 15, Unite = "pièce", PrixParUnite = 7.40 },
            new MarcheItems { Emplacement = 12, Producteur = "Corbaz", Produit = "Melons", Quantite = 12, Unite = "kg", PrixParUnite = 1.60 },
            new MarcheItems { Emplacement = 12, Producteur = "Corbaz", Produit = "Noix", Quantite = 11, Unite = "sac", PrixParUnite = 7.50 },
            new MarcheItems { Emplacement = 12, Producteur = "Corbaz", Produit = "Raisin", Quantite = 16, Unite = "kg", PrixParUnite = 4.50 },
            new MarcheItems { Emplacement = 12, Producteur = "Corbaz", Produit = "Pruneaux", Quantite = 20, Unite = "kg", PrixParUnite = 3.30 },
            new MarcheItems { Emplacement = 13, Producteur = "Amaudruz", Produit = "Myrtilles", Quantite = 18, Unite = "kg", PrixParUnite = 5.70 },
            new MarcheItems { Emplacement = 13, Producteur = "Amaudruz", Produit = "Groseilles", Quantite = 19, Unite = "kg", PrixParUnite = 8.00 },
            new MarcheItems { Emplacement = 13, Producteur = "Amaudruz", Produit = "Pêches", Quantite = 12, Unite = "kg", PrixParUnite = 5.50 },
            new MarcheItems { Emplacement = 13, Producteur = "Amaudruz", Produit = "Haricots", Quantite = 13, Unite = "kg", PrixParUnite = 5.20 },
            new MarcheItems { Emplacement = 13, Producteur = "Amaudruz", Produit = "Courges", Quantite = 7, Unite = "pièce", PrixParUnite = 9.60 },
            new MarcheItems { Emplacement = 14, Producteur = "Bühlmann", Produit = "Tomates", Quantite = 12, Unite = "kg", PrixParUnite = 7.70 },
            new MarcheItems { Emplacement = 14, Producteur = "Bühlmann", Produit = "Pommes", Quantite = 17, Unite = "kg", PrixParUnite = 1.90 },
            new MarcheItems { Emplacement = 14, Producteur = "Bühlmann", Produit = "Poires", Quantite = 7, Unite = "kg", PrixParUnite = 3.00 },
            new MarcheItems { Emplacement = 14, Producteur = "Bühlmann", Produit = "Pastèques", Quantite = 11, Unite = "pièce", PrixParUnite = 6.90 },
            new MarcheItems { Emplacement = 14, Producteur = "Bühlmann", Produit = "Melons", Quantite = 7, Unite = "kg", PrixParUnite = 4.70 },
            new MarcheItems { Emplacement = 15, Producteur = "Crizzi", Produit = "Noix", Quantite = 10, Unite = "sac", PrixParUnite = 1.60 },
            new MarcheItems { Emplacement = 15, Producteur = "Crizzi", Produit = "Raisin", Quantite = 17, Unite = "kg", PrixParUnite = 7.80 },
            new MarcheItems { Emplacement = 15, Producteur = "Crizzi", Produit = "Pruneaux", Quantite = 18, Unite = "kg", PrixParUnite = 9.00 },
            new MarcheItems { Emplacement = 15, Producteur = "Crizzi", Produit = "Myrtilles", Quantite = 12, Unite = "kg", PrixParUnite = 3.00 },
            new MarcheItems { Emplacement = 15, Producteur = "Crizzi", Produit = "Groseilles", Quantite = 12, Unite = "kg", PrixParUnite = 3.50 }
        };

        // var vendeursPêches = marche
        //     .Count(item => item.Produit == "Pêches");
        // Console.WriteLine($"Il y a {vendeursPêches} vendeurs de Pêches.");

        // var MaxPastèque = marche
        //     .Where(item => item.Produit == "Pastèques")
        //     .OrderByDescending(item => item.Quantite)
        //     .First();
        // Console.WriteLine($"C'est {MaxPastèque.Producteur} qui a le plus de pastèques (stand {MaxPastèque.Emplacement}, {MaxPastèque.Quantite} pièces).");

        int pastèques = 0;
        int MaxPastèque = 0;
        string? VendeurMaxPastèque = null;
        foreach (var item in marche)
        {
            if (item.Produit == "Pastèques")
            {
                pastèques += (int)item.Quantite;
            }

            if (item.Produit == "Pastèques" && item.Quantite > MaxPastèque)
            {
                MaxPastèque = (int)item.Quantite;
                VendeurMaxPastèque = item.Producteur;
            }
        }

        Console.WriteLine($"Il y a {pastèques} pastèques.");
        Console.WriteLine($"{VendeurMaxPastèque} à {MaxPastèque}.");
    }
}
