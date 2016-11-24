namespace Amanet
{
    partial class frmPrintContract
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.lstPrintareContractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AmanetDataSet = new Amanet.AmanetDataSet();
            this.rvPrintareRaport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lstPrintareContractTableAdapter = new Amanet.AmanetDataSetTableAdapters.lstPrintareContractTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lstPrintareContractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmanetDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lstPrintareContractBindingSource
            // 
            this.lstPrintareContractBindingSource.DataMember = "lstPrintareContract";
            this.lstPrintareContractBindingSource.DataSource = this.AmanetDataSet;
            // 
            // AmanetDataSet
            // 
            this.AmanetDataSet.DataSetName = "AmanetDataSet";
            this.AmanetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvPrintareRaport
            // 
            this.rvPrintareRaport.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "PrintContractDataSet";
            reportDataSource1.Value = this.lstPrintareContractBindingSource;
            this.rvPrintareRaport.LocalReport.DataSources.Add(reportDataSource1);
            this.rvPrintareRaport.LocalReport.ReportEmbeddedResource = "Amanet.rptPrintareContract.rdlc";
            this.rvPrintareRaport.Location = new System.Drawing.Point(0, 0);
            this.rvPrintareRaport.Name = "rvPrintareRaport";
            this.rvPrintareRaport.Size = new System.Drawing.Size(767, 476);
            this.rvPrintareRaport.TabIndex = 0;
            // 
            // lstPrintareContractTableAdapter
            // 
            this.lstPrintareContractTableAdapter.ClearBeforeFill = true;
            // 
            // frmPrintContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 476);
            this.Controls.Add(this.rvPrintareRaport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrintContract";
            this.ShowIcon = false;
            this.Text = "Printare contract";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmContractPreview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstPrintareContractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmanetDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvPrintareRaport;
        private System.Windows.Forms.BindingSource lstPrintareContractBindingSource;
        private AmanetDataSet AmanetDataSet;
        private AmanetDataSetTableAdapters.lstPrintareContractTableAdapter lstPrintareContractTableAdapter;

    }
}