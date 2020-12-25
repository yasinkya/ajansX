namespace Ajans_X
{
    partial class MudurLog
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunKodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bolgeKodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaKodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bayiFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listeFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ındirimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kDVoranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunResimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunOzetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunTanitimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunDurumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunOncelikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDurumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokMinimumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokAmbarKodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.garantiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dovizKodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reyonKodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanimKlavuzWEBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baStokDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.teslimatSureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dagiticiKodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hacimDesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baKarisikKoliDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.birimKodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblUrunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dukkanDataSet1 = new Ajans_X.dukkanDataSet1();
            this.dukkanDataSet = new Ajans_X.dukkanDataSet();
            this.dukkanDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUrunTableAdapter = new Ajans_X.dukkanDataSet1TableAdapters.tblUrunTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dukkanDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dukkanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dukkanDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "firmalar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(40, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "işler";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(343, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "oyuncular";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(443, 43);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "ofis çalışan";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(241, 43);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "müdür yardımcıları";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunKodDataGridViewTextBoxColumn,
            this.Column1,
            this.bolgeKodDataGridViewTextBoxColumn,
            this.markaKodDataGridViewTextBoxColumn,
            this.urunAdDataGridViewTextBoxColumn,
            this.bayiFiyatDataGridViewTextBoxColumn,
            this.listeFiyatDataGridViewTextBoxColumn,
            this.ındirimDataGridViewTextBoxColumn,
            this.kDVoranDataGridViewTextBoxColumn,
            this.urunResimDataGridViewTextBoxColumn,
            this.urunOzetDataGridViewTextBoxColumn,
            this.urunTanitimDataGridViewTextBoxColumn,
            this.urunDurumDataGridViewTextBoxColumn,
            this.urunOncelikDataGridViewTextBoxColumn,
            this.stokDurumDataGridViewTextBoxColumn,
            this.stokMinimumDataGridViewTextBoxColumn,
            this.stokAmbarKodDataGridViewTextBoxColumn,
            this.garantiDataGridViewTextBoxColumn,
            this.dovizKodDataGridViewTextBoxColumn,
            this.reyonKodDataGridViewTextBoxColumn,
            this.kullanimKlavuzWEBDataGridViewTextBoxColumn,
            this.baStokDurumDataGridViewCheckBoxColumn,
            this.teslimatSureDataGridViewTextBoxColumn,
            this.dagiticiKodDataGridViewTextBoxColumn,
            this.hacimDesiDataGridViewTextBoxColumn,
            this.baKarisikKoliDataGridViewCheckBoxColumn,
            this.birimKodDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblUrunBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(738, 150);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // urunKodDataGridViewTextBoxColumn
            // 
            this.urunKodDataGridViewTextBoxColumn.DataPropertyName = "urunKod";
            this.urunKodDataGridViewTextBoxColumn.HeaderText = "urunKod";
            this.urunKodDataGridViewTextBoxColumn.Name = "urunKodDataGridViewTextBoxColumn";
            this.urunKodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "urunKod";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // bolgeKodDataGridViewTextBoxColumn
            // 
            this.bolgeKodDataGridViewTextBoxColumn.DataPropertyName = "bolgeKod";
            this.bolgeKodDataGridViewTextBoxColumn.HeaderText = "bolgeKod";
            this.bolgeKodDataGridViewTextBoxColumn.Name = "bolgeKodDataGridViewTextBoxColumn";
            // 
            // markaKodDataGridViewTextBoxColumn
            // 
            this.markaKodDataGridViewTextBoxColumn.DataPropertyName = "markaKod";
            this.markaKodDataGridViewTextBoxColumn.HeaderText = "markaKod";
            this.markaKodDataGridViewTextBoxColumn.Name = "markaKodDataGridViewTextBoxColumn";
            // 
            // urunAdDataGridViewTextBoxColumn
            // 
            this.urunAdDataGridViewTextBoxColumn.DataPropertyName = "urunAd";
            this.urunAdDataGridViewTextBoxColumn.HeaderText = "urunAd";
            this.urunAdDataGridViewTextBoxColumn.Name = "urunAdDataGridViewTextBoxColumn";
            // 
            // bayiFiyatDataGridViewTextBoxColumn
            // 
            this.bayiFiyatDataGridViewTextBoxColumn.DataPropertyName = "bayiFiyat";
            this.bayiFiyatDataGridViewTextBoxColumn.HeaderText = "bayiFiyat";
            this.bayiFiyatDataGridViewTextBoxColumn.Name = "bayiFiyatDataGridViewTextBoxColumn";
            // 
            // listeFiyatDataGridViewTextBoxColumn
            // 
            this.listeFiyatDataGridViewTextBoxColumn.DataPropertyName = "listeFiyat";
            this.listeFiyatDataGridViewTextBoxColumn.HeaderText = "listeFiyat";
            this.listeFiyatDataGridViewTextBoxColumn.Name = "listeFiyatDataGridViewTextBoxColumn";
            // 
            // ındirimDataGridViewTextBoxColumn
            // 
            this.ındirimDataGridViewTextBoxColumn.DataPropertyName = "Indirim";
            this.ındirimDataGridViewTextBoxColumn.HeaderText = "Indirim";
            this.ındirimDataGridViewTextBoxColumn.Name = "ındirimDataGridViewTextBoxColumn";
            // 
            // kDVoranDataGridViewTextBoxColumn
            // 
            this.kDVoranDataGridViewTextBoxColumn.DataPropertyName = "KDVoran";
            this.kDVoranDataGridViewTextBoxColumn.HeaderText = "KDVoran";
            this.kDVoranDataGridViewTextBoxColumn.Name = "kDVoranDataGridViewTextBoxColumn";
            // 
            // urunResimDataGridViewTextBoxColumn
            // 
            this.urunResimDataGridViewTextBoxColumn.DataPropertyName = "urunResim";
            this.urunResimDataGridViewTextBoxColumn.HeaderText = "urunResim";
            this.urunResimDataGridViewTextBoxColumn.Name = "urunResimDataGridViewTextBoxColumn";
            // 
            // urunOzetDataGridViewTextBoxColumn
            // 
            this.urunOzetDataGridViewTextBoxColumn.DataPropertyName = "urunOzet";
            this.urunOzetDataGridViewTextBoxColumn.HeaderText = "urunOzet";
            this.urunOzetDataGridViewTextBoxColumn.Name = "urunOzetDataGridViewTextBoxColumn";
            // 
            // urunTanitimDataGridViewTextBoxColumn
            // 
            this.urunTanitimDataGridViewTextBoxColumn.DataPropertyName = "urunTanitim";
            this.urunTanitimDataGridViewTextBoxColumn.HeaderText = "urunTanitim";
            this.urunTanitimDataGridViewTextBoxColumn.Name = "urunTanitimDataGridViewTextBoxColumn";
            // 
            // urunDurumDataGridViewTextBoxColumn
            // 
            this.urunDurumDataGridViewTextBoxColumn.DataPropertyName = "urunDurum";
            this.urunDurumDataGridViewTextBoxColumn.HeaderText = "urunDurum";
            this.urunDurumDataGridViewTextBoxColumn.Name = "urunDurumDataGridViewTextBoxColumn";
            // 
            // urunOncelikDataGridViewTextBoxColumn
            // 
            this.urunOncelikDataGridViewTextBoxColumn.DataPropertyName = "urunOncelik";
            this.urunOncelikDataGridViewTextBoxColumn.HeaderText = "urunOncelik";
            this.urunOncelikDataGridViewTextBoxColumn.Name = "urunOncelikDataGridViewTextBoxColumn";
            // 
            // stokDurumDataGridViewTextBoxColumn
            // 
            this.stokDurumDataGridViewTextBoxColumn.DataPropertyName = "stokDurum";
            this.stokDurumDataGridViewTextBoxColumn.HeaderText = "stokDurum";
            this.stokDurumDataGridViewTextBoxColumn.Name = "stokDurumDataGridViewTextBoxColumn";
            // 
            // stokMinimumDataGridViewTextBoxColumn
            // 
            this.stokMinimumDataGridViewTextBoxColumn.DataPropertyName = "stokMinimum";
            this.stokMinimumDataGridViewTextBoxColumn.HeaderText = "stokMinimum";
            this.stokMinimumDataGridViewTextBoxColumn.Name = "stokMinimumDataGridViewTextBoxColumn";
            // 
            // stokAmbarKodDataGridViewTextBoxColumn
            // 
            this.stokAmbarKodDataGridViewTextBoxColumn.DataPropertyName = "stokAmbarKod";
            this.stokAmbarKodDataGridViewTextBoxColumn.HeaderText = "stokAmbarKod";
            this.stokAmbarKodDataGridViewTextBoxColumn.Name = "stokAmbarKodDataGridViewTextBoxColumn";
            // 
            // garantiDataGridViewTextBoxColumn
            // 
            this.garantiDataGridViewTextBoxColumn.DataPropertyName = "garanti";
            this.garantiDataGridViewTextBoxColumn.HeaderText = "garanti";
            this.garantiDataGridViewTextBoxColumn.Name = "garantiDataGridViewTextBoxColumn";
            // 
            // dovizKodDataGridViewTextBoxColumn
            // 
            this.dovizKodDataGridViewTextBoxColumn.DataPropertyName = "dovizKod";
            this.dovizKodDataGridViewTextBoxColumn.HeaderText = "dovizKod";
            this.dovizKodDataGridViewTextBoxColumn.Name = "dovizKodDataGridViewTextBoxColumn";
            // 
            // reyonKodDataGridViewTextBoxColumn
            // 
            this.reyonKodDataGridViewTextBoxColumn.DataPropertyName = "reyonKod";
            this.reyonKodDataGridViewTextBoxColumn.HeaderText = "reyonKod";
            this.reyonKodDataGridViewTextBoxColumn.Name = "reyonKodDataGridViewTextBoxColumn";
            // 
            // kullanimKlavuzWEBDataGridViewTextBoxColumn
            // 
            this.kullanimKlavuzWEBDataGridViewTextBoxColumn.DataPropertyName = "kullanimKlavuzWEB";
            this.kullanimKlavuzWEBDataGridViewTextBoxColumn.HeaderText = "kullanimKlavuzWEB";
            this.kullanimKlavuzWEBDataGridViewTextBoxColumn.Name = "kullanimKlavuzWEBDataGridViewTextBoxColumn";
            // 
            // baStokDurumDataGridViewCheckBoxColumn
            // 
            this.baStokDurumDataGridViewCheckBoxColumn.DataPropertyName = "baStokDurum";
            this.baStokDurumDataGridViewCheckBoxColumn.HeaderText = "baStokDurum";
            this.baStokDurumDataGridViewCheckBoxColumn.Name = "baStokDurumDataGridViewCheckBoxColumn";
            // 
            // teslimatSureDataGridViewTextBoxColumn
            // 
            this.teslimatSureDataGridViewTextBoxColumn.DataPropertyName = "teslimatSure";
            this.teslimatSureDataGridViewTextBoxColumn.HeaderText = "teslimatSure";
            this.teslimatSureDataGridViewTextBoxColumn.Name = "teslimatSureDataGridViewTextBoxColumn";
            // 
            // dagiticiKodDataGridViewTextBoxColumn
            // 
            this.dagiticiKodDataGridViewTextBoxColumn.DataPropertyName = "dagiticiKod";
            this.dagiticiKodDataGridViewTextBoxColumn.HeaderText = "dagiticiKod";
            this.dagiticiKodDataGridViewTextBoxColumn.Name = "dagiticiKodDataGridViewTextBoxColumn";
            // 
            // hacimDesiDataGridViewTextBoxColumn
            // 
            this.hacimDesiDataGridViewTextBoxColumn.DataPropertyName = "hacimDesi";
            this.hacimDesiDataGridViewTextBoxColumn.HeaderText = "hacimDesi";
            this.hacimDesiDataGridViewTextBoxColumn.Name = "hacimDesiDataGridViewTextBoxColumn";
            // 
            // baKarisikKoliDataGridViewCheckBoxColumn
            // 
            this.baKarisikKoliDataGridViewCheckBoxColumn.DataPropertyName = "baKarisikKoli";
            this.baKarisikKoliDataGridViewCheckBoxColumn.HeaderText = "baKarisikKoli";
            this.baKarisikKoliDataGridViewCheckBoxColumn.Name = "baKarisikKoliDataGridViewCheckBoxColumn";
            // 
            // birimKodDataGridViewTextBoxColumn
            // 
            this.birimKodDataGridViewTextBoxColumn.DataPropertyName = "birimKod";
            this.birimKodDataGridViewTextBoxColumn.HeaderText = "birimKod";
            this.birimKodDataGridViewTextBoxColumn.Name = "birimKodDataGridViewTextBoxColumn";
            // 
            // tblUrunBindingSource
            // 
            this.tblUrunBindingSource.DataMember = "tblUrun";
            this.tblUrunBindingSource.DataSource = this.dukkanDataSet1;
            // 
            // dukkanDataSet1
            // 
            this.dukkanDataSet1.DataSetName = "dukkanDataSet1";
            this.dukkanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dukkanDataSet
            // 
            this.dukkanDataSet.DataSetName = "dukkanDataSet";
            this.dukkanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dukkanDataSetBindingSource
            // 
            this.dukkanDataSetBindingSource.DataSource = this.dukkanDataSet;
            this.dukkanDataSetBindingSource.Position = 0;
            // 
            // tblUrunTableAdapter
            // 
            this.tblUrunTableAdapter.ClearBeforeFill = true;
            // 
            // MudurLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MudurLog";
            this.Text = "MudurLog";
            this.Load += new System.EventHandler(this.MudurLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dukkanDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dukkanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dukkanDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dukkanDataSetBindingSource;
        private dukkanDataSet dukkanDataSet;
        private dukkanDataSet1 dukkanDataSet1;
        private System.Windows.Forms.BindingSource tblUrunBindingSource;
        private dukkanDataSet1TableAdapters.tblUrunTableAdapter tblUrunTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunKodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolgeKodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaKodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bayiFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn listeFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ındirimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kDVoranDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunResimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunOzetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunTanitimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunDurumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunOncelikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDurumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokMinimumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokAmbarKodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn garantiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dovizKodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reyonKodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanimKlavuzWEBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn baStokDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teslimatSureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dagiticiKodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hacimDesiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn baKarisikKoliDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimKodDataGridViewTextBoxColumn;
    }
}