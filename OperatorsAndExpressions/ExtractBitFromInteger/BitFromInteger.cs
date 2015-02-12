﻿// Problem 12. Extract Bit from Integer
// 
// Write an expression that extracts from given integer n the value of given bit at index p.
// Examples:
// 
// n	    binary representation	p	    bit @ p
// 5	    00000000 00000101	    2	    1
// 0	    00000000 00000000	    9	    0
// 15	    00000000 00001111	    1	    1
// 5343	    00010100 11011111	    7	    1
// 62241    11110011 00100001	    11	    0
using System;

    class BitFromInteger
    {
        static void Main()
        {
            Console.WriteLine("enter integer");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter position");
            int p = int.Parse(Console.ReadLine());
            int mask = 1 << p;
            int nAndMask = n & mask;
            int bit = nAndMask >> p;
            Console.WriteLine(bit); 
        }
    }

