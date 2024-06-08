namespace Comics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comic comic = new ClassicComic(10);
            Console.WriteLine(comic.NumberPage);
        }
    }
}