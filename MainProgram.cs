using WashingManagementData;
using WashingManagementModels;
using System;

namespace Client
{
    internal class MainProgram
    {
        static void Main(string[] args)
        {
            bool active = true;
            while (active)
            {
                {

                    Console.WriteLine("Matthew's Laundry Shop");
                    Console.WriteLine("What's up?");
                    Console.WriteLine("1.Need to wash some clothes?");
                    Console.WriteLine("2.Customer wants to claim their clothes");
                    Console.WriteLine("3.Customer Queue Details");


                    Console.WriteLine("Pick an option:");
                    string number = Console.ReadLine();

                    if (number == "1")
                    {
                        Console.WriteLine("What is the name?");
                        string name = Console.ReadLine();



                        Console.WriteLine("What is the Weight of their clothes?");
                        string clWeight = Console.ReadLine();
                        SqlDbData.AddUser(name, clWeight);

                        Console.WriteLine("You're good to go, here's your token and soap");

                    }

                    else if (number == "2")
                    {

                        Console.WriteLine("What is the name?");
                        string name = Console.ReadLine();
                        SqlDbData.DeleteUser(name);

                        Console.WriteLine("Okay, you can now claim your clothes:)");

                    }
                    else if (number == "3")
                    {
                        Console.WriteLine("Okay, the customer details is listed below<3");
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