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
    public partial class PainelMedico : Form
    {
        DataClassesDataContext dc = new DataClassesDataContext();
        public PainelMedico()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Ao Carregar o Form é instanciado metodos para carregar a dataGridView e as comboBoxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PainelMedico_Load(object sender, EventArgs e)
        {
            CarregarComboBoxes();
            CarregarGrid();            
        }
        
        
        #region Metodos de Loads
        private void CarregarComboBoxes()
        {
            cb_salaObs.Items.Add("1- Felídeos");
            cb_salaObs.Items.Add("2- Aves");
            cb_salaObs.Items.Add("3- Reptil");
            cb_salaObs.Items.Add("4- Canídeos");
            
            cb_tipoAnimal.Items.Add("Felídeos");
            cb_tipoAnimal.Items.Add("Ave");
            cb_tipoAnimal.Items.Add("Reptil");
            cb_tipoAnimal.Items.Add("Canídeos");

            cb_EditSalaObs.Items.Add("1- Felídeos");
            cb_EditSalaObs.Items.Add("2- Aves");
            cb_EditSalaObs.Items.Add("3- Reptil");
            cb_EditSalaObs.Items.Add("4- Canídeos");

            cb_EditTipoAnimal.Items.Add("Felídeos");
            cb_EditTipoAnimal.Items.Add("Ave");
            cb_EditTipoAnimal.Items.Add("Reptil");
            cb_EditTipoAnimal.Items.Add("Canídeos");
        }

        /// <summary>
        /// Carrega a GridView com os dados da DB
        /// </summary>
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
        #endregion


        #region Configurações de Butões

        private void bt_Adicionar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(AddMed);
        }

        private void bt_Editar_Click(object sender, EventArgs e)
        {            
            if (dataGridMedico.SelectedRows.Count == 0)
            {
                MessageBox.Show("Deve selecionar um medico primeiro!", "Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tabControl1.SelectTab(EditMed);            
                txt_EditID.Text = dataGridMedico.CurrentRow.Cells[0].Value.ToString();
                txt_EditNome.Text = dataGridMedico.CurrentRow.Cells[1].Value.ToString();
                cb_EditTipoAnimal.Text = dataGridMedico.CurrentRow.Cells[2].Value.ToString();
                txt_EditNif.Text = dataGridMedico.CurrentRow.Cells[3].Value.ToString();
                txt_EditTele.Text = dataGridMedico.CurrentRow.Cells[4].Value.ToString();
                txt_EditEmail.Text = dataGridMedico.CurrentRow.Cells[5].Value.ToString();
                cb_EditSalaObs.Text = dataGridMedico.CurrentRow.Cells[6].Value.ToString();                
            }
        }

        private void bt_Apagar_Click(object sender, EventArgs e)
        {           
            if (this.dataGridMedico.SelectedRows.Count > 0)
            {
                dataGridMedico.Rows.RemoveAt(this.dataGridMedico.SelectedRows[0].Index);
                dc.SubmitChanges();
            }
            else 
            {
                MessageBox.Show("Deve selecionar um medico primeiro!", "Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_addMedic_Click(object sender, EventArgs e)
        {
            if(Validacoes())
            {
                Medico medico = new Medico
                {
                    Nome = txt_AddMedico.Text,
                    TipoAnimal = cb_tipoAnimal.Text,
                    NIF = txt_AddNif.Text,
                    Telemovel = txt_AddTele.Text,
                    Email = txt_AddEmail.Text,
                    SalaObs= cb_salaObs.Text                    
                };
                if(DialogAddMedico())
                {
                    dc.Medicos.InsertOnSubmit(medico);
                    dc.SubmitChanges();
                    txt_AddMedico.Clear();
                    cb_tipoAnimal.SelectedItem = null;
                    txt_AddNif.Clear();
                    txt_AddTele.Clear();
                    txt_AddEmail.Clear();
                    cb_salaObs.SelectedItem = null;
                    DataClassesDataContext reload = new DataClassesDataContext();
                    dataGridMedico.DataSource = reload.Medicos;
                }
            }
        }
        private void bt_EditMedico_Click(object sender, EventArgs e)
        {
            if(ValidacoesEdit())
            {
                if (DialogEditMedico())
                {
                    dataGridMedico.CurrentRow.Cells[1].Value = txt_EditNome.Text;
                    dataGridMedico.CurrentRow.Cells[2].Value = cb_EditTipoAnimal.Text;
                    dataGridMedico.CurrentRow.Cells[3].Value = txt_EditNif.Text;
                    dataGridMedico.CurrentRow.Cells[4].Value = txt_EditTele.Text;
                    dataGridMedico.CurrentRow.Cells[5].Value = txt_EditEmail.Text;
                    dataGridMedico.CurrentRow.Cells[6].Value = cb_EditSalaObs.Text;
                    dc.SubmitChanges();
                    txt_EditNome.Clear();
                    txt_EditNif.Clear();
                    txt_EditNif.Clear();
                    txt_EditTele.Clear();
                    txt_EditEmail.Clear();
                    cb_EditSalaObs.SelectedItem = null;
                    cb_EditTipoAnimal.SelectedItem = null;
                }
            }

        }

        #endregion

        private void txt_pesquisa_TextChanged(object sender, EventArgs e)
        {
            dataGridMedico.DataSource = null;
            dataGridMedico.Refresh();
            dataGridMedico.AutoGenerateColumns = true;
            dataGridMedico.Columns.Clear();
            var medicoPesquisa = txt_pesquisa.Text;
            var medico = from Medico in dc.Medicos
                         where SqlMethods.Like(Medico.Nome, "%" + medicoPesquisa + "%")
                         select Medico;
            dataGridMedico.DataSource = medico.ToList();


            dataGridMedico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            if (txt_pesquisa.Text == "")
            {
                dataGridMedico.DataSource = dc.Medicos;
                dataGridMedico.Refresh();
            }
        }

        private void bt_Apagar_MouseHover(object sender, EventArgs e)
        {
            ToolTip ajuda = new ToolTip();
            ajuda.Show("Selecione uma linha para apagar", bt_Apagar);
        }

        
        /// <summary>
        /// MessageBox é apresentada quando se insere um novo medico na GridView e limpa as respetivas TextBoxes e ComboBoxes
        /// </summary>
        private bool DialogAddMedico()
        {
            DialogResult resposta;

            resposta = MessageBox.Show("Vai adicionar um novo médico deseja continuar?", "Adicionar Médico", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {                
                return true;
            }
            else
                return false;
        }

        private bool DialogEditMedico()
        {
            DialogResult resposta;

            resposta = MessageBox.Show("As alterações vão ser implementadas, deseja continuar?", "Editar Médico", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {                
                return true;
            }
            else
            {
                dataGridMedico.DataSource = dc.Medicos;
                dataGridMedico.Refresh();
                return false;
            }
        }

        /// <summary>
        /// Metodo que valida todos os inputs do user para evitar erros na inserção de Dados
        /// </summary>
        /// <returns></returns>
        private bool Validacoes()
        {
            bool valida = true;
            char testEmail = '@';

            if (string.IsNullOrEmpty(txt_AddMedico.Text) || txt_AddMedico.Text.All(char.IsDigit))
            {
                MessageBox.Show("Insira o nome do Médico!", "Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_AddMedico.Text = string.Empty;
                valida = false;
            }
            if (string.IsNullOrEmpty(cb_tipoAnimal.Text))
            {
                MessageBox.Show("Insira a especialidade do Médico!", "Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);

                valida = false;
            }
            if (string.IsNullOrEmpty(txt_AddNif.Text) || !System.Text.RegularExpressions.Regex.IsMatch(txt_AddNif.Text, "^[0-9]*$") || txt_AddNif.Text.Length != 9)
            {
                MessageBox.Show("Insira o NIF , este deve conter 9 digitos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_AddNif.Text = string.Empty;

                valida = false;
            }
            foreach(Medico testNif in dc.Medicos)
            {
                if(txt_AddNif.Text == testNif.NIF)
                {
                    MessageBox.Show($"Já existe Médico com o NIF {testNif.NIF}, insira um novo Médico", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txt_AddNif.Text = string.Empty;

                    valida = false;
                }
            }
            if (string.IsNullOrEmpty(txt_AddTele.Text) ||!System.Text.RegularExpressions.Regex.IsMatch(txt_AddTele.Text, "^[0-9]*$") || txt_AddTele.Text.Length != 9)
            {
                MessageBox.Show("Insira o número de telemóvel corretamente, verifique se o número telefone está dentro dos paramentros nacionais !", "Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_AddTele.Text = string.Empty;
                valida = false;
            }
            if (string.IsNullOrEmpty(txt_AddEmail.Text) || !txt_AddEmail.Text.Contains(Convert.ToString(testEmail)))
            {
                MessageBox.Show("Insira o email corretamente", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_AddEmail.Text = string.Empty;
                valida = false;
            }
            if(string.IsNullOrEmpty(cb_salaObs.Text))
            {
                MessageBox.Show("Atribua a sala de observações ao medico!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                valida = false;
            }
            return valida;
        }

        private bool ValidacoesEdit()
        {
            bool valida = true;
            char testEmail = '@';

            if (string.IsNullOrEmpty(txt_EditNome.Text) || txt_EditNome.Text.All(char.IsDigit))
            {
                MessageBox.Show("Insira o nome do Médico!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_EditNome.Text = string.Empty;
                valida = false;
            }
            if (string.IsNullOrEmpty(cb_EditTipoAnimal.Text))
            {
                MessageBox.Show("Insira a especialidade do Médico!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_EditTipoAnimal.SelectedItem = null;
                valida = false;
            }
            if (string.IsNullOrEmpty(txt_EditNif.Text) || !System.Text.RegularExpressions.Regex.IsMatch(txt_EditNif.Text, "^[0-9]*$") || txt_EditNif.Text.Length != 9)
            {
                MessageBox.Show("Insira o NIF , este deve conter 9 digitos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_AddNif.Text = string.Empty;

                valida = false;
            }
            foreach (Medico testNif in dc.Medicos)
            {
                if (testNif.Nome != txt_EditNome.Text)
                {
                    if (txt_EditNif.Text == testNif.NIF)
                    {
                        MessageBox.Show($"Já existe Médico com o NIF {testNif.NIF}, insira um novo Médico", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        txt_EditNif.Text = string.Empty;

                        valida = false;
                    }
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
            if (string.IsNullOrEmpty(cb_EditSalaObs.Text))
            {
                MessageBox.Show("Atribua a sala de observações ao medico!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_EditSalaObs.SelectedItem = null;
                valida = false;
            }
            return valida;
        }

    }
}
