using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaVET5413
{
    public partial class PainelAnimal : Form
    {
        //Cria uma ligação a db de form a obter os dados que existem
        DataClassesDataContext dc = new DataClassesDataContext();
        public PainelAnimal()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Ao carregar o form são carregados os dados da DB para a GridView e preenchidas as TextBoxes necessarias 
        /// </summary>        
        private void Form1_Load(object sender, EventArgs e)
        {                      
            //Adicionar Conteudos no combo boxes
            CarregarComboBoxes();
            //Inserir os dados da DB dentro de uma lista 
            CarregarGridView();
            dtpAdicionar.Format = DateTimePickerFormat.Custom;
            dtpAdicionar.CustomFormat = "dd/MM/yyyy";
            
        }

        #region Metodos de Loads

        /// <summary>
        /// Carrega as ComboBoxes independentes de inputs do user 
        /// </summary>
        private void CarregarComboBoxes()
        {
            cbEspecieAdd.Items.Add("Felídeos");
            cbEspecieAdd.Items.Add("Ave");
            cbEspecieAdd.Items.Add("Reptil");
            cbEspecieAdd.Items.Add("Canídeos");

            cb_esterilAdd.Items.Add("Sim");
            cb_esterilAdd.Items.Add("Não");

            cbGeneroAdd.Items.Add("Macho");
            cbGeneroAdd.Items.Add("Fêmea");
            cbEspecieEdit.Items.Add("Felídeos");
            cbEspecieEdit.Items.Add("Ave");
            cbEspecieEdit.Items.Add("Reptil");
            cbEspecieEdit.Items.Add("Canídeos");

            cb_esterilEdit.Items.Add("Sim");
            cb_esterilEdit.Items.Add("Não");

            cbGeneroEdit.Items.Add("Macho");
            cbGeneroEdit.Items.Add("Fêmea");

        }

        /// <summary>
        /// Ao selecionar a Especie do animal está carrega os dados para a ComboBox Raça e altera a foto da respetiva especie
        /// </summary>
        private void cbEspecieAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEspecieAdd.Text == "Felídeos")
            {
                cbRacaAdd.Items.Clear();
                cbRacaAdd.Items.Add("Pelo Curto");
                cbRacaAdd.Items.Add("Persa");
                cbRacaAdd.Items.Add("Siamês");
                pictureBox3.Image = Properties.Resources.cat;
            }
            if (cbEspecieAdd.Text == "Ave")
            {
                cbRacaAdd.Items.Clear();
                cbRacaAdd.Items.Add("Galinha");
                cbRacaAdd.Items.Add("Papagaio");
                cbRacaAdd.Items.Add("Piriquito");
                pictureBox3.Image = Properties.Resources.bird;
            }
            if (cbEspecieAdd.Text == "Reptil")
            {
                cbRacaAdd.Items.Clear();
                cbRacaAdd.Items.Add("Gecko");
                cbRacaAdd.Items.Add("Dragão Barbudo");
                cbRacaAdd.Items.Add("Iguana");
                pictureBox3.Image = Properties.Resources.reptile;
            }
            if (cbEspecieAdd.Text == "Canídeos")
            {
                cbRacaAdd.Items.Clear();
                cbRacaAdd.Items.Add("Pastor Alemão");
                cbRacaAdd.Items.Add("Labrador");
                cbRacaAdd.Items.Add("Pinscher");
                pictureBox3.Image = Properties.Resources.dog;
            }
                
        }        
        private void cbEspecieEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEspecieEdit.Text == "Felídeos")
            {
                cbRacaEdit.Items.Clear();
                cbRacaEdit.Items.Add("Pelo Curto");
                cbRacaEdit.Items.Add("Persa");
                cbRacaEdit.Items.Add("Siamês");
                pictureBox3.Image = Properties.Resources.cat;
            }
            if (cbEspecieEdit.Text == "Ave")
            {
                cbRacaEdit.Items.Clear();
                cbRacaEdit.Items.Add("Galinha");
                cbRacaEdit.Items.Add("Papagaio");
                cbRacaEdit.Items.Add("Piriquito");
                pictureBox3.Image = Properties.Resources.bird;
            }
            if (cbEspecieEdit.Text == "Reptil")
            {
                cbRacaEdit.Items.Clear();
                cbRacaEdit.Items.Add("Gecko");
                cbRacaEdit.Items.Add("Dragão Barbudo");
                cbRacaEdit.Items.Add("Iguana");
                pictureBox3.Image = Properties.Resources.reptile;
            }
            if (cbEspecieEdit.Text == "Canídeos")
            {
                cbRacaEdit.Items.Clear();
                cbRacaEdit.Items.Add("Pastor Alemão");
                cbRacaEdit.Items.Add("Labrador");
                cbRacaEdit.Items.Add("Pinscher");
                pictureBox3.Image = Properties.Resources.dog;
            }
        }
        /// <summary>
        /// Carrega a GridView com os dados da DB
        /// </summary>
        private void CarregarGridView()
        {
            dataGridAnimal.DataSource = null;
            dataGridAnimal.DataSource = dc.Animals;            
            dataGridAnimal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            int getID = 0;
            var listaID = from Animais in dc.Animals select Animais;
            foreach(var animal in listaID)
            {
                if (animal.ID > getID)
                {
                    getID = animal.ID;
                }
            }
            getID += 1;
            txtIdAdd.Text = getID.ToString();
        }
        #endregion


        #region Configurações dos butões 
        private void bt_adicionar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(AdicionarAnimal);            
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(EditarAnimal);
            if(dataGridAnimal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Deve selecionar um Animal primeiro!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                txt_IdEdit.Text = dataGridAnimal.CurrentRow.Cells[0].Value.ToString();
                txt_NomeEdit.Text = dataGridAnimal.CurrentRow.Cells[1].Value.ToString();
                txt_pesoEdit.Text = dataGridAnimal.CurrentRow.Cells[2].Value.ToString();
                cb_esterilEdit.Text = dataGridAnimal.CurrentRow.Cells[3].Value.ToString();
                cbRacaEdit.Text = dataGridAnimal.CurrentRow.Cells[4].Value.ToString();
                cbEspecieEdit.Text = dataGridAnimal.CurrentRow.Cells[5].Value.ToString();
                cbGeneroEdit.Text = dataGridAnimal.CurrentRow.Cells[6].Value.ToString();
                dtpEditar.Text = dataGridAnimal.CurrentRow.Cells[7].Value.ToString();
            }

        }
        

        private void bt_AddAnimal_Click(object sender, EventArgs e)
        {
            if (Validacoes())
            {
                Animal animal = new Animal
                {
                    Nome = txtNomeAdd.Text,
                    Especie = cbEspecieAdd.Text,
                    Raca = cbRacaAdd.Text,
                    Genero = cbGeneroAdd.Text,
                    Peso = txt_pesoAdd.Text + "KG",
                    Esterilizacao = cb_esterilAdd.Text,
                    DataNascimento = dtpAdicionar.Text
                };
                dc.Animals.InsertOnSubmit(animal);
                dc.SubmitChanges();
                DialogAddAnimal();
                //Carrega o DataContext de novo para poder apresentar os novos resultados
                DataClassesDataContext reload = new DataClassesDataContext();
                dataGridAnimal.DataSource = reload.Animals;
            }
            
        }        
               
        private void bt_apagar_Click(object sender, EventArgs e)
        {
            if(this.dataGridAnimal.SelectedRows.Count > 0)
            {
                dataGridAnimal.Rows.RemoveAt(this.dataGridAnimal.SelectedRows[0].Index);
                dc.SubmitChanges();
            }
        }
        //por finalizar
        private void bt_editarAnimal_Click(object sender, EventArgs e)
        {
            if (Validacoes())
            {
                Animal animalEdit = new Animal
                {
                    Nome = txt_NomeEdit.Text,
                    Especie = cbEspecieEdit.Text,
                    Raca = cbRacaEdit.Text,
                    Genero = cbGeneroEdit.Text,
                    Peso = txt_pesoEdit.Text + "KG",
                    Esterilizacao = cb_esterilEdit.Text,
                    DataNascimento = dtpEditar.Text
                };
                

            }
        }
        #endregion


        /// <summary>
        /// Caixa de texto vai atualizando e pesquisado os valores até encontrar um valor na DB, se estiver vazio recarrega a lista para DGV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            dataGridAnimal.DataSource = null;
            dataGridAnimal.Refresh();
            dataGridAnimal.AutoGenerateColumns = true;
            dataGridAnimal.Columns.Clear();
            var animalPesquisa = txtPesquisa.Text;
            var animais = from Animais in dc.Animals
                          where Animais.Nome == animalPesquisa
                          select Animais;
            dataGridAnimal.DataSource = animais.ToList();


            dataGridAnimal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            if (txtPesquisa.Text == "")
            {                
                dataGridAnimal.DataSource = dc.Animals;
                dataGridAnimal.Refresh();
            }
        }
        /// <summary>
        /// Adiciona uma Tip ao passar o rato sobre o botão
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_apagar_MouseHover(object sender, EventArgs e)
        {
            ToolTip ajuda = new ToolTip();
            ajuda.Show("Selecione uma linha para apagar",bt_apagar);
        }


        /// <summary>
        /// MessageBox é apresentada quando se insere um novo animal na GridView e limpa as respetivas TextBoxes e ComboBoxes
        /// </summary>
        private void DialogAddAnimal()
        {
            DialogResult resposta;

            resposta = MessageBox.Show("Vai adicionar um novo animal deseja continuar?","Adicionar Animal", MessageBoxButtons.YesNo, MessageBoxIcon.Question );
            if (resposta == DialogResult.Yes || resposta== DialogResult.No)
            {
                txtIdAdd.Clear();
                txtNomeAdd.Clear();                
                txt_pesoAdd.Clear();
                cbEspecieAdd.SelectedItem = null;
                cbGeneroAdd.SelectedItem = null;
                cbRacaAdd.SelectedItem = null;
                cb_esterilAdd.SelectedItem = null;
            }
        }

        /// <summary>
        /// Valida todos os campos na Tabs de edição e adição de animais
        /// </summary>
        private bool Validacoes()
        {
            bool valida = true;
            double peso;

            if (string.IsNullOrEmpty(txtNomeAdd.Text) || txtNomeAdd.Text.All(char.IsDigit))
            {
                MessageBox.Show("Deve insirir o nome do Animal!", "Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNomeAdd.Text = string.Empty;
                valida = false;
            }
            if (string.IsNullOrEmpty(cbEspecieAdd.Text))
            {
                MessageBox.Show("Deve insirir a Espécie!", "Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);

                valida = false;
            }
            if (string.IsNullOrEmpty(cbRacaAdd.Text))
            {
                MessageBox.Show("Deve insirir a raça", "Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);

                valida = false;
            }
            if (string.IsNullOrEmpty(cbGeneroAdd.Text))
            {
                MessageBox.Show("Deve insirir o género", "Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);

                valida = false;
            }
            if (string.IsNullOrEmpty(txt_pesoAdd.Text) || !double.TryParse(txt_pesoAdd.Text, out peso))
            {
                MessageBox.Show("Deve insirir o peso", "Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_pesoAdd.Text = string.Empty;

                valida = false;
            }
            if (string.IsNullOrEmpty(cb_esterilAdd.Text))
            {
                MessageBox.Show("Indique se é, ou não, esterilizado/a", "Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);

                valida = false;
            }
            return valida;
        }
    }
}
