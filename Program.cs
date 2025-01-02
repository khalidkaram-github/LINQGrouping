namespace LINQGrouping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region GroupBy

            #region ex1

            var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var groups = numbers.GroupBy(n => n % 2);

            foreach (var group in groups)
            {
                //Console.WriteLine($" Key : {group.Key}");

                foreach (var number in group)
                {
                    //Console.Write(number + " - ");
                }
                Console.WriteLine();
            }


            #endregion

            //-------------------------------------
            #region ex2
            var people = new List<(string Name, string City)>
            {
                ("John", "New York"),
                ("Sarah", "London"),
                ("Mike", "New York"),
                ("Emma", "London"),
                ("James", "Paris")
            };

            var cities = people.GroupBy(p => p.City);

            foreach (var group in cities)
            {
                //Console.WriteLine($"City: {group.Key}");

                var d = group.ToList();
                foreach (var person in group)
                {
                    //Console.WriteLine($"  {person.Name}");
                }
            }

            #endregion


            #region Chunk

            var nums = Enumerable.Range(1, 10); // {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}

            var chunks = nums.Chunk(3);

            foreach (var chunk in chunks)
            {
                foreach (var item in chunk)
                {
                    Console.Write(item + " - ");
                }
                Console.WriteLine();
            }

            #endregion
        }
    }
}
