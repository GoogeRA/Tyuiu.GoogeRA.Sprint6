
namespace Tyuiu.GoogeRA.Sprint6.Task6.V18
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
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonOK_GRA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.Image = global::Tyuiu.GoogeRA.Sprint6.Task6.V18.Properties.Resources._1_83408_128;
            this.pictureBoxAvatar.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(121, 150);
            this.pictureBoxAvatar.TabIndex = 0;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(140, 13);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(287, 117);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = resources.GetString("labelInfo.Text");
            // 
            // buttonOK_GRA
            // 
            this.buttonOK_GRA.Location = new System.Drawing.Point(310, 140);
            this.buttonOK_GRA.Name = "buttonOK_GRA";
            this.buttonOK_GRA.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_GRA.TabIndex = 2;
            this.buttonOK_GRA.Text = "ОК";
            this.buttonOK_GRA.UseVisualStyleBackColor = true;
            this.buttonOK_GRA.Click += new System.EventHandler(this.buttonOK_GRA_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 175);
            this.Controls.Add(this.buttonOK_GRA);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.pictureBoxAvatar);
            this.KeyPreview = true;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonOK_GRA;
    }
}