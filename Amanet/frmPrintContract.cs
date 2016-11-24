using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Amanet
{
    public partial class frmPrintContract : Form
    {
        public frmPrintContract()
        {
            InitializeComponent();
            
        }

        private void frmContractPreview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AmanetDataSet.lstPrintareContract' table. You can move, or remove it, as needed.
            this.lstPrintareContractTableAdapter.Connection.ConnectionString = @"Data Source="+global.instanta+";Initial Catalog="+global.db+";User ID="+global.user+";Password="+global.pass+";MultipleActiveResultSets=True;Application Name=EntityFramework";
            this.lstPrintareContractTableAdapter.Fill(this.AmanetDataSet.lstPrintareContract);
            this.rvPrintareRaport.RefreshReport();
        }
    }
}
