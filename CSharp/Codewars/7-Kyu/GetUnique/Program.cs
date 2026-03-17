namespace GetUnique {
    internal class Program {

        static void Main(string[] args) {
            var input = new int[] { 1, 1, 1, 2, 1, 1 };
            var unique = GetUnique(input);
            Console.WriteLine($"Unique number: {unique}");
        }

        static int GetUnique(IEnumerable<int> numbers) => numbers.GroupBy(n => n)
                .Where(g => g.Count() == 1)
                .Select(g => g.Key)
                .FirstOrDefault();
    }
}
