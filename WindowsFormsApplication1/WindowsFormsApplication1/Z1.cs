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
    public partial class Z1 : Form
    {
        public Z1()
        {
            InitializeComponent();
        }

        private void Z1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "базаДанныхDataSet._запрос_1___кол_во_купленного___цену". При необходимости она может быть перемещена или удалена.
            this.запрос_1___кол_во_купленного___ценуTableAdapter.Fill(this.базаДанныхDataSet._запрос_1___кол_во_купленного___цену);
        }
    }
}
