namespace ClinicaVET5413.Forms
{
    partial class frmPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrint));
            this.painelMenu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_enviarEmail = new System.Windows.Forms.Button();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.painelPrint = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_nomecliente = new System.Windows.Forms.Label();
            this.lbl_nomeanimal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_data = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_Troco = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_nºFatura = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.painelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.painelPrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // painelMenu
            // 
            this.painelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(115)))), ((int)(((byte)(80)))));
            this.painelMenu.Controls.Add(this.pictureBox1);
            this.painelMenu.Controls.Add(this.bt_enviarEmail);
            this.painelMenu.Controls.Add(this.bt_guardar);
            this.painelMenu.Controls.Add(this.label1);
            this.painelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelMenu.Location = new System.Drawing.Point(0, 0);
            this.painelMenu.Name = "painelMenu";
            this.painelMenu.Size = new System.Drawing.Size(642, 100);
            this.painelMenu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClinicaVET5413.Properties.Resources.teste;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // bt_enviarEmail
            // 
            this.bt_enviarEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_enviarEmail.Enabled = false;
            this.bt_enviarEmail.FlatAppearance.BorderSize = 0;
            this.bt_enviarEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_enviarEmail.Image = global::ClinicaVET5413.Properties.Resources.Gmail_icon_2020_svg_45x37;
            this.bt_enviarEmail.Location = new System.Drawing.Point(581, 45);
            this.bt_enviarEmail.Name = "bt_enviarEmail";
            this.bt_enviarEmail.Size = new System.Drawing.Size(58, 48);
            this.bt_enviarEmail.TabIndex = 2;
            this.bt_enviarEmail.UseVisualStyleBackColor = true;
            this.bt_enviarEmail.Visible = false;
            this.bt_enviarEmail.Click += new System.EventHandler(this.bt_enviarEmail_Click);
            // 
            // bt_guardar
            // 
            this.bt_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_guardar.FlatAppearance.BorderSize = 0;
            this.bt_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_guardar.Image = global::ClinicaVET5413.Properties.Resources.download_45x37;
            this.bt_guardar.Location = new System.Drawing.Point(518, 46);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(57, 51);
            this.bt_guardar.TabIndex = 1;
            this.bt_guardar.UseVisualStyleBackColor = true;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faturação";
            // 
            // painelPrint
            // 
            this.painelPrint.BackColor = System.Drawing.Color.White;
            this.painelPrint.Controls.Add(this.label13);
            this.painelPrint.Controls.Add(this.lbl_nomecliente);
            this.painelPrint.Controls.Add(this.lbl_nomeanimal);
            this.painelPrint.Controls.Add(this.label10);
            this.painelPrint.Controls.Add(this.lbl_data);
            this.painelPrint.Controls.Add(this.label9);
            this.painelPrint.Controls.Add(this.lbl_Troco);
            this.painelPrint.Controls.Add(this.lbl_total);
            this.painelPrint.Controls.Add(this.label8);
            this.painelPrint.Controls.Add(this.label6);
            this.painelPrint.Controls.Add(this.label7);
            this.painelPrint.Controls.Add(this.lbl_nºFatura);
            this.painelPrint.Controls.Add(this.dataGridView1);
            this.painelPrint.Controls.Add(this.label5);
            this.painelPrint.Controls.Add(this.label4);
            this.painelPrint.Controls.Add(this.label3);
            this.painelPrint.Controls.Add(this.label2);
            this.painelPrint.Controls.Add(this.pictureBox2);
            this.painelPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelPrint.Location = new System.Drawing.Point(0, 100);
            this.painelPrint.Name = "painelPrint";
            this.painelPrint.Size = new System.Drawing.Size(642, 624);
            this.painelPrint.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 453);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 20);
            this.label13.TabIndex = 21;
            this.label13.Text = "Cliente:";
            // 
            // lbl_nomecliente
            // 
            this.lbl_nomecliente.AutoSize = true;
            this.lbl_nomecliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomecliente.Location = new System.Drawing.Point(82, 453);
            this.lbl_nomecliente.Name = "lbl_nomecliente";
            this.lbl_nomecliente.Size = new System.Drawing.Size(0, 20);
            this.lbl_nomecliente.TabIndex = 20;
            // 
            // lbl_nomeanimal
            // 
            this.lbl_nomeanimal.AutoSize = true;
            this.lbl_nomeanimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomeanimal.Location = new System.Drawing.Point(82, 493);
            this.lbl_nomeanimal.Name = "lbl_nomeanimal";
            this.lbl_nomeanimal.Size = new System.Drawing.Size(0, 20);
            this.lbl_nomeanimal.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 493);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Animal:";
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data.Location = new System.Drawing.Point(412, 180);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(60, 20);
            this.lbl_data.TabIndex = 17;
            this.lbl_data.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(324, 591);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(306, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "Obrigado pela sua preferencia !";
            // 
            // lbl_Troco
            // 
            this.lbl_Troco.AutoSize = true;
            this.lbl_Troco.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Troco.Location = new System.Drawing.Point(106, 590);
            this.lbl_Troco.Name = "lbl_Troco";
            this.lbl_Troco.Size = new System.Drawing.Size(0, 31);
            this.lbl_Troco.TabIndex = 15;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(99, 541);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(0, 31);
            this.lbl_total.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 591);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 31);
            this.label8.TabIndex = 13;
            this.label8.Text = "Troco:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 540);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 31);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 31);
            this.label7.TabIndex = 11;
            this.label7.Text = "Fatura Nº";
            // 
            // lbl_nºFatura
            // 
            this.lbl_nºFatura.AutoSize = true;
            this.lbl_nºFatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nºFatura.Location = new System.Drawing.Point(189, 157);
            this.lbl_nºFatura.Name = "lbl_nºFatura";
            this.lbl_nºFatura.Size = new System.Drawing.Size(0, 31);
            this.lbl_nºFatura.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(607, 242);
            this.dataGridView1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(261, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "8365-303 , Faro";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(259, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "NIF:2526446554";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rua do Céu nº 59 , Fonte de Louseiros ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Clinica Vet Plus";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::ClinicaVET5413.Properties.Resources.teste;
            this.pictureBox2.Location = new System.Drawing.Point(566, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 724);
            this.Controls.Add(this.painelPrint);
            this.Controls.Add(this.painelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrint";
            this.Text = "Impressão";
            this.painelMenu.ResumeLayout(false);
            this.painelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.painelPrint.ResumeLayout(false);
            this.painelPrint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painelMenu;
        private System.Windows.Forms.Panel painelPrint;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button bt_enviarEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_Troco;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_nºFatura;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_nomecliente;
        private System.Windows.Forms.Label lbl_nomeanimal;
        private System.Windows.Forms.Label label10;
    }
}