﻿using System;

namespace _1___Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            int check = int.Parse(Console.ReadLine());
            for (int takoa = 2; takoa <= check; takoa++)
            {
                bool takovalie = true;
                for (int cepitel = 2; cepitel < takoa; cepitel++)
                {
                    if (takoa % cepitel == 0)
                    {
                        takovalie = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", takoa, takovalie.ToString().ToLower());
            }
        }
    }
}