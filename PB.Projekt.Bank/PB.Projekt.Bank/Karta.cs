namespace PB.Projekt.Bank
{
    public class Karta
    {
        public string Numer { get; set; }

        private double kwota;

        public double Kwota
        {
            get { return kwota; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("kwota ujemna"); //TODO: zrobic odpowiedni wyjatek w bankexception
                }
                kwota = value; 
            }
        }


        public Karta(string numer)
        {
            Numer = numer;
        }
       
    }
}
