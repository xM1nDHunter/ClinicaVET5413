using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaVET5413.Modelos
{
    public class Fatura
    {
        public int Id { get; set; }
        public string Serviço { get; set; }
        public double Preço { get; set; }
        public int Quantidade { get; set; }
        //public string Dono { get; set; }
        //public string Animal { get; set; }
        public string Total { get { return string.Format("{0}$", Preço * Quantidade); } }
    }
}
