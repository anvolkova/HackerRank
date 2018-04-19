using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static int[] solve(int a0, int a1, int a2, int b0, int b1, int b2) {
        int a = ((a0 > b0)?1:0) + ((a1 > b1)?1:0) + ((a2 > b2)?1:0);
        int b = ((a0 < b0)?1:0) + ((a1 < b1)?1:0) + ((a2 < b2)?1:0);
        int[] result = {a, b};   
        return result;
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] a0A1A2 = Console.ReadLine().Split(' ');

        int a0 = Convert.ToInt32(a0A1A2[0]);

        int a1 = Convert.ToInt32(a0A1A2[1]);

        int a2 = Convert.ToInt32(a0A1A2[2]);

        string[] b0B1B2 = Console.ReadLine().Split(' ');

        int b0 = Convert.ToInt32(b0B1B2[0]);

        int b1 = Convert.ToInt32(b0B1B2[1]);

        int b2 = Convert.ToInt32(b0B1B2[2]);

        int[] result = solve(a0, a1, a2, b0, b1, b2);

        tw.WriteLine(string.Join(" ", result));

        tw.Flush();
        tw.Close();
    }
}
