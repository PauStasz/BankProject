using System;
using PB.Projekt.Bank;

public class Program
{
    private static CentrumObslugi centrumObslugi;

    public static void Main()
    {
        centrumObslugi = new CentrumObslugi();
        UtworzPrzykladoweObiekty();

        while (true)
        {
            WyswietlMenu();
            WyswietlZakladke(WczytajWybor(1, 6));
        }
    }

    public static void UtworzPrzykladoweObiekty()
    {
        //utworzenie przykładowych obiektów (przygotowanie przykladowego stany programu)
        OsobaFizyczna osoba1 = new OsobaFizyczna("Jan", "Kowalski", "42069");
        Firma firma1 = new Firma("JacexDowozWideo");
        Bank bank1 = new Bank("Nbank");

        centrumObslugi.DodajKlienta(osoba1);
        centrumObslugi.DodajKlienta(firma1);
        centrumObslugi.DodajKlienta(bank1);
    }

    public static void WyswietlMenu()
    {
        Console.Clear();
        Console.WriteLine("==========MENU==========");
        Console.WriteLine("1. Klienci");
        Console.WriteLine("2. Karty");
        Console.WriteLine("3. Autoryzacja platnosci");
        Console.WriteLine("4. Archiwum");
        Console.WriteLine("5. Zapisz Stan ");
        Console.WriteLine("5. Wczytaj Stan ");
        Console.WriteLine("6. Zamknij program ");
        Console.WriteLine("========================");
    }

    //prosi uzytkownika o wybranie opcji z zakresu podanego jako argumenty 
    public static int WczytajWybor(int min, int max)
    {
        int liczba = -1;

        while (true)
        {
            Console.WriteLine("\nWybór:");
            liczba = Int32.Parse(Console.ReadLine());
            if (liczba < min || liczba > max)
                Console.WriteLine("Niepoprawny wybór!");
            else
                return liczba;
        }
    }

    //wyswietlanie odpowiedniej zakladki
    public static void WyswietlZakladke(int numer)
    {
        Console.Clear();
        switch (numer)
        {
            case 1:
                Klienci();
                break;
            case 2:
                Karty();
                break;
            case 3:
                AutoryzacjaPlatnosci();
                break;
            case 4:
                ZapisStanu();
                break;
            case 5:
                WczytanieStanu();
                break;
            case 6:
                Environment.Exit(0);
                break;
            default:

                break;
        }
    }

    //wyswietlanie zakladki firmy
    public static void Klienci()
    {
        Console.WriteLine("Banki:");
        WyswietlKlientow<Bank>();

        Console.WriteLine("Firmy:");
        WyswietlKlientow<Firma>();

        Console.WriteLine("Osoby fizyczne:");
        WyswietlKlientow<OsobaFizyczna>();

        Console.WriteLine("\nCo chcesz zrobić?:\n");
        Console.WriteLine("1. Dodaj Klienta");
        Console.WriteLine("2. Usuń Bank");
        Console.WriteLine("3. Usuń Firmę");
        Console.WriteLine("4. Usuń Osobę fizyczną");

        switch(WczytajWybor(1, 4))
        {
            case 1:
                DodajKlienta();
                break;
            case 2:
                //UsunBank() <- użyć tego jak będzie zrobiona obsługa wyjątku (analogicznie w reszcie przypadków poniżej)
                Console.WriteLine("Podaj nazwę banku:");
                UsunKlienta<Bank>(Console.ReadLine());
                break;
            case 3:
                Console.WriteLine("Podaj nazwę firmy:");
                UsunKlienta<Firma>(Console.ReadLine());
                break;
            case 4:
                string nazwa = "";
                Console.WriteLine("Podaj imię:");
                nazwa += Console.ReadLine() + " ";
                Console.WriteLine("Podaj nazwisko:");
                nazwa += Console.ReadLine();

                UsunKlienta<OsobaFizyczna>(nazwa);
                break;
            default:

                break;
        }
    }

    /*  fukcja z obsługą wyjątku 
    public static void UsunBank()
    {
        try
        {
            Console.WriteLine("Podaj nazwę banku:");
            UsunKlienta<Bank>(Console.ReadLine());
        }
        catch (Exception ex) // nazwa wyjątku oczywiście do zmiany
        {
            Console.WriteLine(ex.Message);
            //tutaj albo znowu wywołać funkcje UsunBank() do skutku, 
            //tylko wtedy warto dodać jakiś sposób na anulowanie usuwania
        }
    }
    */


    //wyświetla klientów o podanym typie
    public static void WyswietlKlientow<T>()
    {
        int index = 1;
        foreach (var klient in centrumObslugi.PrzegladKlientow())
        {
            if (klient is T)
                Console.WriteLine($"{index++}. {klient}");
        }
    }

    //funkcjonalnosc dodawania klienta
    public static void DodajKlienta()
    {
        Console.Clear();
        //formularz tworzenia klienta
        //  wybór jaki typ klienta
        //  na podstawie wyboru poproszenie o odpowiednie dane
        //utworzenie obiektu 
        //dodanie klienta do centrum obslugi
    }

    //usuwa klienta o podanym typie i nazwie
    public static void UsunKlienta<T>(string nazwa)
    {
        foreach (var klient in centrumObslugi.PrzegladKlientow().ToList())
        {
            if (klient is T)
            {
                if (klient.ToString() == nazwa)
                {
                    centrumObslugi.UsunKlienta(klient);
                    return;
                }   
            }
        }
        //te exeption trzeba podmienić tzn. zrobić własną klase z odpowiednią nazwą
        throw new Exception("Brak klienta o podanej nazwie!");
    }

    //wyswietlanie zakladki karty
    public static void Karty()
    {

    }

    //wyswietlanie zakladki autoryzacja platnosci
    public static void AutoryzacjaPlatnosci()
    {

    }

    //wyswietlanie zakladki zapisu stanu
    public static void ZapisStanu()
    {

    }

    //wyswietlanie zakladki odczytu stanu
    public static void WczytanieStanu()
    {

    }
        
}
