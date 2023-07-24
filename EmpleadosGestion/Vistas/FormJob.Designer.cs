namespace EmpleadosGestion.Vistas
{
    partial class FormJob
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblTituloPanel = new System.Windows.Forms.Label();
            this.pnlJob = new System.Windows.Forms.Panel();
            this.txtSalarioMax = new System.Windows.Forms.TextBox();
            this.lblSalarioMax = new System.Windows.Forms.Label();
            this.txtSalarioMin = new System.Windows.Forms.TextBox();
            this.lblSalarioMin = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.grdJobs = new System.Windows.Forms.DataGridView();
            this.cboFiltro = new System.Windows.Forms.ComboBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.pnlJob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Location = new System.Drawing.Point(197, 243);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(84, 31);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Location = new System.Drawing.Point(107, 243);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(84, 31);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblTituloPanel
            // 
            this.lblTituloPanel.AutoSize = true;
            this.lblTituloPanel.Location = new System.Drawing.Point(660, 14);
            this.lblTituloPanel.Name = "lblTituloPanel";
            this.lblTituloPanel.Size = new System.Drawing.Size(110, 16);
            this.lblTituloPanel.TabIndex = 6;
            this.lblTituloPanel.Text = "Datos del trabajo";
            // 
            // pnlJob
            // 
            this.pnlJob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlJob.Controls.Add(this.txtSalarioMax);
            this.pnlJob.Controls.Add(this.lblSalarioMax);
            this.pnlJob.Controls.Add(this.txtSalarioMin);
            this.pnlJob.Controls.Add(this.lblSalarioMin);
            this.pnlJob.Controls.Add(this.txtTitulo);
            this.pnlJob.Controls.Add(this.btnLimpiar);
            this.pnlJob.Controls.Add(this.btnAceptar);
            this.pnlJob.Controls.Add(this.lblTitulo);
            this.pnlJob.Enabled = false;
            this.pnlJob.Location = new System.Drawing.Point(651, 24);
            this.pnlJob.Name = "pnlJob";
            this.pnlJob.Size = new System.Drawing.Size(301, 242);
            this.pnlJob.TabIndex = 7;
            // 
            // txtSalarioMax
            // 
            this.txtSalarioMax.Location = new System.Drawing.Point(96, 102);
            this.txtSalarioMax.Name = "txtSalarioMax";
            this.txtSalarioMax.Size = new System.Drawing.Size(193, 22);
            this.txtSalarioMax.TabIndex = 13;
            this.txtSalarioMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalarioMax_KeyPress);
            // 
            // lblSalarioMax
            // 
            this.lblSalarioMax.AutoSize = true;
            this.lblSalarioMax.Location = new System.Drawing.Point(8, 105);
            this.lblSalarioMax.Name = "lblSalarioMax";
            this.lblSalarioMax.Size = new System.Drawing.Size(81, 16);
            this.lblSalarioMax.TabIndex = 12;
            this.lblSalarioMax.Text = "Salario max:";
            // 
            // txtSalarioMin
            // 
            this.txtSalarioMin.Location = new System.Drawing.Point(96, 64);
            this.txtSalarioMin.Name = "txtSalarioMin";
            this.txtSalarioMin.Size = new System.Drawing.Size(193, 22);
            this.txtSalarioMin.TabIndex = 11;
            this.txtSalarioMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalarioMin_KeyPress);
            // 
            // lblSalarioMin
            // 
            this.lblSalarioMin.AutoSize = true;
            this.lblSalarioMin.Location = new System.Drawing.Point(8, 67);
            this.lblSalarioMin.Name = "lblSalarioMin";
            this.lblSalarioMin.Size = new System.Drawing.Size(77, 16);
            this.lblSalarioMin.TabIndex = 10;
            this.lblSalarioMin.Text = "Salario min:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(96, 27);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(193, 22);
            this.txtTitulo.TabIndex = 9;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.Location = new System.Drawing.Point(205, 206);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(84, 31);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(115, 206);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(84, 31);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(8, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(82, 16);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Descripción:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(75, 27);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(410, 22);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(14, 30);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(55, 16);
            this.lblBuscar.TabIndex = 15;
            this.lblBuscar.Text = "Buscar: ";
            // 
            // grdJobs
            // 
            this.grdJobs.AllowUserToAddRows = false;
            this.grdJobs.AllowUserToDeleteRows = false;
            this.grdJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grdJobs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdJobs.Location = new System.Drawing.Point(17, 68);
            this.grdJobs.MultiSelect = false;
            this.grdJobs.Name = "grdJobs";
            this.grdJobs.ReadOnly = true;
            this.grdJobs.RowHeadersWidth = 51;
            this.grdJobs.RowTemplate.Height = 24;
            this.grdJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdJobs.Size = new System.Drawing.Size(617, 169);
            this.grdJobs.TabIndex = 3;
            this.grdJobs.TabStop = false;
            this.grdJobs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdJobs_CellClick);
            // 
            // cboFiltro
            // 
            this.cboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFiltro.FormattingEnabled = true;
            this.cboFiltro.Items.AddRange(new object[] {
            "ID",
            "Descripción",
            "Salario Min",
            "Salario Max"});
            this.cboFiltro.Location = new System.Drawing.Point(491, 26);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(143, 24);
            this.cboFiltro.TabIndex = 2;
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrear.Location = new System.Drawing.Point(17, 243);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(84, 31);
            this.btnCrear.TabIndex = 16;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // FormJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 286);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.cboFiltro);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblTituloPanel);
            this.Controls.Add(this.pnlJob);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.grdJobs);
            this.Name = "FormJob";
            this.Text = "FormJobs";
            this.pnlJob.ResumeLayout(false);
            this.pnlJob.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdJobs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblTituloPanel;
        private System.Windows.Forms.Panel pnlJob;
        private System.Windows.Forms.TextBox txtSalarioMax;
        private System.Windows.Forms.Label lblSalarioMax;
        private System.Windows.Forms.TextBox txtSalarioMin;
        private System.Windows.Forms.Label lblSalarioMin;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridView grdJobs;
        private System.Windows.Forms.ComboBox cboFiltro;
        private System.Windows.Forms.Button btnCrear;
    }
}