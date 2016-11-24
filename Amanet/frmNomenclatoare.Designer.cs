namespace Amanet
{
    partial class frmNomenclatoare
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNomenclatoare));
            this.gbOperatiuni = new System.Windows.Forms.GroupBox();
            this.pnlAdaugaModifica = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.pnlSalveazaAnuleaza = new System.Windows.Forms.Panel();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.gbActiune = new System.Windows.Forms.GroupBox();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.gbOperatiuni.SuspendLayout();
            this.pnlAdaugaModifica.SuspendLayout();
            this.pnlSalveazaAnuleaza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOperatiuni
            // 
            this.gbOperatiuni.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.gbOperatiuni.Controls.Add(this.pnlAdaugaModifica);
            this.gbOperatiuni.Controls.Add(this.pnlSalveazaAnuleaza);
            this.gbOperatiuni.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbOperatiuni.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.gbOperatiuni.ForeColor = System.Drawing.Color.White;
            this.gbOperatiuni.Location = new System.Drawing.Point(0, 0);
            this.gbOperatiuni.Name = "gbOperatiuni";
            this.gbOperatiuni.Size = new System.Drawing.Size(141, 428);
            this.gbOperatiuni.TabIndex = 8;
            this.gbOperatiuni.TabStop = false;
            this.gbOperatiuni.Text = "Operatiuni";
            // 
            // pnlAdaugaModifica
            // 
            this.pnlAdaugaModifica.Controls.Add(this.btnRefresh);
            this.pnlAdaugaModifica.Controls.Add(this.btnModifica);
            this.pnlAdaugaModifica.Controls.Add(this.btnAdauga);
            this.pnlAdaugaModifica.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAdaugaModifica.Location = new System.Drawing.Point(3, 183);
            this.pnlAdaugaModifica.Name = "pnlAdaugaModifica";
            this.pnlAdaugaModifica.Size = new System.Drawing.Size(135, 239);
            this.pnlAdaugaModifica.TabIndex = 10;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(9, 167);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(115, 70);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.Transparent;
            this.btnModifica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.btnModifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifica.ForeColor = System.Drawing.Color.White;
            this.btnModifica.Location = new System.Drawing.Point(9, 91);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(115, 70);
            this.btnModifica.TabIndex = 1;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.Color.Transparent;
            this.btnAdauga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.btnAdauga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdauga.ForeColor = System.Drawing.Color.White;
            this.btnAdauga.Location = new System.Drawing.Point(9, 15);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(115, 70);
            this.btnAdauga.TabIndex = 0;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = false;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // pnlSalveazaAnuleaza
            // 
            this.pnlSalveazaAnuleaza.Controls.Add(this.btnAnuleaza);
            this.pnlSalveazaAnuleaza.Controls.Add(this.btnSalveaza);
            this.pnlSalveazaAnuleaza.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSalveazaAnuleaza.Location = new System.Drawing.Point(3, 21);
            this.pnlSalveazaAnuleaza.Name = "pnlSalveazaAnuleaza";
            this.pnlSalveazaAnuleaza.Size = new System.Drawing.Size(135, 162);
            this.pnlSalveazaAnuleaza.TabIndex = 9;
            this.pnlSalveazaAnuleaza.Visible = false;
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.BackColor = System.Drawing.Color.Transparent;
            this.btnAnuleaza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.btnAnuleaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnuleaza.ForeColor = System.Drawing.Color.White;
            this.btnAnuleaza.Location = new System.Drawing.Point(9, 91);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(115, 70);
            this.btnAnuleaza.TabIndex = 1;
            this.btnAnuleaza.Text = "Anuleaza";
            this.btnAnuleaza.UseVisualStyleBackColor = false;
            this.btnAnuleaza.Click += new System.EventHandler(this.btnAnuleaza_Click);
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.BackColor = System.Drawing.Color.Transparent;
            this.btnSalveaza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.btnSalveaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalveaza.ForeColor = System.Drawing.Color.White;
            this.btnSalveaza.Location = new System.Drawing.Point(9, 15);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(115, 70);
            this.btnSalveaza.TabIndex = 0;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = false;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeight = 45;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(141, 106);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.RowTemplate.Height = 35;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(543, 322);
            this.dgv.TabIndex = 10;
            // 
            // gbActiune
            // 
            this.gbActiune.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.gbActiune.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbActiune.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.gbActiune.ForeColor = System.Drawing.Color.White;
            this.gbActiune.Location = new System.Drawing.Point(141, 0);
            this.gbActiune.Name = "gbActiune";
            this.gbActiune.Size = new System.Drawing.Size(543, 106);
            this.gbActiune.TabIndex = 9;
            this.gbActiune.TabStop = false;
            this.gbActiune.Text = "Actiune";
            this.gbActiune.Visible = false;
            // 
            // gbStatus
            // 
            this.gbStatus.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.gbStatus.Controls.Add(this.lblStatus);
            this.gbStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.gbStatus.ForeColor = System.Drawing.Color.White;
            this.gbStatus.Location = new System.Drawing.Point(0, 428);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(684, 33);
            this.gbStatus.TabIndex = 11;
            this.gbStatus.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.Location = new System.Drawing.Point(12, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(660, 21);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmNomenclatoare
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.gbActiune);
            this.Controls.Add(this.gbOperatiuni);
            this.Controls.Add(this.gbStatus);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "frmNomenclatoare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nomenclator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.frmNomenclatoare_Shown);
            this.gbOperatiuni.ResumeLayout(false);
            this.pnlAdaugaModifica.ResumeLayout(false);
            this.pnlSalveazaAnuleaza.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.gbStatus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOperatiuni;
        public System.Windows.Forms.Button btnAdauga;
        public System.Windows.Forms.Button btnModifica;
        public System.Windows.Forms.Button btnSalveaza;
        public System.Windows.Forms.DataGridView dgv;
        public System.Windows.Forms.Button btnAnuleaza;
        public System.Windows.Forms.Panel pnlAdaugaModifica;
        public System.Windows.Forms.Panel pnlSalveazaAnuleaza;
        protected System.Windows.Forms.GroupBox gbActiune;
        public System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox gbStatus;
        public System.Windows.Forms.Label lblStatus;
    }
}