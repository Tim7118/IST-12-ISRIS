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
    public partial class Zapr3 : Form
    {
        public Zapr3()
        {
            InitializeComponent();
        }


        private void Z3_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "базаДанныхDataSet.Запрос3". При необходимости она может быть перемещена или удалена.
            this.запрос3TableAdapter1.Fill(this.базаДанныхDataSet.Запрос3);

        }
    }
}
