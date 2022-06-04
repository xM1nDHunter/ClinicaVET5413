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
    public partial class PainelMedico : Form
    {
        DataClassesDataContext dc = new DataClassesDataContext();
        public PainelMedico()
        {
            InitializeComponent();
        }
        public void CarregarGrid()
        {
            dataGridMedico.DataSource = null;
            dataGridMedico.DataSource = dc.Medicos;
            dataGridMedico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            int getID = 0;
            var listaID = from Medico in dc.Medicos select Medico;
            foreach (var medico in listaID)
            {
                if (medico.ID > getID)
                {
                    getID = medico.ID;
                }
            }
            getID += 1;
            txt_addID.Text = getID.ToString();
        }
    }
}
