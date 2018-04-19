using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
   
    static int diagonalDifference(int[][] a) {
        int res = 0, sum1 = 0, sum2 = 0;
        int n = a.Length;
        for(int i = 0; i < n; i++){
            sum1 += a[i][i];                
            sum2 += a[i][n - i - 1];              
        }
        return res = Math.Abs(sum1 - sum2);
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[][] a = new int[n][];

        for (int aRowItr = 0; aRowItr < n; aRowItr++) {
            a[aRowItr] = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
        }

        int result = diagonalDifference(a);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
