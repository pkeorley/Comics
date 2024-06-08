namespace Comics.Tests
{
    [TestClass]
    public class TestComics
    {
        [TestMethod]
        public void TestClassicComicCreation()
        {
            ClassicComic comic = new ClassicComic(100);

            Assert.IsNotNull(comic);
            Assert.AreEqual(comic.NumberPage, 100);
            Assert.AreEqual(comic.GiveTimeLoan(), 50);
        }

        [TestMethod]
        public void TestBadClassicComicCreation()
        {
            ClassicComic comic = new ClassicComic(-100);

            Assert.IsNotNull(comic);
            Assert.AreEqual(comic.NumberPage, 1);
            Assert.AreEqual(comic.GiveTimeLoan(), 0.5);
        }

        [TestMethod]
        public void TestModernComicCreation()
        {
            ModernComic comic = new ModernComic(100);

            Assert.IsNotNull(comic);
            Assert.AreEqual(comic.NumberPage, 100);
            Assert.AreEqual(comic.GiveTimeLoan(), 30);
        }

        [TestMethod]
        public void TestBadModernComicCreation()
        {
            ModernComic comic = new ModernComic(-100);

            Assert.IsNotNull(comic);
            Assert.AreEqual(comic.NumberPage, 1);
            Assert.AreEqual(comic.GiveTimeLoan(), 0.3);
        }

        [TestMethod]
        public void TestPopComicCreation()
        {
            PopComic comic = new PopComic(100);

            Assert.IsNotNull(comic);
            Assert.AreEqual(comic.NumberPage, 100);
            Assert.AreEqual(comic.GiveTimeLoan(), 20);
        }

        [TestMethod]
        public void TestPopClassicComicCreation()
        {
            PopComic comic = new PopComic(-100); 

            Assert.IsNotNull(comic);
            Assert.AreEqual(comic.NumberPage, 1);
            Assert.AreEqual(comic.GiveTimeLoan(), 0.2);
        }
    }
}