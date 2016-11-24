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
    public partial class frmContractAdaugare : Form
    {
        #region variabile
        BindingList<claseDB.ProduseContractAdaugare> listaProduseContract = new BindingList<claseDB.ProduseContractAdaugare>();
        #endregion

        #region functii
        public frmContractAdaugare()
        {
            InitializeComponent();
        }
        


        private void PopuleazaCbClienti()
        {
            functiiDB.PopuleazaListaCbClienti();
            cbClient.DataSource = null;
            cbClient.DisplayMember = "NumePrenume";
            cbClient.ValueMember = "id";
            cbClient.DataSource = functiiDB.listaCbClienti;
            cbClient.SelectedItem = null;
        }

        private void PopuleazaCbProduse()
        {
            functiiDB.PopuleazaListaCbProduse();
            cbProdus.DataSource = null;
            cbProdus.DisplayMember = "Denumire";
            cbProdus.ValueMember = "id";
            cbProdus.DataSource = functiiDB.listaCbProduse;
            cbProdus.SelectedItem = null;
        }

        private void PopuleazaCbCalitati()
        {
            functiiDB.PopuleazaListaCbCalitati();
            cbCalitate.DataSource = null;
            cbCalitate.DisplayMember = "Denumire";
            cbCalitate.ValueMember = "id";
            cbCalitate.DataSource = functiiDB.listaCbCalitati;
            cbCalitate.SelectedItem = null;
        }



        private bool VerificaAdaugareProdusLaContract()
        {
            string bucatiS = txtBucati.Text.Trim();
            string gramajPiesaS = txtGramajPiesa.Text.Trim().Replace(',','.');
            string gramajAurS = txtGramajAur.Text.Trim().Replace(',', '.');            
            string valoareProdusS = txtValoareProdus.Text.Trim().Replace(',','.');
            
            if(cbProdus.SelectedValue == null)
            {
                MessageBox.Show("Nu ati selectat produsul pe care il doriti in contract.");
                cbProdus.Focus();
                return false;
            }

            int bucatiD = 0;
            if(bucatiS == "" || !int.TryParse(bucatiS, out bucatiD) || bucatiS.StartsWith("-"))
            {
                MessageBox.Show("Numarul de bucati incorect.");
                txtBucati.Focus();
                txtBucati.SelectAll();
                return false;
            }
            
            if (cbCalitate.SelectedValue == null)
            {
                MessageBox.Show("Nu ati selectat calitatea produsul pe care il doriti in contract.");
                cbCalitate.Focus();
                return false;
            }

            decimal gramajPiesaD = 0;            
            if (gramajPiesaS == "" || !decimal.TryParse(gramajPiesaS, out gramajPiesaD) || gramajPiesaS.StartsWith("-"))
            {
                MessageBox.Show("Gramaj piesa(e) incorect.");
                txtGramajPiesa.Focus();
                txtGramajPiesa.SelectAll();
                return false;
            }

            decimal gramajAurD = 0;
            if (gramajAurS == "" || !decimal.TryParse(gramajAurS, out gramajAurD) || gramajAurS.StartsWith("-"))
            {
                MessageBox.Show("Gramaj aur incorect.");
                txtGramajAur.Focus();
                txtGramajAur.SelectAll();
                return false;
            }

            

            decimal valoareProdusD = 0;
            if (valoareProdusS == "" || !decimal.TryParse(valoareProdusS, out valoareProdusD) || valoareProdusS.StartsWith("-"))
            {
                MessageBox.Show("Valoarea produsului incorecta.");
                txtValoareProdus.Focus();
                txtValoareProdus.SelectAll();
                return false;
            }

            return true;
        }
        
        private void PopuleazaDgvProduseContract()
        {
            dgvProduseContract.DataSource = null;
            dgvProduseContract.DataSource = listaProduseContract;
            dgvProduseContract.Columns["idProdus"].Visible = false;
            dgvProduseContract.Columns["idCalitate"].Visible = false;
            dgvProduseContract.Columns["DenumireProdus"].HeaderText = "Produs";
            dgvProduseContract.Columns["DenumireCalitate"].HeaderText = "Calitate";
            dgvProduseContract.Columns["ValoareProdus"].HeaderText = "Valoare";
        }


        /// <summary>
        /// Procedura populeaza zona de informatii client cu datele clientului cu id-ul din parametru
        /// </summary>
        /// <param name="_idClient"></param>
        private void PopuleazaInfoClient(int _idClient)
        {
            Clienti client = functiiDB.ReturneazaClientDupaId(_idClient);
            if(client != null)
            {
                lblClientInfoDomiciliu.Text = client.domiciliul == null ? "" : client.domiciliul;
                lblClientInfoElibDe.Text = client.ciEliberatDe == null ? "" : client.ciEliberatDe;
                lblClientInfoElibLa.Text = client.ciEliberatLa == null ? "" : client.ciEliberatLa.Value.Date.ToString("dd-MM-yyyy");
                lblClientInfoNumar.Text = client.ciNumar;
                lblClientInfoSerie.Text = client.ciSerie;
                lblClientInfoTelefon.Text = client.telefon == null ? "" : client.telefon;
            }
        }

        private void GolesteInfoClient()
        {
            lblClientInfoDomiciliu.Text = "";
            lblClientInfoElibDe.Text = "";
            lblClientInfoElibLa.Text = "";
            lblClientInfoNumar.Text = "";
            lblClientInfoSerie.Text = "";
            lblClientInfoTelefon.Text = "";
        }



        private bool VerificaProdusNou()
        {
            string denumireProdusNou = txtDenumireProdusNou.Text.Trim();
            
            if (denumireProdusNou == "" || denumireProdusNou.Length > 250)
            {
                MessageBox.Show("Nu ati introdus o denumire de produs valida. Maxim 250 de caractere.");
                txtDenumireProdusNou.Focus();
                txtDenumireProdusNou.SelectAll();
                return false;
            }

            return true;
        }

        private int SalveazaProdusNou()
        {
            string denumireProdusNou = txtDenumireProdusNou.Text.Trim();
            if (VerificaProdusNou())
            {
                if (!functiiDB.VerificaUnicitateProdus(denumireProdusNou))
                {
                    MessageBox.Show("Produsul '" + denumireProdusNou + "' mai exista in baza de date.");
                    return 0;
                }
                Produse produsNou = new Produse();
                produsNou.denumire = denumireProdusNou;                
                produsNou.creatLa = DateTime.Now;
                produsNou.inactiv = false;
                produsNou.lockVersion = 0;
                produsNou.modificatLa = DateTime.Now;
                if (functiiDB.SalveazaProdusNou(produsNou))
                {
                    MessageBox.Show("Produsul '" + denumireProdusNou + "' a fost salvat cu succes.");
                    return produsNou.id;
                }
            }
            return 0;
        }

        private void GolesteProdusNou()
        {
            txtDenumireProdusNou.Text = "";
            gbAdaugareProdus.Visible = false;
        }



        private bool VerificaCalitateNoua()
        {
            string denumireCalitateNoua = txtDenumireCalitateNoua.Text.Trim();

            if (denumireCalitateNoua == "" || denumireCalitateNoua.Length > 250)
            {
                MessageBox.Show("Nu ati introdus o denumire de calitate valida. Maxim 250 de caractere.");
                txtDenumireCalitateNoua.Focus();
                txtDenumireCalitateNoua.SelectAll();
                return false;
            }
            return true;
        }

        private int SalveazaCalitateNoua()
        {
            string denumireCalitateNoua = txtDenumireCalitateNoua.Text.Trim();
            if (VerificaCalitateNoua())
            {
                if (!functiiDB.VerificaUnicitateCalitate(denumireCalitateNoua))
                {
                    MessageBox.Show("Calitatea '" + denumireCalitateNoua + "' mai exista in baza de date.");
                    return 0;
                }
                Calitati calitateNoua = new Calitati();
                calitateNoua.denumire = denumireCalitateNoua;
                calitateNoua.creatLa = DateTime.Now;
                calitateNoua.inactiv = false;
                calitateNoua.lockVersion = 0;
                calitateNoua.modificatLa = DateTime.Now;
                if (functiiDB.SalveazaCalitateNoua(calitateNoua))
                {
                    MessageBox.Show("Calitatea '" + denumireCalitateNoua + "' a fost salvat cu succes.");
                    return calitateNoua.id;
                }
            }
            return 0;
        }
        
        private void GolesteCalitateNoua()
        {
            txtDenumireCalitateNoua.Text = "";
            gbAdaugareCalitate.Visible = false;
        }



        private bool VerificaClientNou()
        {
            string numeClientNou = txtNumeClientNou.Text.Trim();
            string prenumeClientNou = txtPrenumeClientNou.Text.Trim();
            string domiciliuClientNou = txtDomiciliuClientNou.Text.Trim();
            string serieClientNou = txtSerieClientNou.Text.Trim();
            string numarClientNou = txtNumarClientNou.Text.Trim();
            string eliberatDeClientNou = txtEliberatDeClientNou.Text.Trim();
            DateTime eliberatLaClientNou = dtpEliberatLaClientNou.Value.Date;
            string telefonClientNou = txtTelefonClientNou.Text.Trim();

            if (numeClientNou == "" || numeClientNou.Length > 50)
            {
                MessageBox.Show("Nu ati introdus un nume de client valid. Maxim 50 de caractere.");
                txtNumeClientNou.Focus();
                txtNumeClientNou.SelectAll();
                return false;
            }
            if (prenumeClientNou == "" || prenumeClientNou.Length > 50)
            {
                MessageBox.Show("Nu ati introdus un prenume de client valid. Maxim 50 de caractere.");
                txtPrenumeClientNou.Focus();
                txtPrenumeClientNou.SelectAll();
                return false;
            }
            if (serieClientNou == "" || serieClientNou.Length > 2)
            {
                MessageBox.Show("Nu ati introdus o serie de buletin valida. Maxim 2(doua) caractere.");
                txtSerieClientNou.Focus();
                txtSerieClientNou.SelectAll();
                return false;
            }
            if (numarClientNou == "" || numarClientNou.Length > 6 || !global.EsteNumarCI(numarClientNou))
            {
                MessageBox.Show("Nu ati introdus un numar de buletin valid. Maxim 6 caractere.");
                txtNumarClientNou.Focus();
                txtNumarClientNou.SelectAll();
                return false;
            }
            if (eliberatDeClientNou.Length > 20)
            {
                MessageBox.Show("Nu ati introdus o valoare valida la eliberat de (CI). Maxim 20 de caractere.");
                txtEliberatDeClientNou.Focus();
                txtEliberatDeClientNou.SelectAll();
                return false;
            }
            if (telefonClientNou.Length > 20)
            {
                MessageBox.Show("Nu ati introdus un numar de telefon valid. Maxim 20 caractere.");
                txtTelefonClientNou.Focus();
                txtTelefonClientNou.SelectAll();
                return false;
            }
            return true;
        }

        private int SalveazaClientNou()
        {
            string numeClientNou = txtNumeClientNou.Text.Trim();
            string prenumeClientNou = txtPrenumeClientNou.Text.Trim();
            string domiciliuClientNou = txtDomiciliuClientNou.Text.Trim();
            string serieClientNou = txtSerieClientNou.Text.Trim();
            string numarClientNou = txtNumarClientNou.Text.Trim();
            string eliberatDeClientNou = txtEliberatDeClientNou.Text.Trim();
            DateTime eliberatLaClientNou = dtpEliberatLaClientNou.Value.Date;
            string telefonClientNou = txtTelefonClientNou.Text.Trim();

            if (VerificaClientNou())
            {
                if (!functiiDB.VerificaUnicitateClient(numeClientNou, prenumeClientNou, serieClientNou, numarClientNou))
                {
                    MessageBox.Show("Clientul '" + numeClientNou + " " + prenumeClientNou + "' mai exista in baza de date.");
                    return 0;
                }
                Clienti clientNou = new Clienti();
                clientNou.ciEliberatDe = eliberatDeClientNou;
                clientNou.ciEliberatLa = eliberatLaClientNou;
                clientNou.ciNumar = numarClientNou;
                clientNou.ciSerie = serieClientNou;
                clientNou.domiciliul = domiciliuClientNou;
                clientNou.nume = numeClientNou;
                clientNou.prenume = prenumeClientNou;
                clientNou.telefon = telefonClientNou;
                clientNou.creatLa = DateTime.Now;
                clientNou.inactiv = false;
                clientNou.lockVersion = 0;
                clientNou.modificatLa = DateTime.Now;
                if (functiiDB.SalveazaClientNou(clientNou))
                {
                    MessageBox.Show("Clientul '" + numeClientNou + " " + prenumeClientNou + "' a fost salvat cu succes.");
                    return clientNou.id;
                }
            }
            return 0;
        }
   
        private void GolesteClientNou()
        {
            txtNumeClientNou.Text = "";
            txtPrenumeClientNou.Text = "";
            txtDomiciliuClientNou.Text = "";
            txtSerieClientNou.Text = "";
            txtNumarClientNou.Text = "";
            txtEliberatDeClientNou.Text = "";
            dtpEliberatLaClientNou.Value = DateTime.Now;
            txtTelefonClientNou.Text = "";
            gbAdaugareClient.Visible = false;
        }

        

        private void GolesteProdusDinContract()
        {
            txtBucati.Text = "";
            txtDescriereProdusDinContract.Text = "";
            txtGramajPiesa.Text = "";
            txtGramajAur.Text = "";
            txtValoareProdus.Text = "";
            txtPretAur.Text = "";
            cbCalitate.SelectedItem = null;           
        }

        private bool VerificaValoriProdusNou()
        {
            string pretAurGramS = txtPretAur.Text.Trim().Replace(',', '.');
            string gramajAurS = txtGramajAur.Text.Trim().Replace(',', '.');            
            
            decimal pretAurGramD = 0;
            if (pretAurGramS == "" || !decimal.TryParse(pretAurGramS, out pretAurGramD) || pretAurGramS.StartsWith("-"))
            {
                return false;
            }

            decimal gramajAurD = 0;
            if (gramajAurS == "" || !decimal.TryParse(gramajAurS, out gramajAurD) || gramajAurS.StartsWith("-"))
            {
                return false;
            }
            
            return true;
        }


        private bool VerificaValoriContractNou()
        {
            string valCreditConS = txtValoareCredit.Text.Trim().Replace(',', '.');
            string comisionConS = txtComision.Text.Trim().Replace(',', '.');
            string nrZileConS = txtNumarZile.Text.Trim();
            decimal valCreditConD = 0;
            if (valCreditConS == "" || !decimal.TryParse(valCreditConS, out valCreditConD))
            {
                return false;
            }
            decimal comisionConD = 0;
            if (comisionConS == "" || !decimal.TryParse(comisionConS, out comisionConD))
            {
                return false;
            }
            int nrZileConI = 0;
            if (nrZileConS == "" || !int.TryParse(nrZileConS, out nrZileConI))
            {
                return false;
            }
            return true;
        }

        private bool VerificaContractNou()
        {
            string nrConS = txtNumarContract.Text.Trim();
            DateTime dataCon = dtpDataContract.Value.Date;
            int? idClient = (int?)cbClient.SelectedValue;
            string valCreditConS = txtValoareCredit.Text.Trim().Replace(',','.');
            string comisionConS = txtComision.Text.Trim().Replace(',', '.');
            string nrZileConS = txtNumarZile.Text.Trim();
            DateTime dataScadentaCon = dtpDataScadenta.Value.Date;
            string observatiiCon = txtObservatii.Text.Trim();

            if(listaProduseContract.Count == 0)
            {
                MessageBox.Show("Nu ati introdus produse in contract.");
                cbProdus.Focus();
                return false;
            }
            int nrConI = 0;
            if (nrConS == "" || !int.TryParse(nrConS, out nrConI))
            {
                MessageBox.Show("Numarul de contract nu este corect.");
                txtNumarContract.Focus();
                txtNumarContract.SelectAll();
                return false;
            }
            
            if (dataCon > dataScadentaCon)
            {
                MessageBox.Show("Data contractului nu poate fi mai mare decat data scadentei.");
                dtpDataContract.Focus();
                return false;
            }
            if (idClient == null)
            {
                MessageBox.Show("Nu ati selectat un client valid.");
                cbClient.Focus();
                return false;
            }
            if (observatiiCon.Length > 500)
            {
                MessageBox.Show("Observatiile introduse sunt invalide. Maxim 500 de caractere.");
                txtObservatii.Focus();
                txtObservatii.SelectAll();
                return false;
            }
            decimal valCreditConD = 0;
            if (valCreditConS == "" || !decimal.TryParse(valCreditConS, out valCreditConD))
            {
                MessageBox.Show("Valoarea creditului introdusa nu este corecta.");
                txtValoareCredit.Focus();
                txtValoareCredit.SelectAll();
                return false;
            }
            decimal comisionConD = 0;
            if (comisionConS == "" || !decimal.TryParse(comisionConS, out comisionConD))
            {
                MessageBox.Show("Comisionul introdus nu este corect.");
                txtComision.Focus();
                txtComision.SelectAll();
                return false;
            }
            int nrZileConI = 0;
            if (nrZileConS == "" || !int.TryParse(nrZileConS,out nrZileConI))
            {
                MessageBox.Show("Numarul de zile introdus nu este corect.");
                txtNumarZile.Focus();
                txtNumarZile.SelectAll();
                return false;
            }
            return true;
        }
        
        private int SalveazaContractNou()
        {
            if (VerificaContractNou())
            {
                int nrCon = int.Parse(txtNumarContract.Text.Trim());
                DateTime dataCon = dtpDataContract.Value.Date;
                int idClient = (int)cbClient.SelectedValue;

                if (!functiiDB.VerificaUnicitateContract(nrCon, dataCon, idClient))
                {
                    MessageBox.Show("Contractul cu numarul '" + nrCon + "' din data " + dataCon.ToString("dd-MM-yyy") + " mai exista in baza de date pentru acest client.");
                    return 0;
                }
                
                ContracteAntet contractNou = new ContracteAntet();
                contractNou.comisionProcZi = decimal.Parse(txtComision.Text.Trim().Replace(',', '.'));
                contractNou.creatLa = DateTime.Now;
                contractNou.dataContract = dataCon;
                contractNou.dataScadenta = dtpDataScadenta.Value.Date;
                contractNou.idClient = idClient;
                contractNou.inactiv = false;
                contractNou.lockVersion = 0;
                contractNou.modificatLa = DateTime.Now;
                contractNou.nrContract = nrCon;
                contractNou.nrZile = int.Parse(txtNumarZile.Text.Trim());
                contractNou.observatii = txtObservatii.Text.Trim();
                contractNou.stareContract = global.StareContracte.ACTIV.ToString();
                contractNou.valoareCredit = decimal.Parse(txtValoareCredit.Text.Trim().Replace(',', '.'));
                contractNou.valoareCreditZi = decimal.Parse(txtValoareComisionZi.Text.Trim().Replace(',', '.'));
                contractNou.valoareDebit = decimal.Parse(txtValoareCreditPlusComision.Text.Trim().Replace(',', '.'));

                if (functiiDB.SalveazaContract(contractNou, listaProduseContract.ToList()))
                {
                    MessageBox.Show("Contractul cu numarul '" + nrCon + "' din data " + dataCon.ToString("dd-MM-yyy") + " a fost salvat cu succes.");
                    return contractNou.id;
                }
            }
            return 0;
        }

        private void GolesteContractNou()
        {
            txtNumarContract.Text = "";
            dtpDataContract.Value = DateTime.Now;

            cbClient.DataSource = null;
            cbProdus.DataSource = null;
            cbCalitate.DataSource = null;
            dgvProduseContract.DataSource = null;
            listaProduseContract.Clear();
            
            txtGramajPiesa.Text = "";
            txtGramajAur.Text = "";
            txtDescriereProdusDinContract.Text = "";
            txtBucati.Text = "";
            txtValoareProdus.Text = "";
            txtValoareCredit.Text = "";
            txtValoareComisionZi.Text = "";
            txtValoareCreditPlusComision.Text = "";
            txtComision.Text = "";
            txtNumarZile.Text = "";
            dtpDataScadenta.Value = DateTime.Now;
            
            GolesteProdusNou();
            GolesteClientNou();
            GolesteCalitateNoua();
            GolesteInfoClient();

        }



        private void AnimaPanou(Panel _pnl, int _viteza)
        {            
            int wInit = _pnl.Width;
            _pnl.Width = 0;
            
            while(_pnl.Width < wInit)
            {   
                if (_pnl.Width+_viteza > wInit) _pnl.Width = wInit;
                else _pnl.Width+=_viteza;
                Thread.Sleep(10);
            }            
        }
        
        private void CalculeazaValoareCredit()
        {
            if(listaProduseContract.Count>0)
            {
                decimal valoareCredit = 0;
                foreach(var produsContract in listaProduseContract)
                {
                    valoareCredit = valoareCredit + produsContract.ValoareProdus;
                }
                txtValoareCredit.Text = valoareCredit.ToString();
            }
            else
            {
                txtValoareCredit.Text = "0";
            }
        }

        private void CalculeazaValoareProdus()
        {
            if (VerificaValoriProdusNou())
            {
                decimal pretAurD = decimal.Parse(txtPretAur.Text.Trim().Replace(',', '.'));                
                decimal gramajAurD = decimal.Parse(txtGramajAur.Text.Trim().Replace(',', '.'));
                
                decimal valoareProdusD = pretAurD * gramajAurD;
                txtValoareProdus.Text = valoareProdusD.ToString("0.00");                
            }
        }

        private void CalculeazaTotaluriContract()
        {
            if (VerificaValoriContractNou())
            {
                decimal comisionZiD = decimal.Parse(txtComision.Text.Trim().Replace(',', '.'));
                int nrZileI = int.Parse(txtNumarZile.Text.Trim());
                decimal valoareCreditD = decimal.Parse(txtValoareCredit.Text.Trim().Replace(',', '.'));
                decimal valoareComisionZiD = (valoareCreditD * comisionZiD)/100;
                decimal valoareComisionTotalD = valoareComisionZiD * nrZileI;
                decimal valoareCreditPlusComisionD = valoareCreditD + valoareComisionTotalD;
                DateTime scadentaDT = dtpDataContract.Value.Date.AddDays(nrZileI-1);
                txtValoareComisionZi.Text = valoareComisionZiD.ToString("0.00");
                txtValoareComisionTotal.Text = valoareComisionTotalD.ToString("0.00");
                txtValoareCreditPlusComision.Text = valoareCreditPlusComisionD.ToString("0.00");
                dtpDataScadenta.Value = scadentaDT;
            }
        }

        #endregion

        #region actiuni

        private void frmContractAdaugare_Shown(object sender, EventArgs e)
        {
            PopuleazaCbCalitati();
            PopuleazaCbClienti();
            PopuleazaCbProduse();
            PopuleazaDgvProduseContract();
            txtNumarContract.Text = (functiiDB.GenereazaNumarContract()).ToString();
            txtNumarContract.Focus();
        }


        
        private void btnAdaugaProdusNou_Click(object sender, EventArgs e)
        {
            gbAdaugareProdus.Visible = true;
            //AnimaPanou(pnlAdaugareProdusNou, 20);
            txtDenumireProdusNou.Focus();
        }

        private void btnSalveazaProdusNou_Click(object sender, EventArgs e)
        {
            int idProdus = SalveazaProdusNou();
            if(idProdus > 0)
            {
                GolesteProdusNou();
                PopuleazaCbProduse();
                cbProdus.SelectedValue = idProdus;
            }
        }

        private void btnRenuntaProdusNou_Click(object sender, EventArgs e)
        {
            GolesteProdusNou();
        }

        private void txtDenumireProdusNou_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSalveazaProdusNou_Click(null, null);
            }
        }
        

        
        private void btnAdaugaCalitateNoua_Click(object sender, EventArgs e)
        {
            gbAdaugareCalitate.Visible = true;
            //AnimaPanou(pnlAdaugareProdusNou, 20);
            txtDenumireCalitateNoua.Focus();
        }

        private void btnSalveazaCalitateNoua_Click(object sender, EventArgs e)
        {
            int idCalitate = SalveazaCalitateNoua();
            if (idCalitate > 0)
            {
                GolesteCalitateNoua();
                PopuleazaCbCalitati();
                cbCalitate.SelectedValue = idCalitate;
            }
        }

        private void btnRenuntaCalitateNoua_Click(object sender, EventArgs e)
        {
            GolesteCalitateNoua();
        }

        private void txtDenumireCalitateNoua_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSalveazaCalitateNoua_Click(null, null);
            }
        }
 


        private void cbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClient.SelectedValue != null)
            {
                int idClientSelectat = (int)cbClient.SelectedValue;
                PopuleazaInfoClient(idClientSelectat);
            }
            else
            {
                GolesteInfoClient();
            }
        }

        private void btnAdaugaClientNou_Click(object sender, EventArgs e)
        {
            gbAdaugareClient.Visible = true;
            //AnimaPanou(pnlAdaugareProdusNou, 20);
            txtNumeClientNou.Focus();
        }

        private void btnSalveazaClientNou_Click(object sender, EventArgs e)
        {
            int idClientNou = SalveazaClientNou();
            if (idClientNou > 0)
            {
                GolesteClientNou();
                PopuleazaCbClienti();
                cbClient.SelectedValue = idClientNou;
            }
        }

        private void btnRenuntaClientNou_Click(object sender, EventArgs e)
        {
            GolesteClientNou();
        }
        


        private void btnAdaugaProdusInContract_Click(object sender, EventArgs e)
        {
            if(VerificaAdaugareProdusLaContract())
            {
                claseDB.ProduseContractAdaugare prodDeAdaugat = new claseDB.ProduseContractAdaugare();
                prodDeAdaugat.DenumireProdus = cbProdus.Text;
                prodDeAdaugat.Bucati = int.Parse(txtBucati.Text);
                
                string gramajPiesaS = txtGramajPiesa.Text.Trim().Replace(',', '.');
                string gramajAurS = txtGramajAur.Text.Trim().Replace(',', '.');
                string valoareProdusS = txtValoareProdus.Text.Trim().Replace(',', '.');
                prodDeAdaugat.GramajPiesa = decimal.Parse(gramajPiesaS);
                prodDeAdaugat.GramajAur = decimal.Parse(gramajAurS);
                prodDeAdaugat.ValoareProdus = decimal.Parse(valoareProdusS);
                
                prodDeAdaugat.DenumireCalitate = cbCalitate.Text;                
                prodDeAdaugat.idCalitate = (int)cbCalitate.SelectedValue;
                prodDeAdaugat.idProdus = (int)cbProdus.SelectedValue;
                prodDeAdaugat.Descriere = txtDescriereProdusDinContract.Text;
                listaProduseContract.Add(prodDeAdaugat);
                CalculeazaValoareCredit();
            }
        }
        
        private void btnStergeProdusDinContract_Click(object sender, EventArgs e)
        {
            if (dgvProduseContract.SelectedRows.Count > 0)
            {                
                int rand = dgvProduseContract.SelectedRows[0].Index;
                int idProdusDeSters = (int)dgvProduseContract["idProdus", rand].Value;
                string denProdusDeSters = dgvProduseContract["DenumireProdus", rand].Value.ToString();
                decimal gramajProdusDeSters = (decimal)dgvProduseContract["GramajPiesa", rand].Value;
                decimal gramajAurDeSters = (decimal)dgvProduseContract["GramajAur", rand].Value;
                int idCalitateDeSters = (int)dgvProduseContract["idCalitate", rand].Value;
                string denCalitateDeSters = dgvProduseContract["DenumireCalitate", rand].Value.ToString();
                int bucatiDeSters = (int)dgvProduseContract["Bucati", rand].Value;
                decimal valoareProdusDeSters = (decimal)dgvProduseContract["ValoareProdus", rand].Value;
                string descriereProdusDeSters = dgvProduseContract["Descriere", rand].Value.ToString();

                var produsContractDeSters = listaProduseContract.First(p => 
                    p.DenumireCalitate == denCalitateDeSters &&
                    p.DenumireProdus == denProdusDeSters &&
                    p.Bucati == bucatiDeSters &&
                    p.ValoareProdus == valoareProdusDeSters &&
                    p.GramajPiesa == gramajProdusDeSters &&
                    p.GramajAur == gramajAurDeSters &&
                    p.idCalitate == idCalitateDeSters &&
                    p.Descriere == descriereProdusDeSters &&
                    p.idProdus == idProdusDeSters);
                listaProduseContract.Remove(produsContractDeSters);
                CalculeazaValoareCredit();
            }
        }



        private void btnSalveazaContract_Click(object sender, EventArgs e)
        {
            int idContractNou = SalveazaContractNou();
            if (idContractNou > 0)
            {
                if(MessageBox.Show("Doriti listarea contractului?","Listare contract", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    lstPrintareContract contractDePrintat = functiiDB.GenereazaContractDePrintat(idContractNou);

                    using (var rpt = new frmPrintContract())
                    {
                        rpt.ShowDialog();
                    }
                }
                
                GolesteContractNou();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {
            GolesteContractNou();
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
        
        private void txtValoareCredit_TextChanged(object sender, EventArgs e)
        {
            CalculeazaTotaluriContract();
        }

        private void txtValoareCredit_Leave(object sender, EventArgs e)
        {
            CalculeazaTotaluriContract();
        }

        private void txtComision_Leave(object sender, EventArgs e)
        {
            CalculeazaTotaluriContract();
        }

        private void txtNumarZile_Leave(object sender, EventArgs e)
        {
            CalculeazaTotaluriContract();
        }

        private void txtPretAur_Leave(object sender, EventArgs e)
        {
            CalculeazaValoareProdus();
        }

        private void txtGramajAur_Leave(object sender, EventArgs e)
        {
            CalculeazaValoareProdus();
        }

        private void cbProdus_SelectedIndexChanged(object sender, EventArgs e)
        {
            GolesteProdusDinContract();
        }

        #endregion

    }
}
