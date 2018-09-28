using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public class Rule
    {
        public enum TypeOfRule
        {
            ChangeQuality,
            ReturnQuality0
        }

        public enum TypeOfOperator
        {
            None,
            BiggerEqual,
            SmallerEqual
        }


        #region private and public fields
        public int SellInValue { get; set; }
        public int QualityPoint { get; set; }

        public TypeOfRule TypeOfRuleValue { get; set; }
        public TypeOfOperator TypeOfOperatorValue { get; set; }

        #endregion


        #region Constructor
        public Rule(int pSellInValue, int pQualityPoint, TypeOfRule pTypeOfRuleValue, TypeOfOperator pTypeOfOperatorValue)
        {
            SellInValue = pSellInValue;
            QualityPoint = pQualityPoint;
            TypeOfOperatorValue=pTypeOfOperatorValue;
            TypeOfRuleValue = pTypeOfRuleValue;
        }

        #endregion


        #region Functions

        #endregion
    }
}
