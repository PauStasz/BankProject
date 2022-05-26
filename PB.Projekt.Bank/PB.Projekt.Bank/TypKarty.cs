namespace PB.Projekt.Bank
{
    public class TypKarty : Karta
    {
        public string Nazwa { get; set; }

        public TypKarty(string nazwa, string numer) : base(numer)
        {
            Nazwa = nazwa; 
        }

    }
}
