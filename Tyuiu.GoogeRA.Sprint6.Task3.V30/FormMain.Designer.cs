
namespace Tyuiu.GoogeRA.Sprint6.Task3.V30
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
            this.groupBoxOne_GRA = new System.Windows.Forms.GroupBox();
            this.textBoxOne_GRA = new System.Windows.Forms.TextBox();
            this.dataGridViewInput_GRA = new System.Windows.Forms.DataGridView();
            this.groupBoxTwo_GRA = new System.Windows.Forms.GroupBox();
            this.textBoxTwo_GRA = new System.Windows.Forms.TextBox();
            this.buttonHelp_GRA = new System.Windows.Forms.Button();
            this.buttonStart_GRA = new System.Windows.Forms.Button();
            this.groupBoxOne_GRA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_GRA)).BeginInit();
            this.groupBoxTwo_GRA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOne_GRA
            // 
            this.groupBoxOne_GRA.Controls.Add(this.textBoxOne_GRA);
            this.groupBoxOne_GRA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxOne_GRA.Name = "groupBoxOne_GRA";
            this.groupBoxOne_GRA.Size = new System.Drawing.Size(235, 304);
            this.groupBoxOne_GRA.TabIndex = 0;
            this.groupBoxOne_GRA.TabStop = false;
            this.groupBoxOne_GRA.Text = "Условия";
            // 
            // textBoxOne_GRA
            // 
            this.textBoxOne_GRA.Location = new System.Drawing.Point(7, 20);
            this.textBoxOne_GRA.Multiline = true;
            this.textBoxOne_GRA.Name = "textBoxOne_GRA";
            this.textBoxOne_GRA.ReadOnly = true;
            this.textBoxOne_GRA.Size = new System.Drawing.Size(218, 235);
            this.textBoxOne_GRA.TabIndex = 0;
            this.textBoxOne_GRA.Text = resources.GetString("textBoxOne_GRA.Text");
            // 
            // dataGridViewInput_GRA
            // 
            this.dataGridViewInput_GRA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput_GRA.Location = new System.Drawing.Point(6, 45);
            this.dataGridViewInput_GRA.Name = "dataGridViewInput_GRA";
            this.dataGridViewInput_GRA.Size = new System.Drawing.Size(274, 245);
            this.dataGridViewInput_GRA.TabIndex = 1;
            this.dataGridViewInput_GRA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInput_GRA_CellContentClick);
            // 
            // groupBoxTwo_GRA
            // 
            this.groupBoxTwo_GRA.Controls.Add(this.textBoxTwo_GRA);
            this.groupBoxTwo_GRA.Controls.Add(this.dataGridViewInput_GRA);
            this.groupBoxTwo_GRA.Location = new System.Drawing.Point(254, 13);
            this.groupBoxTwo_GRA.Name = "groupBoxTwo_GRA";
            this.groupBoxTwo_GRA.Size = new System.Drawing.Size(286, 304);
            this.groupBoxTwo_GRA.TabIndex = 1;
            this.groupBoxTwo_GRA.TabStop = false;
            this.groupBoxTwo_GRA.Text = "Вывод данных";
            // 
            // textBoxTwo_GRA
            // 
            this.textBoxTwo_GRA.Location = new System.Drawing.Point(6, 19);
            this.textBoxTwo_GRA.Name = "textBoxTwo_GRA";
            this.textBoxTwo_GRA.ReadOnly = true;
            this.textBoxTwo_GRA.Size = new System.Drawing.Size(100, 20);
            this.textBoxTwo_GRA.TabIndex = 0;
            this.textBoxTwo_GRA.Text = "Результат:";
            this.textBoxTwo_GRA.TextChanged += new System.EventHandler(this.textBoxTwo_GRA_TextChanged);
            // 
            // buttonHelp_GRA
            // 
            this.buttonHelp_GRA.Location = new System.Drawing.Point(559, 249);
            this.buttonHelp_GRA.Name = "buttonHelp_GRA";
            this.buttonHelp_GRA.Size = new System.Drawing.Size(229, 55);
            this.buttonHelp_GRA.TabIndex = 2;
            this.buttonHelp_GRA.Text = "СПРАВКА";
            this.buttonHelp_GRA.UseVisualStyleBackColor = true;
            this.buttonHelp_GRA.Click += new System.EventHandler(this.buttonHelp_GRA_Click);
            // 
            // buttonStart_GRA
            // 
            this.buttonStart_GRA.Location = new System.Drawing.Point(559, 187);
            this.buttonStart_GRA.Name = "buttonStart_GRA";
            this.buttonStart_GRA.Size = new System.Drawing.Size(229, 56);
            this.buttonStart_GRA.TabIndex = 3;
            this.buttonStart_GRA.Text = "ВЫПОЛНИТЬ";
            this.buttonStart_GRA.UseVisualStyleBackColor = true;
            this.buttonStart_GRA.Click += new System.EventHandler(this.buttonStart_GRA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 332);
            this.Controls.Add(this.buttonStart_GRA);
            this.Controls.Add(this.buttonHelp_GRA);
            this.Controls.Add(this.groupBoxTwo_GRA);
            this.Controls.Add(this.groupBoxOne_GRA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "| Спринт 6 | Таск 3 | Вариант 30 | Гооге Р. А. ";
            this.Load += new System.EventHandler(this.FormMain_Load_GRA);
            this.groupBoxOne_GRA.ResumeLayout(false);
            this.groupBoxOne_GRA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_GRA)).EndInit();
            this.groupBoxTwo_GRA.ResumeLayout(false);
            this.groupBoxTwo_GRA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOne_GRA;
        private System.Windows.Forms.DataGridView dataGridViewInput_GRA;
        private System.Windows.Forms.TextBox textBoxOne_GRA;
        private System.Windows.Forms.GroupBox groupBoxTwo_GRA;
        private System.Windows.Forms.TextBox textBoxTwo_GRA;
        private System.Windows.Forms.Button buttonHelp_GRA;
        private System.Windows.Forms.Button buttonStart_GRA;
    }
}

