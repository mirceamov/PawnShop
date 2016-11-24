using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amanet
{
    public partial class frmPrintSituatieScadente : Form
    {
        List<claseDB.SituatieScadente> listaSituatieScadenteDePrintat = new List<claseDB.SituatieScadente>();
        string scadentaMaxima = ""; 
        public frmPrintSituatieScadente(List<claseDB.SituatieScadente> _listaSituatieScadente, string _scadentaMaxima)
        {
            InitializeComponent();
            listaSituatieScadenteDePrintat = _listaSituatieScadente;
            scadentaMaxima = _scadentaMaxima;
        }

        private void frmPrintSituatieScadente_Load(object sender, EventArgs e)
        {
            ReportParameter rp = new ReportParameter("paramDataScadenta", scadentaMaxima);
            this.reportViewer1.LocalReport.SetParameters(rp);
            this.SituatieScadenteBindingSource.DataSource = listaSituatieScadenteDePrintat;
            this.reportViewer1.RefreshReport();
        }
    }
}
