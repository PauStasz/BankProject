using System.IO;

namespace PB.Projekt.Bank
{
    public class CentrumObslugi
    {
        private List<Operacja> operacje;
        private List<Klient> listaKlientow;
        private List<Bank> listaBankow;

        public CentrumObslugi()
        {
            operacje = new List<Operacja>();
            listaKlientow = new List<Klient>();
            listaBankow = new List<Bank>();
        }

        public bool AutoryzujPlatnosc(double kwota, Karta karta)
        {

            if (karta.Kwota >= kwota)
                return true;

            return false;
        }

        public void ZapiszStanSystemu(string nazwaPliku, DateTime data)
        {
            //TODO: ZAPISZ STAN
        }

        public void WczytajStanSystemu(string nazwaPliku)
        {
            //TODO: WCZYTAJ STAN
        }

        public void UsunKlienta(Klient klient)
        {
            listaKlientow.Remove(klient);
        }

        public void DodajKlienta(Klient klient)
        {
            listaKlientow.Add(klient);
        }

        public void DodajBank(Bank bank)
        {
            listaBankow.Add(bank);
        }

    public List<Klient> PrzegladKlientow()
        {
            return listaKlientow;
        }

        public List<Bank> PrzegladBankow()
        {
            return listaBankow;
        }

        public bool PrzeszukajArchiwum(string nazwaPliku, object szukany)
        {
            return false;
        }
    }
}
