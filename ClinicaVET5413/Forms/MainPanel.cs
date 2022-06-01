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
    public partial class MainPanel : Form
    {
        public MainPanel()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metodo que recebe um form , o ajusta e coloca no painelForms
        /// </summary>
        /// <param name="NovoForm"></param>
        public void LoadForms(object NovoForm)
        {
            if (this.painelForms.Controls.Count > 0)
                this.painelForms.Controls.RemoveAt(0);
            Form f = NovoForm as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.painelForms.Controls.Add(f);
            this.painelForms.Tag = f;
            f.Show();

        }
        private void bt_Animal_Click(object sender, EventArgs e)
        {
            LoadForms(new PainelAnimal());
        }

        private void bt_medico_Click(object sender, EventArgs e)
        {
            LoadForms(new PainelMedico());
        }
    }
}
