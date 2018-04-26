using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
    
    public static Dictionary<char, int> Dict(string s){
        Dictionary<char, int> dict = new Dictionary<char, int>();
        foreach(char c in s){
            int t = 0;
            dict.TryGetValue(c, out t);
            dict[c] = t + 1;
        }
        return dict;
    }

    static void Main(String[] args) {
        string a = Console.ReadLine();
        string b = Console.ReadLine();
                
        Dictionary<char, int> dict_a = Dict(a);
        Dictionary<char, int> dict_b = Dict(b);
        
        int total = 0;
        foreach(KeyValuePair<char, int> i in dict_a){            
            int value = 0;
            dict_b.TryGetValue(i.Key, out value);
            total += Math.Min(i.Value, value);            
            }           
        int result = (a.Length - total) + (b.Length - total);
        
        
        Console.WriteLine(result);
    }
}
