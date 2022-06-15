using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace ClinicaVET5413.Forms
{
    public partial class frmPrint : Form
    {
        DataTable dt = new DataTable();
        string email="";
        string nome = "";
        string total = "";
        string troco = "";
        private Bitmap memory;


        public frmPrint(DataTable Dt ,string Email , string Nome,string Total , string Troco)
        {
            InitializeComponent();
            dt = Dt;
            email = Email;
            nome = Nome;
            total = Total;
            troco = Troco;
            dataGridView1.DataSource = dt;
            Labels();
            DataGridViewColumn column = dataGridView1.Columns[1];
            column.Width = 150;
        }

        /// <summary>
        /// Preenche as Labels 
        /// </summary>
        private void Labels()
        {
            Random td = new Random();
            int rand = td.Next(0,100);
            lbl_nºFatura.Text = Convert.ToString(rand);
            lbl_total.Text = total + " €";
            lbl_Troco.Text = troco + " €";
            lbl_data.Text = DateTime.Now.ToString("D");
            lbl_nomecliente.Text = Convert.ToString(dataGridView1.Rows[0].Cells[4].Value);//4
            lbl_nomeanimal.Text = Convert.ToString(dataGridView1.Rows[0].Cells[5].Value);//5
        }


        private void Print(Panel p)
        {
            PrinterSettings printSettings = new PrinterSettings();
            painelPrint = p;
            getprintArea(p);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }

        //Tira as medidadas ao Painel 
        private void getprintArea(Panel p)
        {
            memory = new Bitmap(p.Width, p.Height);
            p.DrawToBitmap(memory, new Rectangle(0, 0, p.Width, p.Height));
        }


        //Guarda o painel Print num PDF 
        private void bt_guardar_Click(object sender, EventArgs e)
        {
            Print(this.painelPrint);
            bt_enviarEmail.Enabled = true;
            bt_enviarEmail.Visible = true;
        }

        //Apos Guardar PDF , dá opção de enviar por email para o cliente selecionado no Form Anterior
        private void bt_enviarEmail_Click(object sender, EventArgs e)
        {
            string path = "";
            OpenFileDialog abrir = new OpenFileDialog();
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                path = abrir.FileName;
            }
            MailMessage mail = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            Attachment anexo;
            anexo = new Attachment(path);

            mail.From = new MailAddress("theberserk007@gmail.com", "Vet Plus");
            mail.To.Add(new MailAddress(email, nome));
            mail.Subject = "Fatura nº" + lbl_nºFatura.Text;
            mail.IsBodyHtml = true;
            mail.BodyEncoding = Encoding.UTF8;
            mail.Attachments.Add(anexo);

            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new System.Net.NetworkCredential()
            {
                UserName = "theberserk007@gmail.com",
                Password = "aokuiwdlmakjbzgy"
            };
            smtp.EnableSsl = true;

            mail.Body = $"Boa tarde Sr.(a) {nome},<br><br> Anexado vai a sua fatura nº{lbl_nºFatura.Text} no valor de {total}€. <br> " +
                        "Agradecemos a sua preferencia !<br><br>Obrigado.<br> Atenciosamente VET PLUS!";
            try
            {
                smtp.Send(mail);
                MessageBox.Show("O email foi enviado", "Emails", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi enviado o email, \n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Tira print ao Painel
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagarea = e.PageBounds;
            e.Graphics.DrawImage(memory, (pagarea.Width / 2) - (this.painelPrint.Width / 2), this.painelPrint.Location.Y);
        }        
    }


}
