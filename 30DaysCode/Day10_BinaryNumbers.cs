using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        List<int> binar = new List<int>();  
        int result = 0, max = 0;
        while(n > 0){
            binar.Add(n%2);        
            n = n/2;
        }        
        foreach(int i in binar){            
            if(i == 1){
                result++;
                if(result > max){
                    max = result;
                }
            }            
            else{
                    result = 0;
            }
        }
        Console.WriteLine(max);        
    }
}
