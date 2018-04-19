using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static void miniMaxSum(int[] arr) {
        long minSum = 0, maxSum = 0;
        long min = arr.Min();
        long max = arr.Max();
        long sum = 0;
        foreach(int i in arr){
            sum += i;
        }
        minSum = sum - max;
        maxSum = sum - min;        
        Console.WriteLine(minSum + " " + maxSum); 
    }

    static void Main(string[] args) {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}
