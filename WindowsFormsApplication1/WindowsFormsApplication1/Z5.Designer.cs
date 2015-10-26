namespace WindowsFormsApplication1
{
    partial class Z5
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
            this.запрос5TableAdapter1 = new WindowsFormsApplication1.БазаДанныхDataSetTableAdapters.Запрос5TableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.bindingSource1;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(284, 262);
            this.dataGridView2.TabIndex = 0;
            // 
            // базаДанныхDataSet
            // 
            this.базаДанныхDataSet.DataSetName = "БазаДанныхDataSet";
            this.базаДанныхDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Запрос5";
            this.bindingSource1.DataSource = this.базаДанныхDataSet;
            // 
            // запрос5TableAdapter1
            // 
            this.запрос5TableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Avg-Цена за 1 кг";
            this.dataGridViewTextBoxColumn1.HeaderText = "Avg-Цена за 1 кг";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Z5
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Z5";
            this.Load += new System.EventHandler(this.Z5_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.базаДанныхDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
       /// <summary>
       /// 
       /// </summary>
        private System.Windows.Forms.BindingSource запрос5BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgЦенаЗа1КгDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private БазаДанныхDataSet базаДанныхDataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private БазаДанныхDataSetTableAdapters.Запрос5TableAdapter запрос5TableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}