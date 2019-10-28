namespace SakilaFilms
{
    partial class FilmsDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmsDetails));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lTitle = new System.Windows.Forms.Label();
            this.lTime = new System.Windows.Forms.Label();
            this.lRting = new System.Windows.Forms.Label();
            this.lDescription = new System.Windows.Forms.Label();
            this.descripList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(383, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.Location = new System.Drawing.Point(133, 35);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(95, 46);
            this.lTitle.TabIndex = 1;
            this.lTitle.Text = "Title";
            // 
            // lTime
            // 
            this.lTime.AutoSize = true;
            this.lTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTime.Location = new System.Drawing.Point(399, 247);
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(60, 26);
            this.lTime.TabIndex = 2;
            this.lTime.Text = "Time";
            // 
            // lRting
            // 
            this.lRting.AutoSize = true;
            this.lRting.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRting.Location = new System.Drawing.Point(404, 311);
            this.lRting.Name = "lRting";
            this.lRting.Size = new System.Drawing.Size(56, 25);
            this.lRting.TabIndex = 3;
            this.lRting.Text = "Rting";
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDescription.Location = new System.Drawing.Point(41, 217);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(109, 25);
            this.lDescription.TabIndex = 4;
            this.lDescription.Text = "Description";
            // 
            // descripList
            // 
            this.descripList.FormattingEnabled = true;
            this.descripList.Location = new System.Drawing.Point(46, 261);
            this.descripList.Name = "descripList";
            this.descripList.Size = new System.Drawing.Size(280, 69);
            this.descripList.TabIndex = 5;
            // 
            // FilmsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 390);
            this.Controls.Add(this.descripList);
            this.Controls.Add(this.lDescription);
            this.Controls.Add(this.lRting);
            this.Controls.Add(this.lTime);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FilmsDetails";
            this.Text = "FilmsDetails";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Label lTime;
        private System.Windows.Forms.Label lRting;
        private System.Windows.Forms.Label lDescription;
        private System.Windows.Forms.ListBox descripList;
    }
}