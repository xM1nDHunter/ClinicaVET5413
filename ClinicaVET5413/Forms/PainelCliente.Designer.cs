namespace ClinicaVET5413.Forms
{
    partial class PainelCliente
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
            this.listaClientes = new System.Windows.Forms.TabPage();
            this.rb_pesquisaNif = new System.Windows.Forms.RadioButton();
            this.rb_pesquisarCliente = new System.Windows.Forms.RadioButton();
            this.bt_ApagarCliente = new System.Windows.Forms.Button();
            this.bt_EditarAnimal = new System.Windows.Forms.Button();
            this.bt_AdicionarCliente = new System.Windows.Forms.Button();
            this.dataGridCliente = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pesquisa = new System.Windows.Forms.TextBox();
            this.AddCliente = new System.Windows.Forms.TabPage();
            this.bt_AddCliente = new System.Windows.Forms.Button();
            this.dtp_AddNasci = new System.Windows.Forms.DateTimePicker();
            this.txt_AddEmail = new System.Windows.Forms.TextBox();
            this.txt_AddTele = new System.Windows.Forms.TextBox();
            this.txt_AddNif = new System.Windows.Forms.TextBox();
            this.txt_AddNome = new System.Windows.Forms.TextBox();
            this.txt_AddID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EditClient = new System.Windows.Forms.TabPage();
            this.bt_EditCliente = new System.Windows.Forms.Button();
            this.dtp_EditNasci = new System.Windows.Forms.DateTimePicker();
            this.txt_EditEmail = new System.Windows.Forms.TextBox();
            this.txt_EditTele = new System.Windows.Forms.TextBox();
            this.txt_EditNif = new System.Windows.Forms.TextBox();
            this.txt_EditNome = new System.Windows.Forms.TextBox();
            this.txt_EditID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.listaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).BeginInit();
            this.AddCliente.SuspendLayout();
            this.EditClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gestão de Clientes";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ClinicaVET5413.Properties.Resources.clientex;
            this.pictureBox2.Location = new System.Drawing.Point(750, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClinicaVET5413.Properties.Resources.clientexx;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.listaClientes);
            this.tabControl1.Controls.Add(this.AddCliente);
            this.tabControl1.Controls.Add(this.EditClient);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 100);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(869, 394);
            this.tabControl1.TabIndex = 1;
            // 
            // listaClientes
            // 
            this.listaClientes.BackColor = System.Drawing.Color.Silver;
            this.listaClientes.Controls.Add(this.rb_pesquisaNif);
            this.listaClientes.Controls.Add(this.rb_pesquisarCliente);
            this.listaClientes.Controls.Add(this.bt_ApagarCliente);
            this.listaClientes.Controls.Add(this.bt_EditarAnimal);
            this.listaClientes.Controls.Add(this.bt_AdicionarCliente);
            this.listaClientes.Controls.Add(this.dataGridCliente);
            this.listaClientes.Controls.Add(this.label2);
            this.listaClientes.Controls.Add(this.txt_pesquisa);
            this.listaClientes.Location = new System.Drawing.Point(4, 22);
            this.listaClientes.Name = "listaClientes";
            this.listaClientes.Padding = new System.Windows.Forms.Padding(3);
            this.listaClientes.Size = new System.Drawing.Size(861, 368);
            this.listaClientes.TabIndex = 0;
            this.listaClientes.Text = "Lista da Clientes";
            // 
            // rb_pesquisaNif
            // 
            this.rb_pesquisaNif.AutoSize = true;
            this.rb_pesquisaNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_pesquisaNif.Location = new System.Drawing.Point(206, 16);
            this.rb_pesquisaNif.Name = "rb_pesquisaNif";
            this.rb_pesquisaNif.Size = new System.Drawing.Size(49, 22);
            this.rb_pesquisaNif.TabIndex = 7;
            this.rb_pesquisaNif.Text = "NIF";
            this.rb_pesquisaNif.UseVisualStyleBackColor = true;
            // 
            // rb_pesquisarCliente
            // 
            this.rb_pesquisarCliente.AutoSize = true;
            this.rb_pesquisarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_pesquisarCliente.Location = new System.Drawing.Point(129, 16);
            this.rb_pesquisarCliente.Name = "rb_pesquisarCliente";
            this.rb_pesquisarCliente.Size = new System.Drawing.Size(71, 22);
            this.rb_pesquisarCliente.TabIndex = 6;
            this.rb_pesquisarCliente.TabStop = true;
            this.rb_pesquisarCliente.Text = "Cliente";
            this.rb_pesquisarCliente.UseVisualStyleBackColor = true;
            // 
            // bt_ApagarCliente
            // 
            this.bt_ApagarCliente.Location = new System.Drawing.Point(701, 262);
            this.bt_ApagarCliente.Name = "bt_ApagarCliente";
            this.bt_ApagarCliente.Size = new System.Drawing.Size(117, 24);
            this.bt_ApagarCliente.TabIndex = 5;
            this.bt_ApagarCliente.Text = "Apagar Cliente";
            this.bt_ApagarCliente.UseVisualStyleBackColor = true;
            this.bt_ApagarCliente.Click += new System.EventHandler(this.bt_ApagarCliente_Click);
            this.bt_ApagarCliente.MouseHover += new System.EventHandler(this.bt_ApagarCliente_MouseHover);
            // 
            // bt_EditarAnimal
            // 
            this.bt_EditarAnimal.Location = new System.Drawing.Point(701, 202);
            this.bt_EditarAnimal.Name = "bt_EditarAnimal";
            this.bt_EditarAnimal.Size = new System.Drawing.Size(117, 24);
            this.bt_EditarAnimal.TabIndex = 4;
            this.bt_EditarAnimal.Text = "Editar Cliente";
            this.bt_EditarAnimal.UseVisualStyleBackColor = true;
            this.bt_EditarAnimal.Click += new System.EventHandler(this.bt_EditarAnimal_Click);
            // 
            // bt_AdicionarCliente
            // 
            this.bt_AdicionarCliente.Location = new System.Drawing.Point(701, 139);
            this.bt_AdicionarCliente.Name = "bt_AdicionarCliente";
            this.bt_AdicionarCliente.Size = new System.Drawing.Size(117, 24);
            this.bt_AdicionarCliente.TabIndex = 3;
            this.bt_AdicionarCliente.Text = "Adicionar Cliente";
            this.bt_AdicionarCliente.UseVisualStyleBackColor = true;
            this.bt_AdicionarCliente.Click += new System.EventHandler(this.bt_AdicionarCliente_Click);
            // 
            // dataGridCliente
            // 
            this.dataGridCliente.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCliente.Location = new System.Drawing.Point(28, 66);
            this.dataGridCliente.Name = "dataGridCliente";
            this.dataGridCliente.Size = new System.Drawing.Size(619, 301);
            this.dataGridCliente.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pesquisa por:";
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.Location = new System.Drawing.Point(27, 39);
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(397, 20);
            this.txt_pesquisa.TabIndex = 0;
            this.txt_pesquisa.TextChanged += new System.EventHandler(this.txt_pesquisa_TextChanged);
            // 
            // AddCliente
            // 
            this.AddCliente.BackColor = System.Drawing.Color.Silver;
            this.AddCliente.Controls.Add(this.bt_AddCliente);
            this.AddCliente.Controls.Add(this.dtp_AddNasci);
            this.AddCliente.Controls.Add(this.txt_AddEmail);
            this.AddCliente.Controls.Add(this.txt_AddTele);
            this.AddCliente.Controls.Add(this.txt_AddNif);
            this.AddCliente.Controls.Add(this.txt_AddNome);
            this.AddCliente.Controls.Add(this.txt_AddID);
            this.AddCliente.Controls.Add(this.label9);
            this.AddCliente.Controls.Add(this.label7);
            this.AddCliente.Controls.Add(this.label6);
            this.AddCliente.Controls.Add(this.label5);
            this.AddCliente.Controls.Add(this.lbl);
            this.AddCliente.Controls.Add(this.label3);
            this.AddCliente.Location = new System.Drawing.Point(4, 22);
            this.AddCliente.Name = "AddCliente";
            this.AddCliente.Padding = new System.Windows.Forms.Padding(3);
            this.AddCliente.Size = new System.Drawing.Size(861, 368);
            this.AddCliente.TabIndex = 1;
            this.AddCliente.Text = "Adicionar Clientes";
            // 
            // bt_AddCliente
            // 
            this.bt_AddCliente.Location = new System.Drawing.Point(686, 322);
            this.bt_AddCliente.Name = "bt_AddCliente";
            this.bt_AddCliente.Size = new System.Drawing.Size(147, 23);
            this.bt_AddCliente.TabIndex = 14;
            this.bt_AddCliente.Text = "Adicionar Cliente";
            this.bt_AddCliente.UseVisualStyleBackColor = true;
            this.bt_AddCliente.Click += new System.EventHandler(this.bt_AddCliente_Click);
            // 
            // dtp_AddNasci
            // 
            this.dtp_AddNasci.Location = new System.Drawing.Point(421, 197);
            this.dtp_AddNasci.Name = "dtp_AddNasci";
            this.dtp_AddNasci.Size = new System.Drawing.Size(191, 20);
            this.dtp_AddNasci.TabIndex = 13;
            // 
            // txt_AddEmail
            // 
            this.txt_AddEmail.Location = new System.Drawing.Point(73, 260);
            this.txt_AddEmail.Name = "txt_AddEmail";
            this.txt_AddEmail.Size = new System.Drawing.Size(239, 20);
            this.txt_AddEmail.TabIndex = 11;
            // 
            // txt_AddTele
            // 
            this.txt_AddTele.Location = new System.Drawing.Point(74, 197);
            this.txt_AddTele.Name = "txt_AddTele";
            this.txt_AddTele.Size = new System.Drawing.Size(239, 20);
            this.txt_AddTele.TabIndex = 10;
            // 
            // txt_AddNif
            // 
            this.txt_AddNif.Location = new System.Drawing.Point(74, 141);
            this.txt_AddNif.Name = "txt_AddNif";
            this.txt_AddNif.Size = new System.Drawing.Size(240, 20);
            this.txt_AddNif.TabIndex = 9;
            // 
            // txt_AddNome
            // 
            this.txt_AddNome.Location = new System.Drawing.Point(219, 81);
            this.txt_AddNome.Name = "txt_AddNome";
            this.txt_AddNome.Size = new System.Drawing.Size(234, 20);
            this.txt_AddNome.TabIndex = 8;
            // 
            // txt_AddID
            // 
            this.txt_AddID.Enabled = false;
            this.txt_AddID.Location = new System.Drawing.Point(74, 80);
            this.txt_AddID.Name = "txt_AddID";
            this.txt_AddID.Size = new System.Drawing.Size(75, 20);
            this.txt_AddID.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(417, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Data de Nascimento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(71, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Telemovel:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(213, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nome:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(71, 113);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(35, 18);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "NIF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID Cliente:";
            // 
            // EditClient
            // 
            this.EditClient.BackColor = System.Drawing.Color.Silver;
            this.EditClient.Controls.Add(this.bt_EditCliente);
            this.EditClient.Controls.Add(this.dtp_EditNasci);
            this.EditClient.Controls.Add(this.txt_EditEmail);
            this.EditClient.Controls.Add(this.txt_EditTele);
            this.EditClient.Controls.Add(this.txt_EditNif);
            this.EditClient.Controls.Add(this.txt_EditNome);
            this.EditClient.Controls.Add(this.txt_EditID);
            this.EditClient.Controls.Add(this.label4);
            this.EditClient.Controls.Add(this.label11);
            this.EditClient.Controls.Add(this.label12);
            this.EditClient.Controls.Add(this.label13);
            this.EditClient.Controls.Add(this.label14);
            this.EditClient.Controls.Add(this.label15);
            this.EditClient.Location = new System.Drawing.Point(4, 22);
            this.EditClient.Name = "EditClient";
            this.EditClient.Size = new System.Drawing.Size(861, 368);
            this.EditClient.TabIndex = 2;
            this.EditClient.Text = "Editar Cliente";
            // 
            // bt_EditCliente
            // 
            this.bt_EditCliente.Location = new System.Drawing.Point(683, 326);
            this.bt_EditCliente.Name = "bt_EditCliente";
            this.bt_EditCliente.Size = new System.Drawing.Size(149, 21);
            this.bt_EditCliente.TabIndex = 28;
            this.bt_EditCliente.Text = "Confirmar Alterações";
            this.bt_EditCliente.UseVisualStyleBackColor = true;
            this.bt_EditCliente.Click += new System.EventHandler(this.bt_EditCliente_Click);
            // 
            // dtp_EditNasci
            // 
            this.dtp_EditNasci.Location = new System.Drawing.Point(421, 197);
            this.dtp_EditNasci.Name = "dtp_EditNasci";
            this.dtp_EditNasci.Size = new System.Drawing.Size(191, 20);
            this.dtp_EditNasci.TabIndex = 27;
            // 
            // txt_EditEmail
            // 
            this.txt_EditEmail.Location = new System.Drawing.Point(74, 260);
            this.txt_EditEmail.Name = "txt_EditEmail";
            this.txt_EditEmail.Size = new System.Drawing.Size(239, 20);
            this.txt_EditEmail.TabIndex = 25;
            // 
            // txt_EditTele
            // 
            this.txt_EditTele.Location = new System.Drawing.Point(75, 197);
            this.txt_EditTele.Name = "txt_EditTele";
            this.txt_EditTele.Size = new System.Drawing.Size(239, 20);
            this.txt_EditTele.TabIndex = 24;
            // 
            // txt_EditNif
            // 
            this.txt_EditNif.Location = new System.Drawing.Point(75, 141);
            this.txt_EditNif.Name = "txt_EditNif";
            this.txt_EditNif.Size = new System.Drawing.Size(240, 20);
            this.txt_EditNif.TabIndex = 23;
            // 
            // txt_EditNome
            // 
            this.txt_EditNome.Location = new System.Drawing.Point(220, 81);
            this.txt_EditNome.Name = "txt_EditNome";
            this.txt_EditNome.Size = new System.Drawing.Size(234, 20);
            this.txt_EditNome.TabIndex = 22;
            // 
            // txt_EditID
            // 
            this.txt_EditID.Enabled = false;
            this.txt_EditID.Location = new System.Drawing.Point(75, 80);
            this.txt_EditID.Name = "txt_EditID";
            this.txt_EditID.Size = new System.Drawing.Size(75, 20);
            this.txt_EditID.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(417, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Data de Nascimento:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(72, 227);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 18);
            this.label11.TabIndex = 18;
            this.label11.Text = "Email:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(72, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 18);
            this.label12.TabIndex = 17;
            this.label12.Text = "Telemovel:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(214, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 18);
            this.label13.TabIndex = 16;
            this.label13.Text = "Nome:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(72, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 18);
            this.label14.TabIndex = 15;
            this.label14.Text = "NIF:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(72, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 18);
            this.label15.TabIndex = 14;
            this.label15.Text = "ID Cliente:";
            // 
            // PainelCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 494);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PainelCliente";
            this.Text = "PainelCliente";
            this.Load += new System.EventHandler(this.PainelCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.listaClientes.ResumeLayout(false);
            this.listaClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).EndInit();
            this.AddCliente.ResumeLayout(false);
            this.AddCliente.PerformLayout();
            this.EditClient.ResumeLayout(false);
            this.EditClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage listaClientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_pesquisa;
        private System.Windows.Forms.TabPage AddCliente;
        private System.Windows.Forms.Button bt_ApagarCliente;
        private System.Windows.Forms.Button bt_EditarAnimal;
        private System.Windows.Forms.Button bt_AdicionarCliente;
        private System.Windows.Forms.DataGridView dataGridCliente;
        private System.Windows.Forms.TabPage EditClient;
        private System.Windows.Forms.DateTimePicker dtp_AddNasci;
        private System.Windows.Forms.TextBox txt_AddEmail;
        private System.Windows.Forms.TextBox txt_AddTele;
        private System.Windows.Forms.TextBox txt_AddNif;
        private System.Windows.Forms.TextBox txt_AddNome;
        private System.Windows.Forms.TextBox txt_AddID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_AddCliente;
        private System.Windows.Forms.Button bt_EditCliente;
        private System.Windows.Forms.DateTimePicker dtp_EditNasci;
        private System.Windows.Forms.TextBox txt_EditEmail;
        private System.Windows.Forms.TextBox txt_EditTele;
        private System.Windows.Forms.TextBox txt_EditNif;
        private System.Windows.Forms.TextBox txt_EditNome;
        private System.Windows.Forms.TextBox txt_EditID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton rb_pesquisaNif;
        private System.Windows.Forms.RadioButton rb_pesquisarCliente;
    }
}