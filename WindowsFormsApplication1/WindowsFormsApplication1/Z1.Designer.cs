namespace WindowsFormsApplication1
{
    partial class Z1
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
            this.базаДанныхDataSet = new WindowsFormsApplication1.БазаДанныхDataSet();
            this.запрос1КолВоКупленногоЦенуBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.запрос_1___кол_во_купленного___ценуTableAdapter = new WindowsFormsApplication1.БазаДанныхDataSetTableAdapters.запрос_1___кол_во_купленного___ценуTableAdapter();
            this.названиеПродуктаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumВыражение1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.базаДанныхDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.запрос1КолВоКупленногоЦенуBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиеПродуктаDataGridViewTextBoxColumn,
            this.sumВыражение1DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.запрос1КолВоКупленногоЦенуBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(709, 325);
            this.dataGridView1.TabIndex = 0;
            // 
            // базаДанныхDataSet
            // 
            this.базаДанныхDataSet.DataSetName = "БазаДанныхDataSet";
            this.базаДанныхDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // запрос1КолВоКупленногоЦенуBindingSource
            // 
            this.запрос1КолВоКупленногоЦенуBindingSource.DataMember = "запрос 1 + кол во купленного * цену";
            this.запрос1КолВоКупленногоЦенуBindingSource.DataSource = this.базаДанныхDataSet;
            // 
            // запрос_1___кол_во_купленного___ценуTableAdapter
            // 
            this.запрос_1___кол_во_купленного___ценуTableAdapter.ClearBeforeFill = true;
            // 
            // названиеПродуктаDataGridViewTextBoxColumn
            // 
            this.названиеПродуктаDataGridViewTextBoxColumn.DataPropertyName = "название продукта";
            this.названиеПродуктаDataGridViewTextBoxColumn.HeaderText = "название продукта";
            this.названиеПродуктаDataGridViewTextBoxColumn.Name = "названиеПродуктаDataGridViewTextBoxColumn";
            // 
            // sumВыражение1DataGridViewTextBoxColumn
            // 
            this.sumВыражение1DataGridViewTextBoxColumn.DataPropertyName = "Sum-Выражение1";
            this.sumВыражение1DataGridViewTextBoxColumn.HeaderText = "Sum-Выражение1";
            this.sumВыражение1DataGridViewTextBoxColumn.Name = "sumВыражение1DataGridViewTextBoxColumn";
            // 
            // Z1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 325);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Z1";
            this.Text = "Z1";
            this.Load += new System.EventHandler(this.Z1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.базаДанныхDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.запрос1КолВоКупленногоЦенуBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private БазаДанныхDataSet базаДанныхDataSet;
        private System.Windows.Forms.BindingSource запрос1КолВоКупленногоЦенуBindingSource;
        private БазаДанныхDataSetTableAdapters.запрос_1___кол_во_купленного___ценуTableAdapter запрос_1___кол_во_купленного___ценуTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеПродуктаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumВыражение1DataGridViewTextBoxColumn;

    }
}