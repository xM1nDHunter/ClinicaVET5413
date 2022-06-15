using ClinicaVET5413.Modelos;
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
        #region Consulta CRUD
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
            CarregarColumnsNames();
            CarregarGrid();
            CarregarComboEmail();
            CarregarComboFatura();
            CheckDailyMails();
            //CarregarComboFatura();
            //ServiçoFatura();
        }

        #region Configuraçõse de Butões
        private void bt_AdicionarConsulta_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(AddConsulta);
        }
        private void bt_AddConsulta_Click(object sender, EventArgs e)
        {
            //Pesquisa na base de dados do medicos para ir buscar o ID do medico selecionado
            int getIDMedico = 0;
            var allmedic = from Medico in dc.Medicos select Medico;

            foreach (var medic in allmedic)
            {
                if (medic.Nome == cb_AddMedico.SelectedItem.ToString())
                {
                    getIDMedico = medic.ID;
                }
            }


            //Pesquisa na base de dados do cliente para ir buscar o ID do cliente selecionado
            int getIDCliente = 0;
            var allCliente = from Cliente in dc.Clientes select Cliente;

            foreach (var cli in allCliente)
            {
                if (cli.Nome == cb_AddCliente.SelectedItem.ToString())
                {
                    getIDCliente = cli.ID;
                }
            }
            //Pesquisa na base de dados do animal para ir buscar o ID do animal selecionado
            int getIDAnimal = 0;
            var allAnimal = from Animal in dc.Animals select Animal;

            foreach (var ani in allAnimal)
            {
                if (ani.Nome == cb_AddAnimal.SelectedItem.ToString())
                {
                    getIDAnimal = ani.ID;
                }
            }

            if (Validacoes())
            {
                Consulta consulta = new Consulta
                {
                    Medico = getIDMedico,
                    Cliente = getIDCliente,
                    Animal = getIDAnimal,
                    Tratamento = cb_AddTratamento.Text,
                    DiaConsulta = dtp_AddDia.Text,
                    HoraConsulta = cb_AddHora.Text,
                    Notas = txt_AddNotas.Text
                };

                if (DialogAddConsulta())
                {
                    dc.Consultas.InsertOnSubmit(consulta);
                    dc.SubmitChanges();
                    CarregarGrid();
                    EmailService(consulta);
                }

            }
        }

        private void bt_EditarConsulta_Click(object sender, EventArgs e)
        {
            if (dataGridConsultas.SelectedRows.Count > 0)
            {
                tabControl1.SelectTab(EditConsulta);
                txt_EditID.Text = dataGridConsultas.CurrentRow.Cells[0].Value.ToString();
                cb_EditMedico.Text = dataGridConsultas.CurrentRow.Cells[1].Value.ToString();
                cb_EditCliente.Text = dataGridConsultas.CurrentRow.Cells[2].Value.ToString();
                cb_EditAnimal.Text = dataGridConsultas.CurrentRow.Cells[3].Value.ToString();
                cb_EditTratamento.Text = dataGridConsultas.CurrentRow.Cells[4].Value.ToString();
                dtp_EditDia.Text = dataGridConsultas.CurrentRow.Cells[5].Value.ToString();
                cb_EditHora.Text = dataGridConsultas.CurrentRow.Cells[6].Value.ToString();
                txt_EditNotas.Text = dataGridConsultas.CurrentRow.Cells[7].Value.ToString();
            }
            else
            {
                MessageBox.Show("Deve selecionar uma consulta primeiro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bt_EditConsulta_Click(object sender, EventArgs e)
        {
            dataGridConsultas.CurrentRow.Cells[0].Value = txt_EditID.Text;
            dataGridConsultas.CurrentRow.Cells[1].Value = cb_EditMedico.Text;
            dataGridConsultas.CurrentRow.Cells[2].Value = cb_EditCliente.Text;
            dataGridConsultas.CurrentRow.Cells[3].Value = cb_EditAnimal.Text;
            dataGridConsultas.CurrentRow.Cells[4].Value = cb_EditTratamento.Text;
            dataGridConsultas.CurrentRow.Cells[5].Value = dtp_EditDia.Text;
            dataGridConsultas.CurrentRow.Cells[6].Value = cb_EditHora.Text;
            dataGridConsultas.CurrentRow.Cells[7].Value = txt_EditNotas.Text;
            if(DialogEditConsulta())
            {
                //Pesquisa na base de dados do medicos para ir buscar o ID do medico selecionado
                int getIDMedico = 0;
                var allmedic = from Medico in dc.Medicos select Medico;

                foreach (var medic in allmedic)
                {
                    if (medic.Nome == cb_EditMedico.SelectedItem.ToString())
                    {
                        getIDMedico = medic.ID;
                    }
                }
                //Pesquisa na base de dados do cliente para ir buscar o ID do cliente selecionado
                int getIDCliente = 0;
                var allCliente = from Cliente in dc.Clientes select Cliente;

                foreach (var cli in allCliente)
                {
                    if (cli.Nome == cb_EditCliente.SelectedItem.ToString())
                    {
                        getIDCliente = cli.ID;
                    }
                }
                //Pesquisa na base de dados do animal para ir buscar o ID do animal selecionado
                int getIDAnimal = 0;
                var allAnimal = from Animal in dc.Animals select Animal;

                foreach (var ani in allAnimal)
                {
                    if (ani.Nome == cb_EditAnimal.SelectedItem.ToString())
                    {
                        getIDAnimal = ani.ID;
                    }
                }
                
                Consulta edit = dc.Consultas.Single(consulta => consulta.ID == Convert.ToInt32(txt_EditID.Text));
                edit.Medico = getIDMedico;
                edit.Cliente = getIDCliente;
                edit.Animal = getIDAnimal;
                edit.Tratamento = cb_EditTratamento.Text;                
                edit.DiaConsulta = dtp_EditDia.Text;
                edit.HoraConsulta = cb_EditHora.Text;
                edit.Notas = txt_EditNotas.Text;
                dc.SubmitChanges();
                EmailUpdateService(edit);
                txt_EditID.Text = string.Empty;
                cb_EditMedico.SelectedItem = null;
                cb_EditCliente.SelectedItem = null;
                cb_EditAnimal.SelectedItem = null;
                cb_EditTratamento.SelectedItem = null;
                cb_EditHora.SelectedItem = null;
                txt_EditNotas.Text = string.Empty;
            }
        }

        private void bt_ApagarConsulta_Click(object sender, EventArgs e)
        {
            int getID = Convert.ToInt32(dataGridConsultas.CurrentRow.Cells[0].Value);
            Consulta delete = dc.Consultas.Single(consulta => consulta.ID == getID);
            dc.Consultas.DeleteOnSubmit(delete);
            dc.SubmitChanges();
            EmailDeleteService(delete);
            dataGridConsultas.Rows.RemoveAt(dataGridConsultas.CurrentRow.Index);
        }
        private void bt_PesquisarConsulta_Click(object sender, EventArgs e)
        {
            //if (rbCliente.Checked)
            //{
                 
            //}
            //if (rbAnimal.Checked)
            //{
            //    foreach (DataGridViewRow linha in dataGridConsultas.Rows)
            //    {

            //        if (linha.Cells[3].Value.ToString() == "%" + txt_pesquisa.Text + "%")
            //        {
            //            linha.Visible = true;
            //        }
            //        else
            //            linha.Visible = false;
            //    }
            //}
            //if (rbMedico.Checked)
            //{
            //    foreach (DataGridViewRow linha in dataGridConsultas.Rows)
            //    {

            //        if (linha.Cells[1].Value.ToString() == "%" + txt_pesquisa.Text + "%")
            //        {
            //            linha.Visible = true;
            //        }
            //        else
            //            linha.Visible = false;
            //    }
            //}

            //dataGridConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //if (txt_pesquisa.Text == "")
            //{
            //    CarregarColumnsNames();
            //    CarregarGrid();
            //    dataGridConsultas.Refresh();
            //}
        }
        #endregion

        #region Metodos de Loads
        public void CarregarGrid()
        {
            dataGridConsultas.DataSource = null;

            int linha = 0;
            var loadConsultas = from Consulta in dc.Consultas select Consulta;
            foreach (Consulta consulta in loadConsultas)
            {
                //
                string getNomeMedico = "";
                var allmedic = from Medico in dc.Medicos select Medico;

                foreach (var medic in allmedic)
                {
                    if (medic.ID == consulta.Medico)
                    {
                        getNomeMedico = medic.Nome;
                    }
                }
                //
                string getNomeCliente = "";
                var allCliente = from Cliente in dc.Clientes select Cliente;

                foreach (var cli in allCliente)
                {
                    if (cli.ID == consulta.Cliente)
                    {
                        getNomeCliente = cli.Nome;
                    }
                }
                //
                string getNomeAnimal = "";
                var allAnimal = from Animal in dc.Animals select Animal;

                foreach (var ani in allAnimal)
                {
                    if (ani.ID == consulta.Animal)
                    {
                        getNomeAnimal = ani.Nome;
                    }
                }


                DataGridViewRow novaLinha = new DataGridViewRow();
                dataGridConsultas.Rows.Add(novaLinha);

                dataGridConsultas.Rows[linha].Cells[0].Value = consulta.ID;
                dataGridConsultas.Rows[linha].Cells[1].Value = getNomeMedico;
                dataGridConsultas.Rows[linha].Cells[2].Value = getNomeCliente;
                dataGridConsultas.Rows[linha].Cells[3].Value = getNomeAnimal;
                dataGridConsultas.Rows[linha].Cells[4].Value = consulta.Tratamento;
                dataGridConsultas.Rows[linha].Cells[5].Value = consulta.DiaConsulta;
                dataGridConsultas.Rows[linha].Cells[6].Value = consulta.HoraConsulta;
                dataGridConsultas.Rows[linha].Cells[7].Value = consulta.Notas;
                linha++;
            }
            dataGridConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //GetId para a tab de adicionar Clientes
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

        /// <summary>
        /// Carrega os nomes dos headers
        /// </summary>
        public void CarregarColumnsNames()
        {

            dataGridConsultas.Columns.Add("colID", "ID");
            dataGridConsultas.Columns.Add("colMedico", "Médico");
            dataGridConsultas.Columns.Add("colCliente", "Cliente");
            dataGridConsultas.Columns.Add("colAnimal", "Animal");
            dataGridConsultas.Columns.Add("colTratamento", "Tratamento");
            dataGridConsultas.Columns.Add("colDiaConsulta", "Dia da Consulta");
            dataGridConsultas.Columns.Add("colHoraConsulta", "Hora da Consulta");
            dataGridConsultas.Columns.Add("colNotas", "Notas");
        }
        public void CarregarComboBoxes()
        {
            //var listaMedico = dc.Medicos.ToList();
            //foreach (Medico medico in listaMedico)
            //{
            //    cb_AddMedico.Items.Add(medico.Nome);
            //    cb_EditMedico.Items.Add(medico.Nome);
            //}
            var listaCliente = dc.Clientes.ToList();
            foreach (Cliente cliente in listaCliente)
            {
                cb_AddCliente.Items.Add(cliente.Nome);
                cb_EditCliente.Items.Add(cliente.Nome);
            }
            cb_AddTratamento.Items.Add("Vacinas");
            cb_AddTratamento.Items.Add("Check-Up mensal");
            cb_AddTratamento.Items.Add("Castração");
            cb_AddTratamento.Items.Add("Operação");
            cb_AddTratamento.Items.Add("Cardiologia");
            cb_AddTratamento.Items.Add("Fisioterapia");

            cb_EditTratamento.Items.Add("Vacinas");
            cb_EditTratamento.Items.Add("Check-Up mensal");
            cb_EditTratamento.Items.Add("Castração");
            cb_EditTratamento.Items.Add("Operação");
            cb_EditTratamento.Items.Add("Cardiologia");
            cb_EditTratamento.Items.Add("Fisioterapia");

            cb_AddHora.Items.Add("09h00-10h00");
            cb_AddHora.Items.Add("10h00-11h00");
            cb_AddHora.Items.Add("11h00-12h00");
            cb_AddHora.Items.Add("14h00-15h00");
            cb_AddHora.Items.Add("15h00-16h00");
            cb_AddHora.Items.Add("16h00-17h00");
            cb_AddHora.Items.Add("17h00-18h00");

            cb_EditHora.Items.Add("09h00-10h00");
            cb_EditHora.Items.Add("10h00-11h00");
            cb_EditHora.Items.Add("11h00-12h00");
            cb_EditHora.Items.Add("14h00-15h00");
            cb_EditHora.Items.Add("15h00-16h00");
            cb_EditHora.Items.Add("16h00-17h00");
            cb_EditHora.Items.Add("17h00-18h00");
        }

        /// <summary>
        /// Ao selecionar um cliente na comboBox, os animais deste cliente são carregados para a comboBox dos animais
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_AddCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_AddAnimal.Items.Clear();
            var clientePesquisa = cb_AddCliente.Text;
            var ani = from Animal in dc.Animals
                         where SqlMethods.Like(Animal.Dono, "%" + clientePesquisa + "%")
                         select Animal;
            foreach(Animal pop in ani)
            {
                cb_AddAnimal.Items.Add(pop.Nome);
            }

        }
        private void cb_EditCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_EditAnimal.Items == null)
            {
               MessageBox.Show("Por favor confirme o Cliente, antes de prosseguir!", "Confirme o Cliente",MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
            else 
            {
                cb_EditAnimal.Items.Clear();
                var clientePesquisa = cb_EditCliente.Text;
                var animal = from Animal in dc.Animals
                             where SqlMethods.Like(Animal.Dono, "%" + clientePesquisa + "%")
                             select Animal;
                foreach (Animal pop in animal)
                {
                    cb_EditAnimal.Items.Add(pop.Nome);
                }
            }
        }
        /// <summary>
        /// Apos selecionar o cliente e obter a lista de animais do cliente, este metodo vai carregar os médicos com especialidade do tipo do animal selecionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_AddAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_AddMedico.Items.Clear();
            var animalPesquisa = cb_AddAnimal.Text;
            string getEspecie = "";
            var listaAni = from Animal in dc.Animals select Animal;
            foreach(Animal ani in listaAni)
            {
                if(ani.Nome == cb_AddAnimal.Text)
                {
                    getEspecie = ani.Especie;
                }
            }
            var med = from Medico in dc.Medicos
                      where SqlMethods.Like(Medico.TipoAnimal, "%" + getEspecie + "%")
                      select Medico;
            foreach (Medico pop in med)
            {
                cb_AddMedico.Items.Add(pop.Nome);
            }
        }

        private void cb_EditAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_AddMedico.Items.Clear();
            var animalPesquisa = cb_EditAnimal.Text;
            string getEspecie = "";
            var listaAni = from Animal in dc.Animals select Animal;
            foreach (Animal ani in listaAni)
            {
                if (ani.Nome == cb_EditAnimal.Text)
                {
                    getEspecie = ani.Especie;
                }
            }
            var med = from Medico in dc.Medicos
                      where SqlMethods.Like(Medico.TipoAnimal, "%" + getEspecie + "%")
                      select Medico;
            foreach (Medico pop in med)
            {
                cb_EditMedico.Items.Add(pop.Nome);
            }
        }


        #endregion        
        
        #region Extras
        

        private void bt_ApagarConsulta_MouseHover(object sender, EventArgs e)
        {
            ToolTip ajuda = new ToolTip();
            ajuda.Show("Selecione uma linha para apagar", bt_ApagarConsulta);
        }
        
        /// <summary>
        /// Recebe informação da nova consulta adicionada e notifica o cliente via e-mail 
        /// </summary>
        /// <param name="consulta"></param>        
        private void EmailDeleteService(Consulta consulta)
        {
            Consulta getConsulta = new Consulta();
            getConsulta = consulta;

            MailMessage mail = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            //Obter nome para destinatario
            string nome = "";
            string email = "";
            string nomeMed = "";
            string emailMed = "";
            var listaClientes = from Cliente in dc.Clientes select Cliente;
            foreach (var getInfoCliente in listaClientes)
            {

                if (getInfoCliente.ID == consulta.Cliente)
                {
                    nome = getInfoCliente.Nome;
                    email = getInfoCliente.Email;
                }
            }
            var listaMeds = from Medico in dc.Medicos select Medico;
            foreach (var getInfoMed in listaMeds)
            {
                if (getInfoMed.ID == consulta.Medico)
                {
                    nomeMed = getInfoMed.Nome;
                    emailMed = getInfoMed.Email;
                }
            }



            mail.From = new MailAddress("theberserk007@gmail.com", "Vet Plus");
            mail.To.Add(new MailAddress(email, nome));
            mail.CC.Add(new MailAddress(emailMed, nomeMed));
            mail.Subject = "Consulta Vet Plus";
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

            mail.Body = $"Obrigado por escolher a Vet Plus Sr.(a){nome}, <br> <br>" +
                $"A sua consulta de {consulta.Tratamento} marcada para dia : {consulta.DiaConsulta} entre {consulta.HoraConsulta} foi cancelada, para mais informações contacte diretamente com a clinica! !<br>" +
                $"Obrigado pela sua preferencia! <br> <br> Atenciosamente,<br>VET PLUS";

            try
            {
                smtp.Send(mail);
                MessageBox.Show("O email foi enviado para o cliente", "Emails", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi enviado o email, pórem a consulta foi marcada no sistema!(Utilize a aba de Email para reenviar o email) \n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmailUpdateService(Consulta consulta)
        {
            Consulta getConsulta = new Consulta();
            getConsulta = consulta;

            MailMessage mail = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            //Obter nome para destinatario
            string nome = "";
            string email = "";
            string nomeMed = "";
            string emailMed = "";
            var listaClientes = from Cliente in dc.Clientes select Cliente;
            foreach (var getInfoCliente in listaClientes)
            {

                if (getInfoCliente.ID == consulta.Cliente)
                {
                    nome = getInfoCliente.Nome;
                    email = getInfoCliente.Email;
                }
            }

            var listaMeds = from Medico in dc.Medicos select Medico;
            foreach (var getInfoMed in listaMeds)
            {
                if(getInfoMed.ID == consulta.Medico)
                {
                    nomeMed = getInfoMed.Nome;
                    emailMed = getInfoMed.Email;
                }
            }

            mail.From = new MailAddress("theberserk007@gmail.com", "Vet Plus");
            mail.To.Add(new MailAddress(email, nome));
            mail.CC.Add(new MailAddress(emailMed,nomeMed));
            mail.Subject = "Alteração da sua Consulta";
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

            mail.Body = $"Obrigado por escolher a Vet Plus Sr.(a){nome}, <br> <br>" +
                $"A sua consulta foi alterada , o tratamento será {consulta.Tratamento} e foi marcado para dia : {consulta.DiaConsulta} entre {consulta.HoraConsulta}. Deve comparecer 15 min antes !<br>" +
                $"Obrigado pela sua preferencia! <br> <br> Atenciosamente,<br>VET PLUS";

            try
            {
                smtp.Send(mail);
                MessageBox.Show("O email foi enviado para o cliente", "Emails", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi enviado o email, pórem a consulta foi marcada no sistema!(Utilize a aba de Email para reenviar o email) \n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmailService(Consulta consulta)
        {
            Consulta getConsulta = new Consulta();
            getConsulta = consulta;

            MailMessage mail = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            //Obter nome para destinatario
            string nome = "";
            string email = "";
            string nomeMed = "";
            string emailMed = "";
            var listaClientes = from Cliente in dc.Clientes select Cliente;
            foreach (var getInfoCliente in listaClientes)
            {

                if (getInfoCliente.ID == consulta.Cliente)
                {
                    nome = getInfoCliente.Nome;
                    email = getInfoCliente.Email;
                }
            }
            var listaMeds = from Medico in dc.Medicos select Medico;
            foreach (var getInfoMed in listaMeds)
            {
                if (getInfoMed.ID == consulta.Medico)
                {
                    nomeMed = getInfoMed.Nome;
                    emailMed = getInfoMed.Email;
                }
            }



            mail.From = new MailAddress("theberserk007@gmail.com", "Vet Plus");
            mail.To.Add(new MailAddress(email, nome));
            mail.CC.Add(new MailAddress(emailMed, nomeMed));
            mail.Subject = "Consulta Vet Plus";
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
            
            mail.Body = $"Obrigado por escolher a Vet Plus Sr.(a){nome}, <br> <br>" +
                $"A sua consulta de {consulta.Tratamento} foi confirmada e marcada para dia : {consulta.DiaConsulta} entre {consulta.HoraConsulta}. Deve comparecer 15 min antes !<br>" +
                $"Obrigado pela sua preferencia! <br> <br> Atenciosamente,<br>VET PLUS";            
            
            try
            {
                smtp.Send(mail);
                MessageBox.Show("O email foi enviado para o cliente", "Emails", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi enviado o email, pórem a consulta foi marcada no sistema!(Utilize a aba de Email para reenviar o email) \n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Validações
        private bool Validacoes()
        {
            bool valida = true;
            var listaconsulta = from Consulta in dc.Consultas select Consulta;
            foreach(var teste in listaconsulta)
            {
                int getIDMedico = 0;
                var allmedic = from Medico in dc.Medicos select Medico;
                foreach (var medic in allmedic)
                {
                    if (medic.Nome == cb_AddMedico.SelectedItem.ToString())
                    {
                        getIDMedico = medic.ID;
                    }
                }
                if (teste.DiaConsulta == dtp_AddDia.Text && teste.HoraConsulta == cb_AddHora.Text && teste.Medico == getIDMedico)
                {
                    MessageBox.Show($"Deve escolher um dia ou hora em que o/a Médico/a {cb_AddMedico.SelectedItem.ToString()} que esteja disponivel!\n O dia {teste.DiaConsulta} na hora {teste.HoraConsulta} já se encontra reservado ! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cb_AddHora.SelectedItem = null;
                    valida = false;
                }
            }
            return valida;
        }
        private bool DialogEditConsulta()
        {
            DialogResult resposta;

            resposta = MessageBox.Show("As alterações vão ser implementadas, deseja continuar?", "Editar Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                return true;
            }
            else { return false; }
        }
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

        #endregion

        //--------------------------------------------------------------------------------------------
        //--------------------------------Serviço de Emails-------------------------------------------
        //--------------------------------------------------------------------------------------------
        #region Emails
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
            foreach (Cliente cliente in emailCliente)
            {
                mail.From = new MailAddress("theberserk007@gmail.com", "Vet Plus");
                mail.To.Add(new MailAddress(cliente.Email, cliente.Nome));
                mail.Subject = cb_MotivoTodos.Text;
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

                if (cb_MotivoTodos.Text == "Notificar Férias")
                {
                    mail.Body = $"Caros Clientes, a Clinica VET PLUS , vai encerrar o mês de Agosto para Férias {Environment.NewLine} ." +
                        "Pedimos a sua compreensão e em breve estaremos de volta para cuidar do seu animal de estimação." +
                        "Obrigado. Atenciosamente VET PLUS!";
                }
                if (cb_MotivoTodos.Text == "Notificar Covid")
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foram enviados, \n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            MessageBox.Show("Os emails foram enviados", "Emails", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void bt_EmailIndividual_Click(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Sempre que o form consulta inicia é verificado se existem consultas para dia seguinte e todos os clientes com marcações para dia seguinte são notificados!
        /// </summary>
        private void CheckDailyMails()
        {
            if (dataGridConsultas.Columns.Count > 0)
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                //Obter nome para destinatario
                string nome = "";
                string email = "";
                string nconsulta = "";
                string hora = "";
                string tratamento = "";
                var listaClientes = from Cliente in dc.Clientes select Cliente;
                var listaConsultas = from Consultas in dc.Consultas select Consultas;

                foreach (Consulta con in listaConsultas)
                {
                    DateTime comp = Convert.ToDateTime(con.DiaConsulta);
                    DateTime hoje = DateTime.Now;
                    int teste = Convert.ToInt32(hoje.Day - comp.Day);
                    int getID = 0;

                    if (comp.Year == hoje.Year && comp.Month == hoje.Month && teste == -1)
                    {
                        getID = con.Cliente;
                        hora = con.HoraConsulta;
                        tratamento = con.Tratamento;
                        nconsulta = Convert.ToString(con.ID);
                    }
                    foreach (Cliente cli in listaClientes)
                    {
                        if (cli.ID == getID)
                        {
                            nome = cli.Nome;
                            email = cli.Email;
                        }
                    }
                    if (nome != "" && email != "")
                    {
                        mail.From = new MailAddress("theberserk007@gmail.com", "Vet Plus");
                        mail.To.Add(new MailAddress(email, nome));
                        mail.Subject = "Notificação de Consulta nº" + nconsulta;
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
                        mail.Body = $"Bom Dia Sr.(a) {nome},<br><br> Vemos por este meio notificar que amanhã no hórario {hora} para o tratamento : {tratamento}.<br><br>" +
                            $"Obrigado pela sua preferencia,<br><br>VET PLUS.";
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
        }



        #endregion

        //--------------------------------------------------------------------------------------------
        //--------------------------------Serviço de Faturas------------------------------------------
        //--------------------------------------------------------------------------------------------
        #region Serviço faturas Incompleto
        #region variaveis 
        double preçoServiço = 0;        
        double total = 0;
        #endregion
        private void CarregarComboFatura()
        {
            cb_faturaServiço.Items.Add("Consulta Básica");
            cb_faturaServiço.Items.Add("Consulta Especifica");
            cb_faturaServiço.Items.Add("Vacina Leucemia felina");
            cb_faturaServiço.Items.Add("Vacina Raiva");
            cb_faturaServiço.Items.Add("Vacina para complexo respiratorio");
            cb_faturaServiço.Items.Add("Vacina Leishmanionse");
            cb_faturaServiço.Items.Add("Vacina tosse do canil");
            cb_faturaServiço.Items.Add("Vacina para febre da carraça");
            cb_faturaServiço.Items.Add("Estadia simples");
            cb_faturaServiço.Items.Add("Estadia com vistoria médica");
            cb_faturaServiço.Items.Add("Operação simples");
            cb_faturaServiço.Items.Add("Operação de urgência");

            
            var cliente = from Cliente in dc.Clientes select Cliente;
            foreach (Cliente getNome in cliente)
            {
                cb_faturaCliente.Items.Add(getNome.Nome);
            }
        }

        private void Contas()
        {
            if(cb_faturaServiço.Text == "Consulta Básica")
            {
                preçoServiço = 25;
            }
            if (cb_faturaServiço.Text == "Consulta Especifica")
            {
                preçoServiço = 45;
            }
            if (cb_faturaServiço.Text == "Vacina Leucemia felina")
            {
                preçoServiço = 35;
            }
            if (cb_faturaServiço.Text == "Vacina Raiva")
            {
                preçoServiço = 15;
            }
            if (cb_faturaServiço.Text == "Vacina para complexo respiratorio")
            {
                preçoServiço = 29;
            }
            if (cb_faturaServiço.Text == "Vacina Leishmanionse")
            {
                preçoServiço = 34;
            }
            if (cb_faturaServiço.Text == "Vacina tosse do canil")
            {
                preçoServiço = 48;
            }
            if (cb_faturaServiço.Text == "Vacina para febre da carraça")
            {
                preçoServiço = 25;
            }
            if (cb_faturaServiço.Text == "Estadia simples")
            {
                preçoServiço = 50;
            }
            if (cb_faturaServiço.Text == "Estadia com vistoria médica")
            {
                preçoServiço = 95;
            }
            if (cb_faturaServiço.Text == "Operação simples")
            {
                preçoServiço = 65;
            }
            if (cb_faturaServiço.Text == "Operação de urgência")
            {
                preçoServiço = 150;
            }

        }

        int Id = 1;
        //Criar uma DataTable para que os dados da DataGridView sejam guardados sem necessidade de aceder a DB
        //Uma vez que não é necessario guardar a fatura torna-se mais prático
        DataTable dt = new DataTable();

        /// <summary>
        /// Metodo para Criar uma nova linha na DataGridFaturas
        /// </summary>
        public void CriarRow()
        {
            if(dt.Rows.Count<=0)
            {
                Contas();
                dt.Columns.Add("ID");
                dt.Columns.Add("Serviço");
                dt.Columns.Add("Preço");
                dt.Columns.Add("Quantidade");
                dt.Columns.Add("Dono");
                dt.Columns.Add("Animal");

                dt.Rows.Add(Id, cb_faturaServiço.Text, preçoServiço, txt_faturaQuantidade.Text, cb_faturaCliente.Text, cb_faturaAnimal.Text);
                dataGridFaturas.DataSource = dt;
                total += preçoServiço;
                txt_faturaTotal.Text = Convert.ToString(total);
                Id++;
            }
            else 
            {
                Contas();
                dt.Rows.Add(Id, cb_faturaServiço.Text, preçoServiço, txt_faturaQuantidade.Text, cb_faturaCliente.Text, cb_faturaAnimal.Text);
                dataGridFaturas.DataSource = dt;
                total += preçoServiço;
                txt_faturaTotal.Text = Convert.ToString(total);
                Id++;
            }
        }
        private void bt_addFatura_Click(object sender, EventArgs e)
        {
            CriarRow();            
        }

        private void bt_removeFatura_Click(object sender, EventArgs e)
        {
            if(dataGridFaturas.SelectedRows.Count > 0)
            {
                total = Convert.ToInt32(txt_faturaTotal.Text);            
                double menos=0;
                menos = Convert.ToDouble(dataGridFaturas.CurrentRow.Cells[2].Value);
                txt_faturaTotal.Text = Convert.ToString(total -= menos); 
                dataGridFaturas.Rows.RemoveAt(dataGridFaturas.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("Deve Selecionar primeiro o serviço a apagar!","Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cb_faturaCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_faturaAnimal.Items.Clear();
            var clientePesquisa = cb_faturaCliente.Text;
            var ani = from Animal in dc.Animals
                      where SqlMethods.Like(Animal.Dono, "%" + clientePesquisa + "%")
                      select Animal;
            foreach (Animal pop in ani)
            {
                cb_faturaAnimal.Items.Add(pop.Nome);
            }
        }

        private void bt_faturaPrint_Click(object sender, EventArgs e)
        {
            string email = "";
            string nome = "";
            string total = "";
            string troco = "";
            
            var listaClientes = from Cliente in dc.Clientes select Cliente;
            foreach (Cliente getNome in listaClientes)
            {

                if (getNome.Nome == cb_faturaCliente.Text)
                {
                    nome = getNome.Nome;
                    email = getNome.Email;
                }
            }


            total = txt_faturaTotal.Text;
            troco = Convert.ToString(Convert.ToDouble(txt_faturaDinheiroEntregue.Text) - Convert.ToDouble(txt_faturaTotal.Text));

            frmPrint frmPrint = new frmPrint(dt,email,nome,total,troco);
            frmPrint.Show();            
        }



        #endregion

    }
}
