using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaVET5413.Forms
{
    public partial class PainelCliente : Form
    {
        DataClassesDataContext dc = new DataClassesDataContext();
        public PainelCliente()
        {
            InitializeComponent();
        }
        /// <summary>
        ///  Ao Carregar o Form é instanciado metodos para carregar a dataGridView e as comboBoxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PainelCliente_Load(object sender, EventArgs e)
        {            
            dtp_EditNasci.Format = DateTimePickerFormat.Custom;
            dtp_EditNasci.CustomFormat = "dd/MM/yyyy";
            dtp_AddNasci.Format = DateTimePickerFormat.Custom;
            dtp_AddNasci.CustomFormat = "dd/MM/yyyy";            
            CarregarGrid();
            
        }

        #region Configurações de Butões
        private void bt_AdicionarCliente_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(AddCliente);            
        }

        private void bt_EditarAnimal_Click(object sender, EventArgs e)
        {
            if(dataGridCliente.SelectedRows.Count > 0 )
            {
                tabControl1.SelectTab(EditClient);
                txt_EditID.Text = dataGridCliente.CurrentRow.Cells[0].Value.ToString();
                txt_EditNome.Text= dataGridCliente.CurrentRow.Cells[1].Value.ToString();
                txt_EditNif.Text = dataGridCliente.CurrentRow.Cells[2].Value.ToString();
                txt_EditTele.Text = dataGridCliente.CurrentRow.Cells[3].Value.ToString();
                txt_EditEmail.Text = dataGridCliente.CurrentRow.Cells[4].Value.ToString();                               
                dtp_EditNasci.Text  = dataGridCliente.CurrentRow.Cells[5].Value.ToString();

            }
            else
            {
                MessageBox.Show("Deve selecionar um cliente primeiro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_ApagarCliente_Click(object sender, EventArgs e)
        {
            if(this.dataGridCliente.SelectedRows.Count > 0)
            {
                dataGridCliente.Rows.RemoveAt(this.dataGridCliente.SelectedRows[0].Index);
                dc.SubmitChanges();
            }
            else
            {
                MessageBox.Show("Deve selecionar um cliente primeiro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_AddCliente_Click(object sender, EventArgs e)
        {
            if(Validacoes())
            {
                Cliente cliente = new Cliente
                {
                    Nome = txt_AddNome.Text,
                    NIF = txt_AddNif.Text,
                    Telemovel = txt_AddTele.Text,
                    Email = txt_AddEmail.Text,
                    DataNascimento = dtp_AddNasci.Text                    
                };
                if (DialogAddCliente())
                {
                    dc.Clientes.InsertOnSubmit(cliente);
                    dc.SubmitChanges();
                    DataClassesDataContext reload = new DataClassesDataContext();
                    dataGridCliente.DataSource = reload.Clientes;
                }
            }
        }

        private void bt_EditCliente_Click(object sender, EventArgs e)
        {
            if (ValidacoesEdit())
            {
                dataGridCliente.CurrentRow.Cells[1].Value = txt_EditNome.Text;
                dataGridCliente.CurrentRow.Cells[2].Value = txt_EditNif.Text;
                dataGridCliente.CurrentRow.Cells[3].Value = txt_EditTele.Text;
                dataGridCliente.CurrentRow.Cells[4].Value = txt_EditEmail.Text;                
                dataGridCliente.CurrentRow.Cells[5].Value = dtp_EditNasci.Text;
            }
            if(DialogEditCliente())
            {
                dc.SubmitChanges();
            }       
            
        }
        #endregion

        #region Metodo de Loads       
        public void CarregarGrid()
        {
            dataGridCliente.DataSource = null;
            dataGridCliente.DataSource = dc.Clientes;
            dataGridCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            int getID = 0;
            var listaID = from Cliente in dc.Clientes select Cliente;
            foreach (var cliente in listaID)
            {
                if (cliente.ID > getID)
                {
                    getID = cliente.ID;
                }
            }
            getID += 1;
            txt_AddID.Text = getID.ToString();
        }
        #endregion

        private void txt_pesquisa_TextChanged(object sender, EventArgs e)
        {
            dataGridCliente.DataSource = null;
            dataGridCliente.Refresh();
            dataGridCliente.AutoGenerateColumns = true;
            dataGridCliente.Columns.Clear();
            var clientePesquisa = txt_pesquisa.Text;
            var cliente = from Cliente in dc.Clientes
                         where SqlMethods.Like(Cliente.Nome, "%" + clientePesquisa + "%")
                         select Cliente;
            dataGridCliente.DataSource = cliente.ToList();


            dataGridCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            if (txt_pesquisa.Text == "")
            {
                dataGridCliente.DataSource = dc.Clientes;
                dataGridCliente.Refresh();
            }
        }
        private void bt_ApagarCliente_MouseHover(object sender, EventArgs e)
        {
            ToolTip ajuda = new ToolTip();
            ajuda.Show("Selecione uma linha para apagar", bt_ApagarCliente);
        }

        #region Validacoes
        private bool DialogEditCliente()
        {
            DialogResult resposta;

            resposta = MessageBox.Show("As alterações vão ser implementadas, deseja continuar?", "Editar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                txt_EditNome.Clear();
                txt_EditNif.Clear();
                txt_EditNif.Clear();
                txt_EditTele.Clear();
                txt_EditEmail.Clear();                
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// MessageBox é apresentada quando se insere um novo cliente na GridView e limpa as respetivas TextBoxes e ComboBoxes
        /// </summary>
        private bool DialogAddCliente()
        {
            DialogResult resposta;

            resposta = MessageBox.Show("Vai adicionar um novo cliente deseja continuar?", "Adicionar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes )
            {
                txt_AddNome.Clear();
                txt_AddNif.Clear();                
                txt_AddTele.Clear();
                txt_AddEmail.Clear();               
                return true;
            }
            else  
            {
                return false;
            }
        }
        /// <summary>
        /// Metodo que valida todos os inputs do user para evitar erros na alteração de Dados
        /// </summary>
        /// <returns></returns>
        private bool ValidacoesEdit()
        {
            bool valida = true;
            char testEmail = '@';

            if (string.IsNullOrEmpty(txt_EditNome.Text) || txt_EditNome.Text.All(char.IsDigit))
            {
                MessageBox.Show("Insira o nome do Cliente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_EditNome.Text = string.Empty;
                valida = false;
            }            
            if (string.IsNullOrEmpty(txt_EditNif.Text) || !System.Text.RegularExpressions.Regex.IsMatch(txt_EditNif.Text, "^[0-9]*$") || txt_EditNif.Text.Length != 9)
            {
                MessageBox.Show("Insira o NIF , este deve conter 9 digitos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_EditNif.Text = string.Empty;

                valida = false;
            }
            foreach (Cliente testNif in dc.Clientes)
            {
                if (txt_EditNif.Text == testNif.NIF && txt_EditNome.Text != testNif.Nome)
                {
                    MessageBox.Show($"Já existe um cliente com o NIF {testNif.NIF}, insira um NIF diferente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txt_EditNif.Text = string.Empty;

                    valida = false;
                }
            }
            if (string.IsNullOrEmpty(txt_EditTele.Text) || !System.Text.RegularExpressions.Regex.IsMatch(txt_EditTele.Text, "^[0-9]*$") || txt_EditTele.Text.Length != 9)
            {
                MessageBox.Show("Insira o número de telemóvel corretamente, verifique se o número telefone está dentro dos paramentros nacionais !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_EditTele.Text = string.Empty;
                valida = false;
            }
            if (string.IsNullOrEmpty(txt_EditEmail.Text) || !txt_EditEmail.Text.Contains(Convert.ToString(testEmail)))
            {
                MessageBox.Show("Insira o email corretamente", "Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_EditEmail.Text = string.Empty;
                valida = false;
            }
            return valida;
        }
        
        /// <summary>
        /// Metodo que valida todos os inputs do user para evitar erros na inserção de Dados
        /// </summary>
        /// <returns></returns>
        private bool Validacoes()
        {
            bool valida = true;
            char testEmail = '@';

            if (string.IsNullOrEmpty(txt_AddNome.Text) || txt_AddNome.Text.All(char.IsDigit))
            {
                MessageBox.Show("Insira o nome do Cliente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_AddNome.Text = string.Empty;
                valida = false;
            }            
            if (string.IsNullOrEmpty(txt_AddNif.Text) || !System.Text.RegularExpressions.Regex.IsMatch(txt_AddNif.Text, "^[0-9]*$") || txt_AddNif.Text.Length != 9)
            {
                MessageBox.Show("Insira o NIF , este deve conter 9 digitos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_AddNif.Text = string.Empty;

                valida = false;
            }
            foreach (Cliente testNif in dc.Clientes)
            {
                if (txt_AddNif.Text == testNif.NIF)
                {
                    MessageBox.Show($"Já existe um cliente com o NIF {testNif.NIF}, insira um NIF diferente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txt_AddNif.Text = string.Empty;

                    valida = false;
                }
            }
            if (string.IsNullOrEmpty(txt_AddTele.Text) || !System.Text.RegularExpressions.Regex.IsMatch(txt_AddTele.Text, "^[0-9]*$") || txt_AddTele.Text.Length != 9)
            {
                MessageBox.Show("Insira o número de telemóvel corretamente, verifique se o número telefone está dentro dos paramentros nacionais !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_AddTele.Text = string.Empty;
                valida = false;
            }
            if (string.IsNullOrEmpty(txt_AddEmail.Text) || !txt_AddEmail.Text.Contains(Convert.ToString(testEmail)))
            {
                MessageBox.Show("Insira o email corretamente", "Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_AddEmail.Text = string.Empty;
                valida = false;
            }
            return valida;
        }
        #endregion

    }
}
