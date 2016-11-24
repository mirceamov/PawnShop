using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amanet
{
    public partial class frmContracte : Form
    {
        #region variabile
        List<claseDB.ContracteView> listaContracteView = new List<claseDB.ContracteView>();
        List<claseDB.ProduseContractView> listaProduseContractView = new List<claseDB.ProduseContractView>();
        List<claseDB.SituatieScadente> listaSituatieScadente = new List<claseDB.SituatieScadente>();
        #endregion

        #region functii
        public frmContracte()
        {
            InitializeComponent();
        }

        private void FormateazaGrid(DataGridView _dgv)
        {
            if(_dgv.RowCount > 0)
            {
                for(int rand = 0; rand<_dgv.Rows.Count;rand++)
                {
                    for(int coloana = 0; coloana<_dgv.Columns.Count;coloana++)
                    {
                        if(_dgv[coloana,rand].ValueType.FullName.Contains("Decimal"))
                        {
                            _dgv.Columns[coloana].DefaultCellStyle.Format = "0.00##";
                        }
                        if (_dgv[coloana, rand].ValueType.FullName.Contains("DateTime"))
                        {
                            _dgv.Columns[coloana].DefaultCellStyle.Format = "dd-MM-yyyy";
                        }
                    }
                    if (_dgv.Columns.Contains("DataScadenta") && _dgv.Columns.Contains("StareContract"))
                    {
                        if (Convert.ToDateTime(_dgv["DataScadenta", rand].Value).Date < DateTime.Now.Date && Convert.ToString(_dgv["StareContract", rand].Value) == global.StareContracte.ACTIV.ToString())
                        {
                            _dgv.Rows[rand].DefaultCellStyle.BackColor = Color.LightSalmon;
                        }
                    }
                }                
            }
        }

        private void AscundeColoaneContracte()
        {
            dgvContracte.Columns["idContract"].Visible = false;
            dgvContracte.Columns["ValoareZi"].Visible = false;
            dgvContracte.Columns["NrZile"].Visible = false;
        }

        private void SchimbaHeaderTextColoane()
        {
            dgvContracte.Columns["NumePrenumeClient"].HeaderText = "Nume Prenume";
            dgvContracte.Columns["GramajAurTotal"].HeaderText = "Gramaj aur";
            dgvContracte.Columns["GramajPieseTotal"].HeaderText = "Gramaj piese";
        }

        public void PopuleazaGridContracteView(DateTime _scadenta, string _stare, string _numePrenume = "")
        {
            SeteazaStatus("Asteptati incarcarea contractelor existente...");
            Application.DoEvents();
            listaContracteView.Clear();           
            dgvContracte.DataSource = null;
            listaContracteView = functiiDB.PopuleazaContracteView(_scadenta, _stare, _numePrenume);
            listaProduseContractView.Clear();
            dgvProduseContract.DataSource = null;            

            dgvContracte.SelectionChanged -= this.dgvContracte_SelectionChanged;
            dgvContracte.DataSource = listaContracteView;
            dgvContracte.SelectionChanged += this.dgvContracte_SelectionChanged;
            dgvContracte.CurrentCell = null;
            AscundeColoaneContracte();
            FormateazaGrid(dgvContracte);
            SchimbaHeaderTextColoane();
            SeteazaStatus();
        }

        private void PopuleazaGridProduseContractView(int _idContractSelectat)
        {
            listaProduseContractView.Clear();
            listaProduseContractView = functiiDB.PopuleazaProduseContractView(_idContractSelectat);
            dgvProduseContract.DataSource = null;
            dgvProduseContract.DataSource = listaProduseContractView;
            dgvProduseContract.CurrentCell = null;
            FormateazaGrid(dgvProduseContract);
        }

        private void GolesteFiltre()
        {
            cbStareContract.SelectedIndex = 0;
            dtpScadenta.Value = DateTime.Now.AddMonths(12);
            txtFiltruNumePrenume.Text = "";
        }
        
        /// <summary>
        /// Daca se scrie un mesaj in parametru atunci panoul operatiuni se va inactiva iar statusul va afisa mesajul.
        /// Altfel panoul de operatiuni va fi activ iar statusul va fi fara mesaj.
        /// </summary>
        /// <param name="_mesaj"></param>
        public void SeteazaStatus(string _mesaj = "")
        {
            if (_mesaj != "")
            {
                gbOperatiuni.Enabled = false;
            }
            else
            {
                gbOperatiuni.Enabled = true;
            }
            lblStatus.Text = _mesaj;
        }

        #endregion

        #region actiuni
        private void frmContracte_Shown(object sender, EventArgs e)
        {
            GolesteFiltre();
            PopuleazaGridContracteView(dtpScadenta.Value.Date, cbStareContract.Text, txtFiltruNumePrenume.Text);
            txtFiltruNumePrenume.Focus();
        }

        private void btnArataFiltre_Click(object sender, EventArgs e)
        {
            if(gbFiltre.Visible)
            {
                gbFiltre.Visible = false;
                btnArataFiltre.Text = "Arata filtre";
            }
            else
            {
                gbFiltre.Visible = true;
                btnArataFiltre.Text = "Ascunde filtre";
            }
        }

        private void dgvContracte_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvContracte.SelectedRows.Count > 0)
            {
                int rand = dgvContracte.SelectedRows[0].Index;
                int idContractSelectat = (int)dgvContracte["idContract", rand].Value;
                PopuleazaGridProduseContractView(idContractSelectat);
            }
        }

        private void btnAdaugaContractNou_Click(object sender, EventArgs e)
        {
            using(frmContractAdaugare frmContractAdaugare2 = new frmContractAdaugare())
            {
                if(frmContractAdaugare2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    GolesteFiltre();
                    PopuleazaGridContracteView(dtpScadenta.Value.Date, cbStareContract.Text, txtFiltruNumePrenume.Text);
                }
            }
        }

        private void btnFiltreaza_Click(object sender, EventArgs e)
        {
            PopuleazaGridContracteView(dtpScadenta.Value.Date, cbStareContract.Text, txtFiltruNumePrenume.Text);
        }

        private void btnGolesteFiltre_Click(object sender, EventArgs e)
        {
            GolesteFiltre();
        }

        private void txtFiltruNumePrenume_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnFiltreaza_Click(null, null);
            }
        }

        private void btnFinalizeazaContract_Click(object sender, EventArgs e)
        {
            if (dgvContracte.SelectedRows.Count > 0)
            {
                int rand = (int)dgvContracte.SelectedRows[0].Index;
                int idContractSelectat = (int)dgvContracte["idContract", rand].Value;
                DateTime dataContract = DateTime.Parse(dgvContracte["DataContract", rand].Value.ToString());
                string stareContract = dgvContracte["StareContract", rand].Value.ToString();
                if (stareContract == global.StareContracte.ACTIV.ToString())
                {
                    using (frmContractFinalizare frmContractFinalizare2 = new frmContractFinalizare(idContractSelectat))
                    {
                        if (frmContractFinalizare2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            GolesteFiltre();
                            PopuleazaGridContracteView(dtpScadenta.Value.Date, cbStareContract.Text, txtFiltruNumePrenume.Text);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Contractul selectat nu este ACTIV.");
                }
            }
            else
            {
                MessageBox.Show("Selectati un contract din lista.");
            }
        }

        private void btnPrinteazaContract_Click(object sender, EventArgs e)
        {
            if(dgvContracte.SelectedRows.Count>0)
            {
                int rand = (int)dgvContracte.SelectedRows[0].Index;
                int idContractSelectat = (int)dgvContracte["idContract", rand].Value;
                lstPrintareContract contractDePrintat = functiiDB.GenereazaContractDePrintat(idContractSelectat);

                using(var rpt = new frmPrintContract())
                {
                    rpt.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Selectati un contract din lista.");
            }
        }

        private void btnPrinteazaSituatieInventar_Click(object sender, EventArgs e)
        {
            if (listaContracteView.Count > 0)
            {   
                using (var rpt = new frmPrintSituatieInventar(listaContracteView))
                {
                    rpt.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Nu exista contracte afisate pe ecran rezultate in urma filtrarii. Modificati filtrele si reincercati filtrarea contractelor. Dupa afisarea lor in fereastra, puteti tipari situatia.");
            }
        }

        private void btnPrinteazaSituatieScadente_Click(object sender, EventArgs e)
        {
            listaSituatieScadente = functiiDB.ReturneazaSituatieScadente(dtpScadenta.Value.Date);
            if (listaSituatieScadente.Count > 0)
            {
                using (var rpt = new frmPrintSituatieScadente(listaSituatieScadente, dtpScadenta.Value.Date.ToString("dd-MM-yyyy")))
                {
                    rpt.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Nu exista contracte cu data scadenta mai mica decat cea selectata. Modificati data scadenta si reincercati tiparirea.");
                dtpScadenta.Focus();
            }
        }

        private void btnPrinteazaContract_MouseEnter(object sender, EventArgs e)
        {
            lblInfoTiparire.Text = "Tipareste contractul selectat din lista de contracte afisate.";
        }

        private void btnPrinteazaContract_MouseLeave(object sender, EventArgs e)
        {
            lblInfoTiparire.Text = "";
        }

        private void btnPrinteazaSituatieInventar_MouseEnter(object sender, EventArgs e)
        {
            lblInfoTiparire.Text = "Tipareste un document de tipul SITUATIE INVENTAR pe baza contractelor afisate in urma filtrarii.";
        }

        private void btnPrinteazaSituatieInventar_MouseLeave(object sender, EventArgs e)
        {
            lblInfoTiparire.Text = "";
        }

        private void btnPrinteazaSituatieScadente_MouseEnter(object sender, EventArgs e)
        {
            lblInfoTiparire.Text = "Tipareste situatia contractelor scadente la o data mai mica decat cea selectata in filtre.";
        }

        private void btnPrinteazaSituatieScadente_MouseLeave(object sender, EventArgs e)
        {
            lblInfoTiparire.Text = "";
        }
        #endregion
    }
}
