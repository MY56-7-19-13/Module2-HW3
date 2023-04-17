using Homework3.Models.Candy;
using Homework3.Models.OtherSweets;

namespace Homework3.Models
{
    public class Starter
    {
        public void Run()
        {
            int index = 0;
            Bucket buck = new Bucket();
            Sweets[] addToGift = new Sweets[10];

            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("\nWelcome to *WILLY WONKA FACTORY*");
                Console.WriteLine();
                Console.WriteLine("Menu:");
                Console.WriteLine("-----");
                Console.WriteLine("1. Show products");
                Console.WriteLine("2. Subscribe New Year's gift");
                Console.WriteLine("3. Find sweets in New Year's gift");
                Console.WriteLine("4. Contact us");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1-4): ");
                string? input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Welcome to *WILLY WONKA FACTORY*");
                        Console.WriteLine("\nList of products:");
                        Console.WriteLine("\n" + new string('-', 40));
                        CaramelCandy[] getCaramelCandies = buck.GetCaramelCandies();
                        ChocolateCandy[] getChocolateCandies = buck.GetChocolateCandies();
                        Cookies[] getCookiesList = buck.GetCookiesList();
                        Marmalades[] getMarmaladesList = buck.GetMarmaladesList();
                        Console.WriteLine(new string('-', 40));
                        Console.Write("\nWhat sweets you want to add: ");
                        int takeSweets = Convert.ToInt32(Console.ReadLine());
                        if (takeSweets >= 1 && takeSweets <= 5)
                        {
                            for (int i = 0; i < getCaramelCandies.Length; i++)
                            {
                                if (i == (takeSweets - 1))
                                {
                                    addToGift[index] = getCaramelCandies[takeSweets - 1];
                                    index++;
                                }
                            }

                            Console.WriteLine("Successfully add!");
                            Console.Write("Press enter for continue... ");
                            Console.ReadLine();
                        }

                        if (takeSweets >= 6 && takeSweets <= 10)
                        {
                            for (int i = 0; i < getChocolateCandies.Length; i++)
                            {
                                if (i == (takeSweets - 6))
                                {
                                    addToGift[index] = getChocolateCandies[takeSweets - 6];
                                    index++;
                                 }
                            }

                            Console.WriteLine("Successfully add!");
                            Console.Write("Press enter for continue... ");
                            Console.ReadLine();
                        }

                        if (takeSweets >= 11 && takeSweets <= 15)
                        {
                            for (int i = 0; i < getCookiesList.Length; i++)
                            {
                                if (i == (takeSweets - 11))
                                {
                                    addToGift[index] = getCookiesList[takeSweets - 11];
                                    index++;
                                }
                            }
                        }

                        if (takeSweets >= 16 && takeSweets <= 20)
                        {
                            for (int i = 0; i < getMarmaladesList.Length; i++)
                            {
                                if (i == (takeSweets - 16))
                                {
                                    addToGift[index] = getMarmaladesList[takeSweets - 16];
                                    index++;
                                }
                            }

                            Console.WriteLine("Successfully add!");
                            Console.Write("Press enter for continue... ");
                            Console.ReadLine();
                        }

                        break;
                    case "2":
                        Console.Clear();
                        var sumOfPresent = 0;
                        Console.WriteLine("Your New Year`s present:");
                        Console.WriteLine("\n" + new string('-', 40));
                        Array.Sort(addToGift);

                        for (int i = 0; i < addToGift.Length; i++)
                        {
                            if (addToGift[i] != null)
                            {
                                Console.WriteLine(addToGift[i].GetInfoSweets());
                            }
                            else
                            {
                                addToGift[i] = addToGift[i];
                            }
                        }

                        for (int i = 0; i < addToGift.Length; i++)
                        {
                            if (addToGift[i] != null)
                            {
                                sumOfPresent += addToGift[i].Weight;
                            }
                            else
                            {
                                addToGift[i] = addToGift[i];
                            }
                        }

                        Console.WriteLine(new string('-', 40));
                        Console.WriteLine($"\nTotal weight: {sumOfPresent}g");

                        break;
                    case "3":
                        int standart = 0;
                        Console.Write("Find by standart (write calories): ");
                        int findItem = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < addToGift.Length; i++)
                        {
                            if (addToGift[i] != null)
                            {
                                addToGift[standart] = addToGift[i];
                                if (findItem == addToGift[standart].Calories)
                                {
                                    Console.WriteLine(addToGift[standart].GetInfoSweets());
                                }
                            }
                        }

                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Contact Us:\n");
                        ContactUs contactUs = new ContactUs();
                        contactUs.GetContacts();
                        break;
                    case "5":
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("We don`t have this option!\nTry again!");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
