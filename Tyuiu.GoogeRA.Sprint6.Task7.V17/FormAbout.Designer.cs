
namespace Tyuiu.GoogeRA.Sprint6.Task7.V17
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.buttonOK_GRA = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelHelp_GRA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK_GRA
            // 
            this.buttonOK_GRA.Location = new System.Drawing.Point(314, 157);
            this.buttonOK_GRA.Name = "buttonOK_GRA";
            this.buttonOK_GRA.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_GRA.TabIndex = 0;
            this.buttonOK_GRA.Text = "OK";
            this.buttonOK_GRA.UseVisualStyleBackColor = true;
            this.buttonOK_GRA.Click += new System.EventHandler(this.buttonOK_GRA_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tyuiu.GoogeRA.Sprint6.Task7.V17.Properties.Resources._1_83408_128;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 164);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelHelp_GRA
            // 
            this.labelHelp_GRA.AutoSize = true;
            this.labelHelp_GRA.Location = new System.Drawing.Point(140, 13);
            this.labelHelp_GRA.Name = "labelHelp_GRA";
            this.labelHelp_GRA.Size = new System.Drawing.Size(287, 130);
            this.labelHelp_GRA.TabIndex = 2;
            this.labelHelp_GRA.Text = resources.GetString("labelHelp_GRA.Text");
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 190);
            this.Controls.Add(this.labelHelp_GRA);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonOK_GRA);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK_GRA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelHelp_GRA;
    }
}