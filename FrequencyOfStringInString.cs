using System;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

      public static void StringContain()
        {
            string str1 = "aaaabc";
            string str2 = "aaa";

            int count = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                int t = str1.IndexOf(str2, i);
                if (t == i)
                    count++;
            }
            Console.WriteLine(count);
        }

      public static void AnotherMethod()
        {
            string str1 = "bbbbaac";
            string str2 = "bb";
            int count = 0;
            int i = 0;
            while (i < str1.Length)
            {
                int t = str1.IndexOf(str2, i);
                if (t == i)
                {
                    count++;
                    i = i + str2.Length;
                    //str1 = str1.Remove(t, str2.Length);     i = 0;  //Also We can use Remove() method
                }
                else
                    i++;
            }
            Console.WriteLine(count);
        }
        /* OUTPUT
        StringContain() : If I/P is  "aaaabc" and "aaa" Then O/P 2
                          If I/P is  "bbbbaac" and "bb" Then O/P 3
        
        
        AnotherMethod() : If I/P is  "bbbbaac" and "bb" Then O/P 2
                          If I/P is  "aaaabc" and "aaa" Then O/P 1
        */
