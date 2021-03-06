using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static int[] gradingStudents(int[] grades) {
        int[] result = new int[grades.Length];
        for(int i = 0; i < grades.Length; i++){
            if(grades[i] < 38){
                result[i] = grades[i];
            }
            else{
                if(grades[i]%5 > 2){
                    result[i] = grades[i] + (5 - grades[i]%5);
                }
                else{
                    result[i] = grades[i];
                }
            }
        }
        return result;
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] grades = new int [n];

        for (int gradesItr = 0; gradesItr < n; gradesItr++) {
            int gradesItem = Convert.ToInt32(Console.ReadLine());
            grades[gradesItr] = gradesItem;
        }

        int[] result = gradingStudents(grades);

        tw.WriteLine(string.Join("\n", result));

        tw.Flush();
        tw.Close();
    }
}
