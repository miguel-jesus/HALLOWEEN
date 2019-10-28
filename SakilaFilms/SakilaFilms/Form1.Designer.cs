namespace SakilaFilms
{
    partial class Sakila
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lSakil = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Login = new System.Windows.Forms.TabPage();
            this.bLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.Films = new System.Windows.Forms.TabPage();
            this.lCount = new System.Windows.Forms.Label();
            this.cMatch = new System.Windows.Forms.CheckBox();
            this.lMatch = new System.Windows.Forms.Label();
            this.listFilms = new System.Windows.Forms.ListBox();
            this.bFinder = new System.Windows.Forms.Button();
            this.iSearch = new System.Windows.Forms.TextBox();
            this.lSearch = new System.Windows.Forms.Label();
            this.Staff = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.iUpdate = new System.Windows.Forms.TextBox();
            this.Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Login.SuspendLayout();
            this.Films.SuspendLayout();
            this.Staff.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(788, 122);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lSakil
            // 
            this.lSakil.AutoSize = true;
            this.lSakil.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lSakil.Cursor = System.Windows.Forms.Cursors.Default;
            this.lSakil.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSakil.ForeColor = System.Drawing.Color.White;
            this.lSakil.Location = new System.Drawing.Point(240, 30);
            this.lSakil.Name = "lSakil";
            this.lSakil.Size = new System.Drawing.Size(286, 46);
            this.lSakil.TabIndex = 1;
            this.lSakil.Text = "SAKILA FILMS";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.Login);
            this.tabControl1.Controls.Add(this.Films);
            this.tabControl1.Controls.Add(this.Staff);
            this.tabControl1.Location = new System.Drawing.Point(12, 143);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(742, 295);
            this.tabControl1.TabIndex = 2;
            // 
            // Login
            // 
            this.Login.Controls.Add(this.bLogin);
            this.Login.Controls.Add(this.label2);
            this.Login.Controls.Add(this.label1);
            this.Login.Controls.Add(this.password);
            this.Login.Controls.Add(this.user);
            this.Login.Location = new System.Drawing.Point(23, 4);
            this.Login.Name = "Login";
            this.Login.Padding = new System.Windows.Forms.Padding(3);
            this.Login.Size = new System.Drawing.Size(715, 287);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(440, 123);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(75, 23);
            this.bLogin.TabIndex = 4;
            this.bLogin.Text = "Login";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "User";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(244, 127);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(137, 20);
            this.password.TabIndex = 1;
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(244, 74);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(137, 20);
            this.user.TabIndex = 0;
            // 
            // Films
            // 
            this.Films.Controls.Add(this.lCount);
            this.Films.Controls.Add(this.cMatch);
            this.Films.Controls.Add(this.lMatch);
            this.Films.Controls.Add(this.listFilms);
            this.Films.Controls.Add(this.bFinder);
            this.Films.Controls.Add(this.iSearch);
            this.Films.Controls.Add(this.lSearch);
            this.Films.Location = new System.Drawing.Point(23, 4);
            this.Films.Name = "Films";
            this.Films.Padding = new System.Windows.Forms.Padding(3);
            this.Films.Size = new System.Drawing.Size(715, 287);
            this.Films.TabIndex = 1;
            this.Films.Text = "Films";
            this.Films.UseVisualStyleBackColor = true;
            // 
            // lCount
            // 
            this.lCount.AutoSize = true;
            this.lCount.Location = new System.Drawing.Point(179, 84);
            this.lCount.Name = "lCount";
            this.lCount.Size = new System.Drawing.Size(10, 13);
            this.lCount.TabIndex = 6;
            this.lCount.Text = " ";
            // 
            // cMatch
            // 
            this.cMatch.AutoSize = true;
            this.cMatch.Location = new System.Drawing.Point(487, 81);
            this.cMatch.Name = "cMatch";
            this.cMatch.Size = new System.Drawing.Size(118, 17);
            this.cMatch.TabIndex = 5;
            this.cMatch.Text = "Match whole words";
            this.cMatch.UseVisualStyleBackColor = true;
            // 
            // lMatch
            // 
            this.lMatch.AutoSize = true;
            this.lMatch.Location = new System.Drawing.Point(503, 85);
            this.lMatch.Name = "lMatch";
            this.lMatch.Size = new System.Drawing.Size(0, 13);
            this.lMatch.TabIndex = 4;
            // 
            // listFilms
            // 
            this.listFilms.FormattingEnabled = true;
            this.listFilms.Location = new System.Drawing.Point(179, 104);
            this.listFilms.Name = "listFilms";
            this.listFilms.Size = new System.Drawing.Size(426, 173);
            this.listFilms.TabIndex = 3;
            this.listFilms.DoubleClick += new System.EventHandler(this.listFilms_DoubleClick);
            // 
            // bFinder
            // 
            this.bFinder.Location = new System.Drawing.Point(503, 12);
            this.bFinder.Name = "bFinder";
            this.bFinder.Size = new System.Drawing.Size(102, 23);
            this.bFinder.TabIndex = 2;
            this.bFinder.Text = "Find";
            this.bFinder.UseVisualStyleBackColor = true;
            this.bFinder.Click += new System.EventHandler(this.bFinder_Click);
            // 
            // iSearch
            // 
            this.iSearch.Location = new System.Drawing.Point(179, 16);
            this.iSearch.Name = "iSearch";
            this.iSearch.Size = new System.Drawing.Size(290, 20);
            this.iSearch.TabIndex = 1;
            // 
            // lSearch
            // 
            this.lSearch.AutoSize = true;
            this.lSearch.Location = new System.Drawing.Point(120, 16);
            this.lSearch.Name = "lSearch";
            this.lSearch.Size = new System.Drawing.Size(41, 13);
            this.lSearch.TabIndex = 0;
            this.lSearch.Text = "Search";
            // 
            // Staff
            // 
            this.Staff.Controls.Add(this.Update);
            this.Staff.Controls.Add(this.iUpdate);
            this.Staff.Controls.Add(this.label3);
            this.Staff.Location = new System.Drawing.Point(23, 4);
            this.Staff.Name = "Staff";
            this.Staff.Padding = new System.Windows.Forms.Padding(3);
            this.Staff.Size = new System.Drawing.Size(715, 287);
            this.Staff.TabIndex = 2;
            this.Staff.Text = "Staff";
            this.Staff.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            // 
            // iUpdate
            // 
            this.iUpdate.Location = new System.Drawing.Point(227, 102);
            this.iUpdate.Name = "iUpdate";
            this.iUpdate.Size = new System.Drawing.Size(100, 20);
            this.iUpdate.TabIndex = 1;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(360, 98);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(92, 23);
            this.Update.TabIndex = 2;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Sakila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lSakil);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Sakila";
            this.Text = "Sakila";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            this.Films.ResumeLayout(false);
            this.Films.PerformLayout();
            this.Staff.ResumeLayout(false);
            this.Staff.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lSakil;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Login;
        private System.Windows.Forms.TabPage Films;
        private System.Windows.Forms.TabPage Staff;
        private System.Windows.Forms.Label lSearch;
        private System.Windows.Forms.TextBox iSearch;
        private System.Windows.Forms.Button bFinder;
        private System.Windows.Forms.CheckBox cMatch;
        private System.Windows.Forms.Label lMatch;
        private System.Windows.Forms.ListBox listFilms;
        private System.Windows.Forms.Label lCount;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.TextBox iUpdate;
        private System.Windows.Forms.Label label3;
    }
}

