namespace ShortestPathSolver
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.ButtonToExit = new System.Windows.Forms.Button();
            this.labelMain = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.labelEnter = new System.Windows.Forms.Label();
            this.BeginButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MainPictureBox = new System.Windows.Forms.PictureBox();
            this.TopPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(3)))));
            this.TopPanel.Controls.Add(this.ButtonToExit);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1600, 59);
            this.TopPanel.TabIndex = 5;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // ButtonToExit
            // 
            this.ButtonToExit.AutoSize = true;
            this.ButtonToExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonToExit.BackgroundImage")));
            this.ButtonToExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonToExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonToExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonToExit.FlatAppearance.BorderSize = 0;
            this.ButtonToExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(229)))), ((int)(((byte)(247)))));
            this.ButtonToExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.ButtonToExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonToExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(0)))), ((int)(((byte)(93)))));
            this.ButtonToExit.Location = new System.Drawing.Point(1536, 0);
            this.ButtonToExit.Name = "ButtonToExit";
            this.ButtonToExit.Size = new System.Drawing.Size(64, 59);
            this.ButtonToExit.TabIndex = 6;
            this.ButtonToExit.UseVisualStyleBackColor = true;
            this.ButtonToExit.Click += new System.EventHandler(this.ButtonToExit_Click);
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(189)))), ((int)(((byte)(244)))));
            this.labelMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMain.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(3)))));
            this.labelMain.Location = new System.Drawing.Point(3, 18);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(1032, 54);
            this.labelMain.TabIndex = 7;
            this.labelMain.Text = "Пошук найкоротшого шляху у зважених графах.✅";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionLabel.ForeColor = System.Drawing.Color.White;
            this.DescriptionLabel.Location = new System.Drawing.Point(3, 114);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(1005, 310);
            this.DescriptionLabel.TabIndex = 8;
            this.DescriptionLabel.Text = resources.GetString("DescriptionLabel.Text");
            // 
            // labelEnter
            // 
            this.labelEnter.AutoSize = true;
            this.labelEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.labelEnter.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnter.ForeColor = System.Drawing.Color.White;
            this.labelEnter.Location = new System.Drawing.Point(-5, 476);
            this.labelEnter.Name = "labelEnter";
            this.labelEnter.Size = new System.Drawing.Size(711, 31);
            this.labelEnter.TabIndex = 9;
            this.labelEnter.Text = "Щоб розпочати, задайте граф ваговою матрицею суміжності ▶️";
            // 
            // BeginButton
            // 
            this.BeginButton.AutoSize = true;
            this.BeginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(4)))), ((int)(((byte)(211)))));
            this.BeginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BeginButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(3)))));
            this.BeginButton.FlatAppearance.BorderSize = 0;
            this.BeginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(2)))), ((int)(((byte)(127)))));
            this.BeginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(151)))), ((int)(((byte)(254)))));
            this.BeginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BeginButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BeginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(3)))));
            this.BeginButton.Location = new System.Drawing.Point(779, 465);
            this.BeginButton.Name = "BeginButton";
            this.BeginButton.Size = new System.Drawing.Size(256, 48);
            this.BeginButton.TabIndex = 10;
            this.BeginButton.Text = "Ввести матрицю";
            this.BeginButton.UseVisualStyleBackColor = false;
            this.BeginButton.Click += new System.EventHandler(this.BeginButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.MainPanel.Controls.Add(this.labelMain);
            this.MainPanel.Controls.Add(this.BeginButton);
            this.MainPanel.Controls.Add(this.DescriptionLabel);
            this.MainPanel.Controls.Add(this.labelEnter);
            this.MainPanel.Location = new System.Drawing.Point(30, 159);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1174, 607);
            this.MainPanel.TabIndex = 11;
            // 
            // MainPictureBox
            // 
            this.MainPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MainPictureBox.Image")));
            this.MainPictureBox.Location = new System.Drawing.Point(0, 0);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPictureBox.Size = new System.Drawing.Size(1600, 900);
            this.MainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainPictureBox.TabIndex = 12;
            this.MainPictureBox.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(77)))), ((int)(((byte)(142)))));
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.ControlBox = false;
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.MainPictureBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button ButtonToExit;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label labelEnter;
        private System.Windows.Forms.Button BeginButton;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.PictureBox MainPictureBox;
    }
}

