using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static int birthdayCakeCandles(int n, int[] ar) {
        int tallCandles = 0;
        int max = ar.Max();
        foreach(int i in ar){
            if(i == max){
                tallCandles++;
            }
        }        
        return tallCandles;
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = birthdayCakeCandles(n, ar);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
