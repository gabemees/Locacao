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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label carros_MarcaLabel;
            System.Windows.Forms.Label carros_NomeLabel;
            System.Windows.Forms.Label carros_PlacaLabel;
            System.Windows.Forms.Label clientes_CpfLabel;
            System.Windows.Forms.Label clientes_NomeLabel;
            System.Windows.Forms.Label clientes_TelefoneLabel;
            System.Windows.Forms.Label dataLocacaoLabel;
            System.Windows.Forms.Label statusLabel;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carrosMarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carrosNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carrosPlacaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesCpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesTelefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLocacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.locacaoCarroesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locacaoCarroDBDataSet = new Grupo.Locacao.Apresentacao.LocacaoCarroDBDataSet();
            this.locacaoCarroesTableAdapter = new Grupo.Locacao.Apresentacao.LocacaoCarroDBDataSetTableAdapters.LocacaoCarroesTableAdapter();
            this.tableAdapterManager = new Grupo.Locacao.Apresentacao.LocacaoCarroDBDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.carros_MarcaTextBox = new System.Windows.Forms.TextBox();
            this.carros_NomeTextBox = new System.Windows.Forms.TextBox();
            this.carros_PlacaTextBox = new System.Windows.Forms.TextBox();
            this.clientes_CpfTextBox = new System.Windows.Forms.TextBox();
            this.clientes_NomeTextBox = new System.Windows.Forms.TextBox();
            this.clientes_TelefoneTextBox = new System.Windows.Forms.TextBox();
            this.dataLocacaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.statusCheckBox = new System.Windows.Forms.CheckBox();
            idLabel = new System.Windows.Forms.Label();
            carros_MarcaLabel = new System.Windows.Forms.Label();
            carros_NomeLabel = new System.Windows.Forms.Label();
            carros_PlacaLabel = new System.Windows.Forms.Label();
            clientes_CpfLabel = new System.Windows.Forms.Label();
            clientes_NomeLabel = new System.Windows.Forms.Label();
            clientes_TelefoneLabel = new System.Windows.Forms.Label();
            dataLocacaoLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoCarroesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoCarroDBDataSet)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(315, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(665, 430);
            this.dataGridView1.TabIndex = 0;
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
            // locacaoCarroesBindingSource
            // 
            this.locacaoCarroesBindingSource.DataMember = "LocacaoCarroes";
            this.locacaoCarroesBindingSource.DataSource = this.locacaoCarroDBDataSet;
            // 
            // locacaoCarroDBDataSet
            // 
            this.locacaoCarroDBDataSet.DataSetName = "LocacaoCarroDBDataSet";
            this.locacaoCarroDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Adicionar ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(182, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(109, 405);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Remover";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(11, 85);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 22;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locacaoCarroesBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(109, 82);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 23;
            // 
            // carros_MarcaLabel
            // 
            carros_MarcaLabel.AutoSize = true;
            carros_MarcaLabel.Location = new System.Drawing.Point(11, 111);
            carros_MarcaLabel.Name = "carros_MarcaLabel";
            carros_MarcaLabel.Size = new System.Drawing.Size(73, 13);
            carros_MarcaLabel.TabIndex = 24;
            carros_MarcaLabel.Text = "Carros Marca:";
            // 
            // carros_MarcaTextBox
            // 
            this.carros_MarcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locacaoCarroesBindingSource, "Carros_Marca", true));
            this.carros_MarcaTextBox.Location = new System.Drawing.Point(109, 108);
            this.carros_MarcaTextBox.Name = "carros_MarcaTextBox";
            this.carros_MarcaTextBox.Size = new System.Drawing.Size(200, 20);
            this.carros_MarcaTextBox.TabIndex = 25;
            // 
            // carros_NomeLabel
            // 
            carros_NomeLabel.AutoSize = true;
            carros_NomeLabel.Location = new System.Drawing.Point(11, 137);
            carros_NomeLabel.Name = "carros_NomeLabel";
            carros_NomeLabel.Size = new System.Drawing.Size(71, 13);
            carros_NomeLabel.TabIndex = 26;
            carros_NomeLabel.Text = "Carros Nome:";
            // 
            // carros_NomeTextBox
            // 
            this.carros_NomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locacaoCarroesBindingSource, "Carros_Nome", true));
            this.carros_NomeTextBox.Location = new System.Drawing.Point(109, 134);
            this.carros_NomeTextBox.Name = "carros_NomeTextBox";
            this.carros_NomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.carros_NomeTextBox.TabIndex = 27;
            // 
            // carros_PlacaLabel
            // 
            carros_PlacaLabel.AutoSize = true;
            carros_PlacaLabel.Location = new System.Drawing.Point(11, 163);
            carros_PlacaLabel.Name = "carros_PlacaLabel";
            carros_PlacaLabel.Size = new System.Drawing.Size(70, 13);
            carros_PlacaLabel.TabIndex = 28;
            carros_PlacaLabel.Text = "Carros Placa:";
            // 
            // carros_PlacaTextBox
            // 
            this.carros_PlacaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locacaoCarroesBindingSource, "Carros_Placa", true));
            this.carros_PlacaTextBox.Location = new System.Drawing.Point(109, 160);
            this.carros_PlacaTextBox.Name = "carros_PlacaTextBox";
            this.carros_PlacaTextBox.Size = new System.Drawing.Size(200, 20);
            this.carros_PlacaTextBox.TabIndex = 29;
            // 
            // clientes_CpfLabel
            // 
            clientes_CpfLabel.AutoSize = true;
            clientes_CpfLabel.Location = new System.Drawing.Point(11, 189);
            clientes_CpfLabel.Name = "clientes_CpfLabel";
            clientes_CpfLabel.Size = new System.Drawing.Size(66, 13);
            clientes_CpfLabel.TabIndex = 30;
            clientes_CpfLabel.Text = "Clientes Cpf:";
            // 
            // clientes_CpfTextBox
            // 
            this.clientes_CpfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locacaoCarroesBindingSource, "Clientes_Cpf", true));
            this.clientes_CpfTextBox.Location = new System.Drawing.Point(109, 186);
            this.clientes_CpfTextBox.Name = "clientes_CpfTextBox";
            this.clientes_CpfTextBox.Size = new System.Drawing.Size(200, 20);
            this.clientes_CpfTextBox.TabIndex = 31;
            // 
            // clientes_NomeLabel
            // 
            clientes_NomeLabel.AutoSize = true;
            clientes_NomeLabel.Location = new System.Drawing.Point(11, 215);
            clientes_NomeLabel.Name = "clientes_NomeLabel";
            clientes_NomeLabel.Size = new System.Drawing.Size(78, 13);
            clientes_NomeLabel.TabIndex = 32;
            clientes_NomeLabel.Text = "Clientes Nome:";
            // 
            // clientes_NomeTextBox
            // 
            this.clientes_NomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locacaoCarroesBindingSource, "Clientes_Nome", true));
            this.clientes_NomeTextBox.Location = new System.Drawing.Point(109, 212);
            this.clientes_NomeTextBox.Name = "clientes_NomeTextBox";
            this.clientes_NomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.clientes_NomeTextBox.TabIndex = 33;
            // 
            // clientes_TelefoneLabel
            // 
            clientes_TelefoneLabel.AutoSize = true;
            clientes_TelefoneLabel.Location = new System.Drawing.Point(11, 241);
            clientes_TelefoneLabel.Name = "clientes_TelefoneLabel";
            clientes_TelefoneLabel.Size = new System.Drawing.Size(92, 13);
            clientes_TelefoneLabel.TabIndex = 34;
            clientes_TelefoneLabel.Text = "Clientes Telefone:";
            // 
            // clientes_TelefoneTextBox
            // 
            this.clientes_TelefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.locacaoCarroesBindingSource, "Clientes_Telefone", true));
            this.clientes_TelefoneTextBox.Location = new System.Drawing.Point(109, 238);
            this.clientes_TelefoneTextBox.Name = "clientes_TelefoneTextBox";
            this.clientes_TelefoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.clientes_TelefoneTextBox.TabIndex = 35;
            // 
            // dataLocacaoLabel
            // 
            dataLocacaoLabel.AutoSize = true;
            dataLocacaoLabel.Location = new System.Drawing.Point(11, 268);
            dataLocacaoLabel.Name = "dataLocacaoLabel";
            dataLocacaoLabel.Size = new System.Drawing.Size(78, 13);
            dataLocacaoLabel.TabIndex = 36;
            dataLocacaoLabel.Text = "Data Locacao:";
            // 
            // dataLocacaoDateTimePicker
            // 
            this.dataLocacaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.locacaoCarroesBindingSource, "DataLocacao", true));
            this.dataLocacaoDateTimePicker.Location = new System.Drawing.Point(109, 264);
            this.dataLocacaoDateTimePicker.Name = "dataLocacaoDateTimePicker";
            this.dataLocacaoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataLocacaoDateTimePicker.TabIndex = 37;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(11, 295);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 38;
            statusLabel.Text = "Status:";
            // 
            // statusCheckBox
            // 
            this.statusCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.locacaoCarroesBindingSource, "Status", true));
            this.statusCheckBox.Location = new System.Drawing.Point(109, 290);
            this.statusCheckBox.Name = "statusCheckBox";
            this.statusCheckBox.Size = new System.Drawing.Size(200, 24);
            this.statusCheckBox.TabIndex = 39;
            this.statusCheckBox.Text = "checkBox1";
            this.statusCheckBox.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 461);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(carros_MarcaLabel);
            this.Controls.Add(this.carros_MarcaTextBox);
            this.Controls.Add(carros_NomeLabel);
            this.Controls.Add(this.carros_NomeTextBox);
            this.Controls.Add(carros_PlacaLabel);
            this.Controls.Add(this.carros_PlacaTextBox);
            this.Controls.Add(clientes_CpfLabel);
            this.Controls.Add(this.clientes_CpfTextBox);
            this.Controls.Add(clientes_NomeLabel);
            this.Controls.Add(this.clientes_NomeTextBox);
            this.Controls.Add(clientes_TelefoneLabel);
            this.Controls.Add(this.clientes_TelefoneTextBox);
            this.Controls.Add(dataLocacaoLabel);
            this.Controls.Add(this.dataLocacaoDateTimePicker);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusCheckBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Principal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoCarroesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoCarroDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox carros_MarcaTextBox;
        private System.Windows.Forms.TextBox carros_NomeTextBox;
        private System.Windows.Forms.TextBox carros_PlacaTextBox;
        private System.Windows.Forms.TextBox clientes_CpfTextBox;
        private System.Windows.Forms.TextBox clientes_NomeTextBox;
        private System.Windows.Forms.TextBox clientes_TelefoneTextBox;
        private System.Windows.Forms.DateTimePicker dataLocacaoDateTimePicker;
        private System.Windows.Forms.CheckBox statusCheckBox;
    }
}

