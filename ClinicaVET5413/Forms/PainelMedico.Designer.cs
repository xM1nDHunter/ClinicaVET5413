namespace ClinicaVET5413.Forms
{
    partial class PainelMedico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ListMed = new System.Windows.Forms.TabPage();
            this.bt_Apagar = new System.Windows.Forms.Button();
            this.bt_Editar = new System.Windows.Forms.Button();
            this.bt_Adicionar = new System.Windows.Forms.Button();
            this.dataGridMedico = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pesquisa = new System.Windows.Forms.TextBox();
            this.AddMed = new System.Windows.Forms.TabPage();
            this.bt_addMedic = new System.Windows.Forms.Button();
            this.cb_tipoAnimal = new System.Windows.Forms.ComboBox();
            this.cb_salaObs = new System.Windows.Forms.ComboBox();
            this.txt_AddEmail = new System.Windows.Forms.TextBox();
            this.txt_AddTele = new System.Windows.Forms.TextBox();
            this.txt_AddNif = new System.Windows.Forms.TextBox();
            this.txt_AddMedico = new System.Windows.Forms.TextBox();
            this.txt_addID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EditMed = new System.Windows.Forms.TabPage();
            this.bt_EditMedico = new System.Windows.Forms.Button();
            this.cb_EditTipoAnimal = new System.Windows.Forms.ComboBox();
            this.cb_EditSalaObs = new System.Windows.Forms.ComboBox();
            this.txt_EditEmail = new System.Windows.Forms.TextBox();
            this.txt_EditTele = new System.Windows.Forms.TextBox();
            this.txt_EditNif = new System.Windows.Forms.TextBox();
            this.txt_EditNome = new System.Windows.Forms.TextBox();
            this.txt_EditID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.ListMed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedico)).BeginInit();
            this.AddMed.SuspendLayout();
            this.EditMed.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(115)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 98);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gestão de Médicos";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::ClinicaVET5413.Properties.Resources.doctor1;
            this.pictureBox2.Location = new System.Drawing.Point(744, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClinicaVET5413.Properties.Resources.veterinary;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ListMed);
            this.tabControl1.Controls.Add(this.AddMed);
            this.tabControl1.Controls.Add(this.EditMed);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 98);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(869, 396);
            this.tabControl1.TabIndex = 1;
            // 
            // ListMed
            // 
            this.ListMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(138)))), ((int)(((byte)(129)))));
            this.ListMed.Controls.Add(this.bt_Apagar);
            this.ListMed.Controls.Add(this.bt_Editar);
            this.ListMed.Controls.Add(this.bt_Adicionar);
            this.ListMed.Controls.Add(this.dataGridMedico);
            this.ListMed.Controls.Add(this.label2);
            this.ListMed.Controls.Add(this.txt_pesquisa);
            this.ListMed.Location = new System.Drawing.Point(4, 22);
            this.ListMed.Name = "ListMed";
            this.ListMed.Padding = new System.Windows.Forms.Padding(3);
            this.ListMed.Size = new System.Drawing.Size(861, 370);
            this.ListMed.TabIndex = 0;
            this.ListMed.Text = "Lista de Médicos";
            // 
            // bt_Apagar
            // 
            this.bt_Apagar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bt_Apagar.Location = new System.Drawing.Point(703, 257);
            this.bt_Apagar.Name = "bt_Apagar";
            this.bt_Apagar.Size = new System.Drawing.Size(118, 24);
            this.bt_Apagar.TabIndex = 5;
            this.bt_Apagar.Text = "Apagar Médico";
            this.bt_Apagar.UseVisualStyleBackColor = true;
            this.bt_Apagar.Click += new System.EventHandler(this.bt_Apagar_Click);
            this.bt_Apagar.MouseHover += new System.EventHandler(this.bt_Apagar_MouseHover);
            // 
            // bt_Editar
            // 
            this.bt_Editar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bt_Editar.Location = new System.Drawing.Point(703, 195);
            this.bt_Editar.Name = "bt_Editar";
            this.bt_Editar.Size = new System.Drawing.Size(118, 24);
            this.bt_Editar.TabIndex = 4;
            this.bt_Editar.Text = "Editar Médico";
            this.bt_Editar.UseVisualStyleBackColor = true;
            this.bt_Editar.Click += new System.EventHandler(this.bt_Editar_Click);
            // 
            // bt_Adicionar
            // 
            this.bt_Adicionar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bt_Adicionar.Location = new System.Drawing.Point(703, 131);
            this.bt_Adicionar.Name = "bt_Adicionar";
            this.bt_Adicionar.Size = new System.Drawing.Size(118, 24);
            this.bt_Adicionar.TabIndex = 3;
            this.bt_Adicionar.Text = "Adicionar Médico";
            this.bt_Adicionar.UseVisualStyleBackColor = true;
            this.bt_Adicionar.Click += new System.EventHandler(this.bt_Adicionar_Click);
            // 
            // dataGridMedico
            // 
            this.dataGridMedico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridMedico.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(88)))), ((int)(((byte)(217)))));
            this.dataGridMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMedico.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridMedico.Location = new System.Drawing.Point(16, 69);
            this.dataGridMedico.Name = "dataGridMedico";
            this.dataGridMedico.Size = new System.Drawing.Size(649, 301);
            this.dataGridMedico.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pesquisar Médicos:";
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.Location = new System.Drawing.Point(15, 41);
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(445, 20);
            this.txt_pesquisa.TabIndex = 0;
            this.txt_pesquisa.TextChanged += new System.EventHandler(this.txt_pesquisa_TextChanged);
            // 
            // AddMed
            // 
            this.AddMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(138)))), ((int)(((byte)(129)))));
            this.AddMed.Controls.Add(this.bt_addMedic);
            this.AddMed.Controls.Add(this.cb_tipoAnimal);
            this.AddMed.Controls.Add(this.cb_salaObs);
            this.AddMed.Controls.Add(this.txt_AddEmail);
            this.AddMed.Controls.Add(this.txt_AddTele);
            this.AddMed.Controls.Add(this.txt_AddNif);
            this.AddMed.Controls.Add(this.txt_AddMedico);
            this.AddMed.Controls.Add(this.txt_addID);
            this.AddMed.Controls.Add(this.label9);
            this.AddMed.Controls.Add(this.label8);
            this.AddMed.Controls.Add(this.label7);
            this.AddMed.Controls.Add(this.label6);
            this.AddMed.Controls.Add(this.label5);
            this.AddMed.Controls.Add(this.label4);
            this.AddMed.Controls.Add(this.label3);
            this.AddMed.Location = new System.Drawing.Point(4, 22);
            this.AddMed.Name = "AddMed";
            this.AddMed.Padding = new System.Windows.Forms.Padding(3);
            this.AddMed.Size = new System.Drawing.Size(861, 370);
            this.AddMed.TabIndex = 1;
            this.AddMed.Text = "Adicionar Médico";
            // 
            // bt_addMedic
            // 
            this.bt_addMedic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_addMedic.Location = new System.Drawing.Point(667, 321);
            this.bt_addMedic.Name = "bt_addMedic";
            this.bt_addMedic.Size = new System.Drawing.Size(157, 22);
            this.bt_addMedic.TabIndex = 14;
            this.bt_addMedic.Text = "Adicionar Médico";
            this.bt_addMedic.UseVisualStyleBackColor = true;
            this.bt_addMedic.Click += new System.EventHandler(this.bt_addMedic_Click);
            // 
            // cb_tipoAnimal
            // 
            this.cb_tipoAnimal.FormattingEnabled = true;
            this.cb_tipoAnimal.Location = new System.Drawing.Point(553, 244);
            this.cb_tipoAnimal.Name = "cb_tipoAnimal";
            this.cb_tipoAnimal.Size = new System.Drawing.Size(145, 21);
            this.cb_tipoAnimal.TabIndex = 13;
            // 
            // cb_salaObs
            // 
            this.cb_salaObs.FormattingEnabled = true;
            this.cb_salaObs.Location = new System.Drawing.Point(554, 168);
            this.cb_salaObs.Name = "cb_salaObs";
            this.cb_salaObs.Size = new System.Drawing.Size(145, 21);
            this.cb_salaObs.TabIndex = 12;
            // 
            // txt_AddEmail
            // 
            this.txt_AddEmail.Location = new System.Drawing.Point(68, 286);
            this.txt_AddEmail.Name = "txt_AddEmail";
            this.txt_AddEmail.Size = new System.Drawing.Size(293, 20);
            this.txt_AddEmail.TabIndex = 11;
            // 
            // txt_AddTele
            // 
            this.txt_AddTele.Location = new System.Drawing.Point(67, 210);
            this.txt_AddTele.Name = "txt_AddTele";
            this.txt_AddTele.Size = new System.Drawing.Size(194, 20);
            this.txt_AddTele.TabIndex = 10;
            // 
            // txt_AddNif
            // 
            this.txt_AddNif.Location = new System.Drawing.Point(67, 143);
            this.txt_AddNif.Name = "txt_AddNif";
            this.txt_AddNif.Size = new System.Drawing.Size(194, 20);
            this.txt_AddNif.TabIndex = 9;
            // 
            // txt_AddMedico
            // 
            this.txt_AddMedico.Location = new System.Drawing.Point(216, 76);
            this.txt_AddMedico.Name = "txt_AddMedico";
            this.txt_AddMedico.Size = new System.Drawing.Size(310, 20);
            this.txt_AddMedico.TabIndex = 8;
            // 
            // txt_addID
            // 
            this.txt_addID.Enabled = false;
            this.txt_addID.Location = new System.Drawing.Point(67, 73);
            this.txt_addID.Name = "txt_addID";
            this.txt_addID.Size = new System.Drawing.Size(74, 20);
            this.txt_addID.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(550, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Sala de Observações";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(551, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "Especialidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(63, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Telemovel:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "NIF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(210, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nome Médico:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID Médico:";
            // 
            // EditMed
            // 
            this.EditMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(138)))), ((int)(((byte)(129)))));
            this.EditMed.Controls.Add(this.bt_EditMedico);
            this.EditMed.Controls.Add(this.cb_EditTipoAnimal);
            this.EditMed.Controls.Add(this.cb_EditSalaObs);
            this.EditMed.Controls.Add(this.txt_EditEmail);
            this.EditMed.Controls.Add(this.txt_EditTele);
            this.EditMed.Controls.Add(this.txt_EditNif);
            this.EditMed.Controls.Add(this.txt_EditNome);
            this.EditMed.Controls.Add(this.txt_EditID);
            this.EditMed.Controls.Add(this.label10);
            this.EditMed.Controls.Add(this.label11);
            this.EditMed.Controls.Add(this.label12);
            this.EditMed.Controls.Add(this.label13);
            this.EditMed.Controls.Add(this.label14);
            this.EditMed.Controls.Add(this.label15);
            this.EditMed.Controls.Add(this.label16);
            this.EditMed.Location = new System.Drawing.Point(4, 22);
            this.EditMed.Name = "EditMed";
            this.EditMed.Size = new System.Drawing.Size(861, 370);
            this.EditMed.TabIndex = 2;
            this.EditMed.Text = "Editar Médicos";
            // 
            // bt_EditMedico
            // 
            this.bt_EditMedico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_EditMedico.Location = new System.Drawing.Point(654, 311);
            this.bt_EditMedico.Name = "bt_EditMedico";
            this.bt_EditMedico.Size = new System.Drawing.Size(157, 22);
            this.bt_EditMedico.TabIndex = 29;
            this.bt_EditMedico.Text = "Confirmar Alterações";
            this.bt_EditMedico.UseVisualStyleBackColor = true;
            // 
            // cb_EditTipoAnimal
            // 
            this.cb_EditTipoAnimal.FormattingEnabled = true;
            this.cb_EditTipoAnimal.Location = new System.Drawing.Point(540, 234);
            this.cb_EditTipoAnimal.Name = "cb_EditTipoAnimal";
            this.cb_EditTipoAnimal.Size = new System.Drawing.Size(145, 21);
            this.cb_EditTipoAnimal.TabIndex = 28;
            // 
            // cb_EditSalaObs
            // 
            this.cb_EditSalaObs.FormattingEnabled = true;
            this.cb_EditSalaObs.Location = new System.Drawing.Point(541, 158);
            this.cb_EditSalaObs.Name = "cb_EditSalaObs";
            this.cb_EditSalaObs.Size = new System.Drawing.Size(145, 21);
            this.cb_EditSalaObs.TabIndex = 27;
            // 
            // txt_EditEmail
            // 
            this.txt_EditEmail.Location = new System.Drawing.Point(55, 276);
            this.txt_EditEmail.Name = "txt_EditEmail";
            this.txt_EditEmail.Size = new System.Drawing.Size(293, 20);
            this.txt_EditEmail.TabIndex = 26;
            // 
            // txt_EditTele
            // 
            this.txt_EditTele.Location = new System.Drawing.Point(54, 200);
            this.txt_EditTele.Name = "txt_EditTele";
            this.txt_EditTele.Size = new System.Drawing.Size(194, 20);
            this.txt_EditTele.TabIndex = 25;
            // 
            // txt_EditNif
            // 
            this.txt_EditNif.Location = new System.Drawing.Point(54, 133);
            this.txt_EditNif.Name = "txt_EditNif";
            this.txt_EditNif.Size = new System.Drawing.Size(194, 20);
            this.txt_EditNif.TabIndex = 24;
            // 
            // txt_EditNome
            // 
            this.txt_EditNome.Location = new System.Drawing.Point(203, 66);
            this.txt_EditNome.Name = "txt_EditNome";
            this.txt_EditNome.Size = new System.Drawing.Size(310, 20);
            this.txt_EditNome.TabIndex = 23;
            // 
            // txt_EditID
            // 
            this.txt_EditID.Enabled = false;
            this.txt_EditID.Location = new System.Drawing.Point(54, 63);
            this.txt_EditID.Name = "txt_EditID";
            this.txt_EditID.Size = new System.Drawing.Size(74, 20);
            this.txt_EditID.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(537, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 18);
            this.label10.TabIndex = 21;
            this.label10.Text = "Sala de Observações";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(538, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 18);
            this.label11.TabIndex = 20;
            this.label11.Text = "Especialidade:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(50, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 18);
            this.label12.TabIndex = 19;
            this.label12.Text = "Email:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(50, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 18);
            this.label13.TabIndex = 18;
            this.label13.Text = "Telemovel:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(50, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 18);
            this.label14.TabIndex = 17;
            this.label14.Text = "NIF:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(197, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 18);
            this.label15.TabIndex = 16;
            this.label15.Text = "Nome Médico:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(50, 38);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 18);
            this.label16.TabIndex = 15;
            this.label16.Text = "ID Médico:";
            // 
            // PainelMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 494);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PainelMedico";
            this.Text = "PainelMedico";
            this.Load += new System.EventHandler(this.PainelMedico_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ListMed.ResumeLayout(false);
            this.ListMed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedico)).EndInit();
            this.AddMed.ResumeLayout(false);
            this.AddMed.PerformLayout();
            this.EditMed.ResumeLayout(false);
            this.EditMed.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ListMed;
        private System.Windows.Forms.TabPage AddMed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage EditMed;
        private System.Windows.Forms.DataGridView dataGridMedico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_pesquisa;
        private System.Windows.Forms.Button bt_Apagar;
        private System.Windows.Forms.Button bt_Editar;
        private System.Windows.Forms.Button bt_Adicionar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_tipoAnimal;
        private System.Windows.Forms.ComboBox cb_salaObs;
        private System.Windows.Forms.TextBox txt_AddEmail;
        private System.Windows.Forms.TextBox txt_AddTele;
        private System.Windows.Forms.TextBox txt_AddNif;
        private System.Windows.Forms.TextBox txt_AddMedico;
        private System.Windows.Forms.TextBox txt_addID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_addMedic;
        private System.Windows.Forms.Button bt_EditMedico;
        private System.Windows.Forms.ComboBox cb_EditTipoAnimal;
        private System.Windows.Forms.ComboBox cb_EditSalaObs;
        private System.Windows.Forms.TextBox txt_EditEmail;
        private System.Windows.Forms.TextBox txt_EditTele;
        private System.Windows.Forms.TextBox txt_EditNif;
        private System.Windows.Forms.TextBox txt_EditNome;
        private System.Windows.Forms.TextBox txt_EditID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}