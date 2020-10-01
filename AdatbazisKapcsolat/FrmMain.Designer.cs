namespace AdatbazisKapcsolat
{
    partial class FrmMain
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
            this.dgw_adatok = new System.Windows.Forms.DataGridView();
            this.database1DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new AdatbazisKapcsolat.Database1DataSet();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet2 = new AdatbazisKapcsolat.Database1DataSet2();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new AdatbazisKapcsolat.Database1DataSet2TableAdapters.TableTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_adatok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_adatok
            // 
            this.dgw_adatok.AutoGenerateColumns = false;
            this.dgw_adatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_adatok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nevDataGridViewTextBoxColumn});
            this.dgw_adatok.DataSource = this.tableBindingSource;
            this.dgw_adatok.Location = new System.Drawing.Point(74, 29);
            this.dgw_adatok.Name = "dgw_adatok";
            this.dgw_adatok.Size = new System.Drawing.Size(468, 380);
            this.dgw_adatok.TabIndex = 0;
            // 
            // database1DataSetBindingSource1
            // 
            this.database1DataSetBindingSource1.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource1.Position = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // database1DataSetBindingSource2
            // 
            this.database1DataSetBindingSource2.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource2.Position = 0;
            // 
            // database1DataSet2
            // 
            this.database1DataSet2.DataSetName = "Database1DataSet2";
            this.database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.database1DataSet2;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nevDataGridViewTextBoxColumn
            // 
            this.nevDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nevDataGridViewTextBoxColumn.DataPropertyName = "nev";
            this.nevDataGridViewTextBoxColumn.HeaderText = "nev";
            this.nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(548, 182);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(168, 55);
            this.btn_load.TabIndex = 1;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.Btn_load_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 529);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.dgw_adatok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_adatok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_adatok;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource1;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource2;
        private Database1DataSet2 database1DataSet2;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private Database1DataSet2TableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_load;
    }
}

