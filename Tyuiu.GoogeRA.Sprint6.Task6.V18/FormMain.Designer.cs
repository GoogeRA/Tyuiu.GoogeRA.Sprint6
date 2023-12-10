
namespace Tyuiu.GoogeRA.Sprint6.Task6.V18
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxOne_GRA = new System.Windows.Forms.GroupBox();
            this.groupBoxTwo_GRA = new System.Windows.Forms.GroupBox();
            this.textBoxOne_GRA = new System.Windows.Forms.TextBox();
            this.groupBoxInPut_GRA = new System.Windows.Forms.GroupBox();
            this.textBoxLoadFromFile_GRA = new System.Windows.Forms.TextBox();
            this.groupBoxOutPut_GRA = new System.Windows.Forms.GroupBox();
            this.textBoxRes_GRA = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_GRA = new System.Windows.Forms.OpenFileDialog();
            this.toolTipTask_GRA = new System.Windows.Forms.ToolTip(this.components);
            this.buttonOpenFile_GRA = new System.Windows.Forms.Button();
            this.buttonHelp_GRA = new System.Windows.Forms.Button();
            this.buttonDone_GRA = new System.Windows.Forms.Button();
            this.panelTop_GRA = new System.Windows.Forms.Panel();
            this.panelTopTwo_GRA = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxOne_GRA.SuspendLayout();
            this.groupBoxTwo_GRA.SuspendLayout();
            this.groupBoxInPut_GRA.SuspendLayout();
            this.groupBoxOutPut_GRA.SuspendLayout();
            this.panelTop_GRA.SuspendLayout();
            this.panelTopTwo_GRA.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOne_GRA
            // 
            this.groupBoxOne_GRA.Controls.Add(this.buttonOpenFile_GRA);
            this.groupBoxOne_GRA.Controls.Add(this.buttonHelp_GRA);
            this.groupBoxOne_GRA.Controls.Add(this.buttonDone_GRA);
            this.groupBoxOne_GRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOne_GRA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOne_GRA.Name = "groupBoxOne_GRA";
            this.groupBoxOne_GRA.Size = new System.Drawing.Size(1000, 87);
            this.groupBoxOne_GRA.TabIndex = 0;
            this.groupBoxOne_GRA.TabStop = false;
            // 
            // groupBoxTwo_GRA
            // 
            this.groupBoxTwo_GRA.Controls.Add(this.textBoxOne_GRA);
            this.groupBoxTwo_GRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTwo_GRA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTwo_GRA.Name = "groupBoxTwo_GRA";
            this.groupBoxTwo_GRA.Size = new System.Drawing.Size(1000, 87);
            this.groupBoxTwo_GRA.TabIndex = 1;
            this.groupBoxTwo_GRA.TabStop = false;
            this.groupBoxTwo_GRA.Text = "Условие";
            // 
            // textBoxOne_GRA
            // 
            this.textBoxOne_GRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOne_GRA.Location = new System.Drawing.Point(3, 16);
            this.textBoxOne_GRA.Multiline = true;
            this.textBoxOne_GRA.Name = "textBoxOne_GRA";
            this.textBoxOne_GRA.ReadOnly = true;
            this.textBoxOne_GRA.Size = new System.Drawing.Size(994, 68);
            this.textBoxOne_GRA.TabIndex = 0;
            this.textBoxOne_GRA.Text = resources.GetString("textBoxOne_GRA.Text");
            // 
            // groupBoxInPut_GRA
            // 
            this.groupBoxInPut_GRA.Controls.Add(this.textBoxLoadFromFile_GRA);
            this.groupBoxInPut_GRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPut_GRA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPut_GRA.Name = "groupBoxInPut_GRA";
            this.groupBoxInPut_GRA.Size = new System.Drawing.Size(455, 381);
            this.groupBoxInPut_GRA.TabIndex = 2;
            this.groupBoxInPut_GRA.TabStop = false;
            this.groupBoxInPut_GRA.Text = "Ввод:";
            this.groupBoxInPut_GRA.Enter += new System.EventHandler(this.groupBoxInPut_GRA_Enter);
            // 
            // textBoxLoadFromFile_GRA
            // 
            this.textBoxLoadFromFile_GRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLoadFromFile_GRA.Location = new System.Drawing.Point(3, 16);
            this.textBoxLoadFromFile_GRA.Multiline = true;
            this.textBoxLoadFromFile_GRA.Name = "textBoxLoadFromFile_GRA";
            this.textBoxLoadFromFile_GRA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLoadFromFile_GRA.Size = new System.Drawing.Size(449, 362);
            this.textBoxLoadFromFile_GRA.TabIndex = 0;
            this.textBoxLoadFromFile_GRA.TextChanged += new System.EventHandler(this.textBoxInPut_GRA_TextChanged);
            // 
            // groupBoxOutPut_GRA
            // 
            this.groupBoxOutPut_GRA.Controls.Add(this.textBoxRes_GRA);
            this.groupBoxOutPut_GRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_GRA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_GRA.Name = "groupBoxOutPut_GRA";
            this.groupBoxOutPut_GRA.Size = new System.Drawing.Size(456, 381);
            this.groupBoxOutPut_GRA.TabIndex = 3;
            this.groupBoxOutPut_GRA.TabStop = false;
            this.groupBoxOutPut_GRA.Text = "Вывод:";
            // 
            // textBoxRes_GRA
            // 
            this.textBoxRes_GRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRes_GRA.Location = new System.Drawing.Point(3, 16);
            this.textBoxRes_GRA.Multiline = true;
            this.textBoxRes_GRA.Name = "textBoxRes_GRA";
            this.textBoxRes_GRA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRes_GRA.Size = new System.Drawing.Size(450, 362);
            this.textBoxRes_GRA.TabIndex = 0;
            this.textBoxRes_GRA.TextChanged += new System.EventHandler(this.textBoxOutPut_GRA_TextChanged);
            // 
            // toolTipTask_GRA
            // 
            this.toolTipTask_GRA.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipTask_GRA.ToolTipTitle = "Подсказка";
            // 
            // buttonOpenFile_GRA
            // 
            this.buttonOpenFile_GRA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonOpenFile_GRA.BackgroundImage = global::Tyuiu.GoogeRA.Sprint6.Task6.V18.Properties.Resources.rfgfdg;
            this.buttonOpenFile_GRA.Location = new System.Drawing.Point(24, 11);
            this.buttonOpenFile_GRA.Name = "buttonOpenFile_GRA";
            this.buttonOpenFile_GRA.Size = new System.Drawing.Size(101, 65);
            this.buttonOpenFile_GRA.TabIndex = 0;
            this.toolTipTask_GRA.SetToolTip(this.buttonOpenFile_GRA, "Открыть файл");
            this.buttonOpenFile_GRA.UseMnemonic = false;
            this.buttonOpenFile_GRA.UseVisualStyleBackColor = false;
            this.buttonOpenFile_GRA.Click += new System.EventHandler(this.buttonOpenFile_GRA_Click);
            // 
            // buttonHelp_GRA
            // 
            this.buttonHelp_GRA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_GRA.BackgroundImage = global::Tyuiu.GoogeRA.Sprint6.Task6.V18.Properties.Resources.Ворпром;
            this.buttonHelp_GRA.Location = new System.Drawing.Point(930, 12);
            this.buttonHelp_GRA.Name = "buttonHelp_GRA";
            this.buttonHelp_GRA.Size = new System.Drawing.Size(58, 65);
            this.buttonHelp_GRA.TabIndex = 2;
            this.toolTipTask_GRA.SetToolTip(this.buttonHelp_GRA, "Справка");
            this.buttonHelp_GRA.UseVisualStyleBackColor = true;
            this.buttonHelp_GRA.Click += new System.EventHandler(this.buttonHelp_GRA_Click);
            // 
            // buttonDone_GRA
            // 
            this.buttonDone_GRA.BackgroundImage = global::Tyuiu.GoogeRA.Sprint6.Task6.V18.Properties.Resources.файл1;
            this.buttonDone_GRA.Location = new System.Drawing.Point(131, 11);
            this.buttonDone_GRA.Name = "buttonDone_GRA";
            this.buttonDone_GRA.Size = new System.Drawing.Size(92, 65);
            this.buttonDone_GRA.TabIndex = 1;
            this.toolTipTask_GRA.SetToolTip(this.buttonDone_GRA, "Показать результат");
            this.buttonDone_GRA.UseVisualStyleBackColor = true;
            this.buttonDone_GRA.Click += new System.EventHandler(this.buttonDone_GRA_Click);
            // 
            // panelTop_GRA
            // 
            this.panelTop_GRA.Controls.Add(this.groupBoxOne_GRA);
            this.panelTop_GRA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_GRA.Location = new System.Drawing.Point(0, 0);
            this.panelTop_GRA.Name = "panelTop_GRA";
            this.panelTop_GRA.Size = new System.Drawing.Size(1000, 87);
            this.panelTop_GRA.TabIndex = 3;
            // 
            // panelTopTwo_GRA
            // 
            this.panelTopTwo_GRA.Controls.Add(this.groupBoxTwo_GRA);
            this.panelTopTwo_GRA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopTwo_GRA.Location = new System.Drawing.Point(0, 87);
            this.panelTopTwo_GRA.Name = "panelTopTwo_GRA";
            this.panelTopTwo_GRA.Size = new System.Drawing.Size(1000, 87);
            this.panelTopTwo_GRA.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxInPut_GRA);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 381);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxOutPut_GRA);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(544, 174);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 381);
            this.panel2.TabIndex = 6;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 555);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTopTwo_GRA);
            this.Controls.Add(this.panelTop_GRA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "| Спринт 6 | Таск 6 | Вариант 18 | Гооге Р. А.";
            this.groupBoxOne_GRA.ResumeLayout(false);
            this.groupBoxTwo_GRA.ResumeLayout(false);
            this.groupBoxTwo_GRA.PerformLayout();
            this.groupBoxInPut_GRA.ResumeLayout(false);
            this.groupBoxInPut_GRA.PerformLayout();
            this.groupBoxOutPut_GRA.ResumeLayout(false);
            this.groupBoxOutPut_GRA.PerformLayout();
            this.panelTop_GRA.ResumeLayout(false);
            this.panelTopTwo_GRA.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOne_GRA;
        private System.Windows.Forms.Button buttonOpenFile_GRA;
        private System.Windows.Forms.GroupBox groupBoxTwo_GRA;
        private System.Windows.Forms.TextBox textBoxOne_GRA;
        private System.Windows.Forms.GroupBox groupBoxInPut_GRA;
        private System.Windows.Forms.TextBox textBoxLoadFromFile_GRA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_GRA;
        private System.Windows.Forms.TextBox textBoxRes_GRA;
        private System.Windows.Forms.ToolTip toolTipTask_GRA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_GRA;
        private System.Windows.Forms.Button buttonHelp_GRA;
        private System.Windows.Forms.Button buttonDone_GRA;
        private System.Windows.Forms.Panel panelTop_GRA;
        private System.Windows.Forms.Panel panelTopTwo_GRA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

