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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            label_direitos.Text = "©Todos os direitos reservados a Bruno Cabrita©";
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if(txt_user.Text =="admin" & txt_password.Text=="Vet.123")
            {
                MainPanel frm =new MainPanel();
                frm.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("A password ou utilizador estão errados!", "Tente outra vez",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_password.Text = "";
                txt_user.Text = "";
            }
        }
    }
}
