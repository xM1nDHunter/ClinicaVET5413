using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaVET5413.Modelos
{
    public class Animal
    {
        public string ID { get; set; }
        public string Nome { get; set; }
        public string Especie { get; set; }
        public string Raca { get; set; }
        public string Genero { get; set; }
        public string Peso { get; set; }
        public string Esterilizacao { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
