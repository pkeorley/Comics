namespace Comics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IComic comic = new ClassicComic(10);
            Console.WriteLine(comic.GiveTimeLoan());
        }
    }
}