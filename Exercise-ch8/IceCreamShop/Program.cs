using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;

            // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name' field.
            availableFlavors.Sort(new FlavorComparer());

            
            // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost' field.
            availableCones.Sort(new ConeComparer());


            // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.
            foreach (Flavor flavor in availableFlavors)
            {
                string printFlavors = flavor.Name + "   ALLERGENS: ";
                foreach (string allergen in flavor.Allergens)
                {
                    printFlavors += allergen + " ";
                }
                Console.WriteLine(printFlavors);
            }

            Console.WriteLine("\n\n");

            foreach (Cone cone in availableCones)
            {
                Console.WriteLine(cone.Name + ": " + "$" + cone.Cost);
            }
        }
    }
}
