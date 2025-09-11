using System.Reflection.Metadata;
using System.Text.RegularExpressions;
// Partie 1 : Recherche par critère

// A. Filtrage basique
Console.WriteLine("--------- A. Filtrage basique ---------\n");

string[] wordsA = { "bonjour", "hello", "monde", "vert", "rouge", "bleu", "jaune" };

Func<string, bool> noX = wordsA => !wordsA.Contains('x');
Func<string, bool> moreThanFour = wordsA => wordsA.Length >= 4;
Func<string, bool> sameAsAVG = word => word.Length == wordsA.Average(word2 => word2.Length);

void Menu(IEnumerable<string> wordsA)
{
    Console.WriteLine("Choisissez un filtre : \n[1] Mots sans la lettre 'x'\n[2] Mots avec 4 lettres ou plus\n[3] Mots avec une longueur égale à la moyenne");

    string? input = Console.ReadLine();
    int userInput;
    if (!int.TryParse(input, out userInput))
    {
        Console.WriteLine("Entrée invalide. Veuillez entrer un nombre.");
        return;
    }
    if (userInput == 1)
    {
        Console.WriteLine("Mots sans la lettre 'x' :");
        Console.WriteLine(String.Join(",", wordsA.Where(noX)));
    }
    else if (userInput == 2)
    {
        Console.WriteLine("Mots avec 4 lettres ou plus :");
        Console.WriteLine(String.Join(",", wordsA.Where(moreThanFour)));
    }
    else if (userInput == 3)
    {
        Console.WriteLine("Mots avec une longueur égale à la moyenne :");
        Console.WriteLine(String.Join(",", wordsA.Where(sameAsAVG)));
    }
    else
    {
        Console.WriteLine("Veuillez entrer [1], [2] ou [3].");
    }

    Console.WriteLine("Dans quel ordre afficher le résultat ?\n[1] Ordre croissant\n[2] Ordre décroissant");
    input = Console.ReadLine();
    if (!int.TryParse(input, out userInput))
    {
        Console.WriteLine("Entrée invalide. Veuillez entrer un nombre.");
        return;
    }

    if (userInput == 1)
    {
        Console.WriteLine("Résultat en ordre croissant :");
        Console.WriteLine(String.Join(",", wordsA.OrderBy(word => word)));
    }
    else if (userInput == 2)
    {
        Console.WriteLine("Résultat en ordre décroissant :");
        Console.WriteLine(String.Join(",", wordsA.OrderByDescending(word => word)));
    }
    else
    {
        Console.WriteLine("Veuillez entrer [1] ou [2].");
    }
}

Menu(wordsA);


// B. Données parasites 1
Console.WriteLine("\n--------- B. Données parasites 1 ---------");

string[] wordsB = { "whatThe!!!", "bonjour", "hello", "monde", "vert", "rouge", "bleu", "jaune", "My kingdom for a horse !", "Ooops I did it again" };

var filtredWords = wordsB.Skip(1).Take(wordsB.Length - 3).ToArray();
Console.WriteLine("Mots sans les données parasites :");
Console.WriteLine(String.Join(",", filtredWords));


// C. Données parasites 2
Console.WriteLine("\n--------- C. Données parasites 2 ---------");

string[] wordsC = { "+++++", "<<<<<", ">>>>>", "bonjour", "hello", "@@@@", "vert", "rouge", "bleu", "jaune", "#####", "%%%%%%%" };

// ce que je voulais faire de base:
// var cleanWords = wordsC.Where(word => !word.Contains('+') && !word.Contains('<') && !word.Contains('>') && !word.Contains('@') && !word.Contains('#') && !word.Contains('%')).ToArray();

// mais c'est plus beau et mieux comme ça:
//var cleanWords = wordsC.Where(word => word.All(char.IsLetter)).ToArray();

// avec regex:
Func<string, bool> isOk = word => Regex.IsMatch(word, "^[a-zA-Z]");

var cleanWords = wordsC.Where(isOk);

Console.WriteLine("Mots sans les données parasites 2 :");
Console.WriteLine(String.Join(",", cleanWords));

// D. Elitisme
Console.WriteLine("\n--------- D. Elitisme ---------");

string[] wordsD = { "i am the winner", "hello", "monde", "vert", "rouge", "bleu", "i am the looser" };

var winner = wordsD.First();
var looser = wordsD.Last();

Console.WriteLine($"Le gagnant est : {winner}");
Console.WriteLine($"Le perdant est : {looser}");

// Partie 2: Epsilon
Console.WriteLine("\n--------- Partie 2: Epsilon ---------");

