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
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet2 = new AdatbazisKapcsolat.Database1DataSet2();
            this.database1DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new AdatbazisKapcsolat.Database1DataSet();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new AdatbazisKapcsolat.Database1DataSet2TableAdapters.TableTableAdapter();
            this.btn_load = new System.Windows.Forms.Button();
            this.dgw_adatok = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_add = new System.Windows.Forms.Button();
            this.tb_input = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_adatok)).BeginInit();
            this.SuspendLayout();
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.database1DataSet2;
            // 
            // database1DataSet2
            // 
            this.database1DataSet2.DataSetName = "Database1DataSet2";
            this.database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
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
            // dgw_adatok
            // 
            this.dgw_adatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_adatok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nev});
            this.dgw_adatok.Location = new System.Drawing.Point(74, 29);
            this.dgw_adatok.Name = "dgw_adatok";
            this.dgw_adatok.Size = new System.Drawing.Size(468, 380);
            this.dgw_adatok.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            // 
            // nev
            // 
            this.nev.HeaderText = "nev";
            this.nev.Name = "nev";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(89, 454);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(168, 63);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Hozzaad";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // tb_input
            // 
            this.tb_input.Location = new System.Drawing.Point(89, 428);
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(100, 20);
            this.tb_input.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 529);
            this.Controls.Add(this.tb_input);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.dgw_adatok);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_adatok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource1;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource2;
        private Database1DataSet2 database1DataSet2;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private Database1DataSet2TableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.DataGridView dgw_adatok;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nev;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tb_input;
    }
}

