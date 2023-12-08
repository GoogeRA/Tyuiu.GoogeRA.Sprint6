
namespace Tyuiu.GoogeRA.Sprint6.Task5.V15
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxOne_GRA = new System.Windows.Forms.GroupBox();
            this.textBoxOne_GRA = new System.Windows.Forms.TextBox();
            this.buttonOpenF_GRA = new System.Windows.Forms.Button();
            this.buttonHelp_GRA = new System.Windows.Forms.Button();
            this.dataGridViewRes_GRA = new System.Windows.Forms.DataGridView();
            this.groupBoxTwo_GRA = new System.Windows.Forms.GroupBox();
            this.panelOneChart_GRA = new System.Windows.Forms.Panel();
            this.chartRes_GRA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonStart_GRA = new System.Windows.Forms.Button();
            this.groupBoxOne_GRA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_GRA)).BeginInit();
            this.groupBoxTwo_GRA.SuspendLayout();
            this.panelOneChart_GRA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRes_GRA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOne_GRA
            // 
            this.groupBoxOne_GRA.Controls.Add(this.textBoxOne_GRA);
            this.groupBoxOne_GRA.Location = new System.Drawing.Point(6, 5);
            this.groupBoxOne_GRA.Name = "groupBoxOne_GRA";
            this.groupBoxOne_GRA.Size = new System.Drawing.Size(553, 90);
            this.groupBoxOne_GRA.TabIndex = 0;
            this.groupBoxOne_GRA.TabStop = false;
            this.groupBoxOne_GRA.Text = "Условие";
            // 
            // textBoxOne_GRA
            // 
            this.textBoxOne_GRA.Location = new System.Drawing.Point(7, 18);
            this.textBoxOne_GRA.Multiline = true;
            this.textBoxOne_GRA.Name = "textBoxOne_GRA";
            this.textBoxOne_GRA.ReadOnly = true;
            this.textBoxOne_GRA.Size = new System.Drawing.Size(534, 66);
            this.textBoxOne_GRA.TabIndex = 0;
            this.textBoxOne_GRA.Text = resources.GetString("textBoxOne_GRA.Text");
            // 
            // buttonOpenF_GRA
            // 
            this.buttonOpenF_GRA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonOpenF_GRA.Location = new System.Drawing.Point(648, 23);
            this.buttonOpenF_GRA.Name = "buttonOpenF_GRA";
            this.buttonOpenF_GRA.Size = new System.Drawing.Size(65, 72);
            this.buttonOpenF_GRA.TabIndex = 2;
            this.buttonOpenF_GRA.Text = "Открыть файл";
            this.buttonOpenF_GRA.UseVisualStyleBackColor = false;
            this.buttonOpenF_GRA.Click += new System.EventHandler(this.buttonOpenF_GRA_Click);
            // 
            // buttonHelp_GRA
            // 
            this.buttonHelp_GRA.BackColor = System.Drawing.Color.HotPink;
            this.buttonHelp_GRA.Location = new System.Drawing.Point(719, 23);
            this.buttonHelp_GRA.Name = "buttonHelp_GRA";
            this.buttonHelp_GRA.Size = new System.Drawing.Size(69, 72);
            this.buttonHelp_GRA.TabIndex = 3;
            this.buttonHelp_GRA.Text = "Справка";
            this.buttonHelp_GRA.UseVisualStyleBackColor = false;
            this.buttonHelp_GRA.Click += new System.EventHandler(this.buttonHelp_GRA_Click);
            // 
            // dataGridViewRes_GRA
            // 
            this.dataGridViewRes_GRA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRes_GRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRes_GRA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewRes_GRA.Name = "dataGridViewRes_GRA";
            this.dataGridViewRes_GRA.Size = new System.Drawing.Size(194, 317);
            this.dataGridViewRes_GRA.TabIndex = 2;
            this.dataGridViewRes_GRA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRes_GRA_CellContentClick);
            // 
            // groupBoxTwo_GRA
            // 
            this.groupBoxTwo_GRA.Controls.Add(this.dataGridViewRes_GRA);
            this.groupBoxTwo_GRA.Location = new System.Drawing.Point(13, 102);
            this.groupBoxTwo_GRA.Name = "groupBoxTwo_GRA";
            this.groupBoxTwo_GRA.Size = new System.Drawing.Size(200, 336);
            this.groupBoxTwo_GRA.TabIndex = 5;
            this.groupBoxTwo_GRA.TabStop = false;
            this.groupBoxTwo_GRA.Text = "Вывод данных";
            // 
            // panelOneChart_GRA
            // 
            this.panelOneChart_GRA.Controls.Add(this.chartRes_GRA);
            this.panelOneChart_GRA.Location = new System.Drawing.Point(219, 102);
            this.panelOneChart_GRA.Name = "panelOneChart_GRA";
            this.panelOneChart_GRA.Size = new System.Drawing.Size(569, 346);
            this.panelOneChart_GRA.TabIndex = 6;
            // 
            // chartRes_GRA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRes_GRA.ChartAreas.Add(chartArea1);
            this.chartRes_GRA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartRes_GRA.Legends.Add(legend1);
            this.chartRes_GRA.Location = new System.Drawing.Point(0, 0);
            this.chartRes_GRA.Name = "chartRes_GRA";
            this.chartRes_GRA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartRes_GRA.Series.Add(series1);
            this.chartRes_GRA.Size = new System.Drawing.Size(569, 346);
            this.chartRes_GRA.TabIndex = 0;
            this.chartRes_GRA.Text = "chart1";
            this.chartRes_GRA.Click += new System.EventHandler(this.chartRes_GRA_Click);
            // 
            // buttonStart_GRA
            // 
            this.buttonStart_GRA.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonStart_GRA.Location = new System.Drawing.Point(566, 23);
            this.buttonStart_GRA.Name = "buttonStart_GRA";
            this.buttonStart_GRA.Size = new System.Drawing.Size(75, 66);
            this.buttonStart_GRA.TabIndex = 7;
            this.buttonStart_GRA.Text = "Выполнить";
            this.buttonStart_GRA.UseVisualStyleBackColor = false;
            this.buttonStart_GRA.Click += new System.EventHandler(this.buttonStart_GRA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 454);
            this.Controls.Add(this.buttonStart_GRA);
            this.Controls.Add(this.panelOneChart_GRA);
            this.Controls.Add(this.groupBoxTwo_GRA);
            this.Controls.Add(this.buttonHelp_GRA);
            this.Controls.Add(this.buttonOpenF_GRA);
            this.Controls.Add(this.groupBoxOne_GRA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "| Спринт 6 | Таск 5 | Вариант 15| Гооге Р. А. ";
            this.groupBoxOne_GRA.ResumeLayout(false);
            this.groupBoxOne_GRA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_GRA)).EndInit();
            this.groupBoxTwo_GRA.ResumeLayout(false);
            this.panelOneChart_GRA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRes_GRA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOne_GRA;
        private System.Windows.Forms.Button buttonOpenF_GRA;
        private System.Windows.Forms.Button buttonHelp_GRA;
        private System.Windows.Forms.DataGridView dataGridViewRes_GRA;
        private System.Windows.Forms.GroupBox groupBoxTwo_GRA;
        private System.Windows.Forms.TextBox textBoxOne_GRA;
        private System.Windows.Forms.Panel panelOneChart_GRA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRes_GRA;
        private System.Windows.Forms.Button buttonStart_GRA;
    }
}

