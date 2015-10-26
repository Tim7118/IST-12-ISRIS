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
    public partial class Z2 : Form
    {
        public Z2()
        {
            InitializeComponent();
        }


        private void Z2_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "базаДанныхDataSet.Запрос2". При необходимости она может быть перемещена или удалена.
            this.запрос2TableAdapter1.Fill(this.базаДанныхDataSet.Запрос2);

        }
    }
}
