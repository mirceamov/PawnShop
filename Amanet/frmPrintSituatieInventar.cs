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
    public partial class frmPrintSituatieInventar : Form
    {
        public List<claseDB.ContracteView> listaContracteDePrintat = new List<claseDB.ContracteView>();
        public frmPrintSituatieInventar(List<claseDB.ContracteView> _listaContracte)
        {
            InitializeComponent();
            listaContracteDePrintat = _listaContracte;
        }

        private void frmPrintSituatieInventar_Load(object sender, EventArgs e)
        {
            this.ContracteViewBindingSource.DataSource = listaContracteDePrintat;
            this.rvPrintareRaport.RefreshReport();
        }
    }
}
