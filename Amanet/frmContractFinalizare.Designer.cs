namespace Amanet
{
    partial class frmContractFinalizare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContractFinalizare));
            this.btnFinalizeazaContract = new System.Windows.Forms.Button();
            this.btnRenunta = new System.Windows.Forms.Button();
            this.lblValComisionTotalInitial = new System.Windows.Forms.Label();
            this.lblDataScadenta = new System.Windows.Forms.Label();
            this.lblValCreditComisionInitial = new System.Windows.Forms.Label();
            this.lblValComisionZi = new System.Windows.Forms.Label();
            this.lblValCredit = new System.Windows.Forms.Label();
            this.lblDataContract = new System.Windows.Forms.Label();
            this.lblNumarContract = new System.Windows.Forms.Label();
            this.lblNumarZileInitiale = new System.Windows.Forms.Label();
            this.lblNumarDeZileTrecute = new System.Windows.Forms.Label();
            this.lblValComisionTotalFinal = new System.Windows.Forms.Label();
            this.lblValCreditComisionFinal = new System.Windows.Forms.Label();
            this.lblDataCurenta = new System.Windows.Forms.Label();
            this.gbInitial = new System.Windows.Forms.GroupBox();
            this.gbFinal = new System.Windows.Forms.GroupBox();
            this.lblValCreditComision10 = new System.Windows.Forms.Label();
            this.lblValComisionTotal10 = new System.Windows.Forms.Label();
            this.gbInitial.SuspendLayout();
            this.gbFinal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFinalizeazaContract
            // 
            this.btnFinalizeazaContract.BackColor = System.Drawing.Color.Transparent;
            this.btnFinalizeazaContract.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.btnFinalizeazaContract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizeazaContract.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnFinalizeazaContract.ForeColor = System.Drawing.Color.White;
            this.btnFinalizeazaContract.Location = new System.Drawing.Point(348, 289);
            this.btnFinalizeazaContract.Name = "btnFinalizeazaContract";
            this.btnFinalizeazaContract.Size = new System.Drawing.Size(144, 45);
            this.btnFinalizeazaContract.TabIndex = 3;
            this.btnFinalizeazaContract.Text = "Finalizeaza contract";
            this.btnFinalizeazaContract.UseVisualStyleBackColor = false;
            this.btnFinalizeazaContract.Click += new System.EventHandler(this.btnFinalizeazaContract_Click);
            // 
            // btnRenunta
            // 
            this.btnRenunta.BackColor = System.Drawing.Color.Transparent;
            this.btnRenunta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.btnRenunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenunta.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnRenunta.ForeColor = System.Drawing.Color.White;
            this.btnRenunta.Location = new System.Drawing.Point(516, 289);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(144, 45);
            this.btnRenunta.TabIndex = 4;
            this.btnRenunta.Text = "Renunta";
            this.btnRenunta.UseVisualStyleBackColor = false;
            this.btnRenunta.Click += new System.EventHandler(this.btnRenunta_Click);
            // 
            // lblValComisionTotalInitial
            // 
            this.lblValComisionTotalInitial.AutoSize = true;
            this.lblValComisionTotalInitial.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblValComisionTotalInitial.Location = new System.Drawing.Point(6, 242);
            this.lblValComisionTotalInitial.Name = "lblValComisionTotalInitial";
            this.lblValComisionTotalInitial.Size = new System.Drawing.Size(128, 15);
            this.lblValComisionTotalInitial.TabIndex = 67;
            this.lblValComisionTotalInitial.Text = "Valoare comision total:";
            // 
            // lblDataScadenta
            // 
            this.lblDataScadenta.AutoSize = true;
            this.lblDataScadenta.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblDataScadenta.Location = new System.Drawing.Point(6, 102);
            this.lblDataScadenta.Name = "lblDataScadenta";
            this.lblDataScadenta.Size = new System.Drawing.Size(85, 15);
            this.lblDataScadenta.TabIndex = 66;
            this.lblDataScadenta.Text = "Data scadenta:";
            // 
            // lblValCreditComisionInitial
            // 
            this.lblValCreditComisionInitial.AutoSize = true;
            this.lblValCreditComisionInitial.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblValCreditComisionInitial.Location = new System.Drawing.Point(6, 277);
            this.lblValCreditComisionInitial.Name = "lblValCreditComisionInitial";
            this.lblValCreditComisionInitial.Size = new System.Drawing.Size(145, 15);
            this.lblValCreditComisionInitial.TabIndex = 65;
            this.lblValCreditComisionInitial.Text = "Valoare credit + comision:";
            // 
            // lblValComisionZi
            // 
            this.lblValComisionZi.AutoSize = true;
            this.lblValComisionZi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblValComisionZi.Location = new System.Drawing.Point(6, 207);
            this.lblValComisionZi.Name = "lblValComisionZi";
            this.lblValComisionZi.Size = new System.Drawing.Size(121, 15);
            this.lblValComisionZi.TabIndex = 64;
            this.lblValComisionZi.Text = "Valoare comision / zi:";
            // 
            // lblValCredit
            // 
            this.lblValCredit.AutoSize = true;
            this.lblValCredit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblValCredit.Location = new System.Drawing.Point(8, 172);
            this.lblValCredit.Name = "lblValCredit";
            this.lblValCredit.Size = new System.Drawing.Size(82, 15);
            this.lblValCredit.TabIndex = 63;
            this.lblValCredit.Text = "Valoare credit:";
            // 
            // lblDataContract
            // 
            this.lblDataContract.AutoSize = true;
            this.lblDataContract.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblDataContract.Location = new System.Drawing.Point(6, 67);
            this.lblDataContract.Name = "lblDataContract";
            this.lblDataContract.Size = new System.Drawing.Size(82, 15);
            this.lblDataContract.TabIndex = 62;
            this.lblDataContract.Text = "Data contract:";
            // 
            // lblNumarContract
            // 
            this.lblNumarContract.AutoSize = true;
            this.lblNumarContract.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblNumarContract.Location = new System.Drawing.Point(6, 32);
            this.lblNumarContract.Name = "lblNumarContract";
            this.lblNumarContract.Size = new System.Drawing.Size(94, 15);
            this.lblNumarContract.TabIndex = 61;
            this.lblNumarContract.Text = "Numar contract:";
            // 
            // lblNumarZileInitiale
            // 
            this.lblNumarZileInitiale.AutoSize = true;
            this.lblNumarZileInitiale.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblNumarZileInitiale.Location = new System.Drawing.Point(6, 137);
            this.lblNumarZileInitiale.Name = "lblNumarZileInitiale";
            this.lblNumarZileInitiale.Size = new System.Drawing.Size(122, 15);
            this.lblNumarZileInitiale.TabIndex = 68;
            this.lblNumarZileInitiale.Text = "Numar de zile initiale:";
            // 
            // lblNumarDeZileTrecute
            // 
            this.lblNumarDeZileTrecute.AutoSize = true;
            this.lblNumarDeZileTrecute.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblNumarDeZileTrecute.Location = new System.Drawing.Point(6, 32);
            this.lblNumarDeZileTrecute.Name = "lblNumarDeZileTrecute";
            this.lblNumarDeZileTrecute.Size = new System.Drawing.Size(161, 20);
            this.lblNumarDeZileTrecute.TabIndex = 72;
            this.lblNumarDeZileTrecute.Text = "Numar de zile trecute:";
            // 
            // lblValComisionTotalFinal
            // 
            this.lblValComisionTotalFinal.AutoSize = true;
            this.lblValComisionTotalFinal.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblValComisionTotalFinal.Location = new System.Drawing.Point(6, 67);
            this.lblValComisionTotalFinal.Name = "lblValComisionTotalFinal";
            this.lblValComisionTotalFinal.Size = new System.Drawing.Size(165, 20);
            this.lblValComisionTotalFinal.TabIndex = 71;
            this.lblValComisionTotalFinal.Text = "Valoare comision total:";
            // 
            // lblValCreditComisionFinal
            // 
            this.lblValCreditComisionFinal.AutoSize = true;
            this.lblValCreditComisionFinal.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblValCreditComisionFinal.Location = new System.Drawing.Point(6, 102);
            this.lblValCreditComisionFinal.Name = "lblValCreditComisionFinal";
            this.lblValCreditComisionFinal.Size = new System.Drawing.Size(187, 20);
            this.lblValCreditComisionFinal.TabIndex = 70;
            this.lblValCreditComisionFinal.Text = "Valoare credit + comision:";
            // 
            // lblDataCurenta
            // 
            this.lblDataCurenta.AutoSize = true;
            this.lblDataCurenta.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblDataCurenta.Location = new System.Drawing.Point(6, 137);
            this.lblDataCurenta.Name = "lblDataCurenta";
            this.lblDataCurenta.Size = new System.Drawing.Size(101, 20);
            this.lblDataCurenta.TabIndex = 69;
            this.lblDataCurenta.Text = "Data curenta:";
            // 
            // gbInitial
            // 
            this.gbInitial.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.gbInitial.Controls.Add(this.lblNumarContract);
            this.gbInitial.Controls.Add(this.lblDataContract);
            this.gbInitial.Controls.Add(this.lblValCredit);
            this.gbInitial.Controls.Add(this.lblValComisionZi);
            this.gbInitial.Controls.Add(this.lblValCreditComisionInitial);
            this.gbInitial.Controls.Add(this.lblNumarZileInitiale);
            this.gbInitial.Controls.Add(this.lblDataScadenta);
            this.gbInitial.Controls.Add(this.lblValComisionTotalInitial);
            this.gbInitial.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.gbInitial.ForeColor = System.Drawing.Color.White;
            this.gbInitial.Location = new System.Drawing.Point(12, 12);
            this.gbInitial.Name = "gbInitial";
            this.gbInitial.Size = new System.Drawing.Size(321, 322);
            this.gbInitial.TabIndex = 73;
            this.gbInitial.TabStop = false;
            this.gbInitial.Text = "Informatii din contract";
            // 
            // gbFinal
            // 
            this.gbFinal.BackColor = System.Drawing.Color.Purple;
            this.gbFinal.Controls.Add(this.lblValCreditComision10);
            this.gbFinal.Controls.Add(this.lblValComisionTotal10);
            this.gbFinal.Controls.Add(this.lblValCreditComisionFinal);
            this.gbFinal.Controls.Add(this.lblDataCurenta);
            this.gbFinal.Controls.Add(this.lblNumarDeZileTrecute);
            this.gbFinal.Controls.Add(this.lblValComisionTotalFinal);
            this.gbFinal.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.gbFinal.ForeColor = System.Drawing.Color.White;
            this.gbFinal.Location = new System.Drawing.Point(348, 12);
            this.gbFinal.Name = "gbFinal";
            this.gbFinal.Size = new System.Drawing.Size(312, 236);
            this.gbFinal.TabIndex = 74;
            this.gbFinal.TabStop = false;
            this.gbFinal.Text = "Valori finale raportate la numar zile trecute";
            // 
            // lblValCreditComision10
            // 
            this.lblValCreditComision10.AutoSize = true;
            this.lblValCreditComision10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblValCreditComision10.Location = new System.Drawing.Point(6, 208);
            this.lblValCreditComision10.Name = "lblValCreditComision10";
            this.lblValCreditComision10.Size = new System.Drawing.Size(189, 15);
            this.lblValCreditComision10.TabIndex = 73;
            this.lblValCreditComision10.Text = "Valoare credit + comision (10 zile):";
            // 
            // lblValComisionTotal10
            // 
            this.lblValComisionTotal10.AutoSize = true;
            this.lblValComisionTotal10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblValComisionTotal10.Location = new System.Drawing.Point(7, 184);
            this.lblValComisionTotal10.Name = "lblValComisionTotal10";
            this.lblValComisionTotal10.Size = new System.Drawing.Size(137, 15);
            this.lblValComisionTotal10.TabIndex = 74;
            this.lblValComisionTotal10.Text = "Valoare comision 10 zile:";
            // 
            // frmContractFinalizare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(671, 346);
            this.Controls.Add(this.gbFinal);
            this.Controls.Add(this.gbInitial);
            this.Controls.Add(this.btnRenunta);
            this.Controls.Add(this.btnFinalizeazaContract);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmContractFinalizare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finalizare contract";
            this.Shown += new System.EventHandler(this.frmContractFinalizare_Shown);
            this.gbInitial.ResumeLayout(false);
            this.gbInitial.PerformLayout();
            this.gbFinal.ResumeLayout(false);
            this.gbFinal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFinalizeazaContract;
        private System.Windows.Forms.Button btnRenunta;
        private System.Windows.Forms.Label lblValComisionTotalInitial;
        private System.Windows.Forms.Label lblDataScadenta;
        private System.Windows.Forms.Label lblValCreditComisionInitial;
        private System.Windows.Forms.Label lblValComisionZi;
        private System.Windows.Forms.Label lblValCredit;
        private System.Windows.Forms.Label lblDataContract;
        private System.Windows.Forms.Label lblNumarContract;
        private System.Windows.Forms.Label lblNumarZileInitiale;
        private System.Windows.Forms.Label lblNumarDeZileTrecute;
        private System.Windows.Forms.Label lblValComisionTotalFinal;
        private System.Windows.Forms.Label lblValCreditComisionFinal;
        private System.Windows.Forms.Label lblDataCurenta;
        private System.Windows.Forms.GroupBox gbInitial;
        private System.Windows.Forms.GroupBox gbFinal;
        private System.Windows.Forms.Label lblValCreditComision10;
        private System.Windows.Forms.Label lblValComisionTotal10;
    }
}