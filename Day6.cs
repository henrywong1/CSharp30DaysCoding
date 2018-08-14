using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int t = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < t; i++){
            string s = Console.ReadLine();
            for (int j = 0; j < s.Length; j++){
                if (j % 2 == 0){
                    Console.Write(s[j]);
                }
            }
            Console.Write(" ");
            for (int h = 0; h < s.Length; h++){
                if (h % 2 != 0){
                    Console.Write(s[h]);
                }
            }
            Console.WriteLine();
        }
    }
}
