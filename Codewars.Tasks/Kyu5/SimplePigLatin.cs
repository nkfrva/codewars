using System.Text.RegularExpressions;

namespace Codewars.Tasks.Kyu5;

/// <summary>
/// Move the first letter of each word to the end of it, 
/// then add "ay" to the end of the word. 
/// Leave punctuation marks untouched.
/// </summary>
public class SimplePigLatin
{

    public static string PigIt(string str) =>
        String.Join(' ', str.Split(' ')
            .Select(x => $"{x.Substring(1)}{x[0]}" +
            $"{(char.IsLetter(x[0]) ? "ay" : "")}"));

    //public static string PigIt(string str) =>
    //    string.Join(" ", str.Split(' ')
    //        .Select(w => w.Any(char.IsPunctuation) 
    //        ? w : w.Substring(1) + w[0] + "ay"));


    //public static string PigIt(string str) =>
    //    Regex.Replace(str, @"((\S)(\S+))", "$3$2ay");

    //public static string PigIt(string str) =>
    //    string.Join(" ", str.Split(" ")
    //        .Select(w => char.IsPunctuation(w[0]) ? w : $"{w[1..]}{w[0]}ay"));
}
