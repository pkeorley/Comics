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
            Assert.AreEqual(comic.NumberOfPages, 1);
            Assert.AreEqual(comic.GiveTimeLoan(), 0.5);
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
            Assert.AreEqual(comic.NumberOfPages, 1);
            Assert.AreEqual(comic.GiveTimeLoan(), 0.3);
        }

        [TestMethod]
        public void TestPopComicCreation()
        {
            IComic comic = new PopComic(100);

            Assert.IsNotNull(comic);
            Assert.AreEqual(comic.NumberOfPages, 100);
            Assert.AreEqual(comic.GiveTimeLoan(), 20);
        }

        [TestMethod]
        public void TestPopClassicComicCreation()
        {
            IComic comic = new PopComic(-100); 

            Assert.IsNotNull(comic);
            Assert.AreEqual(comic.NumberOfPages, 1);
            Assert.AreEqual(comic.GiveTimeLoan(), 0.2);
        }
    }
}