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

            #region From 6 to 10

            // Q6
            Console.WriteLine("6. Group all products by Category and print each group with its product count");
            Console.WriteLine();
            var q6 = ProductList.GroupBy(p => p.Category);
            foreach (var g in q6){
                Console.WriteLine(g.Key + " " + g.Count());
            }
            Console.WriteLine();

            // Q7
            Console.WriteLine("7. Group products by Category and project only product names per group");
            Console.WriteLine();
            var q7 = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, Names = g.Select(p => p.ProductName) });
            foreach (var g in q7){
                Console.WriteLine(g.Category);
                foreach (var name in g.Names){
                    Console.WriteLine(name);
                }
            }
            Console.WriteLine();

            // Q8
            Console.WriteLine("8. Find all categories that have MORE THAN 3 products");
            Console.WriteLine();
            var q8 = ProductList.GroupBy(p => p.Category)
                                .Where(g => g.Count() > 3)
                                .Select(g => g.Key);
            foreach (var c in q8)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine();

            // Q9
            Console.WriteLine("9. Using QUERY SYNTAX, group customers by Country, and for each group select { Country, Count, TotalOrderValue }");
            Console.WriteLine();
            var q9 = from c in CustomerList
                     group c by c.Country into g
                     select new
                     {
                         Country = g.Key, Count = g.Count(),
                         TotalOrderValue = g.Sum(c => c.Orders.Sum(o => o.Total))
                     };
            foreach (var item in q9){
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Q10
            Console.WriteLine("10. Calculate the total number of units in stock across all products");
            Console.WriteLine();
            var q10 = ProductList.Sum(p => p.UnitsInStock);
            Console.WriteLine(q10);
            Console.WriteLine();


            #endregion
        }
    }
}
