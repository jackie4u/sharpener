/*
 * Write a function that accepts an array of 10 integers (between 0 and 9), 
 * that returns a string of those numbers in the form of a phone number.
 * Example
 *  Kata.CreatePhoneNumber(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}) // => returns "(123) 456-7890"
 *  The returned format must be correct in order to complete this challenge.
 * Don't forget the space after the closing parentheses!
 */

using System.Text;

namespace PhoneNumber {

    public class Program {
        static void Main(string[] args) {
            var numbers = new int[] { 0, 2, 3, 4, 5, 6, 7, 8, 9, 1 };
            var phone = CreatePhoneNumber(numbers);
            Console.WriteLine($"{phone}");
        }

        public static string CreatePhoneNumber(int[] numbers) {
            // Best answer: 
            // long.Parse(string.Concat(numbers)).ToString("(000) 000-0000");
            var a = string.Concat(numbers);
            var b = long.Parse(a);
            var c = b.ToString("(000) 000-0000");
            // / Best answer

            var numbersBuilder = new StringBuilder();
            foreach (int number in numbers) {
                numbersBuilder.Append(number);
            }

            var telephone = numbersBuilder.ToString();
            if (telephone.Length == 10) {
                // "(123) 456-7890"
                telephone = string.Format("({0}) {1}-{2}",
                    telephone.Substring(0, 3),
                    telephone.Substring(3, 3),
                    telephone.Substring(6));
            }
            return telephone;
        }

    }
}
