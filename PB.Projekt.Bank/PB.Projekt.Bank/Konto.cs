namespace PB.Projekt.Bank
{
    public class Konto
    {
        List<Karta> listaKart = new List<Karta>();

        public Klient klient;
        public double Saldo { get; set; }

        public Konto()
        {
            klient = new Klient();
            Saldo = 0.0;
        }
        public Konto(Klient klient)
        {
          this.klient = klient;
        }

        public void DodajKarte(Karta karta)
        {
            if(karta is null)
            {
                throw new ArgumentNullException();
            }

            listaKart.Add(karta);
        }

        public void StanKonta()
        {
            double suma = 0.0;

            foreach  (Karta karta in listaKart)
            {
                suma += karta.Kwota;
            }

            Saldo = suma;
        }

    }
}
