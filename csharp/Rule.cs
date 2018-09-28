using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public enum TypeOfRule
    {
        Quality,
        SellIn,
        BornMaxQuality,
        BornMinQuality,
        OutOfDate
    }
    public class Rule
    {

        public string NameOfProduct { get; set; }
        public char Operator { get; set; }
        public int SellInValue { get; set; }

        public int QualityValue { get; set; }

        public TypeOfRule TypeOfRuleValue { get; set; }
    }
}
