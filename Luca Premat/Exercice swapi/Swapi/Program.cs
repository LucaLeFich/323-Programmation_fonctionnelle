//Import de la librairie
using System.Text.Json;

//Un client global pour éviter de surcharger l'OS et profiter d'un socket avec tout son contexte
//pour toutes les requêtes (DNS,TCP,...)
HttpClient client = new HttpClient();

string json = HttpGet(client,"films");

//System.Console.WriteLine(json);



//Récupération du json
var moviesJson = HttpGet(client,"films");

//Conversion Json vers une classe définie
var moviesResult = JsonSerializer.Deserialize<FilmResult>(moviesJson);

//Récupération d'une sous-partie
var movies = moviesResult.results;

//Console.WriteLine(string.Join(',',movies.Select(m=>m.title)));

movies.Write();


string HttpGet(HttpClient client,string query)
{
    var json = HttpGetAsync(client,query).ConfigureAwait(false).GetAwaiter().GetResult();
    return json;
}
async Task<string> HttpGetAsync(HttpClient client,string query)
{
    var response = await client.GetAsync(query.Contains("https") ? query : "https://swapi.dev/api/" + query);
    response.EnsureSuccessStatusCode();
    var json = await response.Content.ReadAsStringAsync();

    return json;
}

public static class Extension
{
    public static void Write(this IEnumerable<object> target, char separator = ',')
    {
        Console.WriteLine(String.Join(separator, target));
    }
}

//Définition des classes
class FilmResult
{
    public int count { get; set; }
    public List<Film> results { get; set; }

    public override string? ToString()
    {
        return base.ToString();
    }
}

class Film
{
    public string title { get; set; }
    public List<string> characters { get; set; }

    public override string? ToString()
    {
        return title;
    }
}



