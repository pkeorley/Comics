using Comics.ComicsImplementation;

namespace Comics.Tests
{
    [TestClass]
    public class TestComics
    {
        [TestMethod]
        public void TestWellClassicComicCreation()
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
        public void TestWellModernComicCreation()
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
        public void TestWellPopComicCreation()
        {
            IComic comic = new PopComic(100);

            Assert.IsNotNull(comic);
            Assert.AreEqual(comic.NumberOfPages, 100);
            Assert.AreEqual(comic.GiveTimeLoan(), 30);
        }

        [TestMethod]
        public void TestBadPopComicCreation()
        {
            IComic comic = new PopComic(-100); 

            Assert.IsNotNull(comic);
            Assert.AreEqual(comic.NumberOfPages, 5);
            Assert.AreEqual(comic.GiveTimeLoan(), 1.5);
        }

        [TestMethod]
        public void TestWellCollectionCreation()
        {
            Collection collection = new();
            Assert.IsNotNull(collection);

            collection.Add(new ClassicComic(20));
            Assert.AreEqual(collection.TotalNumberOfPages, 20);

            collection.Add(new ModernComic(30));
            Assert.AreEqual(collection.TotalNumberOfPages, 50);

            collection.Add(new PopComic(70));
            Assert.AreEqual(collection.TotalNumberOfPages, 120);
        }

        [TestMethod]
        public void TestBadCollectionCreation()
        {
            Collection collection = new();
            Assert.IsNotNull(collection);

            collection.Add(new ClassicComic(-100));
            Assert.AreEqual(collection.TotalNumberOfPages, 10);

            collection.Add(new ModernComic(30));
            Assert.AreEqual(collection.TotalNumberOfPages, 40);

            collection.Add(new ModernComic(-30));
            Assert.AreEqual(collection.TotalNumberOfPages, 60);

            collection.Add(new PopComic(-25));
            Assert.AreEqual(collection.TotalNumberOfPages, 65);
        }
    }
}