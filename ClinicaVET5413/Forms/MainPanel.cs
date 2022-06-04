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
            lbl_dia.Text = DateTime.Now.ToString("D");
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
        /// <summary>
        /// Timer para que o relógio da app esteja sempre atualizado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = new DateTime();
            time = DateTime.Now;
            lbl_horas.Text = time.ToString("hh:mm:ss");
        }
        #region Botões Load Forms
        private void bt_Animal_Click(object sender, EventArgs e)
        {
            LoadForms(new PainelAnimal());
        }

        private void bt_medico_Click(object sender, EventArgs e)
        {
            LoadForms(new PainelMedico());
        }
        private void bt_cliente_Click(object sender, EventArgs e)
        {
            LoadForms(new PainelCliente());
        }

        private void bt_GestaoClinica_Click(object sender, EventArgs e)
        {
            LoadForms(new PainelConsulta());
        }

        private void bt_infos_Click(object sender, EventArgs e)
        {
            LoadForms(new PainelInformacoes());
        }
        #endregion
    }
}
