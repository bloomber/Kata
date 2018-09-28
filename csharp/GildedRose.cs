using System;
using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        #region private and public fields
        IList<Item> Items;
        IList<Product> Products;
        #endregion
        [Obsolete("GildedRose(IList<Item> pItems) is deprecated  please use GildedRose(IList<Product> pProducs)")]
        public GildedRose(IList<Item> pItems)
        {
            this.Items = pItems;
        }


        public GildedRose(IList<Product> pProducs)
        {
            this.Products = pProducs;
        }

        [Obsolete("UpdateQuality is deprecated because the result is not correct with Conjured product,please use UpdateQuality2")]
        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (Items[i].Quality > 0)
                    {
                        if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                        {
                            Items[i].Quality = Items[i].Quality - 1;
                        }
                    }
                }
                else
                {
                    if (Items[i].Quality < 50)
                    {
                        Items[i].Quality = Items[i].Quality + 1;

                        if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (Items[i].SellIn < 11)
                            {
                                if (Items[i].Quality < 50)
                                {
                                    Items[i].Quality = Items[i].Quality + 1;
                                }
                            }

                            if (Items[i].SellIn < 6)
                            {
                                if (Items[i].Quality < 50)
                                {
                                    Items[i].Quality = Items[i].Quality + 1;
                                }
                            }
                        }
                    }
                }

                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    Items[i].SellIn = Items[i].SellIn - 1;
                }

                if (Items[i].SellIn < 0)
                {
                    if (Items[i].Name != "Aged Brie")
                    {
                        if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (Items[i].Quality > 0)
                            {
                                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                                {
                                    Items[i].Quality = Items[i].Quality - 1;
                                }
                            }
                        }
                        else
                        {
                            Items[i].Quality = Items[i].Quality - Items[i].Quality;
                        }
                    }
                    else
                    {
                        if (Items[i].Quality < 50)
                        {
                            Items[i].Quality = Items[i].Quality + 1;
                        }
                    }
                }
            }
        }

        public void UpdateQuality2()
        {

            try
            {
                foreach (Product product in this.Products)
                {
                    foreach (Rule rule in product.Rules)
                    {
                        int qualityPoint = 0;
                        bool commitQuality = false;

                        switch (rule.TypeOfOperatorValue)
                        {
                            case Rule.TypeOfOperator.BiggerEqual:
                                if (product.Item.SellIn >= rule.SellInValue)
                                    if (rule.TypeOfRuleValue.Equals(Rule.TypeOfRule.ChangeQuality))
                                    { qualityPoint = rule.QualityPoint; commitQuality = true; }
                                    else
                                        if (rule.TypeOfRuleValue.Equals(Rule.TypeOfRule.ReturnQuality0))
                                    { product.Item.Quality = 0; commitQuality = true; }
                                break;

                            case Rule.TypeOfOperator.SmallerEqual:
                                if (product.Item.SellIn <= rule.SellInValue)
                                    if (rule.TypeOfRuleValue.Equals(Rule.TypeOfRule.ChangeQuality))
                                        { qualityPoint = rule.QualityPoint; commitQuality = true; }
                                    else
                                        if (rule.TypeOfRuleValue.Equals(Rule.TypeOfRule.ReturnQuality0))
                                            { product.Item.Quality = 0; commitQuality = true; }
                                break;

                            case Rule.TypeOfOperator.None: break;

                            default: throw new Exception("Operator not implemented");
                        }


                        if (commitQuality)
                        {
                            int resultQuality = product.Item.Quality + qualityPoint;

                            if (resultQuality >= product.maxQuality)
                                product.Item.Quality = product.maxQuality;
                            else
                                 if (resultQuality <= product.minQuality)
                                product.Item.Quality = product.minQuality;
                            else
                                product.Item.Quality = resultQuality;

                            if (rule.TypeOfRuleValue.Equals(Rule.TypeOfRule.ReturnQuality0))
                                break;
                        }
                    }

                    if (product.Rules.Count > 0)
                        product.Item.SellIn--;
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
