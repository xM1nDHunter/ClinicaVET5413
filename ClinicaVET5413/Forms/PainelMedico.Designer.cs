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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ListMed = new System.Windows.Forms.TabPage();
            this.AddMed = new System.Windows.Forms.TabPage();
            this.EditMed = new System.Windows.Forms.TabPage();
            this.txt_pesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridMedico = new System.Windows.Forms.DataGridView();
            this.bt_Adicionar = new System.Windows.Forms.Button();
            this.bt_Editar = new System.Windows.Forms.Button();
            this.bt_Apagar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_addID = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.ListMed.SuspendLayout();
            this.AddMed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
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
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gestão de Médicos";
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
            this.ListMed.BackColor = System.Drawing.Color.Silver;
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
            // AddMed
            // 
            this.AddMed.BackColor = System.Drawing.Color.Silver;
            this.AddMed.Controls.Add(this.comboBox2);
            this.AddMed.Controls.Add(this.comboBox1);
            this.AddMed.Controls.Add(this.textBox5);
            this.AddMed.Controls.Add(this.textBox4);
            this.AddMed.Controls.Add(this.textBox3);
            this.AddMed.Controls.Add(this.textBox2);
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
            // EditMed
            // 
            this.EditMed.BackColor = System.Drawing.Color.Silver;
            this.EditMed.Location = new System.Drawing.Point(4, 22);
            this.EditMed.Name = "EditMed";
            this.EditMed.Size = new System.Drawing.Size(861, 370);
            this.EditMed.TabIndex = 2;
            this.EditMed.Text = "Editar Médicos";
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.Location = new System.Drawing.Point(15, 41);
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(445, 20);
            this.txt_pesquisa.TabIndex = 0;
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
            // dataGridMedico
            // 
            this.dataGridMedico.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMedico.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridMedico.Location = new System.Drawing.Point(16, 69);
            this.dataGridMedico.Name = "dataGridMedico";
            this.dataGridMedico.Size = new System.Drawing.Size(649, 301);
            this.dataGridMedico.TabIndex = 2;
            // 
            // bt_Adicionar
            // 
            this.bt_Adicionar.Location = new System.Drawing.Point(703, 131);
            this.bt_Adicionar.Name = "bt_Adicionar";
            this.bt_Adicionar.Size = new System.Drawing.Size(118, 24);
            this.bt_Adicionar.TabIndex = 3;
            this.bt_Adicionar.Text = "Adicionar Médico";
            this.bt_Adicionar.UseVisualStyleBackColor = true;
            // 
            // bt_Editar
            // 
            this.bt_Editar.Location = new System.Drawing.Point(703, 195);
            this.bt_Editar.Name = "bt_Editar";
            this.bt_Editar.Size = new System.Drawing.Size(118, 24);
            this.bt_Editar.TabIndex = 4;
            this.bt_Editar.Text = "Editar Médico";
            this.bt_Editar.UseVisualStyleBackColor = true;
            // 
            // bt_Apagar
            // 
            this.bt_Apagar.Location = new System.Drawing.Point(703, 257);
            this.bt_Apagar.Name = "bt_Apagar";
            this.bt_Apagar.Size = new System.Drawing.Size(118, 24);
            this.bt_Apagar.TabIndex = 5;
            this.bt_Apagar.Text = "Apagar Médico";
            this.bt_Apagar.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ClinicaVET5413.Properties.Resources.doctor1;
            this.pictureBox2.Location = new System.Drawing.Point(728, 0);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(571, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "Tipo Animal:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(570, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Sala de Observações";
            // 
            // txt_addID
            // 
            this.txt_addID.Location = new System.Drawing.Point(67, 73);
            this.txt_addID.Name = "txt_addID";
            this.txt_addID.Size = new System.Drawing.Size(74, 20);
            this.txt_addID.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(216, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(67, 143);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(194, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(67, 210);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(194, 20);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(68, 286);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(293, 20);
            this.textBox5.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(574, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(573, 187);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(145, 21);
            this.comboBox2.TabIndex = 13;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ListMed.ResumeLayout(false);
            this.ListMed.PerformLayout();
            this.AddMed.ResumeLayout(false);
            this.AddMed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txt_addID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}