var letterFrequency = new Dictionary<char, double>()
{
    { 'e', 12.10 },
    { 'a', 7.11 },
    { 'i', 6.59 },
    { 's', 6.51 },
    { 'n', 6.39 },
    { 'r', 6.07 },
    { 't', 5.92 },
    { 'o', 5.02 },
    { 'l', 4.96 },
    { 'u', 4.49 },
    { 'd', 3.67 },
    { 'c', 3.18 },
    { 'm', 2.62 },
    { 'p', 2.49 },
    { 'é', 1.94 },
    { 'g', 1.23 },
    { 'b', 1.14 },
    { 'v', 1.11 },
    { 'h', 1.11 },
    { 'f', 1.11 },
    { 'q', 0.65 },
    { 'y', 0.46 },
    { 'x', 0.38 },
    { 'j', 0.34 },
    { 'è', 0.31 },
    { 'à', 0.31 },
    { 'k', 0.29 },
    { 'w', 0.17 },
    { 'z', 0.15 },
    { 'ê', 0.08 },
    { 'ç', 0.06 },
    { 'ô', 0.04 },
    { 'â', 0.03 },
    { 'î', 0.03 },
    { 'û', 0.02 },
    { 'ù', 0.02 },
    { 'ï', 0.01 },
    { 'á', 0.01 },
    { 'ü', 0.01 },
    { 'ë', 0.01 },
    { 'ö', 0.01 },
    { 'í', 0.01 }
};

double Epsilon(string word)
{
    double epsilon = 0.0;
    foreach (char c in word.ToLower())
    {
        if (letterFrequency.ContainsKey(c))
        {
            epsilon += letterFrequency[c];
        }
    }
    return epsilon / word.Length;
}

Console.WriteLine("Entrez un mot pour calculer son score epsilon :");
var userWord = Console.ReadLine();

Console.WriteLine($"Le score epsilon de votre mot est de : {Epsilon(userWord)}");

// Partie 3: Dictionnaire
Console.WriteLine("\n--------- Partie 3: Dictionnaire ---------");

List<string> frenchWords = new List<string>() {
    "Merci",
    "Hotdog",
    "Oui",
    "Non",
    "Désolé",
    "Réunion",
    "Manger",
    "Boire",
    "Téléphone",
    "Ordinateur",
    "Internet",
    "Email",
    "Sandwich",
    "Hello",
    "Taxi",
    "Hotel",
    "Gare",
    "Train",
    "Bus",
    "Métro",
    "Tramway",
    "Vélo",
    "Voiture",
    "Piéton",
    "Feu rouge",
    "Cédez",
    "Ralentir",
    "gauche",
    "droite",
    "Continuer",
    "Sandwich",
    "Retourner",
    "Arrêter",
    "Stationnement",
    "Parking",
    "Interdit",
    "Péage",
    "Trafic",
    "Route",
    "Rond-point",
    "Football",
    "Carrefour",
    "Feu",
    "Panneau",
    "Vitesse",
    "Tramway",
    "Aéroport",
    "Héliport",
    "Port",
    "Ferry",
    "Bateau",
    "Canot",
    "Kayak",
    "Paddle",
    "Surf",
    "Plage",
    "Mer",
    "Océan",
    "Rivière",
    "Lac",
    "Étang",
    "Marais",
    "Forêt",
    "Hello",
    "Montagne",
    "Vallée",
    "Plaine",
    "Désert",
    "Jungle",
    "Savane",
    "Volleyball",
    "Tundra",
    "Glacier",
    "Neige",
    "Pluie",
    "Soleil",
    "Nuage",
    "Vent",
    "Tempête",
    "Ouragan",
    "Tornade",
    "Séisme",
    "Tsunami",
    "Volcan",
    "Éruption",
    "Ciel"
};

List<string> englishWords = new List<string>() {
    "Thank you",
    "Hotdog",
    "Yes",
    "No",
    "Sorry",
    "Meeting",
    "Eat",
    "Drink",
    "Phone",
    "Computer",
    "Internet",
    "Email",
    "Sandwich",
    "Hello",
    "Taxi",
    "Hotel",
    "Station",
    "Train",
    "Bus",
    "Subway",
    "Tram",
    "Bike",
    "Car",
    "Pedestrian",
    "Red light",
    "Yield",
    "Slow down",
    "Left",
    "Right",
    "Continue",
    "Sandwich",
    "Turn back",
    "Stop",
    "Parking lot",
    "Parking",
    "Forbidden",
    "Toll",
    "Traffic",
    "Road",
    "Roundabout",
    "Soccer",
    "Intersection",
    "Light",
    "Sign",
    "Speed",
    "Tram",
    "Airport",
    "Heliport",
    "Port",
    "Ferry",
    "Boat",
    "Canoe",
    "Kayak",
    "Paddle",
    "Surf",
    "Beach",
    "Sea",
    "Ocean",
    "River",
    "Lake",
    "Pond",
    "Swamp",
    "Forest",
    "Hello",
    "Mountain",
    "Valley",
    "Plain",
    "Desert",
    "Jungle",
    "Savanna",
    "Volleyball",
    "Tundra",
    "Glacier",
    "Snow",
    "Rain",
    "Sun",
    "Cloud",
    "Wind",
    "Storm",
    "Hurricane",
    "Tornado",
    "Earthquake",
    "Tsunami",
    "Volcano",
    "Eruption",
    "Sky"
};

var sameWords = frenchWords.Intersect(englishWords);
Console.WriteLine("Mots présents dans les deux dictionnaires :");
Console.WriteLine(String.Join(", ", sameWords));