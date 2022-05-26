namespace PB.Projekt.Bank
{
    public class Bank : Klient
    {
        private List<Konto> listaKont = new List<Konto> ();
        private List<string> listaNr = new List<string> ();
        public string Nazwa { get; set; }   

        public Bank(string nazwa)
        {
            Nazwa = nazwa;
        }

        public void WydajKarte(Konto konto, Karta karta) 
        {
            if (konto is null)
            {
                throw new ArgumentNullException();
            }
            string numer = generujNr();
            listaNr.Add (numer);

            konto.DodajKarte(new Karta(numer));
        }

        public void DodajKonto(Konto konto)
        {
            if (konto is null)
            {
                throw new ArgumentNullException();
            }
            listaKont.Add (konto);
        }

        public void UsunKonto(Konto konto)
        {
            if (konto is null)
            {
                throw new ArgumentNullException();
            }

            listaKont.Remove(konto);

        }

        private string generujNr()
        {
            Random random = new Random();

            string numer = "";

            do
            {
                for (int i = 0; i < 16; i++)
                {
                    numer += random.Next(0, 10);
                }

            } while (sprawdzCzyNrJestNaLiscie(numer));


            return numer;
        }


        private bool sprawdzCzyNrJestNaLiscie(string nr)
        {
            if (listaNr.Exists(warunek => warunek == nr))
                return true;

            return false;
        }


    }
}
