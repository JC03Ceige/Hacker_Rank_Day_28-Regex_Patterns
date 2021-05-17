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


namespace Hacker_Rank_Day_28_Regex_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine().Trim());

            // Create list to sort names
            var contactList = new List<string>();

            // Declares Regex pattern as a string
            string emailPattern = @".+@gmail\.com$";

            for (int NItr = 0; NItr < N; NItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                string firstName = firstMultipleInput[0];

                string emailID = firstMultipleInput[1];

                // Check if email is correct
                if(Regex.IsMatch(emailID, emailPattern))  // can include @".+@gmail\.com$" directly
                {
                    contactList.Add(firstName);
                }
            }
            // Sort list
            contactList.Sort();
            // Print out list
            foreach(var name in contactList)
            {
                Console.WriteLine(name);
            }
        }
    }
}
