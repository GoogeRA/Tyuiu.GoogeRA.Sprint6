using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GoogeRA.Sprint6.Task1.V29.Lib;

namespace Tyuiu.GoogeRA.Sprint6.Task1.V29
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

       
        private void buttonStart_GRA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStarVar_GRA.Text);
                int stopStep = Convert.ToInt32(textBoxStopVar_GRA.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                textBoxRes_GRA.Text = "";
                textBoxRes_GRA.AppendText(" +---------+----------+ " + Environment.NewLine);
                textBoxRes_GRA.AppendText(" |     x   |  f(x)    | " + Environment.NewLine);
                textBoxRes_GRA.AppendText(" +---------+----------+ " + Environment.NewLine);

                for(int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format(" | {0,5:d}   |  {1, 5:f2}   |", startStep, valueArray[i]);
                    textBoxRes_GRA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxRes_GRA.AppendText(" +---------+----------+  " + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show(" Введены неверные данные ", " Ошибка ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxConditions_GRA_Enter(object sender, EventArgs e)
        {

        }

        private void buttonHelp_GRA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ПКТб-23-1 Гооге Роберт Александрович ", "Сообщение");
        }

        private void textBoxStarVar_GRA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStopVar_GRA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRes_GRA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
