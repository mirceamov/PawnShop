namespace Amanet
{
    partial class frmCalitati
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDenumire = new System.Windows.Forms.Label();
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.pnlAdaugaModifica.SuspendLayout();
            this.pnlSalveazaAnuleaza.SuspendLayout();
            this.gbActiune.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdauga
            // 
            this.btnAdauga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            // 
            // btnModifica
            // 
            this.btnModifica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            // 
            // gbActiune
            // 
            this.gbActiune.Controls.Add(this.lblDenumire);
            this.gbActiune.Controls.Add(this.txtDenumire);
            this.gbActiune.Size = new System.Drawing.Size(543, 90);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            // 
            // lblDenumire
            // 
            this.lblDenumire.AutoSize = true;
            this.lblDenumire.Location = new System.Drawing.Point(6, 36);
            this.lblDenumire.Name = "lblDenumire";
            this.lblDenumire.Size = new System.Drawing.Size(120, 19);
            this.lblDenumire.TabIndex = 5;
            this.lblDenumire.Text = "Denumire calitate";
            // 
            // txtDenumire
            // 
            this.txtDenumire.Location = new System.Drawing.Point(129, 33);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(200, 25);
            this.txtDenumire.TabIndex = 4;
            this.txtDenumire.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDenumire_KeyDown);
            // 
            // frmCalitati
            // 
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Name = "frmCalitati";
            this.Text = "Nomenclator calitati";
            this.pnlAdaugaModifica.ResumeLayout(false);
            this.pnlSalveazaAnuleaza.ResumeLayout(false);
            this.gbActiune.ResumeLayout(false);
            this.gbActiune.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDenumire;
        private System.Windows.Forms.TextBox txtDenumire;
    }
}
