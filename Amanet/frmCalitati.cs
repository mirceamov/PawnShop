using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Amanet
{
    public partial class frmCalitati : Amanet.frmNomenclatoare
    {
        #region variabile

        BindingList<claseDB.CalitatiView> listaCalitati = new BindingList<claseDB.CalitatiView>();
        Calitati calitateDeModificat = new Calitati();

        #endregion

        #region functii

        public frmCalitati()
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
            SeteazaStatus("Asteptati incarcarea calitatilor existente...");
            base.PopulareGrid();

            listaCalitati.Clear();
            foreach (var calit in functiiDB.ReturneazaListaCalitati())
            {
                listaCalitati.Add(calit);
            }
            dgv.DataSource = listaCalitati;
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
                    calitateDeModificat = functiiDB.ReturneazaCalitateDupaId(ultimulIdAccesat);
                    if (calitateDeModificat != null)
                    {
                        txtDenumire.Text = calitateDeModificat.denumire;
                        return true;
                    }                    
                }
            }
            return false;
        }

        private bool VerificaDateCalitate()
        {
            string denumireCalitate = txtDenumire.Text.Trim();

            if (denumireCalitate == "" || denumireCalitate.Length > 250)
            {
                MessageBox.Show("Nu ati introdus o denumire de calitate valida. Maxim 250 de caractere.");
                txtDenumire.Focus();
                txtDenumire.SelectAll();
                return false;
            }

            return true;
        }

        private bool Salveaza()
        {
            string denumire = txtDenumire.Text.Trim();
            if (VerificaDateCalitate())
            {
                if (modifica) //modificare
                {
                    //verificare unicitate denumire
                    if (calitateDeModificat.denumire.ToLower() != denumire.ToLower())
                    {
                        if (!functiiDB.VerificaUnicitateCalitate(denumire))
                        {
                            MessageBox.Show("Calitatea '" + denumire + "' mai exista in baza de date.");
                            return false;
                        }
                    }

                    //verificare lockVersion
                    if (calitateDeModificat.lockVersion != functiiDB.ReturneazaCalitateDupaId(ultimulIdAccesat).lockVersion)
                    {
                        MessageBox.Show("Calitatea '" + calitateDeModificat.denumire + "' a fost modificat intre timp. Anulati si reincercati dupa apasarea butonului Refresh.");
                        return false;
                    }

                    calitateDeModificat.denumire = denumire;
                    calitateDeModificat.lockVersion++;
                    calitateDeModificat.modificatLa = DateTime.Now;
                    if (functiiDB.SalveazaCalitateExistenta(ultimulIdAccesat, calitateDeModificat))
                    {
                        MessageBox.Show("Calitatea '" + denumire + "' a fost modificat cu succes.");
                        return true;
                    }                    
                }
                else //adaugare
                {
                    if (!functiiDB.VerificaUnicitateCalitate(denumire))
                    {
                        MessageBox.Show("Calitatea '" + denumire + "' mai exista in baza de date.");
                        return false;
                    }
                    Calitati calitateNoua = new Calitati();
                    calitateNoua.denumire = denumire;
                    calitateNoua.creatLa = DateTime.Now;
                    calitateNoua.inactiv = false;
                    calitateNoua.lockVersion = 0;
                    calitateNoua.modificatLa = DateTime.Now;
                    if (functiiDB.SalveazaCalitateNoua(calitateNoua))
                    {
                        MessageBox.Show("Calitatea '" + denumire + "' a fost salvat cu succes.");
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
            if(e.KeyCode == Keys.Enter)
            {
                btnSalveaza_Click(null, null);
            }
        }

        #endregion

    }
}
