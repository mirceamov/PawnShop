using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Amanet
{
    public partial class frmClienti : Amanet.frmNomenclatoare
    {
        #region variabile

        BindingList<claseDB.ClientiView> listaClienti = new BindingList<claseDB.ClientiView>();
        Clienti clientDeModificat = new Clienti();

        #endregion

        #region functii

        public frmClienti()
        {
            InitializeComponent();
        }

        private void GolesteCampuri()
        {
            txtDomiciliu.Text = "";
            txtEliberatDe.Text = "";
            txtNumarCi.Text = "";
            txtNume.Text = "";
            txtPrenume.Text = "";
            txtSerieCi.Text = "";
            txtTelefon.Text = "";
            dtpEliberatLa.Value = DateTime.Now;           
        }

        public override void AscundeColoane()
        {
            dgv.Columns["ID"].Visible = false;
            dgv.Columns["Inactiv"].Visible = false;
            dgv.Columns["lockVersion"].Visible = false;
        }

        public override void PopulareGrid()
        {
            SeteazaStatus("Asteptati incarcarea clientilor existenti...");
            base.PopulareGrid();

            listaClienti.Clear();
            foreach (var cli in functiiDB.ReturneazaListaClienti())
            {
                listaClienti.Add(cli);
            }
            dgv.DataSource = listaClienti;
            SeteazaStatus();
        }

        private bool PopulareLaModificare()
        {
            if (dgv.SelectedRows.Count > 0)
            {
                ultimulIdAccesat = (int)dgv["ID", dgv.SelectedRows[0].Index].Value;
                lockVersionGrid = (int)dgv["lockVersion", dgv.SelectedRows[0].Index].Value;
                if (ultimulIdAccesat > 0)
                {
                    clientDeModificat = functiiDB.ReturneazaClientDupaId(ultimulIdAccesat);
                    if (clientDeModificat != null)
                    {
                        txtDomiciliu.Text = clientDeModificat.domiciliul;
                        txtEliberatDe.Text = clientDeModificat.ciEliberatDe;
                        txtNumarCi.Text = clientDeModificat.ciNumar;
                        txtNume.Text = clientDeModificat.nume;
                        txtPrenume.Text = clientDeModificat.prenume;
                        txtSerieCi.Text = clientDeModificat.ciSerie;
                        txtTelefon.Text = clientDeModificat.telefon;
                        dtpEliberatLa.Value = (DateTime)clientDeModificat.ciEliberatLa;
                        return true;
                    }                    
                }
            }
            return false;
        }

        private bool VerificaDateClient()
        {
            string numeClient = txtNume.Text.Trim();
            string prenumeClient = txtPrenume.Text.Trim();
            string domiciliuClient = txtDomiciliu.Text.Trim();
            string serieCi = txtSerieCi.Text.Trim();
            string numarCi = txtNumarCi.Text.Trim();
            string eliberatDeCi = txtEliberatDe.Text.Trim();
            DateTime eliberatLaCi = dtpEliberatLa.Value.Date;
            string telefonClient = txtTelefon.Text.Trim();

            if (numeClient == "" || numeClient.Length > 50)
            {
                MessageBox.Show("Nu ati introdus un nume de client valid. Maxim 50 de caractere.");
                txtNume.Focus();
                txtNume.SelectAll();
                return false;
            }
            if (prenumeClient == "" || prenumeClient.Length > 50)
            {
                MessageBox.Show("Nu ati introdus un prenume de client valid. Maxim 50 de caractere.");
                txtPrenume.Focus();
                txtPrenume.SelectAll();
                return false;
            }
            if (serieCi == "" || serieCi.Length > 2)
            {
                MessageBox.Show("Nu ati introdus o serie de buletin valida. Maxim 2(doua) caractere.");
                txtSerieCi.Focus();
                txtSerieCi.SelectAll();
                return false;
            }
            if (numarCi == "" || numarCi.Length > 6 || !global.EsteNumarCI(numarCi))
            {
                MessageBox.Show("Nu ati introdus un numar de buletin valid. Maxim 6 caractere.");
                txtNumarCi.Focus();
                txtNumarCi.SelectAll();
                return false;
            }
            if (eliberatDeCi.Length > 20)
            {
                MessageBox.Show("Nu ati introdus o valoare valida la eliberat de (CI). Maxim 20 de caractere.");
                txtEliberatDe.Focus();
                txtEliberatDe.SelectAll();
                return false;
            }
            if (telefonClient.Length > 20)
            {
                MessageBox.Show("Nu ati introdus un numar de telefon valid. Maxim 20 caractere.");
                txtTelefon.Focus();
                txtTelefon.SelectAll();
                return false;
            }
            return true;
        }

        private bool Salveaza()
        {
            string numeClient = txtNume.Text.Trim();
            string prenumeClient = txtPrenume.Text.Trim();
            string domiciliuClient = txtDomiciliu.Text.Trim();
            string serieCi = txtSerieCi.Text.Trim();
            string numarCi = txtNumarCi.Text.Trim();
            string eliberatDeCi = txtEliberatDe.Text.Trim();
            DateTime eliberatLaCi = dtpEliberatLa.Value.Date;
            string telefonClient = txtTelefon.Text.Trim();

            if (VerificaDateClient())
            {
                if (modifica) //modificare
                {
                    //verificare unicitate denumire
                    if (clientDeModificat.nume.ToLower() != numeClient.ToLower() ||
                        clientDeModificat.prenume.ToLower() != prenumeClient.ToLower() ||
                        clientDeModificat.ciSerie.ToLower() != serieCi.ToLower() ||
                        clientDeModificat.ciNumar.ToLower() != numarCi.ToLower())
                    {
                        if (!functiiDB.VerificaUnicitateClient(numeClient, prenumeClient, serieCi, numarCi))
                        {
                            MessageBox.Show("Clientul '" + numeClient + " " + prenumeClient + "' mai exista in baza de date.");
                            return false;
                        }
                    }

                    //verificare lockVersion
                    if (clientDeModificat.lockVersion != functiiDB.ReturneazaClientDupaId(ultimulIdAccesat).lockVersion)
                    {
                        MessageBox.Show("Clientul '" + numeClient + " " + prenumeClient + "' a fost modificat intre timp. Anulati si reincercati dupa apasarea butonului Refresh.");
                        return false;
                    }

                    clientDeModificat.ciEliberatDe = eliberatDeCi;
                    clientDeModificat.ciEliberatLa = eliberatLaCi;
                    clientDeModificat.ciNumar = numarCi;
                    clientDeModificat.ciSerie = serieCi;
                    clientDeModificat.domiciliul = domiciliuClient;
                    clientDeModificat.lockVersion++;
                    clientDeModificat.modificatLa = DateTime.Now;
                    clientDeModificat.nume = numeClient;
                    clientDeModificat.prenume = prenumeClient;
                    clientDeModificat.telefon = telefonClient;
                    if (functiiDB.SalveazaClientExistent(ultimulIdAccesat, clientDeModificat))
                    {
                        MessageBox.Show("Clientul '" + numeClient + " " + prenumeClient + "' a fost modificat cu succes.");
                        return true;
                    }                    
                }
                else //adaugare
                {
                    if (!functiiDB.VerificaUnicitateClient(numeClient, prenumeClient, serieCi, numarCi))
                    {
                        MessageBox.Show("Clientul '" + numeClient + " " + prenumeClient + "' mai exista in baza de date.");
                        return false;
                    }
                    Clienti clientNou = new Clienti();
                    clientNou.ciEliberatDe = eliberatDeCi;
                    clientNou.ciEliberatLa = eliberatLaCi;
                    clientNou.ciNumar = numarCi;
                    clientNou.ciSerie = serieCi;
                    clientNou.creatLa = DateTime.Now;
                    clientNou.domiciliul = domiciliuClient;
                    clientNou.inactiv = false;
                    clientNou.lockVersion = 0;
                    clientNou.modificatLa = DateTime.Now;
                    clientNou.nume = numeClient;
                    clientNou.prenume = prenumeClient;
                    clientNou.telefon = telefonClient;
                    if (functiiDB.SalveazaClientNou(clientNou))
                    {
                        MessageBox.Show("Clientul '" + numeClient + " " + prenumeClient + "' a fost salvat cu succes.");
                        return true;
                    }
                }
            }
            return false;
        }

        #endregion

        #region actiuni

        public override void btnAdauga_Click(object sender, EventArgs e)
        {
            base.btnAdauga_Click(sender, e);
            txtNume.Focus();
        }

        public override void btnModifica_Click(object sender, EventArgs e)
        {
            if (PopulareLaModificare())
            {
                base.btnModifica_Click(sender, e);
                txtNume.Focus();
            }
        }

        public override void btnSalveaza_Click(object sender, EventArgs e)
        {
            if (Salveaza())
            {
                base.btnSalveaza_Click(sender, e);
                GolesteCampuri();
            }
        }

        public override void btnAnuleaza_Click(object sender, EventArgs e)
        {
            base.btnAnuleaza_Click(sender, e);
            GolesteCampuri();
        }

        #endregion
    }
}
