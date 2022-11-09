using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;

namespace CHALLENGE5
{
    internal class Program
    {

        class User
        {
            // public static List<User> Userlist = new List<User>();


            public String username { get; set; }
            public String password { get; set; }
            public String email { get; set; }


        }

        class NewUser { 
            static void Main(string[] args)
            {
             User myObj = new User();
                Console.WriteLine("Enter username");
                string name = Console.ReadLine();
                Console.WriteLine("Enter password");
                string pass = Console.ReadLine();
                Console.WriteLine("Enter email");
                string mail = Console.ReadLine();

                myObj.username = name;
                myObj.password = pass;
                myObj.email = mail;

                Console.WriteLine("Registration Successful");
                Console.ReadLine();

                Console.WriteLine("Please enter your login details");
                Console.ReadLine();

                Console.WriteLine("Enter username");
                string namee = Console.ReadLine();
                Console.WriteLine("Enter pasword");
                string passs = Console.ReadLine();

                if (namee == myObj.username && passs == myObj.password)
                {
                    Console.WriteLine("Login successful");
                } else
                {
                    Console.WriteLine("Login incorrect");
                }
            }

        }
    }
    }
