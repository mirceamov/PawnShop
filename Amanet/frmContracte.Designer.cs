namespace Amanet
{
    partial class frmContracte
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContracte));
            this.dgvContracte = new System.Windows.Forms.DataGridView();
            this.dgvProduseContract = new System.Windows.Forms.DataGridView();
            this.btnAdaugaContractNou = new System.Windows.Forms.Button();
            this.btnPrinteazaContract = new System.Windows.Forms.Button();
            this.btnFinalizeazaContract = new System.Windows.Forms.Button();
            this.gbOperatiuni = new System.Windows.Forms.GroupBox();
            this.lblInfoTiparire = new System.Windows.Forms.Label();
            this.btnArataFiltre = new System.Windows.Forms.Button();
            this.btnPrinteazaSituatieScadente = new System.Windows.Forms.Button();
            this.btnPrinteazaSituatieInventar = new System.Windows.Forms.Button();
            this.pnlGriduri = new System.Windows.Forms.Panel();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.gbFiltre = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNumePrenume = new System.Windows.Forms.Label();
            this.txtFiltruNumePrenume = new System.Windows.Forms.TextBox();
            this.dtpScadenta = new System.Windows.Forms.DateTimePicker();
            this.lblDataScadenta = new System.Windows.Forms.Label();
            this.lblStareContract = new System.Windows.Forms.Label();
            this.cbStareContract = new System.Windows.Forms.ComboBox();
            this.btnFiltreaza = new System.Windows.Forms.Button();
            this.btnGolesteFiltre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduseContract)).BeginInit();
            this.gbOperatiuni.SuspendLayout();
            this.pnlGriduri.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbFiltre.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvContracte
            // 
            this.dgvContracte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContracte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContracte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContracte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContracte.Location = new System.Drawing.Point(0, 0);
            this.dgvContracte.MultiSelect = false;
            this.dgvContracte.Name = "dgvContracte";
            this.dgvContracte.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvContracte.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvContracte.RowTemplate.Height = 40;
            this.dgvContracte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContracte.Size = new System.Drawing.Size(643, 142);
            this.dgvContracte.TabIndex = 0;
            this.dgvContracte.SelectionChanged += new System.EventHandler(this.dgvContracte_SelectionChanged);
            // 
            // dgvProduseContract
            // 
            this.dgvProduseContract.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduseContract.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProduseContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduseContract.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProduseContract.Location = new System.Drawing.Point(0, 142);
            this.dgvProduseContract.MultiSelect = false;
            this.dgvProduseContract.Name = "dgvProduseContract";
            this.dgvProduseContract.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvProduseContract.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProduseContract.RowTemplate.Height = 30;
            this.dgvProduseContract.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduseContract.Size = new System.Drawing.Size(643, 154);
            this.dgvProduseContract.TabIndex = 1;
            // 
            // btnAdaugaContractNou
            // 
            this.btnAdaugaContractNou.BackColor = System.Drawing.Color.Transparent;
            this.btnAdaugaContractNou.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.btnAdaugaContractNou.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdaugaContractNou.Location = new System.Drawing.Point(6, 87);
            this.btnAdaugaContractNou.Name = "btnAdaugaContractNou";
            this.btnAdaugaContractNou.Size = new System.Drawing.Size(129, 49);
            this.btnAdaugaContractNou.TabIndex = 1;
            this.btnAdaugaContractNou.Text = "Adauga contract";
            this.btnAdaugaContractNou.UseVisualStyleBackColor = false;
            this.btnAdaugaContractNou.Click += new System.EventHandler(this.btnAdaugaContractNou_Click);
            // 
            // btnPrinteazaContract
            // 
            this.btnPrinteazaContract.BackColor = System.Drawing.Color.Transparent;
            this.btnPrinteazaContract.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.btnPrinteazaContract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrinteazaContract.Location = new System.Drawing.Point(6, 197);
            this.btnPrinteazaContract.Name = "btnPrinteazaContract";
            this.btnPrinteazaContract.Size = new System.Drawing.Size(129, 49);
            this.btnPrinteazaContract.TabIndex = 0;
            this.btnPrinteazaContract.Text = "Tipareste contract selectat";
            this.btnPrinteazaContract.UseVisualStyleBackColor = false;
            this.btnPrinteazaContract.Click += new System.EventHandler(this.btnPrinteazaContract_Click);
            this.btnPrinteazaContract.MouseEnter += new System.EventHandler(this.btnPrinteazaContract_MouseEnter);
            this.btnPrinteazaContract.MouseLeave += new System.EventHandler(this.btnPrinteazaContract_MouseLeave);
            // 
            // btnFinalizeazaContract
            // 
            this.btnFinalizeazaContract.BackColor = System.Drawing.Color.Transparent;
            this.btnFinalizeazaContract.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.btnFinalizeazaContract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizeazaContract.Location = new System.Drawing.Point(6, 142);
            this.btnFinalizeazaContract.Name = "btnFinalizeazaContract";
            this.btnFinalizeazaContract.Size = new System.Drawing.Size(129, 49);
            this.btnFinalizeazaContract.TabIndex = 2;
            this.btnFinalizeazaContract.Text = "Finalizeaza contract";
            this.btnFinalizeazaContract.UseVisualStyleBackColor = false;
            this.btnFinalizeazaContract.Click += new System.EventHandler(this.btnFinalizeazaContract_Click);
            // 
            // gbOperatiuni
            // 
            this.gbOperatiuni.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.gbOperatiuni.Controls.Add(this.lblInfoTiparire);
            this.gbOperatiuni.Controls.Add(this.btnArataFiltre);
            this.gbOperatiuni.Controls.Add(this.btnPrinteazaContract);
            this.gbOperatiuni.Controls.Add(this.btnPrinteazaSituatieScadente);
            this.gbOperatiuni.Controls.Add(this.btnAdaugaContractNou);
            this.gbOperatiuni.Controls.Add(this.btnPrinteazaSituatieInventar);
            this.gbOperatiuni.Controls.Add(this.btnFinalizeazaContract);
            this.gbOperatiuni.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbOperatiuni.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.gbOperatiuni.ForeColor = System.Drawing.Color.White;
            this.gbOperatiuni.Location = new System.Drawing.Point(0, 0);
            this.gbOperatiuni.Name = "gbOperatiuni";
            this.gbOperatiuni.Size = new System.Drawing.Size(141, 461);
            this.gbOperatiuni.TabIndex = 7;
            this.gbOperatiuni.TabStop = false;
            this.gbOperatiuni.Text = "Operatiuni";
            // 
            // lblInfoTiparire
            // 
            this.lblInfoTiparire.Font = new System.Drawing.Font("Segoe UI Semibold", 7F, System.Drawing.FontStyle.Bold);
            this.lblInfoTiparire.Location = new System.Drawing.Point(6, 359);
            this.lblInfoTiparire.Name = "lblInfoTiparire";
            this.lblInfoTiparire.Size = new System.Drawing.Size(129, 99);
            this.lblInfoTiparire.TabIndex = 10;
            this.lblInfoTiparire.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnArataFiltre
            // 
            this.btnArataFiltre.BackColor = System.Drawing.Color.Transparent;
            this.btnArataFiltre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.btnArataFiltre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArataFiltre.Location = new System.Drawing.Point(6, 32);
            this.btnArataFiltre.Name = "btnArataFiltre";
            this.btnArataFiltre.Size = new System.Drawing.Size(129, 49);
            this.btnArataFiltre.TabIndex = 0;
            this.btnArataFiltre.Text = "Ascunde filtre";
            this.btnArataFiltre.UseVisualStyleBackColor = false;
            this.btnArataFiltre.Click += new System.EventHandler(this.btnArataFiltre_Click);
            // 
            // btnPrinteazaSituatieScadente
            // 
            this.btnPrinteazaSituatieScadente.BackColor = System.Drawing.Color.Transparent;
            this.btnPrinteazaSituatieScadente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.btnPrinteazaSituatieScadente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrinteazaSituatieScadente.Location = new System.Drawing.Point(6, 307);
            this.btnPrinteazaSituatieScadente.Name = "btnPrinteazaSituatieScadente";
            this.btnPrinteazaSituatieScadente.Size = new System.Drawing.Size(129, 49);
            this.btnPrinteazaSituatieScadente.TabIndex = 2;
            this.btnPrinteazaSituatieScadente.Text = "Situatie scadente";
            this.btnPrinteazaSituatieScadente.UseVisualStyleBackColor = false;
            this.btnPrinteazaSituatieScadente.Click += new System.EventHandler(this.btnPrinteazaSituatieScadente_Click);
            this.btnPrinteazaSituatieScadente.MouseEnter += new System.EventHandler(this.btnPrinteazaSituatieScadente_MouseEnter);
            this.btnPrinteazaSituatieScadente.MouseLeave += new System.EventHandler(this.btnPrinteazaSituatieScadente_MouseLeave);
            // 
            // btnPrinteazaSituatieInventar
            // 
            this.btnPrinteazaSituatieInventar.BackColor = System.Drawing.Color.Transparent;
            this.btnPrinteazaSituatieInventar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.btnPrinteazaSituatieInventar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrinteazaSituatieInventar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrinteazaSituatieInventar.Location = new System.Drawing.Point(6, 252);
            this.btnPrinteazaSituatieInventar.Name = "btnPrinteazaSituatieInventar";
            this.btnPrinteazaSituatieInventar.Size = new System.Drawing.Size(129, 49);
            this.btnPrinteazaSituatieInventar.TabIndex = 1;
            this.btnPrinteazaSituatieInventar.Text = "Situatie inventar";
            this.btnPrinteazaSituatieInventar.UseVisualStyleBackColor = false;
            this.btnPrinteazaSituatieInventar.Click += new System.EventHandler(this.btnPrinteazaSituatieInventar_Click);
            this.btnPrinteazaSituatieInventar.MouseEnter += new System.EventHandler(this.btnPrinteazaSituatieInventar_MouseEnter);
            this.btnPrinteazaSituatieInventar.MouseLeave += new System.EventHandler(this.btnPrinteazaSituatieInventar_MouseLeave);
            // 
            // pnlGriduri
            // 
            this.pnlGriduri.Controls.Add(this.dgvContracte);
            this.pnlGriduri.Controls.Add(this.dgvProduseContract);
            this.pnlGriduri.Controls.Add(this.gbStatus);
            this.pnlGriduri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGriduri.Location = new System.Drawing.Point(141, 124);
            this.pnlGriduri.Name = "pnlGriduri";
            this.pnlGriduri.Size = new System.Drawing.Size(643, 337);
            this.pnlGriduri.TabIndex = 9;
            // 
            // gbStatus
            // 
            this.gbStatus.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.gbStatus.Controls.Add(this.lblStatus);
            this.gbStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.gbStatus.ForeColor = System.Drawing.Color.White;
            this.gbStatus.Location = new System.Drawing.Point(0, 296);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(643, 41);
            this.gbStatus.TabIndex = 12;
            this.gbStatus.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.Location = new System.Drawing.Point(7, 11);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(630, 27);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbFiltre
            // 
            this.gbFiltre.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.gbFiltre.Controls.Add(this.tableLayoutPanel1);
            this.gbFiltre.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFiltre.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.gbFiltre.ForeColor = System.Drawing.Color.White;
            this.gbFiltre.Location = new System.Drawing.Point(141, 0);
            this.gbFiltre.Name = "gbFiltre";
            this.gbFiltre.Size = new System.Drawing.Size(643, 124);
            this.gbFiltre.TabIndex = 8;
            this.gbFiltre.TabStop = false;
            this.gbFiltre.Text = "Filtre";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.99422F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.21387F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.79191F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblNumePrenume, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFiltruNumePrenume, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpScadenta, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDataScadenta, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblStareContract, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbStareContract, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnFiltreaza, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnGolesteFiltre, 4, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 37);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(627, 85);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // lblNumePrenume
            // 
            this.lblNumePrenume.AutoSize = true;
            this.lblNumePrenume.Location = new System.Drawing.Point(3, 0);
            this.lblNumePrenume.Name = "lblNumePrenume";
            this.lblNumePrenume.Size = new System.Drawing.Size(106, 19);
            this.lblNumePrenume.TabIndex = 1;
            this.lblNumePrenume.Text = "Nume prenume";
            // 
            // txtFiltruNumePrenume
            // 
            this.txtFiltruNumePrenume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltruNumePrenume.Location = new System.Drawing.Point(3, 45);
            this.txtFiltruNumePrenume.Name = "txtFiltruNumePrenume";
            this.txtFiltruNumePrenume.Size = new System.Drawing.Size(171, 25);
            this.txtFiltruNumePrenume.TabIndex = 0;
            this.txtFiltruNumePrenume.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFiltruNumePrenume_KeyDown);
            // 
            // dtpScadenta
            // 
            this.dtpScadenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpScadenta.CalendarFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.dtpScadenta.CustomFormat = "dd-MM-yyyy";
            this.dtpScadenta.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.dtpScadenta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpScadenta.Location = new System.Drawing.Point(330, 45);
            this.dtpScadenta.Name = "dtpScadenta";
            this.dtpScadenta.Size = new System.Drawing.Size(146, 24);
            this.dtpScadenta.TabIndex = 2;
            // 
            // lblDataScadenta
            // 
            this.lblDataScadenta.AutoSize = true;
            this.lblDataScadenta.Location = new System.Drawing.Point(330, 0);
            this.lblDataScadenta.Name = "lblDataScadenta";
            this.lblDataScadenta.Size = new System.Drawing.Size(97, 19);
            this.lblDataScadenta.TabIndex = 6;
            this.lblDataScadenta.Text = "Data scadenta";
            // 
            // lblStareContract
            // 
            this.lblStareContract.AutoSize = true;
            this.lblStareContract.Location = new System.Drawing.Point(180, 0);
            this.lblStareContract.Name = "lblStareContract";
            this.lblStareContract.Size = new System.Drawing.Size(97, 19);
            this.lblStareContract.TabIndex = 4;
            this.lblStareContract.Text = "Stare contract";
            // 
            // cbStareContract
            // 
            this.cbStareContract.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStareContract.FormattingEnabled = true;
            this.cbStareContract.Items.AddRange(new object[] {
            "Toate",
            "ACTIV",
            "FINALIZAT"});
            this.cbStareContract.Location = new System.Drawing.Point(180, 45);
            this.cbStareContract.Name = "cbStareContract";
            this.cbStareContract.Size = new System.Drawing.Size(144, 25);
            this.cbStareContract.TabIndex = 1;
            // 
            // btnFiltreaza
            // 
            this.btnFiltreaza.BackColor = System.Drawing.Color.Transparent;
            this.btnFiltreaza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.btnFiltreaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltreaza.Location = new System.Drawing.Point(482, 3);
            this.btnFiltreaza.Name = "btnFiltreaza";
            this.btnFiltreaza.Size = new System.Drawing.Size(140, 36);
            this.btnFiltreaza.TabIndex = 3;
            this.btnFiltreaza.Text = "Filtreaza contracte";
            this.btnFiltreaza.UseVisualStyleBackColor = false;
            this.btnFiltreaza.Click += new System.EventHandler(this.btnFiltreaza_Click);
            // 
            // btnGolesteFiltre
            // 
            this.btnGolesteFiltre.BackColor = System.Drawing.Color.Transparent;
            this.btnGolesteFiltre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumOrchid;
            this.btnGolesteFiltre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGolesteFiltre.Location = new System.Drawing.Point(482, 45);
            this.btnGolesteFiltre.Name = "btnGolesteFiltre";
            this.btnGolesteFiltre.Size = new System.Drawing.Size(140, 36);
            this.btnGolesteFiltre.TabIndex = 4;
            this.btnGolesteFiltre.Text = "Goleste filtre";
            this.btnGolesteFiltre.UseVisualStyleBackColor = false;
            this.btnGolesteFiltre.Click += new System.EventHandler(this.btnGolesteFiltre_Click);
            // 
            // frmContracte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pnlGriduri);
            this.Controls.Add(this.gbFiltre);
            this.Controls.Add(this.gbOperatiuni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "frmContracte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contracte";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.frmContracte_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduseContract)).EndInit();
            this.gbOperatiuni.ResumeLayout(false);
            this.pnlGriduri.ResumeLayout(false);
            this.gbStatus.ResumeLayout(false);
            this.gbFiltre.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContracte;
        private System.Windows.Forms.DataGridView dgvProduseContract;
        private System.Windows.Forms.Button btnAdaugaContractNou;
        private System.Windows.Forms.Button btnPrinteazaContract;
        private System.Windows.Forms.Button btnFinalizeazaContract;
        private System.Windows.Forms.GroupBox gbOperatiuni;
        private System.Windows.Forms.Button btnArataFiltre;
        private System.Windows.Forms.Panel pnlGriduri;
        private System.Windows.Forms.GroupBox gbFiltre;
        private System.Windows.Forms.Button btnFiltreaza;
        private System.Windows.Forms.Label lblNumePrenume;
        private System.Windows.Forms.TextBox txtFiltruNumePrenume;
        private System.Windows.Forms.Label lblStareContract;
        private System.Windows.Forms.ComboBox cbStareContract;
        private System.Windows.Forms.Label lblDataScadenta;
        private System.Windows.Forms.DateTimePicker dtpScadenta;
        private System.Windows.Forms.Button btnGolesteFiltre;
        private System.Windows.Forms.Button btnPrinteazaSituatieScadente;
        private System.Windows.Forms.Button btnPrinteazaSituatieInventar;
        private System.Windows.Forms.Label lblInfoTiparire;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbStatus;
        public System.Windows.Forms.Label lblStatus;
    }
}