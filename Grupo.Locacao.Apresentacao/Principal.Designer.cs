namespace Grupo.Locacao.Apresentacao
{
    partial class Principal
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
            this.locacaoCarroDBDataSet = new Grupo.Locacao.Apresentacao.LocacaoCarroDBDataSet();
            this.locacaoCarroesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locacaoCarroesTableAdapter = new Grupo.Locacao.Apresentacao.LocacaoCarroDBDataSetTableAdapters.LocacaoCarroesTableAdapter();
            this.tableAdapterManager = new Grupo.Locacao.Apresentacao.LocacaoCarroDBDataSetTableAdapters.TableAdapterManager();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carrosMarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carrosNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carrosPlacaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesCpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesTelefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLocacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoCarroDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoCarroesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.carrosMarcaDataGridViewTextBoxColumn,
            this.carrosNomeDataGridViewTextBoxColumn,
            this.carrosPlacaDataGridViewTextBoxColumn,
            this.clientesCpfDataGridViewTextBoxColumn,
            this.clientesNomeDataGridViewTextBoxColumn,
            this.clientesTelefoneDataGridViewTextBoxColumn,
            this.dataLocacaoDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.locacaoCarroesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(942, 407);
            this.dataGridView1.TabIndex = 0;
            // 
            // locacaoCarroDBDataSet
            // 
            this.locacaoCarroDBDataSet.DataSetName = "LocacaoCarroDBDataSet";
            this.locacaoCarroDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locacaoCarroesBindingSource
            // 
            this.locacaoCarroesBindingSource.DataMember = "LocacaoCarroes";
            this.locacaoCarroesBindingSource.DataSource = this.locacaoCarroDBDataSet;
            // 
            // locacaoCarroesTableAdapter
            // 
            this.locacaoCarroesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.@__MigrationHistoryTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LocacaoCarroesTableAdapter = this.locacaoCarroesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Grupo.Locacao.Apresentacao.LocacaoCarroDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carrosMarcaDataGridViewTextBoxColumn
            // 
            this.carrosMarcaDataGridViewTextBoxColumn.DataPropertyName = "Carros_Marca";
            this.carrosMarcaDataGridViewTextBoxColumn.HeaderText = "Carros_Marca";
            this.carrosMarcaDataGridViewTextBoxColumn.Name = "carrosMarcaDataGridViewTextBoxColumn";
            // 
            // carrosNomeDataGridViewTextBoxColumn
            // 
            this.carrosNomeDataGridViewTextBoxColumn.DataPropertyName = "Carros_Nome";
            this.carrosNomeDataGridViewTextBoxColumn.HeaderText = "Carros_Nome";
            this.carrosNomeDataGridViewTextBoxColumn.Name = "carrosNomeDataGridViewTextBoxColumn";
            // 
            // carrosPlacaDataGridViewTextBoxColumn
            // 
            this.carrosPlacaDataGridViewTextBoxColumn.DataPropertyName = "Carros_Placa";
            this.carrosPlacaDataGridViewTextBoxColumn.HeaderText = "Carros_Placa";
            this.carrosPlacaDataGridViewTextBoxColumn.Name = "carrosPlacaDataGridViewTextBoxColumn";
            // 
            // clientesCpfDataGridViewTextBoxColumn
            // 
            this.clientesCpfDataGridViewTextBoxColumn.DataPropertyName = "Clientes_Cpf";
            this.clientesCpfDataGridViewTextBoxColumn.HeaderText = "Clientes_Cpf";
            this.clientesCpfDataGridViewTextBoxColumn.Name = "clientesCpfDataGridViewTextBoxColumn";
            // 
            // clientesNomeDataGridViewTextBoxColumn
            // 
            this.clientesNomeDataGridViewTextBoxColumn.DataPropertyName = "Clientes_Nome";
            this.clientesNomeDataGridViewTextBoxColumn.HeaderText = "Clientes_Nome";
            this.clientesNomeDataGridViewTextBoxColumn.Name = "clientesNomeDataGridViewTextBoxColumn";
            // 
            // clientesTelefoneDataGridViewTextBoxColumn
            // 
            this.clientesTelefoneDataGridViewTextBoxColumn.DataPropertyName = "Clientes_Telefone";
            this.clientesTelefoneDataGridViewTextBoxColumn.HeaderText = "Clientes_Telefone";
            this.clientesTelefoneDataGridViewTextBoxColumn.Name = "clientesTelefoneDataGridViewTextBoxColumn";
            // 
            // dataLocacaoDataGridViewTextBoxColumn
            // 
            this.dataLocacaoDataGridViewTextBoxColumn.DataPropertyName = "DataLocacao";
            this.dataLocacaoDataGridViewTextBoxColumn.HeaderText = "DataLocacao";
            this.dataLocacaoDataGridViewTextBoxColumn.Name = "dataLocacaoDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Status";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(931, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Adicionar\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 464);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Principal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoCarroDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoCarroesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private LocacaoCarroDBDataSet locacaoCarroDBDataSet;
        private System.Windows.Forms.BindingSource locacaoCarroesBindingSource;
        private LocacaoCarroDBDataSetTableAdapters.LocacaoCarroesTableAdapter locacaoCarroesTableAdapter;
        private LocacaoCarroDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carrosMarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carrosNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carrosPlacaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientesCpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientesNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientesTelefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLocacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}

