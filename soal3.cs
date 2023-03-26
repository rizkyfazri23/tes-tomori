//Microsoft (R) Visual C# Compiler version 3.4.0-beta4-19562-05 (ff930dec)
//Copyright (C) Microsoft Corporation. All rights reserved.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


public class Program
{
    public static void Main(string[] args)
    {
         int x = 0, y = 1, z = 0;

            Console.Write("Masukan jumlah bilangan fibonacci = ");
            int jumlah = Convert.ToInt32(Console.ReadLine());
            Console.Write(x + " " + y + " "); 
            for (int i = 2; i < jumlah; i++)
            {
                z = x + y;
                Console.Write(z + " ");
                x = y;
                y = z;
            }
            Console.Read();
    }
}
