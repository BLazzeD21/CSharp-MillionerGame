using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Millioner
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        
        

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программу разработал Секерин Александр, группа k0505\r\n" + "Версия программы 1.0\r\n" + "Дата релиза : 28.04.2019", "Информация об авторе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();//Закрытие формы 3
        }
    }
}
