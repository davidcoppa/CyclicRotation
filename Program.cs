

using System;

namespace CyclicRotation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CyclicRotation cr = new CyclicRotation();
            int[] a1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] a2 = new int[] { 9, 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] a3 = new int[] { 8, 9, 1, 2, 3, 4, 5, 6, 7 };
            int[] a4 = new int[] { 7, 8, 9, 1, 2, 3, 4, 5, 6 };
            int[] a5 = new int[] { 6, 7, 8, 9, 1, 2, 3, 4, 5 };
            int k = 3;

            int[] value1 = cr.solution(a1, k);
            int[] value2 = cr.solution(a2, k);
            int[] value3 = cr.solution(a3, k);
            int[] value4 = cr.solution(a4, k);
            int[] value5 = cr.solution(a5, k);

            Console.WriteLine("K value: " + k);
            Console.WriteLine($"input: {string.Join(", ", a1)} -result: {string.Join(", ", value1)}");
            Console.WriteLine($"input: {string.Join(", ", a2)} -result: {string.Join(", ", value2)}");
            Console.WriteLine($"input: {string.Join(", ", a3)} -result: {string.Join(", ", value3)}");
            Console.WriteLine($"input: {string.Join(", ", a4)} -result: {string.Join(", ", value4)}");
            Console.WriteLine($"input: {string.Join(", ", a5)} -result: {string.Join(", ", value5)}");

            Console.ReadLine();
        }

        
    }
}
