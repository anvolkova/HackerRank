using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static void plusMinus(int[] arr) {
        int l = arr.Length;
        int pos = 0, neg = 0, zer = 0;
        foreach(int i in arr){
           if(i > 0){
               pos++;
           }
            else if(i < 0){
                neg++;
            }
            else{ zer++;
                }
        }
        Console.WriteLine((double)pos/l);
        Console.WriteLine((double)neg/l);
        Console.WriteLine((double)zer/l);
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}
