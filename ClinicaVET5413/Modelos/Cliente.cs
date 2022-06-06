using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaVET5413.Modelos
{
    public  class Cliente
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string NIF { get; set; }
        public string Telemovel { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Animal { get; set; }
    }
}
