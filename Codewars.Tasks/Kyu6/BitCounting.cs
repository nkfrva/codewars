using System.Numerics;

namespace Codewars.Tasks.Kyu6;

/// <summary>
/// Write a function that takes an integer as input, 
/// and returns the number of bits that are equal to 
/// one in the binary representation of that number. 
/// You can guarantee that input is non-negative.
///Example: The binary representation of 1234 is 10011010010, 
///so the function should return 5 in this case
/// </summary>
public class BitCounting
{
    public static int CountBits(int n) =>
      Convert.ToString(n, 2).Count(x => x == '1');

    //public static int CountBits(int n) =>
    //    BitOperations.PopCount((uint)n);
}
