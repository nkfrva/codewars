namespace Codewars.Tasks.Kyu6;

/// <summary>
/// You will be given a number and you will need to 
/// return it as a string in Expanded Form. For example:
///Kata.ExpandedForm(12); # Should return "10 + 2"
///Kata.ExpandedForm(42); # Should return "40 + 2"
///Kata.ExpandedForm(70304); # Should return "70000 + 300 + 4"
///NOTE: All numbers will be whole numbers greater than 0.
/// </summary>
public class WriteNumberInExpandedForm
{
    public static string ExpandedForm(long num)
    {
        var str = num.ToString();
        var e = new List<string>();

        for (var i = 0; i < str.Length; i++)
        {
            var tmp = $"{str[i]}{new string('0', str.Length - i - 1)}";

            if (tmp[0] != '0')
                e.Add(tmp);

        }
        return String.Join(" + ", e);
    }


    //public static string ExpandedForm(long num)
    //{
    //    var str = num.ToString();
    //    return String.Join(" + ", str
    //        .Select((x, i) => char.GetNumericValue(x) * Math.Pow(10, str.Length - i - 1))
    //        .Where(x => x > 0));
    //}

    //public static string ExpandedForm(long n) =>
    //    string.Join(" + ", $"{n}".Select((c, i) => 
    //        c + new string('0', $"{n}".Length - i - 1))
    //        .Where(x => x[0] != '0'));
}
