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
    public partial class frmContractFinalizare : Form
    {
        #region variabile

        public int idContract;

        #endregion

        #region functii

        public frmContractFinalizare(int _idContract)
        {
            InitializeComponent();
            idContract = _idContract;
        }

        private void SeteazaValori(claseDB.InformatiiContractFinalizare _contract)
        {
            int numarZileTrecute = (DateTime.Now.Date - _contract.DataContract.Date).Days;

            lblDataContract.Text = lblDataContract.Text + " " + _contract.DataContract.Date.ToString("dd-MM-yyyy");
            lblDataCurenta.Text = lblDataCurenta.Text + " " + DateTime.Now.Date.ToString("dd-MM-yyyy");
            lblDataScadenta.Text = lblDataScadenta.Text + " " + ((DateTime)_contract.DataScadenta).Date.ToString("dd-MM-yyyy");
            lblNumarContract.Text = lblNumarContract.Text + " " + _contract.NrContract;            
            lblNumarDeZileTrecute.Text = lblNumarDeZileTrecute.Text + " " + numarZileTrecute + " zile";
            lblNumarZileInitiale.Text = lblNumarZileInitiale.Text + " " + _contract.NrZile + " zile";
            lblValComisionTotalFinal.Text = lblValComisionTotalFinal.Text + " " + (numarZileTrecute * _contract.ValoareZi).Value.ToString("0.00") + " lei";
            lblValComisionTotalInitial.Text = lblValComisionTotalInitial.Text + " " + (_contract.NrZile * _contract.ValoareZi).Value.ToString("0.00") + " lei";
            lblValComisionZi.Text = lblValComisionZi.Text + " " + _contract.ValoareZi.Value.ToString("0.00") + " lei";
            lblValCredit.Text = lblValCredit.Text + " " + _contract.ValoareCredit.Value.ToString("0.00") + " lei";
            lblValCreditComisionFinal.Text = lblValCreditComisionFinal.Text + " " + (_contract.ValoareCredit + (_contract.ValoareZi * numarZileTrecute)).Value.ToString("0.00") + " lei";
            lblValCreditComisionInitial.Text = lblValCreditComisionInitial.Text + " " + (_contract.ValoareCredit + (_contract.ValoareZi * _contract.NrZile)).Value.ToString("0.00") + " lei";
            lblValComisionTotal10.Text = lblValComisionTotal10.Text + " " + (10 * _contract.ValoareZi).Value.ToString("0.00") + " lei";
            lblValCreditComision10.Text = lblValCreditComision10.Text + " " + (_contract.ValoareCredit + (_contract.ValoareZi * 10)).Value.ToString("0.00") + " lei";            
        }

        #endregion

        #region actiuni

        private void frmContractFinalizare_Shown(object sender, EventArgs e)
        {
            claseDB.InformatiiContractFinalizare contractInfo = functiiDB.ContractInfo(idContract);
            SeteazaValori(contractInfo);
        }

        private void btnFinalizeazaContract_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Doriti inchiderea contractului ca FINALIZAT (contractul a fost platit)?", "Inchidere contract finalizat", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                functiiDB.InchideContract(idContract, global.StareContracte.FINALIZAT);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        #endregion
    }
}
