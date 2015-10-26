namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПродукцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокТорговыхТочекToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.реализацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.производствоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.утилизацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьИзмененияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.базаДанныхDataSet = new WindowsFormsApplication1.БазаДанныхDataSet();
            this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказыTableAdapter = new WindowsFormsApplication1.БазаДанныхDataSetTableAdapters.заказыTableAdapter();
            this.продукцияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.продукцияTableAdapter = new WindowsFormsApplication1.БазаДанныхDataSetTableAdapters.ПродукцияTableAdapter();
            this.производствоBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.производствоTableAdapter = new WindowsFormsApplication1.БазаДанныхDataSetTableAdapters.производствоTableAdapter();
            this.реализацияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.реализацияTableAdapter = new WindowsFormsApplication1.БазаДанныхDataSetTableAdapters.реализацияTableAdapter();
            this.реализация2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.реализация2TableAdapter = new WindowsFormsApplication1.БазаДанныхDataSetTableAdapters.реализация2TableAdapter();
            this.списокПраздниковBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.список_праздниковTableAdapter = new WindowsFormsApplication1.БазаДанныхDataSetTableAdapters.Список_праздниковTableAdapter();
            this.списокПродукцииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.список_продукцииTableAdapter = new WindowsFormsApplication1.БазаДанныхDataSetTableAdapters.Список_продукцииTableAdapter();
            this.торговыеТочкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.торговые_точкиTableAdapter = new WindowsFormsApplication1.БазаДанныхDataSetTableAdapters.торговые_точкиTableAdapter();
            this.утилизацияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.утилизацияTableAdapter = new WindowsFormsApplication1.БазаДанныхDataSetTableAdapters.УтилизацияTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.базаДанныхDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продукцияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.производствоBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.реализацияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.реализация2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокПраздниковBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокПродукцииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.торговыеТочкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.утилизацияBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(679, 283);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.VirtualMode = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запросыToolStripMenuItem,
            this.таблицыToolStripMenuItem,
            this.сохранитьИзмененияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(691, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.запросыToolStripMenuItem.Text = "Запросы";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(340, 22);
            this.toolStripMenuItem2.Text = "Прибыльность продукции";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(340, 22);
            this.toolStripMenuItem3.Text = "Количество заказов на торговую точку за месяц";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(340, 22);
            this.toolStripMenuItem4.Text = "Производительность цеха";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(340, 22);
            this.toolStripMenuItem5.Text = "Процент утилизированной продукции";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(340, 22);
            this.toolStripMenuItem6.Text = "Средняя цена за 1 кг продукции";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокПродукцииToolStripMenuItem,
            this.списокТорговыхТочекToolStripMenuItem,
            this.реализацияToolStripMenuItem,
            this.производствоToolStripMenuItem,
            this.утилизацияToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.таблицыToolStripMenuItem.Text = "Данные";
            // 
            // списокПродукцииToolStripMenuItem
            // 
            this.списокПродукцииToolStripMenuItem.Name = "списокПродукцииToolStripMenuItem";
            this.списокПродукцииToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.списокПродукцииToolStripMenuItem.Text = "Список Продукции";
            this.списокПродукцииToolStripMenuItem.Click += new System.EventHandler(this.списокПродукцииToolStripMenuItem_Click);
            // 
            // списокТорговыхТочекToolStripMenuItem
            // 
            this.списокТорговыхТочекToolStripMenuItem.Name = "списокТорговыхТочекToolStripMenuItem";
            this.списокТорговыхТочекToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.списокТорговыхТочекToolStripMenuItem.Text = "Список торговых точек";
            this.списокТорговыхТочекToolStripMenuItem.Click += new System.EventHandler(this.списокТорговыхТочекToolStripMenuItem_Click);
            // 
            // реализацияToolStripMenuItem
            // 
            this.реализацияToolStripMenuItem.Name = "реализацияToolStripMenuItem";
            this.реализацияToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.реализацияToolStripMenuItem.Text = "Реализация продукции";
            this.реализацияToolStripMenuItem.Click += new System.EventHandler(this.реализацияToolStripMenuItem_Click);
            // 
            // производствоToolStripMenuItem
            // 
            this.производствоToolStripMenuItem.Name = "производствоToolStripMenuItem";
            this.производствоToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.производствоToolStripMenuItem.Text = "Производство продукции";
            this.производствоToolStripMenuItem.Click += new System.EventHandler(this.производствоToolStripMenuItem_Click);
            // 
            // утилизацияToolStripMenuItem
            // 
            this.утилизацияToolStripMenuItem.Name = "утилизацияToolStripMenuItem";
            this.утилизацияToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.утилизацияToolStripMenuItem.Text = "Утилизация продукции";
            this.утилизацияToolStripMenuItem.Click += new System.EventHandler(this.утилизацияToolStripMenuItem_Click);
            // 
            // сохранитьИзмененияToolStripMenuItem
            // 
            this.сохранитьИзмененияToolStripMenuItem.Name = "сохранитьИзмененияToolStripMenuItem";
            this.сохранитьИзмененияToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.сохранитьИзмененияToolStripMenuItem.Text = "Сохранить изменения";
            this.сохранитьИзмененияToolStripMenuItem.Click += new System.EventHandler(this.сохранитьИзмененияToolStripMenuItem_Click);
            // 
            // базаДанныхDataSet
            // 
            this.базаДанныхDataSet.DataSetName = "БазаДанныхDataSet";
            this.базаДанныхDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказыBindingSource
            // 
            this.заказыBindingSource.DataMember = "заказы";
            this.заказыBindingSource.DataSource = this.базаДанныхDataSet;
            // 
            // заказыTableAdapter
            // 
            this.заказыTableAdapter.ClearBeforeFill = true;
            // 
            // продукцияBindingSource
            // 
            this.продукцияBindingSource.DataMember = "Продукция";
            this.продукцияBindingSource.DataSource = this.базаДанныхDataSet;
            // 
            // продукцияTableAdapter
            // 
            this.продукцияTableAdapter.ClearBeforeFill = true;
            // 
            // производствоBindingSource
            // 
            this.производствоBindingSource.DataMember = "производство";
            this.производствоBindingSource.DataSource = this.базаДанныхDataSet;
            // 
            // производствоTableAdapter
            // 
            this.производствоTableAdapter.ClearBeforeFill = true;
            // 
            // реализацияBindingSource
            // 
            this.реализацияBindingSource.DataMember = "реализация";
            this.реализацияBindingSource.DataSource = this.базаДанныхDataSet;
            // 
            // реализацияTableAdapter
            // 
            this.реализацияTableAdapter.ClearBeforeFill = true;
            // 
            // реализация2BindingSource
            // 
            this.реализация2BindingSource.DataMember = "реализация2";
            this.реализация2BindingSource.DataSource = this.базаДанныхDataSet;
            // 
            // реализация2TableAdapter
            // 
            this.реализация2TableAdapter.ClearBeforeFill = true;
            // 
            // списокПраздниковBindingSource
            // 
            this.списокПраздниковBindingSource.DataMember = "Список праздников";
            this.списокПраздниковBindingSource.DataSource = this.базаДанныхDataSet;
            // 
            // список_праздниковTableAdapter
            // 
            this.список_праздниковTableAdapter.ClearBeforeFill = true;
            // 
            // списокПродукцииBindingSource
            // 
            this.списокПродукцииBindingSource.DataMember = "Список продукции";
            this.списокПродукцииBindingSource.DataSource = this.базаДанныхDataSet;
            // 
            // список_продукцииTableAdapter
            // 
            this.список_продукцииTableAdapter.ClearBeforeFill = true;
            // 
            // торговыеТочкиBindingSource
            // 
            this.торговыеТочкиBindingSource.DataMember = "торговые точки";
            this.торговыеТочкиBindingSource.DataSource = this.базаДанныхDataSet;
            // 
            // торговые_точкиTableAdapter
            // 
            this.торговые_точкиTableAdapter.ClearBeforeFill = true;
            // 
            // утилизацияBindingSource
            // 
            this.утилизацияBindingSource.DataMember = "Утилизация";
            this.утилизацияBindingSource.DataSource = this.базаДанныхDataSet;
            // 
            // утилизацияTableAdapter
            // 
            this.утилизацияTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 309);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.базаДанныхDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продукцияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.производствоBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.реализацияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.реализация2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокПраздниковBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокПродукцииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.торговыеТочкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.утилизацияBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокПродукцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокТорговыхТочекToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem реализацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem производствоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem утилизацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьИзмененияToolStripMenuItem;
        private БазаДанныхDataSet базаДанныхDataSet;
        private System.Windows.Forms.BindingSource заказыBindingSource;
        private БазаДанныхDataSetTableAdapters.заказыTableAdapter заказыTableAdapter;
        private System.Windows.Forms.BindingSource продукцияBindingSource;
        private БазаДанныхDataSetTableAdapters.ПродукцияTableAdapter продукцияTableAdapter;
        private System.Windows.Forms.BindingSource производствоBindingSource;
        private БазаДанныхDataSetTableAdapters.производствоTableAdapter производствоTableAdapter;
        private System.Windows.Forms.BindingSource реализацияBindingSource;
        private БазаДанныхDataSetTableAdapters.реализацияTableAdapter реализацияTableAdapter;
        private System.Windows.Forms.BindingSource реализация2BindingSource;
        private БазаДанныхDataSetTableAdapters.реализация2TableAdapter реализация2TableAdapter;
        private System.Windows.Forms.BindingSource списокПраздниковBindingSource;
        private БазаДанныхDataSetTableAdapters.Список_праздниковTableAdapter список_праздниковTableAdapter;
        private System.Windows.Forms.BindingSource списокПродукцииBindingSource;
        private БазаДанныхDataSetTableAdapters.Список_продукцииTableAdapter список_продукцииTableAdapter;
        private System.Windows.Forms.BindingSource торговыеТочкиBindingSource;
        private БазаДанныхDataSetTableAdapters.торговые_точкиTableAdapter торговые_точкиTableAdapter;
        private System.Windows.Forms.BindingSource утилизацияBindingSource;
        private БазаДанныхDataSetTableAdapters.УтилизацияTableAdapter утилизацияTableAdapter;
    }
}

