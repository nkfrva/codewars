namespace Codewars.Tasks.Kyu7;

/// <summary>
/// Complete the method/function so that it converts 
/// dash/underscore delimited words into camel casing. 
/// The first word within the output should be 
/// capitalized only if the original word was 
/// capitalized (known as Upper Camel Case, also 
/// often referred to as Pascal case). 
/// The next words should be always capitalized.
/// </summary>
public class ConvertStringToCamelCase
{
    public static string ToCamelCase(string str) =>
        str.Split('-', '_')[0] + String.Join(String.Empty, str.Split('-', '_')
            .Skip(1).Select(x => $"{char.ToUpper(x[0])}" +
             $"{String.Join(String.Empty, x.Skip(1))}"));

    //public static string ToCamelCase(string str) =>
    //    string.Concat(str.Split('-', '_')
    //        .Select((x, i) => i > 0 ? char.ToUpper(x[0]) + x[1..] : x));
}
