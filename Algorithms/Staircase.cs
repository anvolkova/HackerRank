using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static void staircase(int n) {
        for(int i = 1; i <= n; i++){
            Console.WriteLine(new String('#', i).PadLeft(n, ' '));   
        }        
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        staircase(n);
    }
}
