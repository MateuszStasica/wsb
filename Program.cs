using System;

namespace tablice_dni_tygodnia
{
    class Program
    {
        static void Main(string[] args)
        {
            string [,] DNI = new string[7, 3];
            string i1;


            for (int i = 0; i < 7; i++)
            {
                //for(int j=0;j<;j++)
                i1 = (i+1).ToString();
                DNI[i, 0] = i1;
                Console.WriteLine("Wprowadź nazwę dnia tygodnia nr: " + (i+1) + " po polsku");
                DNI[i, 1] = Console.ReadLine();
                Console.WriteLine("Wprowadź nazwę dnia tygodnia nr: " + (i+1) + " po angielsku");
                DNI[i, 2] = Console.ReadLine();
                
            }

            for (int i = 0; i < 7; i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.Write(DNI[i,j]+" ");
                }
                Console.WriteLine("");            
            }
            Console.ReadKey();
        }
    }
}
