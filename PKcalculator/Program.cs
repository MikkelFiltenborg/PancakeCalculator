using System;
using System.Threading;

namespace PKcalculaor
{
    class Program
    {
        static void Main(string[] args)
        {
            int flourGram, eggAmount, butterGram, milkDl, saltGram, sugarGram;
            bool check, ok, missing = false;

            Console.WriteLine("\n Pancake calculator" +
                              "\n I will tell you how many pancakes you can make with what you have." +
                              "\n\n Press ENTER to continue.");
            Console.ReadLine();
            do
            {
                do
                {
                    do
                    {
                        Console.Clear();
                        Console.Write("\n Enter the amount of flour you have in Grams : ");

                        check = int.TryParse(Console.ReadLine(), out flourGram);
                        if (check == false)
                        {
                            Console.WriteLine(" Your input is invalid.");
                            Thread.Sleep(1000);
                        }
                    } while (!check);

                    do
                    {
                        Console.Clear();
                        Console.Write("\n Enter the amount of sugar you have in Grams : ");

                        check = int.TryParse(Console.ReadLine(), out sugarGram);
                        if (check == false)
                        {
                            Console.WriteLine(" Your input is invalid.");
                            Thread.Sleep(1000);
                        }
                    } while (!check);

                    do
                    {
                        Console.Clear();
                        Console.Write("\n Enter the amount of salt you have in Grams : ");

                        check = int.TryParse(Console.ReadLine(), out saltGram);
                        if (check == false)
                        {
                            Console.WriteLine(" Your input is invalid.");
                            Thread.Sleep(1000);
                        }
                    } while (!check);

                    do
                    {
                        Console.Clear();
                        Console.Write("\n Enter the amount of butter you have in Grams : ");

                        check = int.TryParse(Console.ReadLine(), out butterGram);
                        if (check == false)
                        {
                            Console.WriteLine(" Your input is invalid.");
                            Thread.Sleep(1000);
                        }
                    } while (!check);

                    do
                    {
                        Console.Clear();
                        Console.Write("\n Enter the amount of milk you have in Decilitre : ");

                        check = int.TryParse(Console.ReadLine(), out milkDl);
                        if (check == false)
                        {
                            Console.WriteLine(" Your input is invalid.");
                            Thread.Sleep(1000);
                        }
                    } while (!check);

                    do
                    {
                        Console.Clear();
                        Console.Write("\n Enter the amount of eggs you have : ");

                        check = int.TryParse(Console.ReadLine(), out eggAmount);
                        if (check == false)
                        {
                            Console.WriteLine(" Your input is invalid.");
                            Thread.Sleep(1000);
                        }
                    } while (!check);

                    Console.Clear();
                    Console.WriteLine($"\n You have the following:" +
                                      $"\n {flourGram}g. of flour." +
                                      $"\n {sugarGram}g. of sugar." +
                                      $"\n {saltGram}g. of salt." +
                                      $"\n {butterGram}g. of butter." +
                                      $"\n {milkDl}dl. of milk." +
                                      $"\n {eggAmount} egg/eggs." +
                                      $"\n\n Is this correct?" +
                                      $"\n [ Y ] for Yes.\n [ N ] for No.");

                    string? answer = Console.ReadLine();
                    if (answer == "y" || answer == "Y")
                    { ok = true; }
                    else if (answer == "n" || answer == "N")
                    { ok = false; }
                    else
                    {
                        ok = false;
                        Console.WriteLine(" Invalid input.");
                        Thread.Sleep(1000);
                    }

                } while (!ok);

                int[] ingredients = { flourGram, sugarGram, saltGram, butterGram, milkDl, eggAmount };
                foreach (int amount in ingredients)
                {
                    if (amount == 0)
                    {
                        Console.WriteLine(" You are missing one or more ingredients");
                        missing = true; break;
                    }
                }

                //4stk = 40g flour, 2g sugar, 0.6g salt, 10g butter, 1dl milk, ½ egg.
                if (!missing)
                {
                    Console.WriteLine("You can make pancakes");


                }

                Thread.Sleep(2000);
            } while (missing);


        }
    }
}