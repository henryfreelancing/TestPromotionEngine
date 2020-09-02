using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMe
{
    public  class ClassPromotion
    {
        IDictionary<string, double> itemValues = new Dictionary<string, double>();
        public ClassPromotion()
        {

            itemValues = new Dictionary<string, double>();
            itemValues.Add("A", 50);
            itemValues.Add("B", 30);
            itemValues.Add("C", 20);
            itemValues.Add("D", 15);

        }


        public double applyPromotion(IDictionary<string, int> itemList)
        {
            double itemVal = 0;
            double itemTotValue = 0;
            int vl;
            int tPQty = 0;
            foreach (KeyValuePair<string, int> itV in itemList)
            {
                double itemRate = itemValues[itV.Key];
                itemVal = 0;
                tPQty = 0;
                switch (itV.Key)
                {
                    case "A":
                        tPQty = 3;
                        vl = itV.Value / tPQty;
                        itemVal = vl * 130 + (itV.Value - vl* tPQty) * 50;
                        break;

                    case "B":
                        tPQty = 2;
                        vl = itV.Value / 2;
                        itemVal = vl * 45 + (itV.Value - vl*tPQty) * 30;
                        break;
                    default :
                        break;

                }
                itemTotValue += itemVal;
                

            }

            if (itemList.ContainsKey("C") && itemList.ContainsKey("D"))
                itemTotValue += 30;
            else if (itemList.ContainsKey("C"))
                itemTotValue += 20;
            else if (itemList.ContainsKey("D"))
                itemTotValue += 15;


            return itemTotValue;
        }




    }
}
