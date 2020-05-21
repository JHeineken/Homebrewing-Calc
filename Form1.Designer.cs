namespace BeerCalculator
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
            this.RadioButton1gal = new System.Windows.Forms.RadioButton();
            this.RadioButton3gal = new System.Windows.Forms.RadioButton();
            this.PoundsTextBox1 = new System.Windows.Forms.TextBox();
            this.GravityTextBox1 = new System.Windows.Forms.TextBox();
            this.poundsLabel = new System.Windows.Forms.Label();
            this.gravityLabel = new System.Windows.Forms.Label();
            this.SRMTextBox1 = new System.Windows.Forms.TextBox();
            this.srmLabel = new System.Windows.Forms.Label();
            this.grain1Label = new System.Windows.Forms.Label();
            this.grain2Label = new System.Windows.Forms.Label();
            this.PoundsTextBox2 = new System.Windows.Forms.TextBox();
            this.SRMTextBox2 = new System.Windows.Forms.TextBox();
            this.GravityTextBox2 = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.estimatedOGLabel = new System.Windows.Forms.Label();
            this.EstimatedColorTextBox = new System.Windows.Forms.TextBox();
            this.EstimatedOGTextBox = new System.Windows.Forms.TextBox();
            this.estimatedColorLabel = new System.Windows.Forms.Label();
            this.batchSizeLabel = new System.Windows.Forms.Label();
            this.RadioButton5gal = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RadioButton1gal
            // 
            this.RadioButton1gal.AutoSize = true;
            this.RadioButton1gal.Checked = true;
            this.RadioButton1gal.Location = new System.Drawing.Point(503, 48);
            this.RadioButton1gal.Name = "RadioButton1gal";
            this.RadioButton1gal.Size = new System.Drawing.Size(82, 21);
            this.RadioButton1gal.TabIndex = 0;
            this.RadioButton1gal.TabStop = true;
            this.RadioButton1gal.Text = "1 Gallon";
            this.RadioButton1gal.UseVisualStyleBackColor = true;
            // 
            // RadioButton3gal
            // 
            this.RadioButton3gal.AutoSize = true;
            this.RadioButton3gal.Location = new System.Drawing.Point(503, 93);
            this.RadioButton3gal.Name = "RadioButton3gal";
            this.RadioButton3gal.Size = new System.Drawing.Size(89, 21);
            this.RadioButton3gal.TabIndex = 1;
            this.RadioButton3gal.Text = "3 Gallons";
            this.RadioButton3gal.UseVisualStyleBackColor = true;
            // 
            // PoundsTextBox1
            // 
            this.PoundsTextBox1.Location = new System.Drawing.Point(123, 48);
            this.PoundsTextBox1.Name = "PoundsTextBox1";
            this.PoundsTextBox1.Size = new System.Drawing.Size(100, 22);
            this.PoundsTextBox1.TabIndex = 2;
            this.PoundsTextBox1.Text = "0.0";
            // 
            // GravityTextBox1
            // 
            this.GravityTextBox1.Location = new System.Drawing.Point(229, 47);
            this.GravityTextBox1.Name = "GravityTextBox1";
            this.GravityTextBox1.Size = new System.Drawing.Size(100, 22);
            this.GravityTextBox1.TabIndex = 3;
            this.GravityTextBox1.Text = "0";
            // 
            // poundsLabel
            // 
            this.poundsLabel.AutoSize = true;
            this.poundsLabel.Location = new System.Drawing.Point(142, 18);
            this.poundsLabel.Name = "poundsLabel";
            this.poundsLabel.Size = new System.Drawing.Size(56, 17);
            this.poundsLabel.TabIndex = 4;
            this.poundsLabel.Text = "Pounds";
            // 
            // gravityLabel
            // 
            this.gravityLabel.AutoSize = true;
            this.gravityLabel.Location = new System.Drawing.Point(233, 18);
            this.gravityLabel.Name = "gravityLabel";
            this.gravityLabel.Size = new System.Drawing.Size(96, 17);
            this.gravityLabel.TabIndex = 5;
            this.gravityLabel.Text = "Gravity Points";
            // 
            // SRMTextBox1
            // 
            this.SRMTextBox1.Location = new System.Drawing.Point(335, 47);
            this.SRMTextBox1.Name = "SRMTextBox1";
            this.SRMTextBox1.Size = new System.Drawing.Size(100, 22);
            this.SRMTextBox1.TabIndex = 6;
            this.SRMTextBox1.Text = "0";
            // 
            // srmLabel
            // 
            this.srmLabel.AutoSize = true;
            this.srmLabel.Location = new System.Drawing.Point(352, 18);
            this.srmLabel.Name = "srmLabel";
            this.srmLabel.Size = new System.Drawing.Size(66, 17);
            this.srmLabel.TabIndex = 7;
            this.srmLabel.Text = "Lovibond";
            // 
            // grain1Label
            // 
            this.grain1Label.AutoSize = true;
            this.grain1Label.Location = new System.Drawing.Point(31, 53);
            this.grain1Label.Name = "grain1Label";
            this.grain1Label.Size = new System.Drawing.Size(55, 17);
            this.grain1Label.TabIndex = 8;
            this.grain1Label.Text = "Grain 1";
            // 
            // grain2Label
            // 
            this.grain2Label.AutoSize = true;
            this.grain2Label.Location = new System.Drawing.Point(31, 120);
            this.grain2Label.Name = "grain2Label";
            this.grain2Label.Size = new System.Drawing.Size(55, 17);
            this.grain2Label.TabIndex = 9;
            this.grain2Label.Text = "Grain 2";
            // 
            // PoundsTextBox2
            // 
            this.PoundsTextBox2.Location = new System.Drawing.Point(123, 120);
            this.PoundsTextBox2.Name = "PoundsTextBox2";
            this.PoundsTextBox2.Size = new System.Drawing.Size(100, 22);
            this.PoundsTextBox2.TabIndex = 10;
            this.PoundsTextBox2.Text = "0.0";
            // 
            // SRMTextBox2
            // 
            this.SRMTextBox2.Location = new System.Drawing.Point(335, 120);
            this.SRMTextBox2.Name = "SRMTextBox2";
            this.SRMTextBox2.Size = new System.Drawing.Size(100, 22);
            this.SRMTextBox2.TabIndex = 11;
            this.SRMTextBox2.Text = "0";
            // 
            // GravityTextBox2
            // 
            this.GravityTextBox2.Location = new System.Drawing.Point(229, 120);
            this.GravityTextBox2.Name = "GravityTextBox2";
            this.GravityTextBox2.Size = new System.Drawing.Size(100, 22);
            this.GravityTextBox2.TabIndex = 12;
            this.GravityTextBox2.Text = "0";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(34, 172);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(100, 40);
            this.CalculateButton.TabIndex = 13;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButtonClick);
            // 
            // estimatedOGLabel
            // 
            this.estimatedOGLabel.AutoSize = true;
            this.estimatedOGLabel.Location = new System.Drawing.Point(173, 209);
            this.estimatedOGLabel.Name = "estimatedOGLabel";
            this.estimatedOGLabel.Size = new System.Drawing.Size(96, 17);
            this.estimatedOGLabel.TabIndex = 14;
            this.estimatedOGLabel.Text = "Estimated OG";
            // 
            // EstimatedColorTextBox
            // 
            this.EstimatedColorTextBox.Location = new System.Drawing.Point(314, 240);
            this.EstimatedColorTextBox.Multiline = true;
            this.EstimatedColorTextBox.Name = "EstimatedColorTextBox";
            this.EstimatedColorTextBox.Size = new System.Drawing.Size(116, 22);
            this.EstimatedColorTextBox.TabIndex = 15;
            this.EstimatedColorTextBox.Text = "0";
            // 
            // EstimatedOGTextBox
            // 
            this.EstimatedOGTextBox.Location = new System.Drawing.Point(169, 240);
            this.EstimatedOGTextBox.Name = "EstimatedOGTextBox";
            this.EstimatedOGTextBox.Size = new System.Drawing.Size(100, 22);
            this.EstimatedOGTextBox.TabIndex = 16;
            this.EstimatedOGTextBox.Text = "0.00";
            // 
            // estimatedColorLabel
            // 
            this.estimatedColorLabel.AutoSize = true;
            this.estimatedColorLabel.Location = new System.Drawing.Point(311, 209);
            this.estimatedColorLabel.Name = "estimatedColorLabel";
            this.estimatedColorLabel.Size = new System.Drawing.Size(151, 17);
            this.estimatedColorLabel.TabIndex = 17;
            this.estimatedColorLabel.Text = "Estimated Color (SRM)";
            // 
            // batchSizeLabel
            // 
            this.batchSizeLabel.AutoSize = true;
            this.batchSizeLabel.Location = new System.Drawing.Point(510, 18);
            this.batchSizeLabel.Name = "batchSizeLabel";
            this.batchSizeLabel.Size = new System.Drawing.Size(75, 17);
            this.batchSizeLabel.TabIndex = 18;
            this.batchSizeLabel.Text = "Batch Size";
            // 
            // RadioButton5gal
            // 
            this.RadioButton5gal.AutoSize = true;
            this.RadioButton5gal.Location = new System.Drawing.Point(503, 140);
            this.RadioButton5gal.Name = "RadioButton5gal";
            this.RadioButton5gal.Size = new System.Drawing.Size(89, 21);
            this.RadioButton5gal.TabIndex = 19;
            this.RadioButton5gal.TabStop = true;
            this.RadioButton5gal.Text = "5 Gallons";
            this.RadioButton5gal.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::BeerCalculator.Properties.Resources.ColorChart1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 268);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RadioButton5gal);
            this.Controls.Add(this.batchSizeLabel);
            this.Controls.Add(this.estimatedColorLabel);
            this.Controls.Add(this.EstimatedOGTextBox);
            this.Controls.Add(this.EstimatedColorTextBox);
            this.Controls.Add(this.estimatedOGLabel);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.GravityTextBox2);
            this.Controls.Add(this.SRMTextBox2);
            this.Controls.Add(this.PoundsTextBox2);
            this.Controls.Add(this.grain2Label);
            this.Controls.Add(this.grain1Label);
            this.Controls.Add(this.srmLabel);
            this.Controls.Add(this.SRMTextBox1);
            this.Controls.Add(this.gravityLabel);
            this.Controls.Add(this.poundsLabel);
            this.Controls.Add(this.GravityTextBox1);
            this.Controls.Add(this.PoundsTextBox1);
            this.Controls.Add(this.RadioButton3gal);
            this.Controls.Add(this.RadioButton1gal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Brewing Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RadioButton1gal;
        private System.Windows.Forms.RadioButton RadioButton3gal;
        private System.Windows.Forms.TextBox PoundsTextBox1;
        private System.Windows.Forms.TextBox GravityTextBox1;
        private System.Windows.Forms.Label poundsLabel;
        private System.Windows.Forms.Label gravityLabel;
        private System.Windows.Forms.TextBox SRMTextBox1;
        private System.Windows.Forms.Label srmLabel;
        private System.Windows.Forms.Label grain1Label;
        private System.Windows.Forms.Label grain2Label;
        private System.Windows.Forms.TextBox PoundsTextBox2;
        private System.Windows.Forms.TextBox SRMTextBox2;
        private System.Windows.Forms.TextBox GravityTextBox2;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label estimatedOGLabel;
        private System.Windows.Forms.TextBox EstimatedColorTextBox;
        private System.Windows.Forms.TextBox EstimatedOGTextBox;
        private System.Windows.Forms.Label estimatedColorLabel;
        private System.Windows.Forms.Label batchSizeLabel;
        private System.Windows.Forms.RadioButton RadioButton5gal;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

