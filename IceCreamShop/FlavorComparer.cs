using System;
using System.Collections.Generic;

namespace IceCreamShop

{
    public class FlavorComparer : IComparer<Flavor>
    {
        //public int Compare(Flavor x, Flavor y)
        //{
        //    return string.Compare(x.Name, y.Name);
        //}


        // BONUS: Modify FlavorComparer to sort Flavor objects by the number of allergens, from lowest to highest.
        public int Compare(Flavor x, Flavor y)
        {
            return x.Allergens.Count - y.Allergens.Count;
        }


    }
}
