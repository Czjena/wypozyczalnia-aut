using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wypozyczalnia_aut
{
    public class Auta 
    {
        public int Id { get; set; }
        #pragma warning disable CS8618
        public string Model;
        public string Segment;
        public string Rodzajpaliwa;
        public string Status;
        #pragma warning restore CS8618

        public int Cenazadobe { get; set; }

        public void Wyswietl()
        {
            Console.WriteLine("|" + Id + " | " + Model + " | " + Segment + " | " + Rodzajpaliwa + " | " + Status + " | " + Cenazadobe + "PLN");
        }
    }






}
