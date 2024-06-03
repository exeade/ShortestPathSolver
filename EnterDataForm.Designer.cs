namespace ShortestPathSolver
{
    partial class EnterDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterDataForm));
            this.MatrixSizeField = new System.Windows.Forms.TextBox();
            this.EnterLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.MethodLabel = new System.Windows.Forms.Label();
            this.MethodSelect = new System.Windows.Forms.ComboBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.buttonToExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ShowWeights = new System.Windows.Forms.CheckBox();
            this.Manually = new System.Windows.Forms.RadioButton();
            this.Generation = new System.Windows.Forms.RadioButton();
            this.WayLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TopPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MatrixSizeField
            // 
            this.MatrixSizeField.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MatrixSizeField.BackColor = System.Drawing.Color.LightGray;
            this.MatrixSizeField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MatrixSizeField.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MatrixSizeField.Location = new System.Drawing.Point(11, 67);
            this.MatrixSizeField.Name = "MatrixSizeField";
            this.MatrixSizeField.Size = new System.Drawing.Size(273, 46);
            this.MatrixSizeField.TabIndex = 7;
            this.MatrixSizeField.Enter += new System.EventHandler(this.MatrixSizeField_Enter);
            this.MatrixSizeField.Leave += new System.EventHandler(this.MatrixSizeField_Leave);
            // 
            // EnterLabel
            // 
            this.EnterLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EnterLabel.AutoSize = true;
            this.EnterLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(189)))), ((int)(((byte)(244)))));
            this.EnterLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EnterLabel.Location = new System.Drawing.Point(3, 19);
            this.EnterLabel.Name = "EnterLabel";
            this.EnterLabel.Size = new System.Drawing.Size(683, 45);
            this.EnterLabel.TabIndex = 8;
            this.EnterLabel.Text = "Введіть розмірність матриці(від 2 до 20):";
            // 
            // SubmitButton
            // 
            this.SubmitButton.AutoSize = true;
            this.SubmitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(4)))), ((int)(((byte)(211)))));
            this.SubmitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubmitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(2)))), ((int)(((byte)(127)))));
            this.SubmitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(151)))), ((int)(((byte)(254)))));
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubmitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(3)))));
            this.SubmitButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SubmitButton.Location = new System.Drawing.Point(374, 466);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(202, 50);
            this.SubmitButton.TabIndex = 9;
            this.SubmitButton.Text = "Підтвердити";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // MethodLabel
            // 
            this.MethodLabel.AutoSize = true;
            this.MethodLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.MethodLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MethodLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MethodLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(189)))), ((int)(((byte)(244)))));
            this.MethodLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MethodLabel.Location = new System.Drawing.Point(3, 153);
            this.MethodLabel.Name = "MethodLabel";
            this.MethodLabel.Size = new System.Drawing.Size(468, 45);
            this.MethodLabel.TabIndex = 10;
            this.MethodLabel.Text = "Оберіть метод розв\'язання:";
            // 
            // MethodSelect
            // 
            this.MethodSelect.BackColor = System.Drawing.Color.LightGray;
            this.MethodSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MethodSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MethodSelect.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MethodSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.MethodSelect.FormattingEnabled = true;
            this.MethodSelect.Items.AddRange(new object[] {
            "Метод Дейкстри",
            "Метод Беллмана-Форда",
            "Динамічне програмування"});
            this.MethodSelect.Location = new System.Drawing.Point(11, 201);
            this.MethodSelect.Name = "MethodSelect";
            this.MethodSelect.Size = new System.Drawing.Size(460, 45);
            this.MethodSelect.TabIndex = 11;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(3)))));
            this.TopPanel.Controls.Add(this.buttonToExit);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1600, 59);
            this.TopPanel.TabIndex = 12;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // buttonToExit
            // 
            this.buttonToExit.AutoSize = true;
            this.buttonToExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonToExit.BackgroundImage")));
            this.buttonToExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonToExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonToExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonToExit.FlatAppearance.BorderSize = 0;
            this.buttonToExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(229)))), ((int)(((byte)(247)))));
            this.buttonToExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ShowWeights);
            this.panel1.Controls.Add(this.Manually);
            this.panel1.Controls.Add(this.Generation);
            this.panel1.Controls.Add(this.WayLabel);
            this.panel1.Controls.Add(this.EnterLabel);
            this.panel1.Controls.Add(this.MatrixSizeField);
            this.panel1.Controls.Add(this.SubmitButton);
            this.panel1.Controls.Add(this.MethodSelect);
            this.panel1.Controls.Add(this.MethodLabel);
            this.panel1.Location = new System.Drawing.Point(314, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 545);
            this.panel1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(4)))), ((int)(((byte)(86)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(189)))), ((int)(((byte)(244)))));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(585, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 115);
            this.label2.TabIndex = 21;
            this.label2.Text = "Заповнюючи масив, можете\r\n використовувати елементи від\r\n -10000 до 10000.\r\nЗа не" +
    "обхідності, вводьте дробову\r\nчастину числа через кому.\r\n";
            // 
            // ShowWeights
            // 
            this.ShowWeights.AutoSize = true;
            this.ShowWeights.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowWeights.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(189)))), ((int)(((byte)(244)))));
            this.ShowWeights.Location = new System.Drawing.Point(522, 351);
            this.ShowWeights.Name = "ShowWeights";
            this.ShowWeights.Size = new System.Drawing.Size(355, 80);
            this.ShowWeights.TabIndex = 15;
            this.ShowWeights.Text = "Показувати ваги ребер\r\nна графі";
            this.ShowWeights.UseVisualStyleBackColor = true;
            // 
            // Manually
            // 
            this.Manually.AutoSize = true;
            this.Manually.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Manually.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(189)))), ((int)(((byte)(244)))));
            this.Manually.Location = new System.Drawing.Point(38, 341);
            this.Manually.Name = "Manually";
            this.Manually.Size = new System.Drawing.Size(133, 42);
            this.Manually.TabIndex = 14;
            this.Manually.TabStop = true;
            this.Manually.Text = "Вручну";
            this.Manually.UseVisualStyleBackColor = true;
            // 
            // Generation
            // 
            this.Generation.AutoSize = true;
            this.Generation.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Generation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(189)))), ((int)(((byte)(244)))));
            this.Generation.Location = new System.Drawing.Point(38, 389);
            this.Generation.Name = "Generation";
            this.Generation.Size = new System.Drawing.Size(167, 42);
            this.Generation.TabIndex = 13;
            this.Generation.TabStop = true;
            this.Generation.Text = "Генерація";
            this.Generation.UseVisualStyleBackColor = true;
            // 
            // WayLabel
            // 
            this.WayLabel.AutoSize = true;
            this.WayLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
            this.WayLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WayLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(189)))), ((int)(((byte)(244)))));
            this.WayLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.WayLabel.Location = new System.Drawing.Point(36, 288);
            this.WayLabel.Name = "WayLabel";
            this.WayLabel.Size = new System.Drawing.Size(275, 45);
            this.WayLabel.TabIndex = 12;
            this.WayLabel.Text = "Спосіб задання:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1600, 900);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // EnterDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(77)))), ((int)(((byte)(142)))));
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EnterDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пошук найкоротшого шляху";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox MatrixSizeField;
        private System.Windows.Forms.Label EnterLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label MethodLabel;
        private System.Windows.Forms.ComboBox MethodSelect;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button buttonToExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton Manually;
        private System.Windows.Forms.RadioButton Generation;
        private System.Windows.Forms.Label WayLabel;
        private System.Windows.Forms.CheckBox ShowWeights;
        private System.Windows.Forms.Label label2;
    }
}