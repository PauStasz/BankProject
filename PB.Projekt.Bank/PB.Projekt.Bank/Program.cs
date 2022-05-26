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
        centrumObslugi.DodajBank(bank1);
    }

    public static void WyswietlMenu()
    {
        Console.WriteLine("==========MENU==========");
        Console.WriteLine("1. Klienci");
        Console.WriteLine("2. Karty");
        Console.WriteLine("3. Autoryzacja platnosci");
        Console.WriteLine("4. Archiwum");
        Console.WriteLine("5. Zapisz Stan ");
        Console.WriteLine("5. Wczytaj Stan ");
        Console.WriteLine("6. Zamknij program ");
    }

    //prosi uzytkownika o wybranie opcji z zakresu podanego jako argumenty 
    public static int WczytajWybor(int min, int max)
    {
        int liczba = -1;

        while (true)
        {
            Console.WriteLine("Wybór:");
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
        int index = 1;
        Console.WriteLine("Banki:");
        foreach (var bank in centrumObslugi.PrzegladBankow())
        {

            Console.WriteLine($"{index++}. {bank.Nazwa}");
            
        }
        index = 1;

        Console.WriteLine("Firmy:");
        foreach (var firma in centrumObslugi.PrzegladKlientow())
        {
            if (firma is Firma)
                Console.WriteLine($"{index++}. {firma}");
        }

        index = 1;
        Console.WriteLine("Osoby fizyczne:");
        foreach (var osobafizyczna in centrumObslugi.PrzegladKlientow())
        {
            if (osobafizyczna is OsobaFizyczna)
                Console.WriteLine($"{index++}. {osobafizyczna}"); ;
        }


        Console.WriteLine("1. Dodaj Klienta");
        Console.WriteLine("2. Usun Klient");
        Console.WriteLine("3. Dodaj Bank");
        Console.WriteLine("4. Usun Bank");
        switch(WczytajWybor(1, 4))
        {
            case 1:
                DodajKlienta();
                break;
            case 2:
                UsunKlienta();
                break;
            case 3:
                DodajBank();
                break;
            case 4:
                UsunBank();
                break;
            default:

                break;
        }
    }

    //funkcjonalnosc dodawania klienta
    public static void DodajKlienta()
    {
        //formularz tworzenia klienta
        //dodanie klienta do centrum obslugi
    }

    //funkcjonalnosc usuwania klienta
    public static void UsunKlienta()
    {
        //poproszenie uzytkownika o 
    }

    //funkcjonalnosc dodawania banku
    public static void DodajBank()
    {

    }

    //funkcjonalnosc usuwania klienta
    public static void UsunBank()
    {

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
