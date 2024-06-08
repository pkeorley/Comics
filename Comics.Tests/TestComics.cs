using Comics.ComicsImplementation;

namespace Comics.Tests
{
    [TestClass]
    public class TestComics
    {
        [TestMethod]
        public void TestClassicComicCreation()
        {
            IComic comic = new ClassicComic(100);

            Assert.IsNotNull(comic);
            Assert.AreEqual(comic.NumberOfPages, 100);
            Assert.AreEqual(comic.GiveTimeLoan(), 50);
        }

        [TestMethod]
        public void TestBadClassicComicCreation()
        {
            IComic comic = new ClassicComic(-100);

            Assert.IsNotNull(comic);
            Assert.AreEqual(comic.NumberOfPages, 10);
            Assert.AreEqual(comic.GiveTimeLoan(), 5);
        }

        [TestMethod]
        public void TestModernComicCreation()
        {
            IComic comic = new ModernComic(100);

            Assert.IsNotNull(comic);
            Assert.AreEqual(comic.NumberOfPages, 100);
            Assert.AreEqual(comic.GiveTimeLoan(), 30);
        }

        [TestMethod]
        public void TestBadModernComicCreation()
        {
            IComic comic = new ModernComic(-100);

            Assert.IsNotNull(comic);
            Assert.AreEqual(comic.NumberOfPages, 20);
            Assert.AreEqual(comic.GiveTimeLoan(), 6);
        }

        [TestMethod]
        public void TestPopComicCreation()
        {
            IComic comic = new PopComic(100);

            Assert.IsNotNull(comic);
            Assert.AreEqual(comic.NumberOfPages, 100);
            Assert.AreEqual(comic.GiveTimeLoan(), 30);
        }

        [TestMethod]
        public void TestPopClassicComicCreation()
        {
            IComic comic = new PopComic(-100); 

            Assert.IsNotNull(comic);
            Assert.AreEqual(comic.NumberOfPages, 5);
            Assert.AreEqual(comic.GiveTimeLoan(), 1.5);
        }
    }
}