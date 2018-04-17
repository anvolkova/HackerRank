using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        
        int T = int.Parse(Console.In.ReadLine());
        for(int i = 0; i < T; i++){
            string S = Console.In.ReadLine();
            char[] arr = S.ToCharArray();
            string even = "", odd = "";
            for(int j = 0; j < S.Length; j++){
                if(j%2 == 0){
                    even += arr[j];                    
                }
                else{
                    odd += arr[j];                    
                }
            }
            Console.WriteLine(even + " " + odd);
        }
    }
}