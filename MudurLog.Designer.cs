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
            this.tblUrunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dukkanDataSet1 = new Ajans_X.dukkanDataSet1();
            this.dukkanDataSet = new Ajans_X.dukkanDataSet();
            this.dukkanDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUrunTableAdapter = new Ajans_X.dukkanDataSet1TableAdapters.tblUrunTableAdapter();
            this.dgvList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dukkanDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dukkanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dukkanDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "firmalar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(239, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "işler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(26, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "oyuncular";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(130, 43);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "ofis çalışan";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(12, 127);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(843, 109);
            this.dgvList.TabIndex = 5;
            // 
            // MudurLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 489);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MudurLog";
            this.Text = "MudurLog";
            this.Load += new System.EventHandler(this.MudurLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dukkanDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dukkanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dukkanDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource dukkanDataSetBindingSource;
        private dukkanDataSet dukkanDataSet;
        private dukkanDataSet1 dukkanDataSet1;
        private System.Windows.Forms.BindingSource tblUrunBindingSource;
        private dukkanDataSet1TableAdapters.tblUrunTableAdapter tblUrunTableAdapter;
        private System.Windows.Forms.DataGridView dgvList;
    }
}