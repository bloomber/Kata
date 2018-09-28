using System;
using System.Collections.Generic;

namespace csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");
            try
            {
                IList<Product> products = BuildProduct();

                var app = new GildedRose(products);


                for (var i = 0; i < 31; i++)
                {
                    Console.WriteLine("-------- day " + i + " --------");
                    Console.WriteLine("name, sellIn, quality");
                    foreach (Product product in products)
                    {
                        System.Console.WriteLine(product.Item);
                    }
                    Console.WriteLine("");
                    app.UpdateQuality2();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n"+ex.StackTrace);
            }
            Console.ReadLine();
        }

        public static IList<Product> BuildProduct()
        {
            IList<Product> Products = null;
            try
            {
                Products = new List<Product>{
                new Product(new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},50,0,new List<Rule>{new Rule(1,-1,Rule.TypeOfRule.ChangeQuality,Rule.TypeOfOperator.BiggerEqual),
                                                                                                                  new Rule(0,-2,Rule.TypeOfRule.ChangeQuality,Rule.TypeOfOperator.SmallerEqual) })
                ,
                new Product(new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},50,0,new List<Rule>{new Rule(1,+1,Rule.TypeOfRule.ChangeQuality,Rule.TypeOfOperator.BiggerEqual),
                                                                                                       new Rule(0,+2,Rule.TypeOfRule.ChangeQuality,Rule.TypeOfOperator.SmallerEqual) })
                ,
                new Product(new Item{Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},50,0,new List<Rule>{new Rule(1,-1,Rule.TypeOfRule.ChangeQuality,Rule.TypeOfOperator.BiggerEqual),
                                                                                                                  new Rule(0,-2,Rule.TypeOfRule.ChangeQuality,Rule.TypeOfOperator.SmallerEqual) })
                ,
                new Product(new Item{Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},80,0, new List<Rule>())
                ,
                new Product(new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80 },80,0, new List<Rule>())
                ,

                new Product(new Item{Name = "Backstage passes to a TAFKAL80ETC concert",SellIn = 15,Quality = 20},50,0,new List<Rule>{new Rule(0,0,Rule.TypeOfRule.ReturnQuality0,Rule.TypeOfOperator.SmallerEqual),
                                                                                                                  new Rule(11,+1,Rule.TypeOfRule.ChangeQuality,Rule.TypeOfOperator.BiggerEqual),
                                                                                                                  new Rule(10,+2,Rule.TypeOfRule.ChangeQuality,Rule.TypeOfOperator.SmallerEqual),
                                                                                                                  new Rule(5,+1,Rule.TypeOfRule.ChangeQuality,Rule.TypeOfOperator.SmallerEqual)  })
                ,
                new Product(new Item{Name = "Backstage passes to a TAFKAL80ETC concert",SellIn = 10,Quality = 49},50,0,new List<Rule>{new Rule(0,0,Rule.TypeOfRule.ReturnQuality0,Rule.TypeOfOperator.SmallerEqual),
                                                                                                                  new Rule(11,+1,Rule.TypeOfRule.ChangeQuality,Rule.TypeOfOperator.BiggerEqual),
                                                                                                                  new Rule(10,+2,Rule.TypeOfRule.ChangeQuality,Rule.TypeOfOperator.SmallerEqual),
                                                                                                                  new Rule(5,+1,Rule.TypeOfRule.ChangeQuality,Rule.TypeOfOperator.SmallerEqual)  })
                ,
                new Product(new Item{Name = "Backstage passes to a TAFKAL80ETC concert",SellIn = 5,Quality = 49},50,0,new List<Rule>{new Rule(0,0,Rule.TypeOfRule.ReturnQuality0,Rule.TypeOfOperator.SmallerEqual),
                                                                                                                  new Rule(11,+1,Rule.TypeOfRule.ChangeQuality,Rule.TypeOfOperator.BiggerEqual),
                                                                                                                  new Rule(10,+2,Rule.TypeOfRule.ChangeQuality,Rule.TypeOfOperator.SmallerEqual),
                                                                                                                  new Rule(5,+1,Rule.TypeOfRule.ChangeQuality,Rule.TypeOfOperator.SmallerEqual)  })
                ,
                new Product(new Item{ Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 },50,0,new List<Rule>{new Rule(1,-2,Rule.TypeOfRule.ChangeQuality,Rule.TypeOfOperator.BiggerEqual),
                                                                                                                  new Rule(0,-4,Rule.TypeOfRule.ChangeQuality,Rule.TypeOfOperator.SmallerEqual) })
            };
            }
            catch
            {
                throw;
            }

            return Products;
        }
    }
}
