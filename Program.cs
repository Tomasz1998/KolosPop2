using System;


namespace KolosPop2
{
    class Program
    {
        public static void Zadanie1(double a, double b, double c)
        {
            if(a >= 1 || a <= 0)
            {
                Console.WriteLine("Zle podane a");
            }
            else if (b >= 1 || b <= 0)
            {
                Console.WriteLine("Zle podane b");
            }
            else if (c >= 1 || c <= 0)
            {
                Console.WriteLine("Zle podane c");
            }
            else
            {
                Console.WriteLine("Prawdopodobieństwo jest równe=" + a*b*c);
            }
        }
        public static void Zadanie2(int[] tablica)
        {
            
            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = i + 10;
            }

            int licz = 0;
            double srednia = 0;
            double suma = 0;

            for (int i = 0; i < tablica.Length; i++)
            {
                licz++;
                suma += tablica[i];
            }

            srednia = suma / licz;
            double srednia1 = 0;

            for (int i = 0; i < tablica.Length; i++)
            {
                srednia1 += (Math.Pow((tablica[i] - srednia),2));
            }

            double odchyleniestandardowe = Math.Sqrt(srednia1 / licz);
            Console.WriteLine("Odchylenie standardowe jest równe= " + odchyleniestandardowe);
            
        }
        public static void Zadanie3(int[,] tablica1)
        {
            int[,] wynikowa = new int[tablica1.GetLength(0) - 2, tablica1.GetLength(1) - 2];
            for (int i = 0; i < tablica1.GetLength(0); i++)
            {
                for (int j = 0; j < tablica1.GetLength(1); j++)
                {
                    
                }
            }
        }
        public static void Otworz(int pin)
        {
            if(pin == 1234)
            {
                Console.WriteLine("Drzwi otwarte");
            }
            else Console.WriteLine("Spróbuj ponownie");
        }
        public static void Otworz(string haslo)
        {
            if(haslo == "password")
            {
                Console.WriteLine("Drzwi otwarte");
            }
            else Console.WriteLine("Spróbuj ponownie");
        }
        public static void Otworz(DateTime data)
        {
            DateTime data1 = new DateTime(2020, 5, 3);
            DateTime data2 = new DateTime(2020, 5, 1);
            if(data >= data2 && data <=data1)
            {
                Console.WriteLine("Drzwi otwarte");
            }
            else Console.WriteLine("Spróbuj ponownie");
        }
        static void Main(string[] args)
        {
            //Zadanie1
            Console.WriteLine("Zadanie 1");
            Zadanie1(0.3,0.2,0.6);
            Console.WriteLine();
            //Zadanie2
            Console.WriteLine("Zadanie 2");
            Zadanie2(new int[10]);
            Console.WriteLine();
            //Zadanie4
            Console.WriteLine("Zadanie 4");
            Otworz(1234);
            Otworz("password");
            Otworz(new DateTime(2020,5,2));
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
