using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        //Bubble sort
        int totalSwaps = 0;
        for(int i = 0; i < n; i++){
            // Track number of elements swapped during a single array traversal
            int numberOfSwaps = 0;
            
            for(int k = 0; k < n-1; k++){
                // Swap adjacent elements if they are in decreasing order
                if(a[k] > a[k+1]){
                    int tmp = a[k];
                    a[k] = a[k+1];
                    a[k+1] = tmp;
                    numberOfSwaps++;
                }
            }
            totalSwaps += numberOfSwaps;
            // If no elements were swapped during a traversal, array is sorted
            if(numberOfSwaps == 0){
                break;
            }
        }
        Console.WriteLine("Array is sorted in " + totalSwaps + " swaps.");
        Console.WriteLine("First Element: " + a[0]);
        Console.WriteLine("Last Element: " + a[n-1]);
    }
}
