namespace ClinicaVET5413.Forms
{
    partial class MainPanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPanel));
            this.PainelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_infos = new System.Windows.Forms.Button();
            this.bt_GestaoClinica = new System.Windows.Forms.Button();
            this.bt_cliente = new System.Windows.Forms.Button();
            this.bt_medico = new System.Windows.Forms.Button();
            this.bt_Animal = new System.Windows.Forms.Button();
            this.PainelCabecalho = new System.Windows.Forms.Panel();
            this.bt_minimizar = new System.Windows.Forms.Button();
            this.bt_maximizar = new System.Windows.Forms.Button();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.lbl_dia = new System.Windows.Forms.Label();
            this.lbl_horas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.painelForms = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.PainelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PainelCabecalho.SuspendLayout();
            this.painelForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PainelMenu
            // 
            this.PainelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(88)))), ((int)(((byte)(217)))));
            this.PainelMenu.Controls.Add(this.panel1);
            this.PainelMenu.Controls.Add(this.bt_infos);
            this.PainelMenu.Controls.Add(this.bt_GestaoClinica);
            this.PainelMenu.Controls.Add(this.bt_cliente);
            this.PainelMenu.Controls.Add(this.bt_medico);
            this.PainelMenu.Controls.Add(this.bt_Animal);
            this.PainelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PainelMenu.Location = new System.Drawing.Point(0, 0);
            this.PainelMenu.MaximumSize = new System.Drawing.Size(199, 598);
            this.PainelMenu.MinimumSize = new System.Drawing.Size(50, 598);
            this.PainelMenu.Name = "PainelMenu";
            this.PainelMenu.Size = new System.Drawing.Size(50, 598);
            this.PainelMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(88)))), ((int)(((byte)(217)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClinicaVET5413.Properties.Resources.teste;
            this.pictureBox1.Location = new System.Drawing.Point(3, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bt_infos
            // 
            this.bt_infos.FlatAppearance.BorderSize = 0;
            this.bt_infos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_infos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_infos.Image = global::ClinicaVET5413.Properties.Resources.miniinfo;
            this.bt_infos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_infos.Location = new System.Drawing.Point(7, 498);
            this.bt_infos.Name = "bt_infos";
            this.bt_infos.Size = new System.Drawing.Size(199, 60);
            this.bt_infos.TabIndex = 5;
            this.bt_infos.Text = "Informações";
            this.bt_infos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_infos.UseVisualStyleBackColor = true;
            this.bt_infos.Click += new System.EventHandler(this.bt_infos_Click);
            // 
            // bt_GestaoClinica
            // 
            this.bt_GestaoClinica.FlatAppearance.BorderSize = 0;
            this.bt_GestaoClinica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_GestaoClinica.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_GestaoClinica.Image = global::ClinicaVET5413.Properties.Resources.minihospital;
            this.bt_GestaoClinica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_GestaoClinica.Location = new System.Drawing.Point(7, 404);
            this.bt_GestaoClinica.Name = "bt_GestaoClinica";
            this.bt_GestaoClinica.Size = new System.Drawing.Size(199, 60);
            this.bt_GestaoClinica.TabIndex = 4;
            this.bt_GestaoClinica.Text = "Gestão da Clinica";
            this.bt_GestaoClinica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_GestaoClinica.UseVisualStyleBackColor = true;
            this.bt_GestaoClinica.Click += new System.EventHandler(this.bt_GestaoClinica_Click);
            // 
            // bt_cliente
            // 
            this.bt_cliente.FlatAppearance.BorderSize = 0;
            this.bt_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cliente.Image = global::ClinicaVET5413.Properties.Resources.mincliente;
            this.bt_cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_cliente.Location = new System.Drawing.Point(7, 122);
            this.bt_cliente.Name = "bt_cliente";
            this.bt_cliente.Size = new System.Drawing.Size(199, 60);
            this.bt_cliente.TabIndex = 3;
            this.bt_cliente.Text = "Gestão de Clientes";
            this.bt_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_cliente.UseVisualStyleBackColor = true;
            this.bt_cliente.Click += new System.EventHandler(this.bt_cliente_Click);
            // 
            // bt_medico
            // 
            this.bt_medico.FlatAppearance.BorderSize = 0;
            this.bt_medico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_medico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_medico.Image = global::ClinicaVET5413.Properties.Resources.minidoc;
            this.bt_medico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_medico.Location = new System.Drawing.Point(7, 216);
            this.bt_medico.Name = "bt_medico";
            this.bt_medico.Size = new System.Drawing.Size(199, 60);
            this.bt_medico.TabIndex = 1;
            this.bt_medico.Text = "Gestão de Médicos";
            this.bt_medico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_medico.UseVisualStyleBackColor = true;
            this.bt_medico.Click += new System.EventHandler(this.bt_medico_Click);
            // 
            // bt_Animal
            // 
            this.bt_Animal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Animal.FlatAppearance.BorderSize = 0;
            this.bt_Animal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Animal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Animal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Animal.Image = global::ClinicaVET5413.Properties.Resources.mini;
            this.bt_Animal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Animal.Location = new System.Drawing.Point(7, 310);
            this.bt_Animal.Name = "bt_Animal";
            this.bt_Animal.Size = new System.Drawing.Size(199, 60);
            this.bt_Animal.TabIndex = 0;
            this.bt_Animal.Text = "Gestão de Animais";
            this.bt_Animal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Animal.UseVisualStyleBackColor = true;
            this.bt_Animal.Click += new System.EventHandler(this.bt_Animal_Click);
            // 
            // PainelCabecalho
            // 
            this.PainelCabecalho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(140)))), ((int)(((byte)(119)))));
            this.PainelCabecalho.Controls.Add(this.bt_minimizar);
            this.PainelCabecalho.Controls.Add(this.bt_maximizar);
            this.PainelCabecalho.Controls.Add(this.bt_fechar);
            this.PainelCabecalho.Controls.Add(this.lbl_dia);
            this.PainelCabecalho.Controls.Add(this.lbl_horas);
            this.PainelCabecalho.Controls.Add(this.label1);
            this.PainelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.PainelCabecalho.Location = new System.Drawing.Point(50, 0);
            this.PainelCabecalho.Name = "PainelCabecalho";
            this.PainelCabecalho.Size = new System.Drawing.Size(1121, 51);
            this.PainelCabecalho.TabIndex = 1;
            this.PainelCabecalho.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PainelCabecalho_MouseDown);
            // 
            // bt_minimizar
            // 
            this.bt_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_minimizar.FlatAppearance.BorderSize = 0;
            this.bt_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_minimizar.Font = new System.Drawing.Font("Webdings", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.bt_minimizar.Location = new System.Drawing.Point(1019, 3);
            this.bt_minimizar.Name = "bt_minimizar";
            this.bt_minimizar.Size = new System.Drawing.Size(28, 37);
            this.bt_minimizar.TabIndex = 7;
            this.bt_minimizar.Text = "0";
            this.bt_minimizar.UseVisualStyleBackColor = true;
            this.bt_minimizar.Click += new System.EventHandler(this.bt_minimizar_Click);
            // 
            // bt_maximizar
            // 
            this.bt_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_maximizar.FlatAppearance.BorderSize = 0;
            this.bt_maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_maximizar.Font = new System.Drawing.Font("Webdings", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.bt_maximizar.Location = new System.Drawing.Point(1053, 3);
            this.bt_maximizar.Name = "bt_maximizar";
            this.bt_maximizar.Size = new System.Drawing.Size(25, 37);
            this.bt_maximizar.TabIndex = 6;
            this.bt_maximizar.Text = "2";
            this.bt_maximizar.UseVisualStyleBackColor = true;
            this.bt_maximizar.Click += new System.EventHandler(this.bt_maximizar_Click);
            // 
            // bt_fechar
            // 
            this.bt_fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_fechar.FlatAppearance.BorderSize = 0;
            this.bt_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_fechar.Font = new System.Drawing.Font("Webdings", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.bt_fechar.Location = new System.Drawing.Point(1084, 3);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(25, 37);
            this.bt_fechar.TabIndex = 5;
            this.bt_fechar.Text = "r";
            this.bt_fechar.UseVisualStyleBackColor = true;
            this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
            // 
            // lbl_dia
            // 
            this.lbl_dia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_dia.AutoSize = true;
            this.lbl_dia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dia.Location = new System.Drawing.Point(688, 2);
            this.lbl_dia.Name = "lbl_dia";
            this.lbl_dia.Size = new System.Drawing.Size(30, 18);
            this.lbl_dia.TabIndex = 4;
            this.lbl_dia.Text = "dia";
            // 
            // lbl_horas
            // 
            this.lbl_horas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_horas.AutoSize = true;
            this.lbl_horas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horas.Location = new System.Drawing.Point(688, 22);
            this.lbl_horas.Name = "lbl_horas";
            this.lbl_horas.Size = new System.Drawing.Size(42, 18);
            this.lbl_horas.TabIndex = 3;
            this.lbl_horas.Text = "hora";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clinica     Vet       Plus";
            // 
            // painelForms
            // 
            this.painelForms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(140)))), ((int)(((byte)(132)))));
            this.painelForms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.painelForms.Controls.Add(this.pictureBox2);
            this.painelForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelForms.Location = new System.Drawing.Point(50, 51);
            this.painelForms.Name = "painelForms";
            this.painelForms.Size = new System.Drawing.Size(1121, 547);
            this.painelForms.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::ClinicaVET5413.Properties.Resources.teste1;
            this.pictureBox2.Location = new System.Drawing.Point(453, 137);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(242, 219);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sideBarTimer
            // 
            this.sideBarTimer.Tick += new System.EventHandler(this.sideBarTimer_Tick);
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 598);
            this.Controls.Add(this.painelForms);
            this.Controls.Add(this.PainelCabecalho);
            this.Controls.Add(this.PainelMenu);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPanel";
            this.Text = "MainPanel";
            this.PainelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PainelCabecalho.ResumeLayout(false);
            this.PainelCabecalho.PerformLayout();
            this.painelForms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PainelMenu;
        private System.Windows.Forms.Panel PainelCabecalho;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel painelForms;
        private System.Windows.Forms.Button bt_Animal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_medico;
        private System.Windows.Forms.Button bt_infos;
        private System.Windows.Forms.Button bt_GestaoClinica;
        private System.Windows.Forms.Button bt_cliente;
        private System.Windows.Forms.Label lbl_horas;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_dia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_minimizar;
        private System.Windows.Forms.Button bt_maximizar;
        private System.Windows.Forms.Button bt_fechar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer sideBarTimer;
    }
}