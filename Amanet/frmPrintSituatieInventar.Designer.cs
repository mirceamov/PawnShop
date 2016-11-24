namespace Amanet
{
    partial class frmPrintSituatieInventar
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rvPrintareRaport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ContracteViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ContracteViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvPrintareRaport
            // 
            this.rvPrintareRaport.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet_SituatieInventar";
            reportDataSource2.Value = this.ContracteViewBindingSource;
            this.rvPrintareRaport.LocalReport.DataSources.Add(reportDataSource2);
            this.rvPrintareRaport.LocalReport.ReportEmbeddedResource = "Amanet.rptSituatieInventar.rdlc";
            this.rvPrintareRaport.Location = new System.Drawing.Point(0, 0);
            this.rvPrintareRaport.Name = "rvPrintareRaport";
            this.rvPrintareRaport.Size = new System.Drawing.Size(763, 402);
            this.rvPrintareRaport.TabIndex = 0;
            // 
            // ContracteViewBindingSource
            // 
            this.ContracteViewBindingSource.DataSource = typeof(Amanet.claseDB.ContracteView);
            // 
            // frmPrintSituatieInventar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 402);
            this.Controls.Add(this.rvPrintareRaport);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrintSituatieInventar";
            this.ShowIcon = false;
            this.Text = "Printare situatie inventar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrintSituatieInventar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ContracteViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvPrintareRaport;
        private System.Windows.Forms.BindingSource ContracteViewBindingSource;
    }
}