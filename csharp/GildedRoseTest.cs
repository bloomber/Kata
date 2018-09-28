using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreNotEqual("fixme", Items[0].Name);
        }


        [Test]
        public void foo2()
        {
            IList<Product> Products = new List<Product> { new Product(new Item { Name = "foo", SellIn = 0, Quality = 0 }, 50, 0, new List<Rule>() { }) };
            GildedRose app = new GildedRose(Products);
            app.UpdateQuality2();
            Assert.AreEqual("foo", Products[0].Item.Name);
        }



        [Test]
        public void foo3()
        {
            IList<Product> Products = new List<Product> { new Product(new Item { Name = "foo", SellIn = 0, Quality = 0 }, 50, 0, new List<Rule>() { }) };
            GildedRose app = new GildedRose(Products);
            app.UpdateQuality2();
            Assert.AreNotEqual("Bad", Products[0].Item.Name);
        }
    }
}
