namespace Bottle.UI
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StartKompasButton = new System.Windows.Forms.Button();
            this.CloseKompasButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BuildButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.BottleneckDiameterTextBox = new System.Windows.Forms.TextBox();
            this.BaseDiameterTextBox = new System.Windows.Forms.TextBox();
            this.BottleneckLengthTextBox = new System.Windows.Forms.TextBox();
            this.BaseLengthTextBox = new System.Windows.Forms.TextBox();
            this.LengthFullBottleTextBox = new System.Windows.Forms.TextBox();
            this.BottleneckDiameterLabel = new System.Windows.Forms.Label();
            this.BaseDiameterLabel = new System.Windows.Forms.Label();
            this.BottleneckLengthLabel = new System.Windows.Forms.Label();
            this.BaseLengthLabel = new System.Windows.Forms.Label();
            this.LangthFullBottleLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StartKompasButton);
            this.groupBox1.Controls.Add(this.CloseKompasButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "КОМПAС-3D";
            // 
            // StartKompasButton
            // 
            this.StartKompasButton.Location = new System.Drawing.Point(230, 39);
            this.StartKompasButton.Name = "StartKompasButton";
            this.StartKompasButton.Size = new System.Drawing.Size(100, 30);
            this.StartKompasButton.TabIndex = 11;
            this.StartKompasButton.Text = "Запустить";
            this.StartKompasButton.UseVisualStyleBackColor = true;
            this.StartKompasButton.Click += new System.EventHandler(this.StartKompasButton_Click);
            // 
            // CloseKompasButton
            // 
            this.CloseKompasButton.Location = new System.Drawing.Point(124, 39);
            this.CloseKompasButton.Name = "CloseKompasButton";
            this.CloseKompasButton.Size = new System.Drawing.Size(100, 30);
            this.CloseKompasButton.TabIndex = 10;
            this.CloseKompasButton.Text = "Закрыть";
            this.CloseKompasButton.UseVisualStyleBackColor = true;
            this.CloseKompasButton.Click += new System.EventHandler(this.CloseKompasButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BuildButton);
            this.groupBox2.Controls.Add(this.ClearButton);
            this.groupBox2.Controls.Add(this.BottleneckDiameterTextBox);
            this.groupBox2.Controls.Add(this.BaseDiameterTextBox);
            this.groupBox2.Controls.Add(this.BottleneckLengthTextBox);
            this.groupBox2.Controls.Add(this.BaseLengthTextBox);
            this.groupBox2.Controls.Add(this.LengthFullBottleTextBox);
            this.groupBox2.Controls.Add(this.BottleneckDiameterLabel);
            this.groupBox2.Controls.Add(this.BaseDiameterLabel);
            this.groupBox2.Controls.Add(this.BottleneckLengthLabel);
            this.groupBox2.Controls.Add(this.BaseLengthLabel);
            this.groupBox2.Controls.Add(this.LangthFullBottleLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 222);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Бутылка";
            // 
            // BuildButton
            // 
            this.BuildButton.Location = new System.Drawing.Point(230, 186);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(100, 30);
            this.BuildButton.TabIndex = 12;
            this.BuildButton.Text = "Построить";
            this.BuildButton.UseVisualStyleBackColor = true;
            this.BuildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(124, 186);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(100, 30);
            this.ClearButton.TabIndex = 11;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // BottleneckDiameterTextBox
            // 
            this.BottleneckDiameterTextBox.Location = new System.Drawing.Point(160, 145);
            this.BottleneckDiameterTextBox.Name = "BottleneckDiameterTextBox";
            this.BottleneckDiameterTextBox.Size = new System.Drawing.Size(170, 22);
            this.BottleneckDiameterTextBox.TabIndex = 9;
            this.BottleneckDiameterTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // BaseDiameterTextBox
            // 
            this.BaseDiameterTextBox.Location = new System.Drawing.Point(160, 117);
            this.BaseDiameterTextBox.Name = "BaseDiameterTextBox";
            this.BaseDiameterTextBox.Size = new System.Drawing.Size(170, 22);
            this.BaseDiameterTextBox.TabIndex = 8;
            this.BaseDiameterTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // BottleneckLengthTextBox
            // 
            this.BottleneckLengthTextBox.Location = new System.Drawing.Point(160, 89);
            this.BottleneckLengthTextBox.Name = "BottleneckLengthTextBox";
            this.BottleneckLengthTextBox.Size = new System.Drawing.Size(170, 22);
            this.BottleneckLengthTextBox.TabIndex = 7;
            this.BottleneckLengthTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // BaseLengthTextBox
            // 
            this.BaseLengthTextBox.Location = new System.Drawing.Point(160, 61);
            this.BaseLengthTextBox.Name = "BaseLengthTextBox";
            this.BaseLengthTextBox.Size = new System.Drawing.Size(170, 22);
            this.BaseLengthTextBox.TabIndex = 6;
            this.BaseLengthTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // LengthFullBottleTextBox
            // 
            this.LengthFullBottleTextBox.Location = new System.Drawing.Point(160, 33);
            this.LengthFullBottleTextBox.Name = "LengthFullBottleTextBox";
            this.LengthFullBottleTextBox.Size = new System.Drawing.Size(170, 22);
            this.LengthFullBottleTextBox.TabIndex = 5;
            this.LengthFullBottleTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // BottleneckDiameterLabel
            // 
            this.BottleneckDiameterLabel.AutoSize = true;
            this.BottleneckDiameterLabel.Location = new System.Drawing.Point(6, 150);
            this.BottleneckDiameterLabel.Name = "BottleneckDiameterLabel";
            this.BottleneckDiameterLabel.Size = new System.Drawing.Size(136, 17);
            this.BottleneckDiameterLabel.TabIndex = 4;
            this.BottleneckDiameterLabel.Text = "Диаметр горлышка";
            // 
            // BaseDiameterLabel
            // 
            this.BaseDiameterLabel.AutoSize = true;
            this.BaseDiameterLabel.Location = new System.Drawing.Point(6, 120);
            this.BaseDiameterLabel.Name = "BaseDiameterLabel";
            this.BaseDiameterLabel.Size = new System.Drawing.Size(141, 17);
            this.BaseDiameterLabel.TabIndex = 3;
            this.BaseDiameterLabel.Text = "Диаметр основания";
            // 
            // BottleneckLengthLabel
            // 
            this.BottleneckLengthLabel.AutoSize = true;
            this.BottleneckLengthLabel.Location = new System.Drawing.Point(6, 92);
            this.BottleneckLengthLabel.Name = "BottleneckLengthLabel";
            this.BottleneckLengthLabel.Size = new System.Drawing.Size(126, 17);
            this.BottleneckLengthLabel.TabIndex = 2;
            this.BottleneckLengthLabel.Text = "Высота горлышка";
            // 
            // BaseLengthLabel
            // 
            this.BaseLengthLabel.AutoSize = true;
            this.BaseLengthLabel.Location = new System.Drawing.Point(6, 64);
            this.BaseLengthLabel.Name = "BaseLengthLabel";
            this.BaseLengthLabel.Size = new System.Drawing.Size(131, 17);
            this.BaseLengthLabel.TabIndex = 1;
            this.BaseLengthLabel.Text = "Высота основания";
            // 
            // LangthFullBottleLabel
            // 
            this.LangthFullBottleLabel.AutoSize = true;
            this.LangthFullBottleLabel.Location = new System.Drawing.Point(6, 36);
            this.LangthFullBottleLabel.Name = "LangthFullBottleLabel";
            this.LangthFullBottleLabel.Size = new System.Drawing.Size(116, 17);
            this.LangthFullBottleLabel.TabIndex = 0;
            this.LangthFullBottleLabel.Text = "Высота бутылки";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 327);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "КОМПАС-3D: Бутылка";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button StartKompasButton;
        private System.Windows.Forms.Button CloseKompasButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BuildButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox BottleneckDiameterTextBox;
        private System.Windows.Forms.TextBox BaseDiameterTextBox;
        private System.Windows.Forms.TextBox BottleneckLengthTextBox;
        private System.Windows.Forms.TextBox BaseLengthTextBox;
        private System.Windows.Forms.TextBox LengthFullBottleTextBox;
        private System.Windows.Forms.Label BottleneckDiameterLabel;
        private System.Windows.Forms.Label BaseDiameterLabel;
        private System.Windows.Forms.Label BottleneckLengthLabel;
        private System.Windows.Forms.Label BaseLengthLabel;
        private System.Windows.Forms.Label LangthFullBottleLabel;
    }
}

