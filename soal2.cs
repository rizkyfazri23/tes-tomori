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
        for (int i=1; i<=10; i++) {
            for (int k=1; k<=i; k++) {
                Console.Write ("*");
            }
            Console.WriteLine();
        }

    }
}
