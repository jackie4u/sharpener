// See https://aka.ms/new-console-template for more information
//Count the number of Duplicates
//Write a function that will return the count of distinct case-insensitive alphabetic characters and numeric digits that occur more than once in the input string.
//The input string can be assumed to contain only alphabets (both uppercase and lowercase) and numeric digits.

//Example
//"abcde" -> 0 # no characters repeats more than once
//"aabbcde" -> 2 # 'a' and 'b'
//"aabBcde" -> 2 # 'a' occurs twice and 'b' twice (`b` and `B`)
//"indivisibility" -> 1 # 'i' occurs six times
//"Indivisibilities" -> 2 # 'i' occurs seven times and 's' occurs twice
//"aA11" -> 2 # 'a' and '1'
//"ABBA" -> 2 # 'A' and 'B' each occur twice

using System;
using System.Linq;

var tst = "aabbcde";

var o = Kata.DuplicateCount(tst);

Console.WriteLine(o.ToString());

public static class Kata {

    public static int DuplicateCount(string str) {
        //var input = str.ToLower();
        //var count = input.GroupBy(s => s)
        //    .Select(group => new
        //    {
        //        key = group.Key,
        //        cnt = group.Count()
        //    }).Count(g => g.cnt > 1);

        int result = str.ToLower().GroupBy(x => x).Count(x => x.Count() > 1);

        return result;
    }
}