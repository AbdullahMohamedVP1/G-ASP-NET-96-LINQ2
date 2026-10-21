using static LINQ.DataSources.Source;
using LINQ.DataSources;
using LINQ.Models;

namespace LinqAssi2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region From 1 to 5

            // Q1
            Console.WriteLine("1. Get top 3 most expensive products");
            Console.WriteLine();
            var q1 = ProductList.OrderByDescending(p => p.UnitPrice).Take(3);
            foreach (var p in q1)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();

            // Q2
            Console.WriteLine("2. Show page 2 of products, with page size = 5");
            Console.WriteLine();
            var q2 = ProductList.Skip(5).Take(5);
            foreach (var p in q2)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();

            // Q3
            Console.WriteLine("3. Take products from the list as long as their UnitPrice is less than $25 (list is ordered by price)");
            Console.WriteLine();
            var q3 = ProductList.OrderBy(p => p.UnitPrice).TakeWhile(p => p.UnitPrice < 25);
            foreach (var p in q3)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();

            // Q4
            Console.WriteLine("4. Check if ALL products in the \"Seafood\" category are in stock");
            Console.WriteLine();
            var q4 = ProductList.Where(p => p.Category == "Seafood").All(p => p.UnitsInStock > 0);
            Console.WriteLine(q4);
            Console.WriteLine();

            // Q5
            Console.WriteLine("5. Check if the ID list contains 9");
            Console.WriteLine();
            int[] ids = { 3, 9, 13, 18 };
            var q5 = ids.Contains(9);
            Console.WriteLine(q5);
            Console.WriteLine();

            #endregion
        }
    }
}
