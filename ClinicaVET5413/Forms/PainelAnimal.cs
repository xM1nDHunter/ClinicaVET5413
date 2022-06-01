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
        /// Ao carregar o form são carregadas as colunas e inserido os dados da DB para a GridView 
        /// </summary>        
        private void Form1_Load(object sender, EventArgs e)
        {
            //Adicionar as colunas na GridView
            dataGridAnimal.Columns.Add("colID", "ID");
            dataGridAnimal.Columns.Add("colNome", "Nome");
            dataGridAnimal.Columns.Add("colEspecie", "Espécie"); 
            dataGridAnimal.Columns.Add("colRaca", "Raça");
            dataGridAnimal.Columns.Add("colGenero", "Género");
            dataGridAnimal.Columns.Add("colPeso", "Peso");
            dataGridAnimal.Columns.Add("colEsterilização", "Esterilização");
            dataGridAnimal.Columns.Add("colDataNascimento", "Data Nascimento");
            //Adicionar Conteudos no combo boxes
            CarregarComboBoxes();
            //Inserir os dados da DB dentro de uma lista 
            CarregarGridView();
        }
        
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
       
        
        

        /// <summary>
        /// Carrega a GridView com os dados da DB
        /// </summary>
        private void CarregarGridView()
        {            
            var listaAnimais = from Animais in dc.Animals select Animais;
            
            int linha = 0;

            foreach (var animal in listaAnimais)
            {
                DataGridViewRow row = new DataGridViewRow();
                dataGridAnimal.Rows.Add(row);

                dataGridAnimal.Rows[linha].Cells[0].Value = animal.ID;
                dataGridAnimal.Rows[linha].Cells[1].Value = animal.Nome;
                dataGridAnimal.Rows[linha].Cells[2].Value = animal.Especie;
                dataGridAnimal.Rows[linha].Cells[3].Value = animal.Raca;
                dataGridAnimal.Rows[linha].Cells[4].Value = animal.Genero;
                dataGridAnimal.Rows[linha].Cells[5].Value = animal.Peso;
                dataGridAnimal.Rows[linha].Cells[6].Value = animal.Esterilizacao;
                dataGridAnimal.Rows[linha].Cells[7].Value = animal.DataNascimento;
                linha++;
            }
            dataGridAnimal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;            
        }

        #region Configurações dos butões 
        private void bt_adicionar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(AdicionarAnimal);            
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(EditarAnimal);
        }

        private void bt_pesquisar_Click(object sender, EventArgs e)
        {
            dataGridAnimal.Rows.Clear();
            var listaPesquisa = from Animais in dc.Animals select Animais;

            int linha = 0;

            foreach (var animal in listaPesquisa)
            {
                if (animal.Nome == txtPesquisa.Text)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    dataGridAnimal.Rows.Add(row);

                    dataGridAnimal.Rows[linha].Cells[0].Value = animal.ID;
                    dataGridAnimal.Rows[linha].Cells[1].Value = animal.Nome;
                    dataGridAnimal.Rows[linha].Cells[2].Value = animal.Especie;
                    dataGridAnimal.Rows[linha].Cells[3].Value = animal.Raca;
                    dataGridAnimal.Rows[linha].Cells[4].Value = animal.Genero;
                    dataGridAnimal.Rows[linha].Cells[5].Value = animal.Peso;
                    dataGridAnimal.Rows[linha].Cells[6].Value = animal.Esterilizacao;
                    dataGridAnimal.Rows[linha].Cells[7].Value = animal.DataNascimento;
                    linha++;
                }
            }
            dataGridAnimal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void bt_guardarAdd_Click(object sender, EventArgs e)
        {
            if (Validacoes()) 
            {
                Animal animal = new Animal
                {                    
                    Nome = txtNomeAdd.Text,
                    Especie = cbEspecieAdd.Text,
                    Raca = cbRacaAdd.Text,
                    Genero = cbGeneroAdd.Text,
                    Peso = txt_pesoAdd.Text+"KG",
                    Esterilizacao = cb_esterilAdd.Text,
                    DataNascimento = dtpAdicionar.Text
                };
                dc.Animals.InsertOnSubmit(animal);
                dc.SubmitChanges();
                CarregarGridView();
                DialogAddAnimal();
            } 

        }
        private void bt_apagar_Click(object sender, EventArgs e)
        {

        }
        #endregion

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
            bool output = true;
            double peso;

            if (string.IsNullOrEmpty(txtNomeAdd.Text) || txtNomeAdd.Text.All(char.IsDigit))
            {
                MessageBox.Show("Deve insirir o nome do Animal!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            if (string.IsNullOrEmpty(cbEspecieAdd.Text) || cbEspecieAdd.Text.All(char.IsDigit))
            {
                MessageBox.Show("Deve insirir a Espécie!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            if (string.IsNullOrEmpty(cbRacaAdd.Text) || cbRacaAdd.Text.All(char.IsDigit))
            {
                MessageBox.Show("Deve insirir a raça", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            if (string.IsNullOrEmpty(cbGeneroAdd.Text))
            {
                MessageBox.Show("Deve insirir o género", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            if (string.IsNullOrEmpty(txt_pesoAdd.Text) || !double.TryParse(txt_pesoAdd.Text, out peso))
            {
                MessageBox.Show("Deve insirir o peso", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            if (string.IsNullOrEmpty(cb_esterilAdd.Text))
            {
                MessageBox.Show("Indique se é, ou não, esterilizado/a", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                output = false;
            }
            return output;
        }

    }
}
