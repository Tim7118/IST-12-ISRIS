namespace WindowsFormsApplication1
{
    partial class Z3
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.базаДанныхDataSet = new WindowsFormsApplication1.БазаДанныхDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.запрос3TableAdapter1 = new WindowsFormsApplication1.БазаДанныхDataSetTableAdapters.Запрос3TableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.базаДанныхDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView2.DataSource = this.bindingSource1;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(315, 334);
            this.dataGridView2.TabIndex = 0;
            // 
            // базаДанныхDataSet
            // 
            this.базаДанныхDataSet.DataSetName = "БазаДанныхDataSet";
            this.базаДанныхDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Запрос3";
            this.bindingSource1.DataSource = this.базаДанныхDataSet;
            // 
            // запрос3TableAdapter1
            // 
            this.запрос3TableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "название продукции";
            this.dataGridViewTextBoxColumn1.HeaderText = "название продукции";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "кг в сутки";
            this.dataGridViewTextBoxColumn2.HeaderText = "кг в сутки";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Z3
            // 
            this.ClientSize = new System.Drawing.Size(315, 334);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Z3";
            this.Load += new System.EventHandler(this.Z3_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.базаДанныхDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource запрос3BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеПродукцииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоПродуктаВПартииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn выражение1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кгВСуткиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private БазаДанныхDataSet базаДанныхDataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private БазаДанныхDataSetTableAdapters.Запрос3TableAdapter запрос3TableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}