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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPanel));
            this.PainelMenu = new System.Windows.Forms.Panel();
            this.PainelCabecalho = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.painelForms = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bt_medico = new System.Windows.Forms.Button();
            this.bt_Animal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PainelMenu.SuspendLayout();
            this.PainelCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PainelMenu
            // 
            this.PainelMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PainelMenu.Controls.Add(this.pictureBox2);
            this.PainelMenu.Controls.Add(this.bt_medico);
            this.PainelMenu.Controls.Add(this.bt_Animal);
            this.PainelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PainelMenu.Location = new System.Drawing.Point(0, 51);
            this.PainelMenu.Name = "PainelMenu";
            this.PainelMenu.Size = new System.Drawing.Size(199, 499);
            this.PainelMenu.TabIndex = 0;
            // 
            // PainelCabecalho
            // 
            this.PainelCabecalho.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PainelCabecalho.Controls.Add(this.label2);
            this.PainelCabecalho.Controls.Add(this.label1);
            this.PainelCabecalho.Controls.Add(this.pictureBox1);
            this.PainelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.PainelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.PainelCabecalho.Name = "PainelCabecalho";
            this.PainelCabecalho.Size = new System.Drawing.Size(1075, 51);
            this.PainelCabecalho.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "Menu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(438, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clinica     Vet       Plus";
            // 
            // painelForms
            // 
            this.painelForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelForms.Location = new System.Drawing.Point(199, 51);
            this.painelForms.Name = "painelForms";
            this.painelForms.Size = new System.Drawing.Size(876, 499);
            this.painelForms.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ClinicaVET5413.Properties.Resources.hospital;
            this.pictureBox2.Location = new System.Drawing.Point(6, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(187, 138);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // bt_medico
            // 
            this.bt_medico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_medico.Image = global::ClinicaVET5413.Properties.Resources.minidoc;
            this.bt_medico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_medico.Location = new System.Drawing.Point(0, 248);
            this.bt_medico.Name = "bt_medico";
            this.bt_medico.Size = new System.Drawing.Size(197, 32);
            this.bt_medico.TabIndex = 1;
            this.bt_medico.Text = "Gestão de Médicos";
            this.bt_medico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_medico.UseVisualStyleBackColor = true;
            this.bt_medico.Click += new System.EventHandler(this.bt_medico_Click);
            // 
            // bt_Animal
            // 
            this.bt_Animal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Animal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Animal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_Animal.Image = global::ClinicaVET5413.Properties.Resources.mini;
            this.bt_Animal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Animal.Location = new System.Drawing.Point(0, 163);
            this.bt_Animal.Name = "bt_Animal";
            this.bt_Animal.Size = new System.Drawing.Size(199, 35);
            this.bt_Animal.TabIndex = 0;
            this.bt_Animal.Text = "Gestão de Animais";
            this.bt_Animal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Animal.UseVisualStyleBackColor = true;
            this.bt_Animal.Click += new System.EventHandler(this.bt_Animal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClinicaVET5413.Properties.Resources.teste;
            this.pictureBox1.Location = new System.Drawing.Point(1009, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 550);
            this.Controls.Add(this.painelForms);
            this.Controls.Add(this.PainelMenu);
            this.Controls.Add(this.PainelCabecalho);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPanel";
            this.Text = "MainPanel";
            this.PainelMenu.ResumeLayout(false);
            this.PainelCabecalho.ResumeLayout(false);
            this.PainelCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}