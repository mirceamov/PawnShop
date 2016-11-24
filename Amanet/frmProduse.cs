using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Amanet
{
    public partial class frmProduse : Amanet.frmNomenclatoare
    {
        #region variabile

        BindingList<claseDB.ProduseView> listaProduse = new BindingList<claseDB.ProduseView>();
        Produse produsDeModificat = new Produse();

        #endregion

        #region functii

        public frmProduse()
        {
            InitializeComponent();
        }

        private void GolesteCampuri()
        {
            txtDenumire.Text = "";            
        }

        public override void AscundeColoane()
        {
            dgv.Columns["ID"].Visible = false;
            dgv.Columns["Inactiv"].Visible = false;
            dgv.Columns["lockVersion"].Visible = false;
        }

        public override void PopulareGrid()
        {
            SeteazaStatus("Asteptati incarcarea produselor existente...");
            base.PopulareGrid();
            
            listaProduse.Clear();
            foreach (var prod in functiiDB.ReturneazaListaProduse())
            {
                listaProduse.Add(prod);
            }
            dgv.DataSource = listaProduse;
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
                    produsDeModificat = functiiDB.ReturneazaProdusDupaId(ultimulIdAccesat);
                    if (produsDeModificat != null)
                    {
                        txtDenumire.Text = produsDeModificat.denumire;
                        return true;
                    }                    
                }
            }
            return false;
        }

        private bool VerificaDateProdus()
        {
            string denumireProdus = txtDenumire.Text.Trim();

            if (denumireProdus == "" || denumireProdus.Length > 250)
            {
                MessageBox.Show("Nu ati introdus o denumire de produs valida. Maxim 250 de caractere.");
                txtDenumire.Focus();
                txtDenumire.SelectAll();
                return false;
            }

            return true;
        }

        private bool Salveaza()
        {
            string denumire = txtDenumire.Text.Trim();
            if (VerificaDateProdus())
            {
                if (modifica) //modificare
                {
                    //verificare unicitate denumire
                    if (produsDeModificat.denumire.ToLower() != denumire.ToLower())
                    {
                        if (!functiiDB.VerificaUnicitateProdus(denumire))
                        {
                            MessageBox.Show("Produsul '" + denumire + "' mai exista in baza de date.");
                            return false;
                        }
                    }

                    //verificare lockVersion
                    if(produsDeModificat.lockVersion != functiiDB.ReturneazaProdusDupaId(ultimulIdAccesat).lockVersion)
                    {
                        MessageBox.Show("Produsul '" + produsDeModificat.denumire + "' a fost modificat intre timp. Anulati si reincercati dupa apasarea butonului Refresh.");
                        return false;
                    }

                    produsDeModificat.denumire = denumire;
                    produsDeModificat.lockVersion++;
                    produsDeModificat.modificatLa = DateTime.Now;
                    if (functiiDB.SalveazaProdusExistent(ultimulIdAccesat, produsDeModificat))
                    {
                        MessageBox.Show("Produsul '" + denumire + "' a fost modificat cu succes.");
                        return true;
                    }                    
                }
                else //adaugare
                {
                    if (!functiiDB.VerificaUnicitateProdus(denumire))
                    {
                        MessageBox.Show("Produsul '" + denumire + "' mai exista in baza de date.");
                        return false;
                    }
                    Produse produsNou = new Produse();
                    produsNou.denumire = denumire;
                    produsNou.creatLa = DateTime.Now;
                    produsNou.inactiv = false;
                    produsNou.lockVersion = 0;
                    produsNou.modificatLa = DateTime.Now;
                    if (functiiDB.SalveazaProdusNou(produsNou))
                    {
                        MessageBox.Show("Produsul '" + denumire + "' a fost salvat cu succes.");
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
            txtDenumire.Focus();
        }

        public override void btnModifica_Click(object sender, EventArgs e)
        {
            if (PopulareLaModificare())
            {
                base.btnModifica_Click(sender, e);
                txtDenumire.Focus();
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

        private void txtDenumire_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSalveaza_Click(null, null);
            }
        }

        #endregion

    }
}
