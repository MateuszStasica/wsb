using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Comment*/
            Console.WriteLine("Andrzej");       // Console.WriteLine jest metodą, metody mają okrągłe nawiasy /cout
                                                //ZMIENNE I TYPY DANYCH

            int x=0, y=5, z=10;                 //Od razu należy przypisać wartości poszczególnym zmiennym
            int c = new int();                  //Chyba, że tak. Wtedy wartość domyślna jest równa NULL

            Console.WriteLine("Zmienna x wynosi: "+x+"\nZmienna y wynosi: "+y+"\nZmienna z wynosi: "+z);    //Rozpoczęcie nowej lini \n


            int a = 100;
            int b = a;

            Console.WriteLine(a + "\n" + b);

            Console.WriteLine("Podaj imie");
            string name = Console.ReadLine();
            Console.WriteLine("Twoje imie to: "+name);

            uint z1 = 200;                    //int moze miec ujemne wartosci, a uint nie
            float y1 = 10.55F;
            double y2 = 15.95;                //double - używane przy dużych wartościach

            Console.WriteLine("Podaj dlugosc boku kwadratu (zmiennoprzecinkowa)");
            double BOK = double.Parse(Console.ReadLine());

            double result = BOK * BOK;
            Console.WriteLine("Pole tego kwadratu wynosi: " + result);

            Console.ReadKey();                // Wciśnięcie klawisza powoduje zamknięcie programu /cin
        }
    }
}
