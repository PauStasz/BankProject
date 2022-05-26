namespace PB.Projekt.Bank
{
    public class OsobaFizyczna :  Klient
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public string PESEL { get; set; }

        public OsobaFizyczna(string imie, string nazwisko, string PESEL)
        {
            Imie = imie;
            Nazwisko = nazwisko;    
            this.PESEL = PESEL;
        }

        public override string ToString()
        {
            return $"{Imie} {Nazwisko}";
        }
    }
}
