namespace Codewars.Tasks.Kyu6;

/// <summary>
/// The goal of this exercise is to convert a string 
/// to a new string where each character in the new 
/// string is "(" if that character appears only once 
/// in the original string, or ")" if that character 
/// appears more than once in the original string. 
/// Ignore capitalization when determining if a character 
/// is a duplicate.
/// </summary>
public class DuplicateEncoder
{
    public static string DuplicateEncode(string word) =>
    String.Join(String.Empty, 
        word.Select(x => $"{(word.Count(i => char.ToLower(i) == char.ToLower(x)) > 1 ? ")" : "(")}"));

    //public static string DuplicateEncode(string word) =>
    //    string.Concat(word.ToUpper()
    //        .Select(x => word.ToUpper().Split(x).Length == 2 ? "(" : ")"));
}
