namespace PB.Projekt.Bank
{
    public class Firma : Klient
    {
        public string NazwaFirmy
        { get; set; }

        public Firma(string nazwa)
        {
            NazwaFirmy = nazwa;
        }

        public override string ToString()
        {
            return NazwaFirmy;
        }
    }
}
