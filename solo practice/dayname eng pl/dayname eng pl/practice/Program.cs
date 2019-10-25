using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Rzeczy, które chciałbym wprowadzić, ale nie wiem, jak:
            1. Powrót do menu głównego
            2. Możliwość ignorowania wielkości liter
            3.
             */

            Console.WriteLine("Witaj w tłumaczu dni tygodnia!\nWybierz opcję tłumaczenia:\n" +
                "1. Polski na angielski\n" +
                "2. Angielski na polski");

            string choice1 = Console.ReadLine();
            int choice;

            if(Int32.TryParse(choice1, out choice)&& (choice == 1 || choice == 2))
            // Jeśli udało się przekonwerować na
            //int oraz jest to liczba 1 lub 2 - kontynyuj
            {
                switch(choice)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("POLSKI NA ANGIELSKI\n" +
                                "Wpisz dzień tygodnia po polsku: ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            string dayname=Console.ReadLine();

                            if (dayname=="poniedziałek" || dayname == "wtorek"|| dayname == "środa" ||
                                dayname == "czwartek" || dayname == "piątek" || dayname == "sobota" ||
                                dayname == "niedziela")
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                switch (dayname)
                                {
                                    case "poniedziałek":
                                        {
                                            Console.Write("poniedziałek po angielsku to: ");
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.Write("monday");
                                            break;
                                        }
                                    case "wtorek":
                                        {
                                            Console.Write("wtorek po angielsku to: ");
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.Write("tuesday");
                                            break;
                                        }
                                    case "środa":
                                        {
                                            Console.Write("środa po angielsku to: ");
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.Write("wednesday");
                                            break;
                                        }
                                    case "czwartek":
                                        {
                                            Console.Write("czwartek po angielsku to: ");
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.Write("thursday");
                                            break;
                                        }
                                    case "piątek":
                                        {
                                            Console.Write("piątek po angielsku to: ");
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.Write("friday");
                                            break;
                                        }
                                    case "sobota":
                                        {
                                            Console.Write("sobota po angielsku to: ");
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.Write("saturday");
                                            break;
                                        }
                                    case "niedziela":
                                        {
                                            Console.Write("niedziela po angielsku to: ");
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.Write("sunday");
                                            break;
                                        }
                                }
                                
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Clear();
                                Console.WriteLine("Podaj poprawną nazwę dnia tygodnia używając polskich znaków i małych liter!");
                            }

                            break;
                        }
                    case 2:
                        {

                            break;
                        }
                }
            }
            //Jeśli nie, wywal error
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wybierz liczbę 1 lub 2!");
                Console.ReadKey();
            }
        }
    }
}
