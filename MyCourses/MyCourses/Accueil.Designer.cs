namespace MyCourses
{
    partial class Accueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonProfesseurs = new System.Windows.Forms.Button();
            this.buttonEtudiants = new System.Windows.Forms.Button();
            this.buttonAccueil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelusername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelControls = new System.Windows.Forms.Panel();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelMenu.Controls.Add(this.label4);
            this.panelMenu.Controls.Add(this.buttonExit);
            this.panelMenu.Controls.Add(this.buttonAdmin);
            this.panelMenu.Controls.Add(this.buttonProfesseurs);
            this.panelMenu.Controls.Add(this.buttonEtudiants);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.buttonAccueil);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenu.ForeColor = System.Drawing.Color.White;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(156, 601);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(32)))), ((int)(((byte)(13)))));
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.Location = new System.Drawing.Point(0, 564);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(156, 37);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Quitter";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdmin.FlatAppearance.BorderSize = 0;
            this.buttonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdmin.ForeColor = System.Drawing.Color.White;
            this.buttonAdmin.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdmin.Image")));
            this.buttonAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdmin.Location = new System.Drawing.Point(1, 292);
            this.buttonAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(156, 54);
            this.buttonAdmin.TabIndex = 2;
            this.buttonAdmin.Text = "Adminstrateurs";
            this.buttonAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdmin.UseVisualStyleBackColor = false;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // buttonProfesseurs
            // 
            this.buttonProfesseurs.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonProfesseurs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonProfesseurs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProfesseurs.FlatAppearance.BorderSize = 0;
            this.buttonProfesseurs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfesseurs.ForeColor = System.Drawing.Color.White;
            this.buttonProfesseurs.Image = ((System.Drawing.Image)(resources.GetObject("buttonProfesseurs.Image")));
            this.buttonProfesseurs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProfesseurs.Location = new System.Drawing.Point(1, 237);
            this.buttonProfesseurs.Margin = new System.Windows.Forms.Padding(0);
            this.buttonProfesseurs.Name = "buttonProfesseurs";
            this.buttonProfesseurs.Size = new System.Drawing.Size(156, 54);
            this.buttonProfesseurs.TabIndex = 2;
            this.buttonProfesseurs.Text = "Professeurs";
            this.buttonProfesseurs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonProfesseurs.UseVisualStyleBackColor = false;
            this.buttonProfesseurs.Click += new System.EventHandler(this.buttonProfesseurs_Click);
            // 
            // buttonEtudiants
            // 
            this.buttonEtudiants.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonEtudiants.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEtudiants.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEtudiants.FlatAppearance.BorderSize = 0;
            this.buttonEtudiants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEtudiants.ForeColor = System.Drawing.Color.White;
            this.buttonEtudiants.Image = ((System.Drawing.Image)(resources.GetObject("buttonEtudiants.Image")));
            this.buttonEtudiants.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEtudiants.Location = new System.Drawing.Point(1, 182);
            this.buttonEtudiants.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEtudiants.Name = "buttonEtudiants";
            this.buttonEtudiants.Size = new System.Drawing.Size(156, 54);
            this.buttonEtudiants.TabIndex = 2;
            this.buttonEtudiants.Text = "Etudiants";
            this.buttonEtudiants.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEtudiants.UseVisualStyleBackColor = false;
            this.buttonEtudiants.Click += new System.EventHandler(this.buttonEtudiants_Click);
            // 
            // buttonAccueil
            // 
            this.buttonAccueil.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonAccueil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAccueil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAccueil.FlatAppearance.BorderSize = 0;
            this.buttonAccueil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccueil.ForeColor = System.Drawing.Color.White;
            this.buttonAccueil.Image = ((System.Drawing.Image)(resources.GetObject("buttonAccueil.Image")));
            this.buttonAccueil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAccueil.Location = new System.Drawing.Point(1, 127);
            this.buttonAccueil.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAccueil.Name = "buttonAccueil";
            this.buttonAccueil.Size = new System.Drawing.Size(155, 54);
            this.buttonAccueil.TabIndex = 2;
            this.buttonAccueil.Text = "Acceuil";
            this.buttonAccueil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAccueil.UseVisualStyleBackColor = false;
            this.buttonAccueil.Click += new System.EventHandler(this.buttonAccueil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.logo_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.logo_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.logo_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonMinimize);
            this.panel1.Controls.Add(this.buttonMaximize);
            this.panel1.Controls.Add(this.labelDate);
            this.panel1.Controls.Add(this.labelusername);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(156, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 35);
            this.panel1.TabIndex = 1;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDate.Location = new System.Drawing.Point(758, 8);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(98, 18);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "jj/mm/aaaa";
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusername.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelusername.Location = new System.Drawing.Point(480, 7);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(92, 21);
            this.labelusername.TabIndex = 2;
            this.labelusername.Text = "Ahmed Ali";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(376, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bienvenue : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gestion d\'utilisateurs";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(117, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 41);
            this.panel2.TabIndex = 0;
            // 
            // panelControls
            // 
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(156, 35);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(938, 566);
            this.panelControls.TabIndex = 2;
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMaximize.BackgroundImage")));
            this.buttonMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMaximize.FlatAppearance.BorderSize = 0;
            this.buttonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximize.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMaximize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonMaximize.Location = new System.Drawing.Point(900, 0);
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.Size = new System.Drawing.Size(38, 35);
            this.buttonMaximize.TabIndex = 4;
            this.buttonMaximize.UseVisualStyleBackColor = true;
            this.buttonMaximize.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMinimize.BackgroundImage")));
            this.buttonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonMinimize.Location = new System.Drawing.Point(862, 0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(38, 35);
            this.buttonMinimize.TabIndex = 5;
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(26, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "My Courses";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(18, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "___________________";
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1094, 601);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Courses";
            this.Load += new System.EventHandler(this.Accueil_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button buttonAccueil;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Button buttonProfesseurs;
        private System.Windows.Forms.Button buttonEtudiants;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Button buttonMaximize;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}