public class Program {
    /*
     * A pangram is a sentence that contains every single letter of the alphabet at least once. 
     * For example, the sentence "The quick brown fox jumps over the lazy dog" is a pangram, because it uses the letters A-Z at least once (case is irrelevant).
     * 
     * Given a string, detect whether or not it is a pangram. Return True if it is, False if not. Ignore numbers and punctuation.
     */
    public static void Main(string[] args) {
        Console.WriteLine($"Inter input strinng:");
        var input = Console.ReadLine();
        input = string.IsNullOrEmpty(input) ? "The quick brown fox jumps over the lazy dog" : input;
        var isPanagram = IsPangram(input);
        Console.WriteLine($"Is panagram: {isPanagram}");
    }

    public static bool IsPangram(string input) {
        List<char> alphabet = "abcdefghijklmnopqrstuvwxyz".ToList();
        int i = 0;
        while (alphabet.Count > 0 && i < input.Length) {
            char letter = input.ToLower()[i];
            alphabet.Remove(letter);
            i++;
        }
        return alphabet.Count == 0;
    }

    public static bool IsPangramSmart(string input) {
        return input.ToLower()
            .Where(Char.IsLetter)
            .Distinct()
            .Count() == 26;
    }
}