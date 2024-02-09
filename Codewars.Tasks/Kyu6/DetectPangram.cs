namespace Codewars.Tasks.Kyu6;

/// <summary>
/// A pangram is a sentence that contains every single letter of 
/// the alphabet at least once. 
/// For example, the sentence "The quick brown fox jumps over the lazy dog" 
/// is a pangram, because it uses the letters A-Z at least once 
/// (case is irrelevant).
/// 
/// Given a string, detect whether or not it is a pangram.Return 
/// True if it is, False if not.Ignore numbers and punctuation.
/// </summary>
public class DetectPangram
{    
    public static bool IsPangram(string str)
    {
        var dict = str
          .ToLower()
          .Distinct()
          .Where(x => char.IsLetter(x));
        return dict
                .ToDictionary(x => x,
                                 x => str.Count(ch => ch == x))
                .All(x => x.Value >= 0) &&
              dict.Count() == 26;
    }
    //public static bool IsPangram(string str) =>
    //"abcdefghijklmnopqrstuvwxyz".All(x => str.ToLower().Contains(char.ToLower(x)));


}
