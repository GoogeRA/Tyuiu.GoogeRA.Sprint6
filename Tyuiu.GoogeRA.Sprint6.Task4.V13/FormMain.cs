using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.GoogeRA.Sprint6.Task4.V13.Lib;

namespace Tyuiu.GoogeRA.Sprint6.Task4.V13
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxOne_GRA_Enter(object sender, EventArgs e)
        {

        }

       

        private void buttonHelp_GRA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ПКТб-23-1 Гооге Роберт Александрович ", "Сообщение");
        }

        private void textBoxRes_GRA_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonStart_GRA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartVar_GRA.Text);
                int stopStep = Convert.ToInt32(textBoxStopVar_GRA.Text);

                

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.ChartGraff_GRA.Titles.Add(" График функиции F(X) ");
                this.ChartGraff_GRA.ChartAreas[0].AxisX.Title = " Ось X ";
                this.ChartGraff_GRA.ChartAreas[0].AxisY.Title = " Ось Y ";

                textBoxRes_GRA.Text = "";
                ChartGraff_GRA.Series[0].Points.Clear();


                for (int i = 0; i <= len - 1; i++)
                {

                    this.ChartGraff_GRA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxRes_GRA.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;


                }

            }
            catch
            {
                MessageBox.Show(" Введены неверные данные ", " Ошибка ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_GRA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V13.txt";
                File.WriteAllText(path, textBoxRes_GRA.Text);
                DialogResult dialogResult = MessageBox.Show("Файл" + path + "сохранен успешно!\n Открыть его блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void textBoxStartVar_GRA_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChartGraff_GRA_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxOutput_GRA_Enter(object sender, EventArgs e)
        {

        }
    }
}
