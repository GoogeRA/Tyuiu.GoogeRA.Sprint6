
namespace Tyuiu.GoogeRA.Sprint6.Task7.V17
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
            this.textBoxOne_GRA = new System.Windows.Forms.TextBox();
            this.groupBoxTwo_GRA = new System.Windows.Forms.GroupBox();
            this.buttonHelp_GRA = new System.Windows.Forms.Button();
            this.buttonSave_GRA = new System.Windows.Forms.Button();
            this.buttonStart_GRA = new System.Windows.Forms.Button();
            this.buttonOpenFile_GRA = new System.Windows.Forms.Button();
            this.groupBoxLoadFile_GRA = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPut_GRA = new System.Windows.Forms.DataGridView();
            this.groupBoxOutPut_GRA = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPut_GRA = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_GRA = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix_GRA = new System.Windows.Forms.OpenFileDialog();
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.panelRait_GRA = new System.Windows.Forms.Panel();
            this.panelLeft_GRA = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTwo_GRA = new System.Windows.Forms.Panel();
            this.groupBoxOne_GRA.SuspendLayout();
            this.groupBoxTwo_GRA.SuspendLayout();
            this.groupBoxLoadFile_GRA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_GRA)).BeginInit();
            this.groupBoxOutPut_GRA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_GRA)).BeginInit();
            this.panelRait_GRA.SuspendLayout();
            this.panelLeft_GRA.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTwo_GRA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOne_GRA
            // 
            this.groupBoxOne_GRA.Controls.Add(this.textBoxOne_GRA);
            this.groupBoxOne_GRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOne_GRA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOne_GRA.Name = "groupBoxOne_GRA";
            this.groupBoxOne_GRA.Size = new System.Drawing.Size(978, 91);
            this.groupBoxOne_GRA.TabIndex = 0;
            this.groupBoxOne_GRA.TabStop = false;
            this.groupBoxOne_GRA.Text = "Условие";
            // 
            // textBoxOne_GRA
            // 
            this.textBoxOne_GRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOne_GRA.Location = new System.Drawing.Point(3, 16);
            this.textBoxOne_GRA.Multiline = true;
            this.textBoxOne_GRA.Name = "textBoxOne_GRA";
            this.textBoxOne_GRA.ReadOnly = true;
            this.textBoxOne_GRA.Size = new System.Drawing.Size(972, 72);
            this.textBoxOne_GRA.TabIndex = 0;
            this.textBoxOne_GRA.Text = resources.GetString("textBoxOne_GRA.Text");
            // 
            // groupBoxTwo_GRA
            // 
            this.groupBoxTwo_GRA.Controls.Add(this.buttonHelp_GRA);
            this.groupBoxTwo_GRA.Controls.Add(this.buttonSave_GRA);
            this.groupBoxTwo_GRA.Controls.Add(this.buttonStart_GRA);
            this.groupBoxTwo_GRA.Controls.Add(this.buttonOpenFile_GRA);
            this.groupBoxTwo_GRA.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxTwo_GRA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTwo_GRA.Name = "groupBoxTwo_GRA";
            this.groupBoxTwo_GRA.Size = new System.Drawing.Size(978, 100);
            this.groupBoxTwo_GRA.TabIndex = 1;
            this.groupBoxTwo_GRA.TabStop = false;
            // 
            // buttonHelp_GRA
            // 
            this.buttonHelp_GRA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_GRA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHelp_GRA.BackgroundImage")));
            this.buttonHelp_GRA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonHelp_GRA.Location = new System.Drawing.Point(865, 19);
            this.buttonHelp_GRA.Name = "buttonHelp_GRA";
            this.buttonHelp_GRA.Size = new System.Drawing.Size(98, 75);
            this.buttonHelp_GRA.TabIndex = 3;
            this.toolTipInfo.SetToolTip(this.buttonHelp_GRA, "Справка о пользователе");
            this.buttonHelp_GRA.UseVisualStyleBackColor = true;
            this.buttonHelp_GRA.Click += new System.EventHandler(this.buttonHelp_GRA_Click);
            this.buttonHelp_GRA.MouseEnter += new System.EventHandler(this.buttonHelp_GRA_Mouse_Enter);
            // 
            // buttonSave_GRA
            // 
            this.buttonSave_GRA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSave_GRA.BackgroundImage")));
            this.buttonSave_GRA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSave_GRA.Enabled = false;
            this.buttonSave_GRA.Location = new System.Drawing.Point(201, 19);
            this.buttonSave_GRA.Name = "buttonSave_GRA";
            this.buttonSave_GRA.Size = new System.Drawing.Size(100, 75);
            this.buttonSave_GRA.TabIndex = 2;
            this.toolTipInfo.SetToolTip(this.buttonSave_GRA, "Сохранить файл");
            this.buttonSave_GRA.UseVisualStyleBackColor = true;
            this.buttonSave_GRA.Click += new System.EventHandler(this.buttonSave_GRA_Click);
            this.buttonSave_GRA.MouseEnter += new System.EventHandler(this.buttonSave_GRA_Mouse_Enter);
            // 
            // buttonStart_GRA
            // 
            this.buttonStart_GRA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStart_GRA.BackgroundImage")));
            this.buttonStart_GRA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonStart_GRA.Enabled = false;
            this.buttonStart_GRA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart_GRA.Location = new System.Drawing.Point(107, 19);
            this.buttonStart_GRA.Name = "buttonStart_GRA";
            this.buttonStart_GRA.Size = new System.Drawing.Size(88, 75);
            this.buttonStart_GRA.TabIndex = 1;
            this.toolTipInfo.SetToolTip(this.buttonStart_GRA, "Применить изменения ");
            this.buttonStart_GRA.UseVisualStyleBackColor = true;
            this.buttonStart_GRA.Click += new System.EventHandler(this.buttonStart_GRA_Click);
            this.buttonStart_GRA.MouseEnter += new System.EventHandler(this.buttonStart_GRA_Mouse_Enter);
            // 
            // buttonOpenFile_GRA
            // 
            this.buttonOpenFile_GRA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_GRA.BackgroundImage")));
            this.buttonOpenFile_GRA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonOpenFile_GRA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_GRA.Location = new System.Drawing.Point(18, 19);
            this.buttonOpenFile_GRA.Name = "buttonOpenFile_GRA";
            this.buttonOpenFile_GRA.Size = new System.Drawing.Size(83, 75);
            this.buttonOpenFile_GRA.TabIndex = 0;
            this.toolTipInfo.SetToolTip(this.buttonOpenFile_GRA, "Открыть Файл");
            this.buttonOpenFile_GRA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_GRA.Click += new System.EventHandler(this.buttonOpenFile_GRA_Click);
            this.buttonOpenFile_GRA.MouseEnter += new System.EventHandler(this.buttonOpen_GRA_Mouse_Enter);
            // 
            // groupBoxLoadFile_GRA
            // 
            this.groupBoxLoadFile_GRA.Controls.Add(this.dataGridViewInPut_GRA);
            this.groupBoxLoadFile_GRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxLoadFile_GRA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxLoadFile_GRA.Name = "groupBoxLoadFile_GRA";
            this.groupBoxLoadFile_GRA.Size = new System.Drawing.Size(506, 363);
            this.groupBoxLoadFile_GRA.TabIndex = 2;
            this.groupBoxLoadFile_GRA.TabStop = false;
            this.groupBoxLoadFile_GRA.Text = "Ввод:";
            // 
            // dataGridViewInPut_GRA
            // 
            this.dataGridViewInPut_GRA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPut_GRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInPut_GRA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewInPut_GRA.Name = "dataGridViewInPut_GRA";
            this.dataGridViewInPut_GRA.RowHeadersVisible = false;
            this.dataGridViewInPut_GRA.Size = new System.Drawing.Size(500, 344);
            this.dataGridViewInPut_GRA.TabIndex = 0;
            // 
            // groupBoxOutPut_GRA
            // 
            this.groupBoxOutPut_GRA.Controls.Add(this.dataGridViewOutPut_GRA);
            this.groupBoxOutPut_GRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_GRA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_GRA.Name = "groupBoxOutPut_GRA";
            this.groupBoxOutPut_GRA.Size = new System.Drawing.Size(466, 363);
            this.groupBoxOutPut_GRA.TabIndex = 3;
            this.groupBoxOutPut_GRA.TabStop = false;
            this.groupBoxOutPut_GRA.Text = "Вывод:";
            // 
            // dataGridViewOutPut_GRA
            // 
            this.dataGridViewOutPut_GRA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_GRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutPut_GRA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOutPut_GRA.Name = "dataGridViewOutPut_GRA";
            this.dataGridViewOutPut_GRA.RowHeadersVisible = false;
            this.dataGridViewOutPut_GRA.Size = new System.Drawing.Size(460, 344);
            this.dataGridViewOutPut_GRA.TabIndex = 0;
            // 
            // toolTipInfo
            // 
            this.toolTipInfo.IsBalloon = true;
            this.toolTipInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipInfo.ToolTipTitle = "Подсказка";
            // 
            // panelRait_GRA
            // 
            this.panelRait_GRA.Controls.Add(this.groupBoxTwo_GRA);
            this.panelRait_GRA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRait_GRA.Location = new System.Drawing.Point(0, 0);
            this.panelRait_GRA.Name = "panelRait_GRA";
            this.panelRait_GRA.Size = new System.Drawing.Size(978, 113);
            this.panelRait_GRA.TabIndex = 4;
            // 
            // panelLeft_GRA
            // 
            this.panelLeft_GRA.Controls.Add(this.groupBoxOne_GRA);
            this.panelLeft_GRA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLeft_GRA.Location = new System.Drawing.Point(0, 113);
            this.panelLeft_GRA.Name = "panelLeft_GRA";
            this.panelLeft_GRA.Size = new System.Drawing.Size(978, 91);
            this.panelLeft_GRA.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.groupBoxOutPut_GRA);
            this.panel1.Location = new System.Drawing.Point(512, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 363);
            this.panel1.TabIndex = 6;
            // 
            // panelTwo_GRA
            // 
            this.panelTwo_GRA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTwo_GRA.Controls.Add(this.groupBoxLoadFile_GRA);
            this.panelTwo_GRA.Location = new System.Drawing.Point(0, 204);
            this.panelTwo_GRA.Name = "panelTwo_GRA";
            this.panelTwo_GRA.Size = new System.Drawing.Size(506, 363);
            this.panelTwo_GRA.TabIndex = 7;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 567);
            this.Controls.Add(this.panelTwo_GRA);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLeft_GRA);
            this.Controls.Add(this.panelRait_GRA);
            this.Name = "FormMain";
            this.Text = "|Спринт 6 | Таск 7 |  Вариант 17 | Гооге Р. А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxOne_GRA.ResumeLayout(false);
            this.groupBoxOne_GRA.PerformLayout();
            this.groupBoxTwo_GRA.ResumeLayout(false);
            this.groupBoxLoadFile_GRA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_GRA)).EndInit();
            this.groupBoxOutPut_GRA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_GRA)).EndInit();
            this.panelRait_GRA.ResumeLayout(false);
            this.panelLeft_GRA.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelTwo_GRA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOne_GRA;
        private System.Windows.Forms.TextBox textBoxOne_GRA;
        private System.Windows.Forms.GroupBox groupBoxTwo_GRA;
        private System.Windows.Forms.Button buttonOpenFile_GRA;
        private System.Windows.Forms.GroupBox groupBoxLoadFile_GRA;
        private System.Windows.Forms.DataGridView dataGridViewInPut_GRA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_GRA;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_GRA;
        private System.Windows.Forms.Button buttonStart_GRA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_GRA;
        private System.Windows.Forms.OpenFileDialog saveFileDialogMatrix_GRA;
        private System.Windows.Forms.Button buttonSave_GRA;
        private System.Windows.Forms.Button buttonHelp_GRA;
        private System.Windows.Forms.ToolTip toolTipInfo;
        private System.Windows.Forms.Panel panelRait_GRA;
        private System.Windows.Forms.Panel panelLeft_GRA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTwo_GRA;
    }
}

