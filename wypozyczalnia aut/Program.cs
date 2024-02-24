using System;
using System.Net.NetworkInformation;
using System.Net.Security;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

namespace wypozyczalnia_aut
{
    public class Program
    {
        static void Main(string[] args)
        {
            Auta auta1 = new Auta();

            auta1.Id = 1;
            auta1.Model = "Škoda Citigo";
            auta1.Segment = "Mini";
            auta1.Rodzajpaliwa = "Benzyna";
            auta1.Cenazadobe = 70;
            auta1.Status = "Dostępny";

            Auta auta2 = new Auta();

            auta2.Id = 2;
            auta2.Model = "Toyota Aygo";
            auta2.Segment = "Mini";
            auta2.Rodzajpaliwa = "Benzyna";
            auta2.Cenazadobe = 90;
            auta2.Status = "Dostępny";

            Auta auta3 = new Auta();

            auta2.Id = 3;
            auta2.Model = "Volkswagen";
            auta2.Segment = "Mini";
            auta2.Rodzajpaliwa = "Benzyna";
            auta2.Cenazadobe = 70;
            auta2.Status = "Dostępny";

            List<Auta> listaaut = new List<Auta>();

            listaaut.Add(auta1);
            listaaut.Add(auta2);
            listaaut.Add(auta3);

            Console.WriteLine("Witaj w wypożyczalni aut prosze wybrać opcje:");
                int numerek = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (numerek == 1)
                {
                Console.Clear();
                foreach (Auta auta in listaaut)
                    {
                    Console.WriteLine("|" + auta.Id + " | " + auta.Model + " | " + auta.Segment + " | " + auta.Rodzajpaliwa + " | " + auta.Status + " | " + auta.Cenazadobe + "PLN");
                    }
                Console.WriteLine("Witaj w wypożyczalni aut prosze wybrać opcje:");
                numerek = Convert.ToInt32(Console.ReadLine());
                
                }
            }while (numerek == 1);
            
            
            if (numerek == 2)
            {
                Console.WriteLine("Essa wariacie");
            }
       
        }
    }
}
