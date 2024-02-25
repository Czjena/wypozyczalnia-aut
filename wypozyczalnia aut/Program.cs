using System;
using System.ComponentModel.Design;
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
            
            auta3.Id = 3;
            auta3.Model = "Fiat 500";
            auta3.Segment = "Mini";
            auta3.Rodzajpaliwa = "Elektryczny";
            auta3.Cenazadobe = 110;
            auta3.Status = "Dostępny";

            Auta auta4 = new Auta();
            
            auta4.Id = 4;
            auta4.Model = "Ford Focus";
            auta4.Segment = "Kompakt";
            auta4.Rodzajpaliwa = "Diesel";
            auta4.Cenazadobe = 160;
            auta4.Status = "Dostępny";

            Auta auta5 = new Auta();
            
            auta5.Id = 5;
            auta5.Model = "Kia Ceed";
            auta5.Segment = "Kompakt";
            auta5.Rodzajpaliwa = "Benzyna";
            auta5.Cenazadobe = 150;
            auta5.Status = "Dostępny";

            Auta auta6 = new Auta();
           
            auta6.Id = 6;
            auta6.Model = "Volkswagen Golf";
            auta6.Segment = "Kompakt";
            auta6.Rodzajpaliwa = "Benzyna";
            auta6.Cenazadobe = 160;
            auta6.Status = "Dostępny";

            Auta auta7 = new Auta();
            
            auta7.Id = 7;
            auta7.Model = "Hyundai Kona Electric";
            auta7.Segment = "Kompakt";
            auta7.Rodzajpaliwa = "Elektryczny";
            auta7.Cenazadobe = 180;
            auta7.Status = "Dostępny";

            Auta auta8 = new Auta();
            
            auta8.Id = 8;
            auta8.Model = "Audi A6 Allroad";
            auta8.Segment = "Premium";
            auta8.Rodzajpaliwa = "Diesel";
            auta8.Cenazadobe = 290;
            auta8.Status = "Dostępny";

            Auta auta9 = new Auta();
            
            auta9.Id = 9;
            auta9.Model = "Mercedes E270 AMG";
            auta9.Segment = "Premium";
            auta9.Rodzajpaliwa = "Benzyna";
            auta9.Cenazadobe = 320;
            auta9.Status = "Dostępny";

            Auta auta10 = new Auta();
            
            auta10.Id = 10;
            auta10.Model = "Tesla Model S";
            auta10.Segment = "Premium";
            auta10.Rodzajpaliwa = "Elektryczny";
            auta10.Cenazadobe = 350;
            auta10.Status = "Dostępny";

            List<Auta> listaaut = new List<Auta>();

            listaaut.Add(auta1);
            listaaut.Add(auta2);
            listaaut.Add(auta3);
            listaaut.Add(auta4);
            listaaut.Add(auta5);
            listaaut.Add(auta6);
            listaaut.Add(auta7);
            listaaut.Add(auta8);
            listaaut.Add(auta9);
            listaaut.Add(auta10);

            var Prawojazdy1 = new DateTime(2021, 03, 04);
            var osoby1 = new Osoby();
            osoby1.Id = 1;
            osoby1.Imie = "Jan Nowak";
            osoby1.Dataprawajazd = Prawojazdy1;

            var Prawojazdy2 = new DateTime(1999, 01, 15);
            var osoby2 = new Osoby();
            osoby2.Id = 2;
            osoby2.Imie = "Agnieszka Kowalska";
            osoby2.Dataprawajazd = Prawojazdy2;

            var Prawojazdy3 = new DateTime(2010, 12, 18);
            var osoby3 = new Osoby();
            osoby3.Id = 3;
            osoby3.Imie = "Robert Lewandowski";
            osoby3.Dataprawajazd = Prawojazdy3;

            var Prawojazdy4 = new DateTime(2020, 04, 29);
            var osoby4 = new Osoby();
            osoby4.Id = 4;
            osoby4.Imie = "Zofia Plucińska";
            osoby4.Dataprawajazd = Prawojazdy4;

            var Prawojazdy5 = new DateTime(2015, 07, 12);
            var osoby5 = new Osoby();
            osoby5.Id = 5;
            osoby5.Imie = "Grzegorz Braun";
            osoby5.Dataprawajazd = Prawojazdy5;

            List<Osoby> listosob = new List<Osoby>();

           listosob.Add(osoby1);
           listosob.Add(osoby2);
           listosob.Add(osoby3);
           listosob.Add(osoby4);
           listosob.Add(osoby5);

            Console.WriteLine("Witaj w wypożyczalni aut prosze wybrać opcje: \n1.Lista Klientów i samochodów \n2.Wynajmij Samochód");
                int numerek = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (numerek == 1)
                {
                Console.Clear();
                    Console.WriteLine("\nLista Aut");
                    foreach (Auta auta in listaaut)
                    {
                    Console.WriteLine($"|" + auta.Id + " | " + auta.Model + " | " + auta.Segment + " | " + auta.Rodzajpaliwa + " | " + auta.Status + " | " + auta.Cenazadobe + "PLN");
                    }
                    Console.WriteLine("\nLista Klientów");
                    foreach (var osoby in listosob)
                    {
                        Console.WriteLine($"|" + osoby.Id + " | " + osoby.Imie + " | " + osoby.Dataprawajazd.ToShortDateString());
                    }
                    Console.WriteLine("Witaj w wypożyczalni aut prosze wybrać opcje:\n1.Lista Klientów i samochodów \n2.Wynajmij Samochód");
                numerek = Convert.ToInt32(Console.ReadLine());
                
                }
            }while (numerek == 1);
            
            
            if (numerek == 2)
            {
                Console.Clear();
                Console.WriteLine("Proszę podać nr klienta");
                int numerklienta = Convert.ToInt32(Console.ReadLine());
                
                Osoby wybranaOsoba = listosob.FirstOrDefault(o => o.Id == numerklienta);

                if (wybranaOsoba != null)
                {
                    var roznicaLat = (DateTime.Now - wybranaOsoba.Dataprawajazd).TotalDays / 365;
                    if (roznicaLat < 4)
                    {
                        Console.WriteLine("Dostępne auta dla klienta: \n1.Mini \n2.Kompakt");
                        int Opcjaauta = Convert.ToInt32(Console.ReadLine());

                    }
                    else
                    {
                        Console.WriteLine("Dostępne auta dla klienta: \n1.Mini \n2.Kompakt \n3.Premium");
                    }
  
                }
                else
                {
                    Console.WriteLine("Nie znaleziono klienta o podanym numerze.");
                }


            }
       
        }
    }
}
