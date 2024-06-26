using ParkingManagementData;
using ParkingManagementModels;
using System;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool active = true;
            while (active)
            {
                {

                    Console.WriteLine("Matt's Laundry Shop");
                    Console.WriteLine("What's up?");
                    Console.WriteLine("1.People wants to wash some clothes");
                    Console.WriteLine("2.People wants to claim their clothes");
                    Console.WriteLine("3.Details of the People that in queue");


                    Console.WriteLine("Enter the number:");
                    string number = Console.ReadLine();

                    if (number == "1")
                    {
                        Console.WriteLine("What is the name?");
                        string name = Console.ReadLine();



                        Console.WriteLine("What is the Weight if their clothes?");
                        string clWeight = Console.ReadLine();
                        SqlDbData.AddUser(name, clWeight);

                        Console.WriteLine("Okay, heres the token and the soap");

                    }

                    else if (number == "2")
                    {

                        Console.WriteLine("Under What Name?");
                        string name = Console.ReadLine();
                        SqlDbData.DeleteUser(name);

                        Console.WriteLine("Okay, Heres their clothes");

                    }
                    else if (number == "3")
                    {
                        Console.WriteLine("Okay, heres the details");
                        Console.WriteLine("");
                        GetUsers();

                    }

                else
                {
                    Console.WriteLine("ERROR");
                }


            }
        }


        }

        public static void GetUsers()
        {
            List<User> usersFromDB = SqlDbData.GetUsers();

            foreach (var item in usersFromDB)
            {
                Console.WriteLine(item.name);
                Console.WriteLine(item.clWeight);
            }
        }
    }
}
