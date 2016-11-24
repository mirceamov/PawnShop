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
    public partial class frmNomenclatoare : Form
    {
        #region variabile

        public bool modifica = false;
        public int ultimulIdAccesat = 0;
        public int lockVersionGrid = 0;

        #endregion

        #region functii

        public frmNomenclatoare()
        {
            InitializeComponent();
        }

        public virtual void PopulareGrid()
        {
            Application.DoEvents();            
            dgv.DataSource = null;
        }

        public virtual void AscundeColoane()
        {

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

        public virtual void frmNomenclatoare_Shown(object sender, EventArgs e)
        {
            PopulareGrid();
            AscundeColoane();
        }

        public virtual void btnAdauga_Click(object sender, EventArgs e)
        {
            gbActiune.Visible = true;
            pnlAdaugaModifica.Visible = false;
            pnlSalveazaAnuleaza.Visible = true;
            gbActiune.Text = "Adaugare";
            modifica = false;
        }

        public virtual void btnModifica_Click(object sender, EventArgs e)
        {
            gbActiune.Visible = true;
            pnlAdaugaModifica.Visible = false;
            pnlSalveazaAnuleaza.Visible = true;
            gbActiune.Text = "Modificare";
            modifica = true;
        }

        public virtual void btnSalveaza_Click(object sender, EventArgs e)
        {
            pnlSalveazaAnuleaza.Visible = false;
            pnlAdaugaModifica.Visible = true;
            gbActiune.Visible = false;
            modifica = false;
            PopulareGrid();
            AscundeColoane();
        }

        public virtual void btnAnuleaza_Click(object sender, EventArgs e)
        {
            pnlSalveazaAnuleaza.Visible = false;
            pnlAdaugaModifica.Visible = true;
            gbActiune.Visible = false;
            modifica = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulareGrid();
            AscundeColoane();
        }

        #endregion
    }
}
