using ClinicaVET5413.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaVET5413;
using Microsoft.Reporting.WinForms;

namespace ClinicaVET5413.Forms
{
    public partial class frmPrint : Form 
    {
        //List<Fatura> _lista;
        //string _total, _dinheiro, _troco, _data,_cliente,_animal;
        //public frmPrint(List<Fatura> dataSource,string total,string dinheiro, string troco, string data)/*string cliente,string animal*/
        //{
        //     InitializeComponent();
        //    _lista = dataSource;
        //    _total = total;
        //    _dinheiro = dinheiro;
        //    _troco = troco;
        //    _data = data;
        //    //_cliente = cliente;
        //    //_animal = animal;
            
        }
        
        
        //public void frmPrint_Load(object sender, EventArgs e)
        //{
        //    ReportDataSource source = new ReportDataSource("dataFatura", _lista);
        //    reportViewer1.LocalReport.DataSources.Clear();
        //    reportViewer1.LocalReport.DataSources.Add(source);
            
        //    Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
        //    {                
        //        new Microsoft.Reporting.WinForms.ReportParameter("pAnimal", _animal),
        //        new Microsoft.Reporting.WinForms.ReportParameter("pCliente", _cliente),
        //        new Microsoft.Reporting.WinForms.ReportParameter("pTotal",_total),
        //        new Microsoft.Reporting.WinForms.ReportParameter("pPago", _dinheiro),
        //        new Microsoft.Reporting.WinForms.ReportParameter("pTroco", _troco),
        //        new Microsoft.Reporting.WinForms.ReportParameter("pDate",_data),
        //    };
        //    this.reportViewer1.LocalReport.SetParameters(para);
        //    this.reportViewer1.RefreshReport();
    //    }
    //}
}
