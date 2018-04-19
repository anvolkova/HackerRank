using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
    
    static int[] breakingRecords(int[] score) {        
        int min = 0, max = 0;        
        int minScore = score[0], maxScore = score[0];
        for(int i = 1; i < score.Length; i++){
            if(score[i] > maxScore){
                maxScore = score[i];
                max++;
            }
            if(score[i] < minScore){
                minScore = score[i];
                min++;
            }
        }
        return new int[]{max, min}; 
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] score = Array.ConvertAll(Console.ReadLine().Split(' '), scoreTemp => Convert.ToInt32(scoreTemp))
        ;
        int[] result = breakingRecords(score);

        tw.WriteLine(string.Join(" ", result));

        tw.Flush();
        tw.Close();
    }
}
