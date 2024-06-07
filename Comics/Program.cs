namespace Comics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Collection comics = new();

            comics.Add(new Comic(50));
            comics.Add(new ClassicComic(50));
            comics.Add(new ModernComic(75));
            comics.Add(new PopComic(25));

            Console.WriteLine(comics.TotalNumberOfPages);
        }
    }
}