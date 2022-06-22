using ClinicaVET5413.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaVET5413.Forms
{
    public partial class MainPanel : Form
    {
        #region Variaveis
        private Button currentButton;
        private Random random;
        private int tempIndex;
        Color cor = new Color();
        #endregion
        public MainPanel()
        {
            InitializeComponent();
            random = new Random();
            sideBarTimer.Stop();
            
            //Formatação das cores dos paineis
            Color color = SelectThemeColor();
            PainelCabecalho.BackColor = CorTema.ChangeColorBrightness(color, -0.15);
            panel1.BackColor = CorTema.ChangeColorBrightness(color, -0.3);
            PainelMenu.BackColor = CorTema.ChangeColorBrightness(color, +0.3);
            cor = CorTema.ChangeColorBrightness(color, +0.3);

            //obter dia para Label
            lbl_dia.Text = DateTime.Now.ToString("D");

            //Não deixa que o form ocupe todo o ecrã
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        /// <summary>
        /// Dlls para poder mover e reajustar o form
        /// </summary>        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        /// <summary>
        /// Metodo que recebe um form , o ajusta e coloca no painelForms
        /// </summary>
        /// <param name="NovoForm"></param>
        public void LoadForms(object NovoForm,Object btnSender)
        {            
            ActivateButton(btnSender);
            if (this.painelForms.Controls.Count > 0)
                this.painelForms.Controls.RemoveAt(0);
            Form f = NovoForm as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.None;
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
            lbl_horas.Text = time.ToString("HH:mm:ss");
        }
        #region Botões Load Forms
        private void bt_Animal_Click(object sender, EventArgs e)
        {
            LoadForms(new PainelAnimal(),sender);
        }

        private void bt_medico_Click(object sender, EventArgs e)
        {
            LoadForms(new PainelMedico(), sender);
        }
        private void bt_cliente_Click(object sender, EventArgs e)
        {
            LoadForms(new PainelCliente(), sender);
        }

        private void bt_GestaoClinica_Click(object sender, EventArgs e)
        {
            LoadForms(new PainelConsulta(), sender);
        }

        private void bt_infos_Click(object sender, EventArgs e)
        {
            LoadForms(new PainelInformacoes(), sender);
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo para escolher cores aleatorias, mas a lista está apenas populadas por 1 cor
        /// </summary>
        /// <returns></returns>
        private Color SelectThemeColor()
        {
            int index = random.Next(CorTema.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(CorTema.ColorList.Count);
            }
            tempIndex = index;
            string color = CorTema.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        /// <summary>
        /// Cria animação de quando um botão selecionado este fica destacada
        /// </summary>
        /// <param name="btnSender"></param>
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                                       
                }
            }
        }

        /// <summary>
        /// Reverte as ações do Metodo ActivateButton
        /// </summary>
        private void DisableButton()
        {
            foreach (Control previousBtn in PainelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = cor;
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        /// <summary>
        /// Este metedo permite que o form seja movimentado arrastado apartir do cabeçalho
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PainelCabecalho_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Butões ControlBox
        private void bt_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_maximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void bt_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sideBarTimer.Start();            
        }
        bool sidebarExpand = false;
        private void sideBarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                PainelMenu.Width -= 10;
                if (PainelMenu.Width == PainelMenu.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sideBarTimer.Stop();
                }
            }
            else 
            {
                PainelMenu.Width += 10;
                if (PainelMenu.Width == PainelMenu.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sideBarTimer.Stop();
                }
            }
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
