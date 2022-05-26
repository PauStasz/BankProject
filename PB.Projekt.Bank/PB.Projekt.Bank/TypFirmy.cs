namespace PB.Projekt.Bank
{
    public class TypFirmy : Firma
    {
        public string Typ { get; private set;  }
        public TypFirmy(string typ, string nazwaFirmy) : base(nazwaFirmy)
        {
            Typ = typ;   
        }
    }
}
