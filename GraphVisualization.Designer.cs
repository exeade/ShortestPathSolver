namespace ShortestPathSolver
{
    partial class GraphVisualization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphVisualization));
            this.graphPanel = new System.Windows.Forms.Panel();
            this.GraphPicPanel = new System.Windows.Forms.Panel();
            this.GraphCreatedLabel = new System.Windows.Forms.Label();
            this.EnterVerteciesLabel = new System.Windows.Forms.Label();
            this.StartLabel = new System.Windows.Forms.Label();
            this.buttonToExit = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.StartButton = new System.Windows.Forms.Button();
            this.EndVertPanel = new System.Windows.Forms.Panel();
            this.StartVertPanel = new System.Windows.Forms.Panel();
            this.EndLabel = new System.Windows.Forms.Label();
            this.graphPanel.SuspendLayout();
            this.GraphPicPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // graphPanel
            // 
            this.graphPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(189)))), ((int)(((byte)(244)))));
            this.graphPanel.Controls.Add(this.GraphPicPanel);
            this.graphPanel.Location = new System.Drawing.Point(727, 65);
            this.graphPanel.Name = "graphPanel";
            this.graphPanel.Size = new System.Drawing.Size(823, 823);
            this.graphPanel.TabIndex = 8;
            // 
            // GraphPicPanel
            // 
            this.GraphPicPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(7)))), ((int)(((byte)(143)))));
            this.GraphPicPanel.Controls.Add(this.GraphCreatedLabel);
            this.GraphPicPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GraphPicPanel.Location = new System.Drawing.Point(0, 0);
            this.GraphPicPanel.Name = "GraphPicPanel";
            this.GraphPicPanel.Size = new System.Drawing.Size(823, 34);
            this.GraphPicPanel.TabIndex = 10;
            // 
            // GraphCreatedLabel
            // 
            this.GraphCreatedLabel.AutoSize = true;
            this.GraphCreatedLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(7)))), ((int)(((byte)(143)))));
            this.GraphCreatedLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.GraphCreatedLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.GraphCreatedLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GraphCreatedLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GraphCreatedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(189)))), ((int)(((byte)(244)))));
            this.GraphCreatedLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GraphCreatedLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GraphCreatedLabel.Location = new System.Drawing.Point(0, 0);
            this.GraphCreatedLabel.Name = "GraphCreatedLabel";
            this.GraphCreatedLabel.Size = new System.Drawing.Size(247, 25);
            this.GraphCreatedLabel.TabIndex = 9;
            this.GraphCreatedLabel.Text = "Граф було задано успішно";
            this.GraphCreatedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EnterVerteciesLabel
            // 
            this.EnterVerteciesLabel.AutoSize = true;
            this.EnterVerteciesLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.EnterVerteciesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterVerteciesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(189)))), ((int)(((byte)(244)))));
            this.EnterVerteciesLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EnterVerteciesLabel.Location = new System.Drawing.Point(5, 9);
            this.EnterVerteciesLabel.Name = "EnterVerteciesLabel";
            this.EnterVerteciesLabel.Size = new System.Drawing.Size(429, 56);
            this.EnterVerteciesLabel.TabIndex = 10;
            this.EnterVerteciesLabel.Text = "Для пошуку найкоротшого шляху, оберіть\r\n стартову та кінцеву вершини\r\n";
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(189)))), ((int)(((byte)(244)))));
            this.StartLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(3)))));
            this.StartLabel.Location = new System.Drawing.Point(5, 110);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(107, 31);
            this.StartLabel.TabIndex = 12;
            this.StartLabel.Text = "Старт🅰";
            // 
            // buttonToExit
            // 
            this.buttonToExit.AutoSize = true;
            this.buttonToExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonToExit.BackgroundImage")));
            this.buttonToExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonToExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonToExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonToExit.FlatAppearance.BorderSize = 0;
            this.buttonToExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(77)))), ((int)(((byte)(201)))));
            this.buttonToExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.buttonToExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(0)))), ((int)(((byte)(93)))));
            this.buttonToExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonToExit.Location = new System.Drawing.Point(1536, 0);
            this.buttonToExit.Name = "buttonToExit";
            this.buttonToExit.Size = new System.Drawing.Size(64, 59);
            this.buttonToExit.TabIndex = 6;
            this.buttonToExit.UseVisualStyleBackColor = true;
            this.buttonToExit.Click += new System.EventHandler(this.ButtonToExit_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(3)))));
            this.TopPanel.Controls.Add(this.buttonToExit);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1600, 59);
            this.TopPanel.TabIndex = 13;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1600, 900);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.MainPanel.Controls.Add(this.StartButton);
            this.MainPanel.Controls.Add(this.EndVertPanel);
            this.MainPanel.Controls.Add(this.StartVertPanel);
            this.MainPanel.Controls.Add(this.EndLabel);
            this.MainPanel.Controls.Add(this.EnterVerteciesLabel);
            this.MainPanel.Controls.Add(this.StartLabel);
            this.MainPanel.Location = new System.Drawing.Point(65, 65);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(616, 806);
            this.MainPanel.TabIndex = 16;
            // 
            // StartButton
            // 
            this.StartButton.AutoSize = true;
            this.StartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(4)))), ((int)(((byte)(211)))));
            this.StartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StartButton.FlatAppearance.BorderSize = 0;
            this.StartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(2)))), ((int)(((byte)(127)))));
            this.StartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(151)))), ((int)(((byte)(254)))));
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(146, 99);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(206, 52);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Знайти шлях 🔀";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // EndVertPanel
            // 
            this.EndVertPanel.Location = new System.Drawing.Point(401, 144);
            this.EndVertPanel.Name = "EndVertPanel";
            this.EndVertPanel.Size = new System.Drawing.Size(236, 638);
            this.EndVertPanel.TabIndex = 15;
            // 
            // StartVertPanel
            // 
            this.StartVertPanel.Location = new System.Drawing.Point(10, 144);
            this.StartVertPanel.Name = "StartVertPanel";
            this.StartVertPanel.Size = new System.Drawing.Size(236, 638);
            this.StartVertPanel.TabIndex = 14;
            // 
            // EndLabel
            // 
            this.EndLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(189)))), ((int)(((byte)(244)))));
            this.EndLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(3)))));
            this.EndLabel.Location = new System.Drawing.Point(395, 110);
            this.EndLabel.Name = "EndLabel";
            this.EndLabel.Size = new System.Drawing.Size(132, 31);
            this.EndLabel.TabIndex = 13;
            this.EndLabel.Text = "Кінець🅱";
            // 
            // GraphVisualization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.ControlBox = false;
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.graphPanel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GraphVisualization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Граф";
            this.graphPanel.ResumeLayout(false);
            this.GraphPicPanel.ResumeLayout(false);
            this.GraphPicPanel.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel graphPanel;
        private System.Windows.Forms.Label EnterVerteciesLabel;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.Button buttonToExit;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label EndLabel;
        private System.Windows.Forms.Panel StartVertPanel;
        private System.Windows.Forms.Panel EndVertPanel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Panel GraphPicPanel;
        private System.Windows.Forms.Label GraphCreatedLabel;
    }
}