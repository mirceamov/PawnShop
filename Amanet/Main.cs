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
    
    public partial class Main : Form
    {
        #region variabile

        List<string> listaProverbe = new List<string>() {
            "Prietenul omului este punga cu bani si sacul cu malai.",
            "Ori te poartă cum ţi-e vorba, ori vorbeşte cum ţi-e portul.",
            "Saracul are necazuri pentru ca n-are bani, bogatul pentru ca-i are.",
            "Daca vrei sa-ti faci dusmani, imprumuta-le bani.",
            "Nu e bun ce e bun, ci e bun ce-mi place mie.",
            "Banul bani unde zareste, acolo se rostogoleste.",
            "Pe toţi să-i asculţi, dar din mintea ta să nu ieşi.",
            "Banul ascuns in pamant, nici creste, nici rodeste.",
            "Cel ce pierde drumul e bucuros şi de cărare.",
            "Banii nu aduc invatatura, dar invatatura aduce banii.",
            "Porcul îl baţi şi el zice că-l scarpini.",
            "Banul e o mica roata, ce-nvarteste lumea toata.",
            "Prietenul vechi e ca vinul: cu cât e mai vechi, cu atât e mai bun.",
            "Banii nu aduc fericirea, numai numarul lor.",
            "Sau taci sau zi ceva mai bun decât tăcerea.",
            "Frate ca frate, da' branza-i pe bani barbate.",
            "Vântul aţâţă focul şi vorba vrajba.",
            "Santierul 'cucu'. Nu iei bani, dar ai de lucru.",
            "Bani să fie, că loc pentru ei – destul.",
            "Toţi se plâng de bani, dar de minte nimeni."
        };

        #endregion

        #region functii

        public Main()
        {
            InitializeComponent();           
        }
        
        private void AfiseazaProverb()
        {            
            lblProverbulZilei.Text = lblProverbulZilei.Text + Environment.NewLine + "\"" + listaProverbe[new Random().Next(0, listaProverbe.Count)] + "\"";
        }
        
        #endregion

        #region actiuni
        private void Main_Load(object sender, EventArgs e)
        {
            functiiDB.Initializare();
            AfiseazaProverb();            
        }

        private void btnContracte_Click(object sender, EventArgs e)
        {
            using (var frmContracte2 = new frmContracte())
            {
                frmContracte2.ShowDialog();
            }
        }

        private void btnProduseView_Click(object sender, EventArgs e)
        {
            using (var frmProduse2 = new frmProduse())
            {
                frmProduse2.ShowDialog();
            }
        }

        private void btnCalitatiView_Click(object sender, EventArgs e)
        {
            using (var frmCalitati2 = new frmCalitati())
            {
                frmCalitati2.ShowDialog();
            }
        }

        private void btnClientiView_Click(object sender, EventArgs e)
        {
            using (var frmClienti2 = new frmClienti())
            {
                frmClienti2.ShowDialog();
            }
        }
        #endregion
    }
}
