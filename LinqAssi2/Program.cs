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

            //// Q1
            //Console.WriteLine("1. Get top 3 most expensive products");
            //Console.WriteLine();
            //var q1 = ProductList.OrderByDescending(p => p.UnitPrice).Take(3);
            //foreach (var p in q1)
            //{
            //    Console.WriteLine(p);
            //}
            //Console.WriteLine();

            //// Q2
            //Console.WriteLine("2. Show page 2 of products, with page size = 5");
            //Console.WriteLine();
            //var q2 = ProductList.Skip(5).Take(5);
            //foreach (var p in q2)
            //{
            //    Console.WriteLine(p);
            //}
            //Console.WriteLine();

            //// Q3
            //Console.WriteLine("3. Take products from the list as long as their UnitPrice is less than $25 (list is ordered by price)");
            //Console.WriteLine();
            //var q3 = ProductList.OrderBy(p => p.UnitPrice).TakeWhile(p => p.UnitPrice < 25);
            //foreach (var p in q3)
            //{
            //    Console.WriteLine(p);
            //}
            //Console.WriteLine();

            //// Q4
            //Console.WriteLine("4. Check if ALL products in the \"Seafood\" category are in stock");
            //Console.WriteLine();
            //var q4 = ProductList.Where(p => p.Category == "Seafood").All(p => p.UnitsInStock > 0);
            //Console.WriteLine(q4);
            //Console.WriteLine();

            //// Q5
            //Console.WriteLine("5. Check if the ID list contains 9");
            //Console.WriteLine();
            //int[] ids = { 3, 9, 13, 18 };
            //var q5 = ids.Contains(9);
            //Console.WriteLine(q5);
            //Console.WriteLine();

            #endregion

            #region From 6 to 10

            //// Q6
            //Console.WriteLine("6. Group all products by Category and print each group with its product count");
            //Console.WriteLine();
            //var q6 = ProductList.GroupBy(p => p.Category);
            //foreach (var g in q6){
            //    Console.WriteLine(g.Key + " " + g.Count());
            //}
            //Console.WriteLine();

            //// Q7
            //Console.WriteLine("7. Group products by Category and project only product names per group");
            //Console.WriteLine();
            //var q7 = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, Names = g.Select(p => p.ProductName) });
            //foreach (var g in q7){
            //    Console.WriteLine(g.Category);
            //    foreach (var name in g.Names){
            //        Console.WriteLine(name);
            //    }
            //}
            //Console.WriteLine();

            //// Q8
            //Console.WriteLine("8. Find all categories that have MORE THAN 3 products");
            //Console.WriteLine();
            //var q8 = ProductList.GroupBy(p => p.Category)
            //                    .Where(g => g.Count() > 3)
            //                    .Select(g => g.Key);
            //foreach (var c in q8)
            //{
            //    Console.WriteLine(c);
            //}
            //Console.WriteLine();

            //// Q9
            //Console.WriteLine("9. Using QUERY SYNTAX, group customers by Country, and for each group select { Country, Count, TotalOrderValue }");
            //Console.WriteLine();
            //var q9 = from c in CustomerList
            //         group c by c.Country into g
            //         select new
            //         {
            //             Country = g.Key, Count = g.Count(),
            //             TotalOrderValue = g.Sum(c => c.Orders.Sum(o => o.Total))
            //         };
            //foreach (var item in q9){
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            //// Q10
            //Console.WriteLine("10. Calculate the total number of units in stock across all products");
            //Console.WriteLine();
            //var q10 = ProductList.Sum(p => p.UnitsInStock);
            //Console.WriteLine(q10);
            //Console.WriteLine();


            #endregion

            #region From 11 to 15

            //// Q11
            //Console.WriteLine("11. Find the CHEAPEST and MOST EXPENSIVE product prices");
            //Console.WriteLine();
            //var minPrice = ProductList.Min(p => p.UnitPrice);
            //var maxPrice = ProductList.Max(p => p.UnitPrice);
            //Console.WriteLine(minPrice + " " + maxPrice);
            //Console.WriteLine();

            //// Q12
            //Console.WriteLine("12. Get a distinct list of all product categories");
            //Console.WriteLine();
            //var q12 = ProductList.Select(p => p.Category).Distinct();
            //foreach (var c in q12){
            //    Console.WriteLine(c);
            //}
            //Console.WriteLine();

            //// Q13
            //Console.WriteLine("13. Find product IDs that are in setA but NOT in setB");
            //Console.WriteLine();
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };
            //var q13 = setA.Except(setB);
            //foreach (var n in q13){
            //    Console.WriteLine(n);
            //}
            //Console.WriteLine();

            //// Q14
            //Console.WriteLine("14. Find countries that appear in list1 but NOT in list2 (case-insensitive)");
            //Console.WriteLine();
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };
            //var q14 = list1.Except(list2, StringComparer.OrdinalIgnoreCase);
            //foreach (var c in q14){
            //    Console.WriteLine(c);
            //}
            //Console.WriteLine();

            //// Q15
            //Console.WriteLine("15. Build a Dictionary<int, Product> keyed by ProductID, then retrieve and print the product with ID = 18");
            //Console.WriteLine();
            //var q15 = ProductList.ToDictionary(p => p.ProductID);
            //Console.WriteLine(q15[18]);
            //Console.WriteLine();

            #endregion

            #region From 16 to 21

            // Q16
            Console.WriteLine("16. Get the first product whose price is greater than $50");
            Console.WriteLine();
            var q16 = ProductList.First(p => p.UnitPrice > 50);
            Console.WriteLine(q16);
            Console.WriteLine();

            // Q17
            Console.WriteLine("17. Try to get the first product with a price > $500, it returns null instead of throwing");
            Console.WriteLine();
            var q17 = ProductList.FirstOrDefault(p => p.UnitPrice > 500);
            Console.WriteLine(q17 == null ? "null" : q17.ToString());
            Console.WriteLine();

            // Q18
            Console.WriteLine("18. Generate a multiplication table row for 7");
            Console.WriteLine();
            var q18 = Enumerable.Range(1, 10).Select(i => 7 * i);
            foreach (var n in q18)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();

            // Q19
            Console.WriteLine("19. Generate even numbers between 1 and 30");
            Console.WriteLine();
            var q19 = Enumerable.Range(1, 30).Where(n => n % 2 == 0);
            foreach (var n in q19)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();

            // Q20
            Console.WriteLine("20. Concatenate the first 3 product names with the first 3 customer company names into a single sequence");
            Console.WriteLine();
            var q20 = ProductList.Take(3)
                .Select(p => p.ProductName)
                .Concat(CustomerList.Take(3).Select(c => c.CustomerName));
            foreach (var s in q20)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            // Q21
            Console.WriteLine("21. Pair each product with a customer (by position) and produce a string \"ProductName sold to CompanyName\"");
            Console.WriteLine();
            var q21 = ProductList.Zip(CustomerList, (p, c) => p.ProductName + " sold to " + c.CustomerName);
            foreach (var s in q21)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            #endregion
        }
    }
}
