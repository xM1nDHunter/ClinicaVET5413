using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaVET5413.Forms
{
    public partial class PainelConsulta : Form
    {
        //--------------------------------------------------------------------------------------------
        //--------------------------------CRUD CONSULTAS----------------------------------------------
        //--------------------------------------------------------------------------------------------
        DataClassesDataContext dc = new DataClassesDataContext();
        public PainelConsulta()
        {
            InitializeComponent();
        }
        private void PainelConsulta_Load(object sender, EventArgs e)
        {
            dtp_EditDia.Format = DateTimePickerFormat.Custom;
            dtp_EditDia.CustomFormat = "dd/MM/yyyy";
            dtp_AddDia.Format = DateTimePickerFormat.Custom;
            dtp_AddDia.CustomFormat = "dd/MM/yyyy";
            CarregarComboBoxes();
            CarregarGrid();
            CarregarComboEmail();
        }
        #region Configuraçõse de Butões
        private void bt_AdicionarConsulta_Click(object sender, EventArgs e)
        {

        }

        private void bt_EditarConsulta_Click(object sender, EventArgs e)
        {

        }

        private void bt_ApagarConsulta_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Metodos de Loads
        public void CarregarGrid()
        {
            dataGridConsultas.DataSource = null;
            dataGridConsultas.DataSource = dc.Consultas;
            dataGridConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            int getID = 0;
            var consultas = from Consulta in dc.Consultas select Consulta;
            foreach (var consulta in consultas)
            {
                if (consulta.ID > getID)
                {
                    getID = consulta.ID;
                }
            }
            getID += 1;
            txt_AddID.Text = getID.ToString();
        }
        public void CarregarComboBoxes()
        {            
            var listaMedico = dc.Medicos.ToList();
            foreach (Medico medico in listaMedico)
            {
                cb_AddMedico.Items.Add(medico.Nome);
            }
            var listaCliente = dc.Clientes.ToList();
            foreach (Cliente cliente in listaCliente)
            {
                cb_AddCliente.Items.Add(cliente.Nome);
            }
            cb_AddTratamento.Items.Add("Vacinas");
            cb_AddTratamento.Items.Add("Check-Up mensal");
            cb_AddTratamento.Items.Add("Castração");
            cb_AddTratamento.Items.Add("Operação");
            cb_AddTratamento.Items.Add("Cardiologia");
            cb_AddTratamento.Items.Add("Fisioterapia");

            cb_AddHora.Items.Add("09h00-10h00");
            cb_AddHora.Items.Add("10h00-11h00");
            cb_AddHora.Items.Add("11h00-12h00");
            cb_AddHora.Items.Add("14h00-15h00");
            cb_AddHora.Items.Add("15h00-16h00");
            cb_AddHora.Items.Add("16h00-17h00");
            cb_AddHora.Items.Add("17h00-18h00");
        }       
        private void cb_AddCliente_SelectedIndexChanged(object sender, EventArgs e)
        {            
                cb_AddAnimal.Items.Clear();
                var clientePesquisa = cb_AddCliente.Text;
                var animal = from Animal in dc.Animals
                             where SqlMethods.Like(Animal.Dono, "%" + clientePesquisa + "%")
                             select Animal;
                foreach (Animal pop in animal)
                {
                    cb_AddAnimal.Items.Add(pop.Nome);
                }
           
        }


        #endregion
        #region Configurações do Butões
        private void bt_AddConsulta_Click(object sender, EventArgs e)
        {
            

        }
        #endregion
        private void txt_pesquisa_TextChanged(object sender, EventArgs e)
        {
            dataGridConsultas.DataSource = null;
            dataGridConsultas.Refresh();
            dataGridConsultas.AutoGenerateColumns = true;
            dataGridConsultas.Columns.Clear();
            if(rbCliente.Checked)
            {
                var clientePesquisa = txt_pesquisa.Text;
                var cliente = from Cliente in dc.Clientes
                              where SqlMethods.Like(Cliente.Nome, "%" + clientePesquisa + "%")
                              select Cliente;
                dataGridConsultas.DataSource = cliente.ToList();
            }
            if(rbAnimal.Checked)
            {
                var animalPesquisa = txt_pesquisa.Text;
                var animal = from Animal in dc.Animals
                              where SqlMethods.Like(Animal.Nome, "%" + animalPesquisa + "%")
                              select Animal;
                dataGridConsultas.DataSource = animal.ToList();
            }
            if(rbMedico.Checked)
            {
                var medicoPesquisa = txt_pesquisa.Text;
                var medico = from Medico in dc.Medicos
                             where SqlMethods.Like(Medico.Nome, "%" + medicoPesquisa + "%")
                             select Medico;
                dataGridConsultas.DataSource = medico.ToList();
            }

            dataGridConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            if (txt_pesquisa.Text == "")
            {
                dataGridConsultas.DataSource = dc.Clientes;
                dataGridConsultas.Refresh();
            }
        }

        private void bt_ApagarConsulta_MouseHover(object sender, EventArgs e)
        {
            ToolTip ajuda = new ToolTip();
            ajuda.Show("Selecione uma linha para apagar", bt_ApagarConsulta);
        }

        #region Validações
        private bool DialogAddConsulta()
        {
            DialogResult resposta;

            resposta = MessageBox.Show("Vai marcar uma nova consulta, deseja continuar ?", "Adicionar Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                cb_AddAnimal.SelectedItem = null;
                cb_AddCliente.SelectedItem = null;
                cb_AddMedico.SelectedItem = null;
                cb_AddTratamento.SelectedItem = null;
                cb_AddHora.SelectedItem = null;
                txt_AddNotas.Text = string.Empty;
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
        //--------------------------------------------------------------------------------------------
        //--------------------------------Serviço de Emails-------------------------------------------
        //--------------------------------------------------------------------------------------------
        
        private void CarregarComboEmail()
        {
            cb_MotivoTodos.Items.Add("Notificar Férias");
            cb_MotivoTodos.Items.Add("Notificar Covid");
            cb_MotivoTodos.Items.Add("Motivos de força maior");

            cb_MotivoCliente.Items.Add("Notificação de Consulta");
            cb_MotivoCliente.Items.Add("Desmarcação de Consulta");
            var listaClientes = from Cliente in dc.Clientes select Cliente;
            foreach (Cliente cliente in listaClientes)
            {
                cb_EmailCliente.Items.Add(cliente.Email);
            }
        }
        private void bt_EmailTodos_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            var emailCliente = from Cliente in dc.Clientes select Cliente;
            foreach(Cliente cliente in emailCliente)
            {
                mail.From = new MailAddress("theberserk007@gmail.com" ,"Vet Plus");
                mail.To.Add(new MailAddress(cliente.Email , cliente.Nome));
                mail.Subject = cb_MotivoTodos.Text;
                mail.IsBodyHtml = true;
                mail.BodyEncoding= Encoding.UTF8;

                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new System.Net.NetworkCredential()
                {
                    UserName = "theberserk007@gmail.com",
                    Password = "aokuiwdlmakjbzgy"

                };
                smtp.EnableSsl= true;

                if(cb_MotivoTodos.Text == "Notificar Férias")
                {
                    mail.Body = "Caros Clientes, a Clinica VET PLUS , vai encerrar o mês de Agosto para Férias ." +
                        "Pedimos a sua compreensão e em breve estaremos de volta para cuidar do seu animal de estimação." +
                        "Obrigado. Atenciosamente VET PLUS!";
                }
                if(cb_MotivoTodos.Text == "Notificar Covid")
                {
                    mail.Body = "Caros Clientes, a Clinica VET PLUS , vai encerrar por provaveis caso de Covid. " +
                        "Pedimos a sua compreensão e em breve estaremos de volta para cuidar do seu animal de estimação." +
                        "Obrigado. Atenciosamente VET PLUS!";
                }
                if (cb_MotivoTodos.Text == "Motivos de força maior")
                {
                    mail.Body = "Caros Clientes, a Clinica VET PLUS , vai encerrar por motivos de força maior " +
                        "Pedimos a sua compreensão e em breve estaremos de volta para cuidar do seu animal de estimação" +
                        "Obrigado. Atenciosamente VET PLUS!";
                }
                //else 
                //{
                //    MessageBox.Show("Selecione um motivo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                try
                {
                    smtp.Send(mail);                    
                }catch(Exception ex)
                {
                    MessageBox.Show("Não foram enviados, \n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                MessageBox.Show("Os emails foram enviados", "Emails", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void bt_EmailIndividual_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            
                
                
                mail.From = new MailAddress("theberserk007@gmail.com", "Vet Plus");
                mail.To.Add(new MailAddress(cb_EmailCliente.Text));
                mail.Subject = cb_MotivoCliente.Text;
                mail.IsBodyHtml = true;
                mail.BodyEncoding = Encoding.UTF8;

                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new System.Net.NetworkCredential()
                {
                    UserName = "theberserk007@gmail.com",
                    Password = "aokuiwdlmakjbzgy"

                };
                smtp.EnableSsl = true;
                if(cb_MotivoCliente.Text == "Notificação de Consulta")
                {
                    mail.Body = "Teste";
                }
                if(cb_MotivoCliente.Text == "Desmarcação de Consulta")
                {
                    mail.Body = "Arroz";
                }
                try
                {
                    smtp.Send(mail);
                    MessageBox.Show("O email foi enviado", "Emails", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi enviado o email, \n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }
    }
}
