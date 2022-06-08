using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaVET5413.Modelos
{
    public class Consulta
    {
        public int ID { get; set; }
        public Medico Medico { get; set; }
        public Cliente Cliente { get; set; }
        public Animal Animal { get; set; }
        public string Tratamento { get; set; }
        public DateTime DiaConsulta { get; set; }
        public string HoraConsulta { get; set; }
        public string Notas { get; set; }
        
        public Consulta(Medico medico,Cliente cliente,Animal animal,string tratamento,DateTime diaConsulta,string horaConsulta,string notas)
        {
            Medico = medico;
            Cliente = cliente;
            Animal = animal;
            Tratamento = tratamento;
            DiaConsulta = diaConsulta;
            HoraConsulta = horaConsulta;
            Notas = notas;
        }
    }

}
