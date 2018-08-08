using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the solve function below.
    static void solve(double meal_cost, int tip_percent, int tax_percent) {
            double tipAmount = meal_cost * ((double)tip_percent / 100);
            double taxAmount = meal_cost * ((double)tax_percent / 100);
            double total = meal_cost + tipAmount + taxAmount;
            if (total - (int)total >= 0.5){
                total = (int)total + 1;
            }
            Console.WriteLine("The total meal cost is " + (int)total + " dollars.");

    }

    static void Main(string[] args) {
        double meal_cost = Convert.ToDouble(Console.ReadLine());

        int tip_percent = Convert.ToInt32(Console.ReadLine());

        int tax_percent = Convert.ToInt32(Console.ReadLine());

        solve(meal_cost, tip_percent, tax_percent);
    }
}
