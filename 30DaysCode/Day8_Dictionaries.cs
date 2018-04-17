using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        for(int i = 1; i <= n; i++){
            string[] s = Console.ReadLine().Split(' ');            
            phoneBook.Add(s[0], s[1]);
        }
        do{
            string query = Console.ReadLine();
            if(query != null){
                 string value = "";
                 if(phoneBook.TryGetValue(query, out value)){
                Console.WriteLine(query + "=" + value);
                }
                 else{
                     Console.WriteLine("Not found");
                 }
             }
            else{
                break;
            }        
        }
        while (true);
    }
}