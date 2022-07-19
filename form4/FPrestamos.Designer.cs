namespace form4
{
    partial class FPrestamos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadSolicitadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadMesesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRESTAMOSDataSet = new form4.PRESTAMOSDataSet();
            this.prestamosTableAdapter = new form4.PRESTAMOSDataSetTableAdapters.PrestamosTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRESTAMOSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.clienteIdDataGridViewTextBoxColumn,
            this.cantidadSolicitadaDataGridViewTextBoxColumn,
            this.tasaDataGridViewTextBoxColumn,
            this.cantidadMesesDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.prestamosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(961, 289);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // clienteIdDataGridViewTextBoxColumn
            // 
            this.clienteIdDataGridViewTextBoxColumn.DataPropertyName = "ClienteId";
            this.clienteIdDataGridViewTextBoxColumn.HeaderText = "ClienteId";
            this.clienteIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.clienteIdDataGridViewTextBoxColumn.Name = "clienteIdDataGridViewTextBoxColumn";
            this.clienteIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // cantidadSolicitadaDataGridViewTextBoxColumn
            // 
            this.cantidadSolicitadaDataGridViewTextBoxColumn.DataPropertyName = "CantidadSolicitada";
            this.cantidadSolicitadaDataGridViewTextBoxColumn.HeaderText = "CantidadSolicitada";
            this.cantidadSolicitadaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cantidadSolicitadaDataGridViewTextBoxColumn.Name = "cantidadSolicitadaDataGridViewTextBoxColumn";
            this.cantidadSolicitadaDataGridViewTextBoxColumn.Width = 150;
            // 
            // tasaDataGridViewTextBoxColumn
            // 
            this.tasaDataGridViewTextBoxColumn.DataPropertyName = "Tasa";
            this.tasaDataGridViewTextBoxColumn.HeaderText = "Tasa";
            this.tasaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tasaDataGridViewTextBoxColumn.Name = "tasaDataGridViewTextBoxColumn";
            this.tasaDataGridViewTextBoxColumn.Width = 150;
            // 
            // cantidadMesesDataGridViewTextBoxColumn
            // 
            this.cantidadMesesDataGridViewTextBoxColumn.DataPropertyName = "CantidadMeses";
            this.cantidadMesesDataGridViewTextBoxColumn.HeaderText = "CantidadMeses";
            this.cantidadMesesDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cantidadMesesDataGridViewTextBoxColumn.Name = "cantidadMesesDataGridViewTextBoxColumn";
            this.cantidadMesesDataGridViewTextBoxColumn.Width = 150;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.Width = 150;
            // 
            // prestamosBindingSource
            // 
            this.prestamosBindingSource.DataMember = "Prestamos";
            this.prestamosBindingSource.DataSource = this.pRESTAMOSDataSet;
            // 
            // pRESTAMOSDataSet
            // 
            this.pRESTAMOSDataSet.DataSetName = "PRESTAMOSDataSet";
            this.pRESTAMOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prestamosTableAdapter
            // 
            this.prestamosTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agregar solicitud prestamo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FPrestamos";
            this.Load += new System.EventHandler(this.FPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRESTAMOSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PRESTAMOSDataSet pRESTAMOSDataSet;
        private System.Windows.Forms.BindingSource prestamosBindingSource;
        private PRESTAMOSDataSetTableAdapters.PrestamosTableAdapter prestamosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadSolicitadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadMesesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}