  // public static List<string> SinglePermutations(string s) {

  string s = "ab";
  //var soManyPermutations = new SinglePermutations("ab");
  char[] chars = s.ToCharArray();
  List<string> allPermutations = chars.Join.Select(p => new string(p, 1)).ToList();

  foreach (var item in allPermutations)
  {
    Console.WriteLine(item);
  }
  //return allPermutations;
