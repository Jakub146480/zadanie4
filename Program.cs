using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c, d, wynik;

        Console.WriteLine("Witaj w algorytmie który wyliczy licznik i mianownik ułamka");
        Console.WriteLine("wpisz liczbę całkowitą a");
        a = inputValue();
        Console.WriteLine("Wpisz liczbę całkowitą b");
        b = inputValue();
        if (b > 0)
        {
            Console.WriteLine("podaj liczbę całkowitą c");
            c = inputValue();
            Console.WriteLine("podaj liczbę całkowitą d");
            d = inputValue();
            if (d > 0)
            {
                Console.WriteLine("Twój wynik to");
                wynik = a / b + c / d;
                Console.WriteLine(wynik);
            }
            else
            {
                Console.WriteLine("Brak rozwiązania");
            }
        }
        else
        {
            Console.WriteLine("Brak rozwiązania");
        }
    }

    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
