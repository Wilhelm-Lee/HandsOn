using System.Collections;

namespace HandsOn;

internal static class Program
{
    /*
     * 给定一个数组，长度为 x, 请以逆序逐个输出其成员。
     * 示例：
     *   x = 3
     *   [ "astronaut", "enchante", "endoscopia" ]
     */

    private static string[] strings = ["astronaut", "enchante", "endoscopia"];

    public static string[] ReverseStringArrayStrings(
        string[]? originStringArray)
    {
        if (originStringArray == null)
        {
            return [];
        }

        int n = originStringArray.Length;
        string[] reverseStringArray = new string[n];

        for (int i = 0; i < n; i++)
        {
            reverseStringArray[i] = originStringArray[n - i - 1];
        }

        return reverseStringArray;
    }


    /*
     * 给定一个数组，找到相邻两个元素的最大差值。
     * 示例：
     *   [ 1, 2, 3, 4, 5, 6, 7, 9 ]  -> 2
     *   [ 10, 50, 100, 1000, 20, 60, 110, 1100 ]  -> 990
     */
    private static int[] intArray1 = [1, 2, 3, 4, 5, 6, 7, 9];
    private static int[] intArray2 = [10, 50, 100, 1000, 20, 60, 110, 1100];

    public static int? diffMax(int[]? originArray)
    {
        if (originArray == null)
        {
            return null;
        }

        int diffvalue;
        int n = originArray.Length;

        if (n == 1)
        {
            return originArray[0];
        }

        for (int i = 0; i < n - 1; i++)
        {
            originArray[i] = originArray[i + 1] - originArray[i];
        }

        originArray[n - 1] = 0;

        diffvalue = originArray[0];
        foreach (var item in originArray)
        {
            if (item > diffvalue)
            {
                diffvalue = item;
            }
        }

        return diffvalue;
    }


/*
 * 给定一个数组，输出给定 offset 起始，延长 length 的子序列。
 * 示例：
 *   原数组 = [ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ]
 *   offset = 7, length = 2
 *   [ 8, 9 ]
 *
 *   offset = 3, length 10
 *   [ 4, 5, 6, 7, 8, 9, 10 ]  // 越界熔断，越界的成员不输出。
 */


    private static int[] TrimArrayInts(int[] originArray, int offset,
        int length)
    {
        int edgeValue = offset + length;
        if (edgeValue > originArray.Length)
        {
            length = originArray.Length - offset;
        }

        // Todo find n = length
        int[] TrimArrayInts = new int[length];
        for (int i = 0; i < length; i++)
        {
            TrimArrayInts[i] = originArray[i + offset];
        }

        return TrimArrayInts;
    }
    
    /*
     * 调试下方函数使其满足设计预期。
     */
    // 5  -> 120
    // 5 * 4 * 3 * 2 * 1 = 120
    private static int CalcFactorio(int n)
    {
        if (n <= 0)
        {
            return 0;
        }
      
        if (n == 1)
        {
            return 1;
        }
        
        return n * CalcFactorio(n - 1);
    }

    private static int Main()
    {
        // foreach (var item in ReverseStringArrayStrings(strings))
        // {
        //     Console.Write($"{item} ");   
        // }

        // Console.WriteLine(diffMax(intArray1));
        // Console.WriteLine(diffMax(intArray2));

        // int[] originArray = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        //
        // foreach (var item in TrimArrayInts(originArray, 7, 2))
        // {
        //     Console.Write($"{item} ");
        // }
        //
        // Console.WriteLine();
        //
        // foreach (var item in TrimArrayInts(originArray, 3, 10))
        // {
        //     Console.Write($"{item} ");
        // }
        //
        // Console.WriteLine();

        //  offset = 7, length = 2
        //  offset = 3, length 10

        Console.WriteLine(CalcFactorio(5));
        Console.WriteLine(CalcFactorio(-1));
        Console.WriteLine(CalcFactorio(4));

        return 0;
    }
}
