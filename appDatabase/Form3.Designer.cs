
namespace appDatabase
{
    partial class Form3
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
            this.voituresDataSet1 = new appDatabase.VoituresDataSet1();
            this.voitureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voitureTableAdapter = new appDatabase.VoituresDataSet1TableAdapters.VoitureTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anneeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voituresDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voitureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.marqueDataGridViewTextBoxColumn,
            this.modeleDataGridViewTextBoxColumn,
            this.anneeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.voitureBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(554, 382);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // voituresDataSet1
            // 
            this.voituresDataSet1.DataSetName = "VoituresDataSet1";
            this.voituresDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // voitureBindingSource
            // 
            this.voitureBindingSource.DataMember = "Voiture";
            this.voitureBindingSource.DataSource = this.voituresDataSet1;
            // 
            // voitureTableAdapter
            // 
            this.voitureTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // marqueDataGridViewTextBoxColumn
            // 
            this.marqueDataGridViewTextBoxColumn.DataPropertyName = "Marque";
            this.marqueDataGridViewTextBoxColumn.HeaderText = "Marque";
            this.marqueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.marqueDataGridViewTextBoxColumn.Name = "marqueDataGridViewTextBoxColumn";
            this.marqueDataGridViewTextBoxColumn.ReadOnly = true;
            this.marqueDataGridViewTextBoxColumn.Width = 125;
            // 
            // modeleDataGridViewTextBoxColumn
            // 
            this.modeleDataGridViewTextBoxColumn.DataPropertyName = "Modele";
            this.modeleDataGridViewTextBoxColumn.HeaderText = "Modele";
            this.modeleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modeleDataGridViewTextBoxColumn.Name = "modeleDataGridViewTextBoxColumn";
            this.modeleDataGridViewTextBoxColumn.ReadOnly = true;
            this.modeleDataGridViewTextBoxColumn.Width = 125;
            // 
            // anneeDataGridViewTextBoxColumn
            // 
            this.anneeDataGridViewTextBoxColumn.DataPropertyName = "Annee";
            this.anneeDataGridViewTextBoxColumn.HeaderText = "Annee";
            this.anneeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.anneeDataGridViewTextBoxColumn.Name = "anneeDataGridViewTextBoxColumn";
            this.anneeDataGridViewTextBoxColumn.ReadOnly = true;
            this.anneeDataGridViewTextBoxColumn.Width = 125;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(520, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 458);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Table de voitures";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voituresDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voitureBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private VoituresDataSet1 voituresDataSet1;
        private System.Windows.Forms.BindingSource voitureBindingSource;
        private VoituresDataSet1TableAdapters.VoitureTableAdapter voitureTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anneeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}