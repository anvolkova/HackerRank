using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

// wordFrequency function counts the frequency of each word in the input //string

class Solution
{
    public static void wordFrequency(string input){
        string pattern = @"[^a-zA-Z]+";
        string[] words = Regex.Split(input, pattern);
        //put words and its frequency into dictionary
        Dictionary<string, int> dict = new Dictionary<string, int>();
        foreach(string s in words){
            int t = 0;
            dict.TryGetValue(s, out t);
            dict[s] = t + 1;
        }       
        
        //sort dictionary in decs order and print
        var query = dict.OrderByDescending(q => q.Value);
        foreach(KeyValuePair<string, int> item in query){
            Console.WriteLine("{0}: {1}",item.Key,item.Value);
        }   
        
    }
    static void Main(string[] args)
    {
        wordFrequency("anna bsdf. sdf? anna fgd anna sdf");
    }
}

