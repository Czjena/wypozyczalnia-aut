using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wypozyczalnia_aut
{
    public class Osoby
    {
#pragma warning disable CS8618
        public int Id { get; set; }
        public string Imie { get; set; }
        public DateTime Dataprawajazd {  get; set; }
#pragma warning restore CS8618
    }
}
