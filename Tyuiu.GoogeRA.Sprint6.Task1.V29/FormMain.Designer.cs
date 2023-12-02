
namespace Tyuiu.GoogeRA.Sprint6.Task1.V29
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
            this.groupBoxConditions_GRA = new System.Windows.Forms.GroupBox();
            this.textBoxOne_GRA = new System.Windows.Forms.TextBox();
            this.groupBoxInput_GRA = new System.Windows.Forms.GroupBox();
            this.textBoxFree_GRA = new System.Windows.Forms.TextBox();
            this.textBoxTwo_GRA = new System.Windows.Forms.TextBox();
            this.textBoxStopVar_GRA = new System.Windows.Forms.TextBox();
            this.textBoxStarVar_GRA = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_GRA = new System.Windows.Forms.GroupBox();
            this.textBoxRes_GRA = new System.Windows.Forms.TextBox();
            this.textBoxFour_GRA = new System.Windows.Forms.TextBox();
            this.buttonHelp_GRA = new System.Windows.Forms.Button();
            this.buttonStart_GRA = new System.Windows.Forms.Button();
            this.groupBoxConditions_GRA.SuspendLayout();
            this.groupBoxInput_GRA.SuspendLayout();
            this.groupBoxOutput_GRA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxConditions_GRA
            // 
            this.groupBoxConditions_GRA.Controls.Add(this.textBoxOne_GRA);
            this.groupBoxConditions_GRA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxConditions_GRA.Name = "groupBoxConditions_GRA";
            this.groupBoxConditions_GRA.Size = new System.Drawing.Size(536, 320);
            this.groupBoxConditions_GRA.TabIndex = 0;
            this.groupBoxConditions_GRA.TabStop = false;
            this.groupBoxConditions_GRA.Text = "Условия";
            this.groupBoxConditions_GRA.Enter += new System.EventHandler(this.groupBoxConditions_GRA_Enter);
            // 
            // textBoxOne_GRA
            // 
            this.textBoxOne_GRA.Location = new System.Drawing.Point(7, 20);
            this.textBoxOne_GRA.Multiline = true;
            this.textBoxOne_GRA.Name = "textBoxOne_GRA";
            this.textBoxOne_GRA.ReadOnly = true;
            this.textBoxOne_GRA.Size = new System.Drawing.Size(431, 48);
            this.textBoxOne_GRA.TabIndex = 0;
            this.textBoxOne_GRA.Text = "Протабулировать функцию f(x) на заданном диапозоне \r\nс шагом 1.Произвести проверк" +
    "у деления на ноль.\r\nРезультат вывести в Textbox.";
            // 
            // groupBoxInput_GRA
            // 
            this.groupBoxInput_GRA.Controls.Add(this.textBoxFree_GRA);
            this.groupBoxInput_GRA.Controls.Add(this.textBoxTwo_GRA);
            this.groupBoxInput_GRA.Controls.Add(this.textBoxStopVar_GRA);
            this.groupBoxInput_GRA.Controls.Add(this.textBoxStarVar_GRA);
            this.groupBoxInput_GRA.Location = new System.Drawing.Point(12, 338);
            this.groupBoxInput_GRA.Name = "groupBoxInput_GRA";
            this.groupBoxInput_GRA.Size = new System.Drawing.Size(301, 100);
            this.groupBoxInput_GRA.TabIndex = 1;
            this.groupBoxInput_GRA.TabStop = false;
            this.groupBoxInput_GRA.Text = "Ввод данных";
            // 
            // textBoxFree_GRA
            // 
            this.textBoxFree_GRA.Location = new System.Drawing.Point(185, 31);
            this.textBoxFree_GRA.Multiline = true;
            this.textBoxFree_GRA.Name = "textBoxFree_GRA";
            this.textBoxFree_GRA.ReadOnly = true;
            this.textBoxFree_GRA.Size = new System.Drawing.Size(100, 20);
            this.textBoxFree_GRA.TabIndex = 3;
            this.textBoxFree_GRA.Text = "Конец шага:";
            // 
            // textBoxTwo_GRA
            // 
            this.textBoxTwo_GRA.Location = new System.Drawing.Point(7, 31);
            this.textBoxTwo_GRA.Multiline = true;
            this.textBoxTwo_GRA.Name = "textBoxTwo_GRA";
            this.textBoxTwo_GRA.ReadOnly = true;
            this.textBoxTwo_GRA.Size = new System.Drawing.Size(100, 20);
            this.textBoxTwo_GRA.TabIndex = 2;
            this.textBoxTwo_GRA.Text = "Старт шага:";
            // 
            // textBoxStopVar_GRA
            // 
            this.textBoxStopVar_GRA.Location = new System.Drawing.Point(185, 64);
            this.textBoxStopVar_GRA.Multiline = true;
            this.textBoxStopVar_GRA.Name = "textBoxStopVar_GRA";
            this.textBoxStopVar_GRA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopVar_GRA.TabIndex = 1;
            this.textBoxStopVar_GRA.TextChanged += new System.EventHandler(this.textBoxStopVar_GRA_TextChanged);
            // 
            // textBoxStarVar_GRA
            // 
            this.textBoxStarVar_GRA.Location = new System.Drawing.Point(7, 64);
            this.textBoxStarVar_GRA.Multiline = true;
            this.textBoxStarVar_GRA.Name = "textBoxStarVar_GRA";
            this.textBoxStarVar_GRA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStarVar_GRA.TabIndex = 0;
            this.textBoxStarVar_GRA.TextChanged += new System.EventHandler(this.textBoxStarVar_GRA_TextChanged);
            // 
            // groupBoxOutput_GRA
            // 
            this.groupBoxOutput_GRA.Controls.Add(this.textBoxRes_GRA);
            this.groupBoxOutput_GRA.Controls.Add(this.textBoxFour_GRA);
            this.groupBoxOutput_GRA.Location = new System.Drawing.Point(554, 12);
            this.groupBoxOutput_GRA.Name = "groupBoxOutput_GRA";
            this.groupBoxOutput_GRA.Size = new System.Drawing.Size(234, 426);
            this.groupBoxOutput_GRA.TabIndex = 2;
            this.groupBoxOutput_GRA.TabStop = false;
            this.groupBoxOutput_GRA.Text = "Вывод данных";
            // 
            // textBoxRes_GRA
            // 
            this.textBoxRes_GRA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRes_GRA.Location = new System.Drawing.Point(7, 47);
            this.textBoxRes_GRA.Multiline = true;
            this.textBoxRes_GRA.Name = "textBoxRes_GRA";
            this.textBoxRes_GRA.Size = new System.Drawing.Size(221, 373);
            this.textBoxRes_GRA.TabIndex = 1;
            this.textBoxRes_GRA.TextChanged += new System.EventHandler(this.textBoxRes_GRA_TextChanged);
            // 
            // textBoxFour_GRA
            // 
            this.textBoxFour_GRA.Location = new System.Drawing.Point(7, 20);
            this.textBoxFour_GRA.Name = "textBoxFour_GRA";
            this.textBoxFour_GRA.ReadOnly = true;
            this.textBoxFour_GRA.Size = new System.Drawing.Size(100, 20);
            this.textBoxFour_GRA.TabIndex = 0;
            this.textBoxFour_GRA.Text = "Результат";
            // 
            // buttonHelp_GRA
            // 
            this.buttonHelp_GRA.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonHelp_GRA.Location = new System.Drawing.Point(319, 347);
            this.buttonHelp_GRA.Name = "buttonHelp_GRA";
            this.buttonHelp_GRA.Size = new System.Drawing.Size(89, 91);
            this.buttonHelp_GRA.TabIndex = 3;
            this.buttonHelp_GRA.Text = "СПРАВКА";
            this.buttonHelp_GRA.UseVisualStyleBackColor = false;
            this.buttonHelp_GRA.Click += new System.EventHandler(this.buttonHelp_GRA_Click);
            // 
            // buttonStart_GRA
            // 
            this.buttonStart_GRA.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonStart_GRA.Location = new System.Drawing.Point(415, 347);
            this.buttonStart_GRA.Name = "buttonStart_GRA";
            this.buttonStart_GRA.Size = new System.Drawing.Size(133, 91);
            this.buttonStart_GRA.TabIndex = 4;
            this.buttonStart_GRA.Text = "ВЫПОЛНИТЬ";
            this.buttonStart_GRA.UseVisualStyleBackColor = false;
            this.buttonStart_GRA.Click += new System.EventHandler(this.buttonStart_GRA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonStart_GRA);
            this.Controls.Add(this.buttonHelp_GRA);
            this.Controls.Add(this.groupBoxOutput_GRA);
            this.Controls.Add(this.groupBoxInput_GRA);
            this.Controls.Add(this.groupBoxConditions_GRA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 29  | Гооге Р А. ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxConditions_GRA.ResumeLayout(false);
            this.groupBoxConditions_GRA.PerformLayout();
            this.groupBoxInput_GRA.ResumeLayout(false);
            this.groupBoxInput_GRA.PerformLayout();
            this.groupBoxOutput_GRA.ResumeLayout(false);
            this.groupBoxOutput_GRA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConditions_GRA;
        private System.Windows.Forms.TextBox textBoxOne_GRA;
        private System.Windows.Forms.GroupBox groupBoxInput_GRA;
        private System.Windows.Forms.TextBox textBoxFree_GRA;
        private System.Windows.Forms.TextBox textBoxTwo_GRA;
        private System.Windows.Forms.TextBox textBoxStopVar_GRA;
        private System.Windows.Forms.TextBox textBoxStarVar_GRA;
        private System.Windows.Forms.GroupBox groupBoxOutput_GRA;
        private System.Windows.Forms.TextBox textBoxRes_GRA;
        private System.Windows.Forms.TextBox textBoxFour_GRA;
        private System.Windows.Forms.Button buttonHelp_GRA;
        private System.Windows.Forms.Button buttonStart_GRA;
    }
}

