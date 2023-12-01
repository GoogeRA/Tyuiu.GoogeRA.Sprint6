
namespace Tyuiu.GoogeRA.Sprint6.Task0.V13
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
            this.components = new System.ComponentModel.Container();
            this.buttonOne_GRA_Use = new System.Windows.Forms.Button();
            this.buttonTwo_GRA_Help = new System.Windows.Forms.Button();
            this.groupBoxOne_GRA = new System.Windows.Forms.GroupBox();
            this.pictureBoxOne_GRA = new System.Windows.Forms.PictureBox();
            this.textBoxFree_GRA = new System.Windows.Forms.TextBox();
            this.groupBoxTwo_GRA = new System.Windows.Forms.GroupBox();
            this.textBoxFour_GRA = new System.Windows.Forms.TextBox();
            this.textBoxOne_GRA_VarX = new System.Windows.Forms.TextBox();
            this.groupBoxFree_GRA = new System.Windows.Forms.GroupBox();
            this.textBoxFive_GRA = new System.Windows.Forms.TextBox();
            this.textBoxResult_GRA = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBoxOne_GRA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOne_GRA)).BeginInit();
            this.groupBoxTwo_GRA.SuspendLayout();
            this.groupBoxFree_GRA.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOne_GRA_Use
            // 
            this.buttonOne_GRA_Use.Location = new System.Drawing.Point(581, 353);
            this.buttonOne_GRA_Use.Name = "buttonOne_GRA_Use";
            this.buttonOne_GRA_Use.Size = new System.Drawing.Size(155, 41);
            this.buttonOne_GRA_Use.TabIndex = 0;
            this.buttonOne_GRA_Use.Text = "Выполнить";
            this.buttonOne_GRA_Use.UseVisualStyleBackColor = true;
            this.buttonOne_GRA_Use.Click += new System.EventHandler(this.buttonOne_GRA_Click);
            // 
            // buttonTwo_GRA_Help
            // 
            this.buttonTwo_GRA_Help.Location = new System.Drawing.Point(536, 352);
            this.buttonTwo_GRA_Help.Name = "buttonTwo_GRA_Help";
            this.buttonTwo_GRA_Help.Size = new System.Drawing.Size(39, 41);
            this.buttonTwo_GRA_Help.TabIndex = 1;
            this.buttonTwo_GRA_Help.Text = "?";
            this.buttonTwo_GRA_Help.UseVisualStyleBackColor = true;
            this.buttonTwo_GRA_Help.Click += new System.EventHandler(this.FormMain_Load);
            // 
            // groupBoxOne_GRA
            // 
            this.groupBoxOne_GRA.Controls.Add(this.pictureBoxOne_GRA);
            this.groupBoxOne_GRA.Controls.Add(this.textBoxFree_GRA);
            this.groupBoxOne_GRA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxOne_GRA.Name = "groupBoxOne_GRA";
            this.groupBoxOne_GRA.Size = new System.Drawing.Size(724, 220);
            this.groupBoxOne_GRA.TabIndex = 2;
            this.groupBoxOne_GRA.TabStop = false;
            this.groupBoxOne_GRA.Text = "Условие";
            // 
            // pictureBoxOne_GRA
            // 
            this.pictureBoxOne_GRA.Image = global::Tyuiu.GoogeRA.Sprint6.Task0.V13.Properties.Resources.Пример;
            this.pictureBoxOne_GRA.Location = new System.Drawing.Point(587, 19);
            this.pictureBoxOne_GRA.Name = "pictureBoxOne_GRA";
            this.pictureBoxOne_GRA.Size = new System.Drawing.Size(116, 65);
            this.pictureBoxOne_GRA.TabIndex = 2;
            this.pictureBoxOne_GRA.TabStop = false;
            // 
            // textBoxFree_GRA
            // 
            this.textBoxFree_GRA.Location = new System.Drawing.Point(16, 19);
            this.textBoxFree_GRA.Multiline = true;
            this.textBoxFree_GRA.Name = "textBoxFree_GRA";
            this.textBoxFree_GRA.ReadOnly = true;
            this.textBoxFree_GRA.Size = new System.Drawing.Size(565, 184);
            this.textBoxFree_GRA.TabIndex = 1;
            this.textBoxFree_GRA.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxTwo_GRA
            // 
            this.groupBoxTwo_GRA.Controls.Add(this.textBoxFour_GRA);
            this.groupBoxTwo_GRA.Controls.Add(this.textBoxOne_GRA_VarX);
            this.groupBoxTwo_GRA.Location = new System.Drawing.Point(13, 239);
            this.groupBoxTwo_GRA.Name = "groupBoxTwo_GRA";
            this.groupBoxTwo_GRA.Size = new System.Drawing.Size(517, 107);
            this.groupBoxTwo_GRA.TabIndex = 3;
            this.groupBoxTwo_GRA.TabStop = false;
            this.groupBoxTwo_GRA.Text = "Ввод данных";
            // 
            // textBoxFour_GRA
            // 
            this.textBoxFour_GRA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxFour_GRA.Location = new System.Drawing.Point(15, 21);
            this.textBoxFour_GRA.Name = "textBoxFour_GRA";
            this.textBoxFour_GRA.ReadOnly = true;
            this.textBoxFour_GRA.Size = new System.Drawing.Size(100, 20);
            this.textBoxFour_GRA.TabIndex = 1;
            this.textBoxFour_GRA.Text = "Переменная X:";
            // 
            // textBoxOne_GRA_VarX
            // 
            this.textBoxOne_GRA_VarX.Location = new System.Drawing.Point(15, 47);
            this.textBoxOne_GRA_VarX.Name = "textBoxOne_GRA_VarX";
            this.textBoxOne_GRA_VarX.Size = new System.Drawing.Size(115, 20);
            this.textBoxOne_GRA_VarX.TabIndex = 0;
            this.textBoxOne_GRA_VarX.TextChanged += new System.EventHandler(this.textBoxTwo_GRA_TextChanged);
            this.textBoxOne_GRA_VarX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOne_GRA_VarX_KeyPress);
            // 
            // groupBoxFree_GRA
            // 
            this.groupBoxFree_GRA.Controls.Add(this.textBoxFive_GRA);
            this.groupBoxFree_GRA.Controls.Add(this.textBoxResult_GRA);
            this.groupBoxFree_GRA.Location = new System.Drawing.Point(536, 239);
            this.groupBoxFree_GRA.Name = "groupBoxFree_GRA";
            this.groupBoxFree_GRA.Size = new System.Drawing.Size(200, 107);
            this.groupBoxFree_GRA.TabIndex = 4;
            this.groupBoxFree_GRA.TabStop = false;
            this.groupBoxFree_GRA.Text = "Вывод данных";
            // 
            // textBoxFive_GRA
            // 
            this.textBoxFive_GRA.Location = new System.Drawing.Point(45, 20);
            this.textBoxFive_GRA.Multiline = true;
            this.textBoxFive_GRA.Name = "textBoxFive_GRA";
            this.textBoxFive_GRA.ReadOnly = true;
            this.textBoxFive_GRA.Size = new System.Drawing.Size(100, 20);
            this.textBoxFive_GRA.TabIndex = 2;
            this.textBoxFive_GRA.Text = "Результат:";
            // 
            // textBoxResult_GRA
            // 
            this.textBoxResult_GRA.Location = new System.Drawing.Point(45, 43);
            this.textBoxResult_GRA.Name = "textBoxResult_GRA";
            this.textBoxResult_GRA.ReadOnly = true;
            this.textBoxResult_GRA.Size = new System.Drawing.Size(116, 20);
            this.textBoxResult_GRA.TabIndex = 1;
            this.textBoxResult_GRA.TextChanged += new System.EventHandler(this.textBoxTwo_GRA_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 406);
            this.Controls.Add(this.groupBoxFree_GRA);
            this.Controls.Add(this.groupBoxTwo_GRA);
            this.Controls.Add(this.groupBoxOne_GRA);
            this.Controls.Add(this.buttonTwo_GRA_Help);
            this.Controls.Add(this.buttonOne_GRA_Use);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 13 | Гооге Р.А. ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxOne_GRA.ResumeLayout(false);
            this.groupBoxOne_GRA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOne_GRA)).EndInit();
            this.groupBoxTwo_GRA.ResumeLayout(false);
            this.groupBoxTwo_GRA.PerformLayout();
            this.groupBoxFree_GRA.ResumeLayout(false);
            this.groupBoxFree_GRA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOne_GRA_Use;
        private System.Windows.Forms.Button buttonTwo_GRA_Help;
        private System.Windows.Forms.GroupBox groupBoxOne_GRA;
        private System.Windows.Forms.GroupBox groupBoxTwo_GRA;
        private System.Windows.Forms.GroupBox groupBoxFree_GRA;
        private System.Windows.Forms.TextBox textBoxFree_GRA;
        private System.Windows.Forms.TextBox textBoxOne_GRA_VarX;
        private System.Windows.Forms.TextBox textBoxResult_GRA;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBoxOne_GRA;
        private System.Windows.Forms.TextBox textBoxFour_GRA;
        private System.Windows.Forms.TextBox textBoxFive_GRA;
    }
}

