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
    public partial class Z4 : Form
    {
        public Z4()
        {
            InitializeComponent();
        }

      

        private void Z4_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "базаДанныхDataSet.Запрос4". При необходимости она может быть перемещена или удалена.
            this.запрос4TableAdapter1.Fill(this.базаДанныхDataSet.Запрос4);

        }
    }
}
