using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "базаДанныхDataSet.Утилизация". При необходимости она может быть перемещена или удалена.
            this.утилизацияTableAdapter.Fill(this.базаДанныхDataSet.Утилизация);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "базаДанныхDataSet.торговые_точки". При необходимости она может быть перемещена или удалена.
            this.торговые_точкиTableAdapter.Fill(this.базаДанныхDataSet.торговые_точки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "базаДанныхDataSet.Список_продукции". При необходимости она может быть перемещена или удалена.
            this.список_продукцииTableAdapter.Fill(this.базаДанныхDataSet.Список_продукции);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "базаДанныхDataSet.Список_праздников". При необходимости она может быть перемещена или удалена.
            this.список_праздниковTableAdapter.Fill(this.базаДанныхDataSet.Список_праздников);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "базаДанныхDataSet.реализация2". При необходимости она может быть перемещена или удалена.
            this.реализация2TableAdapter.Fill(this.базаДанныхDataSet.реализация2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "базаДанныхDataSet.реализация". При необходимости она может быть перемещена или удалена.
            this.реализацияTableAdapter.Fill(this.базаДанныхDataSet.реализация);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "базаДанныхDataSet.производство". При необходимости она может быть перемещена или удалена.
            this.производствоTableAdapter.Fill(this.базаДанныхDataSet.производство);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "базаДанныхDataSet.Продукция". При необходимости она может быть перемещена или удалена.
            this.продукцияTableAdapter.Fill(this.базаДанныхDataSet.Продукция);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "базаДанныхDataSet.заказы". При необходимости она может быть перемещена или удалена.
            this.заказыTableAdapter.Fill(this.базаДанныхDataSet.заказы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бДDataSet.Утилизация". При необходимости она может быть перемещена или удалена.
          //  this.утилизацияTableAdapter.Fill(this.бДDataSet.Утилизация);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бДDataSet.торговые_точки". При необходимости она может быть перемещена или удалена.
            //this.торговые_точкиTableAdapter.Fill(this.бДDataSet.торговые_точки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бДDataSet.реализация". При необходимости она может быть перемещена или удалена.
           // this.реализацияTableAdapter.Fill(this.бДDataSet.реализация);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бДDataSet.производство". При необходимости она может быть перемещена или удалена.
           // this.производствоTableAdapter.Fill(this.бДDataSet.производство);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бДDataSet.Продукция". При необходимости она может быть перемещена или удалена.
           // this.продукцияTableAdapter.Fill(this.бДDataSet.Продукция);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бДDataSet.заказы". При необходимости она может быть перемещена или удалена.
           // this.заказыTableAdapter.Fill(this.бДDataSet.заказы);

        }

        private void списокПродукцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.базаДанныхDataSet.Список_продукции; 
        }

        private void списокТорговыхТочекToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.базаДанныхDataSet.торговые_точки;
        }

        private void реализацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.бДDataSet.реализация.Columns[1].Expression = "торговые_точки.название";
            dataGridView1.DataSource = this.базаДанныхDataSet.реализация;      
        }

        private void производствоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.базаДанныхDataSet.производство;
        }

        private void утилизацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.базаДанныхDataSet.Утилизация;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
           // this.Hide();
            Z1 Z = new Z1();
            Z.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Z2 Z = new Z2();
            Z.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Zapr3 Z = new Zapr3();
            Z.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Z4 Z = new Z4();
            Z.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Z5 Z = new Z5();
            Z.Show();
        }

        private void сохранитьИзмененияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.заказыTableAdapter.Update(this.бДDataSet);//   .Update(this.lab1DataSet);
            this.продукцияTableAdapter.Update(this.базаДанныхDataSet);
            this.торговые_точкиTableAdapter.Update(this.базаДанныхDataSet);
            this.утилизацияTableAdapter.Update(this.базаДанныхDataSet);
            this.реализацияTableAdapter.Update(this.базаДанныхDataSet);
            this.производствоTableAdapter.Update(this.базаДанныхDataSet);

        }
    }
}
