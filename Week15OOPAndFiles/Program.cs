List<Movie> mymovies = new List<Movie>();

string[] data = GetDataFromMyFile();
//ReadDataFromArray(data);

foreach(string line in data)
{
    string[] temparray = line.Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);
    //Console.WriteLine("Temp array");
    //ReadDataFromArray(temparray);
    Movie newmovie = new Movie(temparray[0], temparray[2], temparray[1]);
    mymovies.Add(newmovie);
}

foreach(Movie movie in mymovies )
{
    Console.WriteLine($"One of my favorite movies {movie.Title} was released in {movie.Year}. Rating: {movie.Rating}");
}

static string[] GetDataFromMyFile()
{
    string filepath = @"C:\Users\PC\Desktop\Julia aine\Week5\Week15OOPAndFiles\movies.txt";
    //string[] datafromfile = File.ReadAllLines(filepath);

    return File.ReadAllLines(filepath);
}

static void ReadDataFromArray(string[] somearray)
{
    foreach(string line in somearray)
    {
        Console.WriteLine(line);
    }
}

class Movie
{
    string title;
    string year;
    string rating;

    public string Title
    {
        get { return title; }
    }
    public string Year
    {
        get { return year; }
    }
    public string Rating
    {
        get { return rating; }
    }
    public Movie(string _title, string _year, string _rating)
    {
        title = _title;
        year = _year;
        rating = _rating;
    }
}