namespace Codewars.Tasks.Kyu6;

/// <summary>
/// Build a pyramid-shaped tower, as an array/list of strings, 
/// given a positive integer number of floors. 
/// A tower block is represented with "*" character.
/// </summary>
internal class BuildTower
{
    public static string[] TowerBuilder(int nFloors)
    {
        var result = new string[nFloors];

        for (var i = 0; i < nFloors; i++)
        {
            var count = (i + 1) * 2 - 1;

            result[i] = $"{new string(' ', (nFloors * 2 - 1 - count) / 2)}" +
                   $"{new string('*', count)}" +
                   $"{new string(' ', (nFloors * 2 - 1 - count) / 2)}";
        }
        return result;
    }

    //public static string[] TowerBuilder(int nFloors)
    //{
    //    return Enumerable.Range(1, nFloors)
    //        .Select(i => string.Format("{0}{1}{0}", 
    //        i == nFloors ? "" : new string(' ', nFloors - i), 
    //        new string('*', 2 * i - 1))).ToArray();
    //}

    //public static string[] TowerBuilder(int nFloors)
    //{
    //    return Enumerable.Range(0, nFloors)
    //        .Select(x => new string('*', x * 2 + 1)
    //        .PadLeft(nFloors + x)
    //        .PadRight(nFloors * 2 - 1))
    //        .ToArray();
    //}

}
