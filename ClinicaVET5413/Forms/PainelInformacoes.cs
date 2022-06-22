using ClinicaVET5413.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaVET5413.Forms
{
    public partial class PainelInformacoes : Form
    {
        
        public PainelInformacoes()
        {
            InitializeComponent();
            Color cor = new Color();
            cor = Color.FromArgb(104, 138, 129);
            BackColor = cor;
        }
    }
}
