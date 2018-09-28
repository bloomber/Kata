using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class Product
    {
        #region private and public field

        public Item Item { get; set; }
        public int maxQuality;
        public int minQuality;
        public IList<Rule> Rules;

        #endregion


        #region constructor

        public Product(Item pItem, int pMaxQuality, int pMinQuality, IList<Rule> pRules)
        {
            Item = pItem;
            maxQuality = pMaxQuality;
            minQuality = pMinQuality;
            Rules=pRules;
        }
        #endregion

        #region functions

        #endregion
    }
}
