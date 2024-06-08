using Comics.ComicsImplementation;

namespace Comics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Collection collection = new();

            collection.Add(new ClassicComic(10));
            collection.Add(new ModernComic(20));
            collection.Add(new PopComic(30));

            Console.WriteLine(collection.TotalNumberOfPages);
        }
    }
}