using System.Runtime.Serialization; //dla DataContract

namespace PB.Projekt.Bank
{
    [DataContract] //konieczne przed nazwa klasy jesli chcemy zapisac ja jako nazwaPlikuJakasTam.xml
    public class Operacja
    {
        [DataMember] //podobnie jak klasa obiekty tez musza byc oznaczone (kazdy)
        public Karta Karta { get; set; }

        [DataMember]
        public double Kwota { get; set; }

        [DataMember]
        public DateTime Data { get; set; }

        [DataMember]
        public Klient Podmiot1 { get; set; }

        [DataMember]
        public Klient Podmiot2 { get; set; }

        public Operacja(Karta karta, double kwota, DateTime data, Klient podmiot1, Klient podmiot2)
        {
            Karta = karta;
            Kwota = kwota;
            Data = data;
            Podmiot1 = podmiot1;
            Podmiot2 = podmiot2;
        }

    }
}
