﻿using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int month;  
            Console.Write("Input Month Number: ");
            month = Convert.ToInt32(Console.ReadLine());

            switch(month)
            {
	            case 1:
	            Console.Write("January\n");
	                break;
	            case 2:
	            Console.Write("February\n");
	                break;
	            case 3:
	            Console.Write("March\n");
	                break;
	            case 4:
	            Console.Write("April\n");
	                break;
	            case 5:
	            Console.Write("May\n");
	                break;
	            case 6:
	            Console.Write("June\n");
	                break;
	            case 7:
	            Console.Write("July\n");
	                break;
	            case 8:
	            Console.Write("August\n");
	                break;
	            case 9:
	            Console.Write("September\n");
	                break;
	            case 10:
	            Console.Write("October\n");
	                break;
	            case 11:
	            Console.Write("November\n");
	                break;
	            case 12:
	            Console.Write("December\n");
	                break;
	            default:
	            Console.Write("not existing");
	                break;
            }

        }
    }
}
