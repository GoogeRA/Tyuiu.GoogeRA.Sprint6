using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GoogeRA.Sprint6.Task5.V15.Lib;

namespace Tyuiu.GoogeRA.Sprint6.Task5.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutFileTask5V15.txt";

        private void dataGridViewRes_GRA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonOpenF_GRA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonStart_GRA_Click(object sender, EventArgs e)
        {
            dataGridViewRes_GRA.ColumnCount = 2;
            dataGridViewRes_GRA.Columns[0].Width = 20;
            dataGridViewRes_GRA.Columns[1].Width = 50;

            this.chartRes_GRA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartRes_GRA.ChartAreas[0].AxisY.Title = "Ось Y";

            chartRes_GRA.Series[0].Points.Clear();

            double [] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numsMass.Length; i++ )
            {
                dataGridViewRes_GRA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartRes_GRA.Series[0].Points.AddXY(i, numsMass[i]);
            }


        }

        private void chartRes_GRA_Click(object sender, EventArgs e)
        {

        }

        private void buttonHelp_GRA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ПКТб-23-1 Гооге Роберт Александрович ", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
