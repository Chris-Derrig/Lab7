﻿using System;
using System.Text.RegularExpressions;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            while (again)
            {
                bool repeatNumber = true;
                bool repeatEmail = true;
                bool repeatDate = true;
                bool repeatName = true;
                
                while (repeatName)
                {
                    Console.WriteLine("Please Enter Your Name");
                    string name = Console.ReadLine();

                    Match temp = Regex.Match(name, @"(^[A Z]{1}[a-z]+){1,30}");

                    if (Regex.IsMatch(name, @"(^[A-Z]{1}[a-z]+){1,30}"))
                    {
                        Console.WriteLine("\nHi " + name + ", nice to meet you");
                        repeatName = false;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid Input: Please try again.\nONLY Letters\nFirst Letter MUST be Capitol\nMax 30 Letters\n");
                        repeatName = true;
                    }
                }
                while (repeatEmail)
                {
                    Console.WriteLine("\nPlease Enter Your email address");
                    string email = Console.ReadLine();

                    Match temp = Regex.Match(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

                    if (Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                    {
                        Console.WriteLine("\nThanks");
                        repeatEmail = false;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid Input:\nMust contain an '@' symbol.\nMust contain '.XXX' or '.XX' TLD\n");
                        repeatEmail = true;
                    }
                }
                while (repeatNumber)
                {
                    Console.WriteLine("\nPlease Enter Your phone number");
                    string phone = Console.ReadLine();

                    Match temp = Regex.Match(phone, @"\(?(\d{3}\)?-?)*(\d{3}-?) *(-?\d){4}");

                    if (Regex.IsMatch(phone, @"\(?(\d{3}\)?-?)*(\d{3}-?) *(-?\d){4}"))
                    {
                        Console.WriteLine("\nCool");
                        repeatNumber = false;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid Input:\nONLY Numbers\nMust follow the pattern XXX-XXX-XXXX");
                        repeatNumber = true;
                    }
                }
                while (repeatDate)
                {
                    Console.WriteLine("\nPlease Your Birthday");
                    string date = Console.ReadLine();

                    Match temp = Regex.Match(date, @"(((0[1-9]|[12][0-9]|3[01])([/])(0[13578]|10|12)([/])(\d{4}))|(([0][1-9]|[12][0-9]|30)([/])(0[469]|11)([/])(\d{4}))|((0[1-9]|1[0-9]|2[0-8])([/])(02)([/])(\d{4}))|((29)(\.|-|\/)(02)([/])([02468][048]00))|((29)([/])(02)([/])([13579][26]00))|((29)([/])(02)([/])([0-9][0-9][0][48]))|((29)([/])(02)([/])([0-9][0-9][2468][048]))|((29)([/])(02)([/])([0-9][0-9][13579][26])))");

                    if (Regex.IsMatch(date, @"(((0[1-9]|[12][0-9]|3[01])([/])(0[13578]|10|12)([/])(\d{4}))|(([0][1-9]|[12][0-9]|30)([/])(0[469]|11)([/])(\d{4}))|((0[1-9]|1[0-9]|2[0-8])([/])(02)([/])(\d{4}))|((29)(\.|-|\/)(02)([/])([02468][048]00))|((29)([/])(02)([/])([13579][26]00))|((29)([/])(02)([/])([0-9][0-9][0][48]))|((29)([/])(02)([/])([0-9][0-9][2468][048]))|((29)([/])(02)([/])([0-9][0-9][13579][26])))"))
                    {
                        Console.WriteLine("\nAWESOME");
                        repeatDate = false;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid Input:\nMust follow the pattern mm/dd/yyyy");
                        repeatDate = true;
                    }
                }
                Console.WriteLine("\nWould you like to input more people. ('Y' or 'N')\n");
                string doAgain = Console.ReadLine();
                while (again)
                {
                    if (doAgain == "n" || doAgain == "N")
                    {
                        Console.WriteLine("\nThanks for participating.  Have a great day!");
                        return;
                    }
                    else if (doAgain == "y" || doAgain == "Y")
                    {
                        again = false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter either 'Y' or 'N'");
                        doAgain = Console.ReadLine();
                        again = true;
                    }
                }
                if (doAgain == "y" || doAgain == "Y")
                {

                }
                again = true;
            }
        }
    }
}

