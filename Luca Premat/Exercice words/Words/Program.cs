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

char[] 