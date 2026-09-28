using System.Diagnostics;
using System.Runtime.InteropServices.JavaScript;
using Foundational;

namespace HandsOn;

internal static class Program
{
    /* 输入： 一个整数 n，描述后续跟随元素数量。
             跟随 n 个整数。
       输出： 倒序输出所给所有元素。
       样例： 3 1 2 3
             3 2 1
     */


    /*
     * 输入： 一个整数 n, 描述后续跟随元素数量。
     *       跟随 n 个字符串，以空格分隔。
     * 输出： 按序输出每个字符串的倒序内容。
     *
     * 样例： 3 apple banana coconut
     *       elppa ananab tunococ
     */

    /*
     * 输入： 两个整数 n, m
     *       跟随 n 行输入
     *       每行跟随 m 个整数元素
     * 输出： 找出在 n 行中的最大平均值。
     * 样例： 3 3
     *       1 2 3   // avg == 2
     *       3 4 5   // avg == 4
     *       5 6 7   // avg == 6
     *       6
     */
    public static int[] Reverse(int n, int[] intArray) {
        // int[n] intArrayReverse;
        if (n == 0)
        {
            return [];
        }
        int[] intArrayReverse = new int[n];
        for (int i = n-1; i >= 0; i--)
        {
            Console.WriteLine($"{i}");
            intArrayReverse[n - i -1] = intArray[i];
        }
        return intArrayReverse;
    }

    public static string ReverseString(string stringItem)
    {
        char[] chars = stringItem.ToCharArray();
        Array.Reverse(chars);

        string reversed = new string(chars);
        return reversed;
    }
    
    public static string[] ReverseStringArray(int n, string[] stringArray) {
        // string[n] stingArrayReverse;
        if (n == 0)
        {
            return [];
        }
        //string[] stringArrayReverse = new string[n];
        //for (int i = n-1; i >= 0; i--)
        //{
        //    Console.WriteLine($"{i}");
        //    stringArrayReverse[n - i -1] = stringArray[i];
        //}
        int[] intArrayReverse = new int[n];
        for (int i = 0; i < n; i++)
        {
            stringArray[i] = ReverseString(stringArray[i]);
        }
        //foreach (var stringItem in stringArray)
        //{
        //    stringArray.stringItem  = stringItem.Reverse();
        //}
        return stringArray;
    }




    
    // 输入： 两个整数 n, m
    //       跟随 n 行输入
    //       每行跟随 m 个整数元素
    // 输出： 找出在 n 行中的最大平均值。
    // 样例： 3 3
    //       1 2 3   // avg == 2
    //       3 4 5   // avg == 4
    //       5 6 7   // avg == 6
    //       6
    

    public static double? AverageMaxArrays(int n, int  m, int[, ] matrix )
    {
	// if type of average is double which can not Initializion, because average can not be determined in first
	double? average = null;
	double averageLocal;

	int sum = 0;

	if ( n == 0) {
	    return 0;
	}

	// C# muti-dim-array is regarded as one dimension array 
	// n = marix.GetLength(0); m = marix.GetLength(1);
	for (int i = 0; i < n; i++)
	{
	    sum = 0;
	    for(int j = 0; j < m; j++)
	    {
		sum += matrix[i,j];
	    }
	    // First Initialize average
	    if ( i == 0 ) {
	   	average = (double)sum / m;
		continue;
	    }

	    averageLocal = (double)sum / m;
	    if (average <= averageLocal) {
		 average = averageLocal;
	    }
	}

	return average;
    }
    


    // 3 a wow racecar
    private static void Main(string[] args)
    {


	// // 3 [1, 2, 3]
        // foreach (var item in Reverse(3, [1, 2, 3]))
        // {
        //     Console.Write($"{item} ");
        // }
	// // 4 [10, 20, 30, 40]
        // foreach (var item in Reverse(4, [10, 20, 30, 40]))
        // {
        //     Console.Write($"{item} ");
        // }

	

	// // 3, ["apple", "banana", "coconut"]
	//        foreach (var item in ReverseStringArray(3, ["apple", "banana", "coconut"]))
	//        {
	//            Console.Write($"{item} ");
	//        }

       
	// // 3, ["a", "wow", "racecar"]
	//        foreach (var item in ReverseStringArray(3, ["a", "wow", "racecar"]))
	//        {
	//            Console.Write($"{item} ");
	//        }


	int[,] matrix1 = {{1, 2, 3}, {3, 4, 5}, {5, 6, 7}};
	int[,] matrix2 = {{1, 2, 3}};

	Console.WriteLine(AverageMaxArrays(3, 3, matrix1));
	
	Console.WriteLine(AverageMaxArrays(1, 3, matrix2));
    }
}


