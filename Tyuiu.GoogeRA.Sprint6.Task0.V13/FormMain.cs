using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.GoogeRA.Sprint6.Task0.V13.Lib;

    

namespace Tyuiu.GoogeRA.Sprint6.Task0.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOne_GRA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_GRA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxOne_GRA_VarX.Text)));
            }
            catch
            {
                MessageBox.Show("Ввдены неверные данные","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ПКТб-23-1 Гооге Роберт Александрович", "Сообщение");
        }

       
        private void textBoxTwo_GRA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxOne_GRA_VarX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >=58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}
