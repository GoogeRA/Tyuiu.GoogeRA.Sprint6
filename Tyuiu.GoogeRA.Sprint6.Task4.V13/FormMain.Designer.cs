
namespace Tyuiu.GoogeRA.Sprint6.Task4.V13
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
            this.groupBoxTwo_GRA = new System.Windows.Forms.GroupBox();
            this.textBoxFree_GRA = new System.Windows.Forms.TextBox();
            this.textBoxTwo_GRA = new System.Windows.Forms.TextBox();
            this.textBoxStopVar_GRA = new System.Windows.Forms.TextBox();
            this.textBoxStartVar_GRA = new System.Windows.Forms.TextBox();
            this.buttonHelp_GRA = new System.Windows.Forms.Button();
            this.groupBoxOutput_GRA = new System.Windows.Forms.GroupBox();
            this.textBoxRes_GRA = new System.Windows.Forms.TextBox();
            this.ChartGraff_GRA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonStart_GRA = new System.Windows.Forms.Button();
            this.buttonSave_GRA = new System.Windows.Forms.Button();
            this.panelOne_GRA = new System.Windows.Forms.Panel();
            this.panelTwo_GRA = new System.Windows.Forms.Panel();
            this.panelFree_GRA = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxOne_GRA.SuspendLayout();
            this.groupBoxTwo_GRA.SuspendLayout();
            this.groupBoxOutput_GRA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartGraff_GRA)).BeginInit();
            this.panelOne_GRA.SuspendLayout();
            this.panelTwo_GRA.SuspendLayout();
            this.panelFree_GRA.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOne_GRA
            // 
            this.groupBoxOne_GRA.Controls.Add(this.textBoxOne_GRA);
            this.groupBoxOne_GRA.Location = new System.Drawing.Point(3, 11);
            this.groupBoxOne_GRA.Name = "groupBoxOne_GRA";
            this.groupBoxOne_GRA.Size = new System.Drawing.Size(483, 79);
            this.groupBoxOne_GRA.TabIndex = 0;
            this.groupBoxOne_GRA.TabStop = false;
            this.groupBoxOne_GRA.Text = "Условие";
            this.groupBoxOne_GRA.Enter += new System.EventHandler(this.groupBoxOne_GRA_Enter);
            // 
            // textBoxOne_GRA
            // 
            this.textBoxOne_GRA.Location = new System.Drawing.Point(7, 14);
            this.textBoxOne_GRA.Multiline = true;
            this.textBoxOne_GRA.Name = "textBoxOne_GRA";
            this.textBoxOne_GRA.ReadOnly = true;
            this.textBoxOne_GRA.Size = new System.Drawing.Size(470, 59);
            this.textBoxOne_GRA.TabIndex = 0;
            this.textBoxOne_GRA.Text = resources.GetString("textBoxOne_GRA.Text");
            // 
            // groupBoxTwo_GRA
            // 
            this.groupBoxTwo_GRA.Controls.Add(this.textBoxFree_GRA);
            this.groupBoxTwo_GRA.Controls.Add(this.textBoxTwo_GRA);
            this.groupBoxTwo_GRA.Controls.Add(this.textBoxStopVar_GRA);
            this.groupBoxTwo_GRA.Controls.Add(this.textBoxStartVar_GRA);
            this.groupBoxTwo_GRA.Location = new System.Drawing.Point(492, 11);
            this.groupBoxTwo_GRA.Name = "groupBoxTwo_GRA";
            this.groupBoxTwo_GRA.Size = new System.Drawing.Size(213, 79);
            this.groupBoxTwo_GRA.TabIndex = 1;
            this.groupBoxTwo_GRA.TabStop = false;
            this.groupBoxTwo_GRA.Text = "Ввод данных";
            // 
            // textBoxFree_GRA
            // 
            this.textBoxFree_GRA.Location = new System.Drawing.Point(117, 14);
            this.textBoxFree_GRA.Name = "textBoxFree_GRA";
            this.textBoxFree_GRA.ReadOnly = true;
            this.textBoxFree_GRA.Size = new System.Drawing.Size(87, 20);
            this.textBoxFree_GRA.TabIndex = 3;
            this.textBoxFree_GRA.Text = "Конец шага:";
            // 
            // textBoxTwo_GRA
            // 
            this.textBoxTwo_GRA.Location = new System.Drawing.Point(7, 14);
            this.textBoxTwo_GRA.Name = "textBoxTwo_GRA";
            this.textBoxTwo_GRA.ReadOnly = true;
            this.textBoxTwo_GRA.Size = new System.Drawing.Size(90, 20);
            this.textBoxTwo_GRA.TabIndex = 2;
            this.textBoxTwo_GRA.Text = "Старт шага:";
            // 
            // textBoxStopVar_GRA
            // 
            this.textBoxStopVar_GRA.Location = new System.Drawing.Point(117, 40);
            this.textBoxStopVar_GRA.Name = "textBoxStopVar_GRA";
            this.textBoxStopVar_GRA.Size = new System.Drawing.Size(87, 20);
            this.textBoxStopVar_GRA.TabIndex = 1;
            // 
            // textBoxStartVar_GRA
            // 
            this.textBoxStartVar_GRA.Location = new System.Drawing.Point(7, 40);
            this.textBoxStartVar_GRA.Name = "textBoxStartVar_GRA";
            this.textBoxStartVar_GRA.Size = new System.Drawing.Size(90, 20);
            this.textBoxStartVar_GRA.TabIndex = 0;
            this.textBoxStartVar_GRA.TextChanged += new System.EventHandler(this.textBoxStartVar_GRA_TextChanged);
            // 
            // buttonHelp_GRA
            // 
            this.buttonHelp_GRA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_GRA.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonHelp_GRA.Location = new System.Drawing.Point(975, 21);
            this.buttonHelp_GRA.Name = "buttonHelp_GRA";
            this.buttonHelp_GRA.Size = new System.Drawing.Size(86, 59);
            this.buttonHelp_GRA.TabIndex = 4;
            this.buttonHelp_GRA.Text = "Справка";
            this.buttonHelp_GRA.UseVisualStyleBackColor = false;
            this.buttonHelp_GRA.Click += new System.EventHandler(this.buttonHelp_GRA_Click);
            // 
            // groupBoxOutput_GRA
            // 
            this.groupBoxOutput_GRA.Controls.Add(this.textBoxRes_GRA);
            this.groupBoxOutput_GRA.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxOutput_GRA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutput_GRA.Name = "groupBoxOutput_GRA";
            this.groupBoxOutput_GRA.Size = new System.Drawing.Size(263, 433);
            this.groupBoxOutput_GRA.TabIndex = 5;
            this.groupBoxOutput_GRA.TabStop = false;
            this.groupBoxOutput_GRA.Text = "Вывод:";
            this.groupBoxOutput_GRA.Enter += new System.EventHandler(this.groupBoxOutput_GRA_Enter);
            // 
            // textBoxRes_GRA
            // 
            this.textBoxRes_GRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRes_GRA.Location = new System.Drawing.Point(3, 16);
            this.textBoxRes_GRA.Multiline = true;
            this.textBoxRes_GRA.Name = "textBoxRes_GRA";
            this.textBoxRes_GRA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRes_GRA.Size = new System.Drawing.Size(257, 414);
            this.textBoxRes_GRA.TabIndex = 0;
            this.textBoxRes_GRA.TextChanged += new System.EventHandler(this.textBoxRes_GRA_TextChanged);
            // 
            // ChartGraff_GRA
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartGraff_GRA.ChartAreas.Add(chartArea1);
            this.ChartGraff_GRA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.ChartGraff_GRA.Legends.Add(legend1);
            this.ChartGraff_GRA.Location = new System.Drawing.Point(3, 16);
            this.ChartGraff_GRA.Name = "ChartGraff_GRA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.LabelForeColor = System.Drawing.Color.Maroon;
            series1.Legend = "Legend1";
            series1.Name = "F(x)";
            this.ChartGraff_GRA.Series.Add(series1);
            this.ChartGraff_GRA.Size = new System.Drawing.Size(803, 420);
            this.ChartGraff_GRA.TabIndex = 6;
            this.ChartGraff_GRA.Text = "График функции  f(x)";
            this.ChartGraff_GRA.Click += new System.EventHandler(this.ChartGraff_GRA_Click);
            // 
            // buttonStart_GRA
            // 
            this.buttonStart_GRA.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonStart_GRA.Location = new System.Drawing.Point(723, 19);
            this.buttonStart_GRA.Name = "buttonStart_GRA";
            this.buttonStart_GRA.Size = new System.Drawing.Size(75, 63);
            this.buttonStart_GRA.TabIndex = 7;
            this.buttonStart_GRA.Text = "Выполнить";
            this.buttonStart_GRA.UseVisualStyleBackColor = false;
            this.buttonStart_GRA.Click += new System.EventHandler(this.buttonStart_GRA_Click);
            // 
            // buttonSave_GRA
            // 
            this.buttonSave_GRA.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSave_GRA.Location = new System.Drawing.Point(814, 19);
            this.buttonSave_GRA.Name = "buttonSave_GRA";
            this.buttonSave_GRA.Size = new System.Drawing.Size(70, 63);
            this.buttonSave_GRA.TabIndex = 8;
            this.buttonSave_GRA.Text = "Сохранить";
            this.buttonSave_GRA.UseVisualStyleBackColor = false;
            this.buttonSave_GRA.Click += new System.EventHandler(this.buttonSave_GRA_Click);
            // 
            // panelOne_GRA
            // 
            this.panelOne_GRA.Controls.Add(this.groupBoxOutput_GRA);
            this.panelOne_GRA.Location = new System.Drawing.Point(3, 99);
            this.panelOne_GRA.Name = "panelOne_GRA";
            this.panelOne_GRA.Size = new System.Drawing.Size(266, 433);
            this.panelOne_GRA.TabIndex = 9;
            // 
            // panelTwo_GRA
            // 
            this.panelTwo_GRA.Controls.Add(this.groupBoxOne_GRA);
            this.panelTwo_GRA.Controls.Add(this.groupBoxTwo_GRA);
            this.panelTwo_GRA.Controls.Add(this.buttonSave_GRA);
            this.panelTwo_GRA.Controls.Add(this.buttonHelp_GRA);
            this.panelTwo_GRA.Controls.Add(this.buttonStart_GRA);
            this.panelTwo_GRA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTwo_GRA.Location = new System.Drawing.Point(0, 0);
            this.panelTwo_GRA.Name = "panelTwo_GRA";
            this.panelTwo_GRA.Size = new System.Drawing.Size(1084, 93);
            this.panelTwo_GRA.TabIndex = 10;
            // 
            // panelFree_GRA
            // 
            this.panelFree_GRA.Controls.Add(this.groupBox1);
            this.panelFree_GRA.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelFree_GRA.Location = new System.Drawing.Point(275, 93);
            this.panelFree_GRA.Name = "panelFree_GRA";
            this.panelFree_GRA.Size = new System.Drawing.Size(809, 439);
            this.panelFree_GRA.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChartGraff_GRA);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(809, 439);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 532);
            this.Controls.Add(this.panelFree_GRA);
            this.Controls.Add(this.panelOne_GRA);
            this.Controls.Add(this.panelTwo_GRA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 13 | Гооге Р. А. ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxOne_GRA.ResumeLayout(false);
            this.groupBoxOne_GRA.PerformLayout();
            this.groupBoxTwo_GRA.ResumeLayout(false);
            this.groupBoxTwo_GRA.PerformLayout();
            this.groupBoxOutput_GRA.ResumeLayout(false);
            this.groupBoxOutput_GRA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartGraff_GRA)).EndInit();
            this.panelOne_GRA.ResumeLayout(false);
            this.panelTwo_GRA.ResumeLayout(false);
            this.panelFree_GRA.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOne_GRA;
        private System.Windows.Forms.GroupBox groupBoxTwo_GRA;
        private System.Windows.Forms.Button buttonHelp_GRA;
        private System.Windows.Forms.TextBox textBoxOne_GRA;
        private System.Windows.Forms.TextBox textBoxFree_GRA;
        private System.Windows.Forms.TextBox textBoxTwo_GRA;
        private System.Windows.Forms.TextBox textBoxStopVar_GRA;
        private System.Windows.Forms.TextBox textBoxStartVar_GRA;
        private System.Windows.Forms.GroupBox groupBoxOutput_GRA;
        private System.Windows.Forms.TextBox textBoxRes_GRA;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartGraff_GRA;
        private System.Windows.Forms.Button buttonStart_GRA;
        private System.Windows.Forms.Button buttonSave_GRA;
        private System.Windows.Forms.Panel panelOne_GRA;
        private System.Windows.Forms.Panel panelTwo_GRA;
        private System.Windows.Forms.Panel panelFree_GRA;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

