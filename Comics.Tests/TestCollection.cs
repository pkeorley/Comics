using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comics.Tests
{
    [TestClass]
    public class TestCollection
    {

        [TestMethod]
        public void TestCollectionClass()
        {
            Collection collection = new();

            collection.Add(new Comic(150));
            Assert.AreEqual(collection.TotalNumberOfPages, 150);

            collection.Add(new Comic(100));
            Assert.AreEqual(collection.TotalNumberOfPages, 250);

            collection.Add(new Comic(1));
            Assert.AreEqual(collection.TotalNumberOfPages, 251);
        }

        [TestMethod]
        public void TestBadCollectionClass()
        {
            Collection collection = new();
            
            collection.Add(new Comic(-150));
            Assert.AreEqual(collection.TotalNumberOfPages, 1);

            collection.Add(new Comic(-1));
            Assert.AreEqual(collection.TotalNumberOfPages, 2);

            collection.Add(new Comic(0));
            Assert.AreEqual(collection.TotalNumberOfPages, 3);
        }

    }
}
