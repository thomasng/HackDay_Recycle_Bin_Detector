namespace RecycleApp
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
            this.webCameraControl1 = new WebEye.Controls.WinForms.WebCameraControl.WebCameraControl();
            this.comboBoxCameraType = new System.Windows.Forms.ComboBox();
            this.imageButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.ResultText = new System.Windows.Forms.Label();
            this.StatisticText = new System.Windows.Forms.Label();
            this.btnMixedBin = new System.Windows.Forms.Button();
            this.btnOrganicbin = new System.Windows.Forms.Button();
            this.btnPapaerBin = new System.Windows.Forms.Button();
            this.btnLandFillBin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // webCameraControl1
            // 
            this.webCameraControl1.Location = new System.Drawing.Point(12, 12);
            this.webCameraControl1.Name = "webCameraControl1";
            this.webCameraControl1.Size = new System.Drawing.Size(383, 292);
            this.webCameraControl1.TabIndex = 1;
            // 
            // comboBoxCameraType
            // 
            this.comboBoxCameraType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxCameraType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCameraType.FormattingEnabled = true;
            this.comboBoxCameraType.Location = new System.Drawing.Point(10, 458);
            this.comboBoxCameraType.Name = "comboBoxCameraType";
            this.comboBoxCameraType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCameraType.TabIndex = 4;
            this.comboBoxCameraType.SelectedIndexChanged += new System.EventHandler(this.comboBoxCameraType_SelectedIndexChanged);
            // 
            // imageButton
            // 
            this.imageButton.Enabled = false;
            this.imageButton.Location = new System.Drawing.Point(75, 323);
            this.imageButton.Margin = new System.Windows.Forms.Padding(2);
            this.imageButton.Name = "imageButton";
            this.imageButton.Size = new System.Drawing.Size(183, 55);
            this.imageButton.TabIndex = 7;
            this.imageButton.Text = "Capture";
            this.imageButton.UseVisualStyleBackColor = true;
            this.imageButton.Click += new System.EventHandler(this.imageButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(224, 458);
            this.stopButton.Margin = new System.Windows.Forms.Padding(2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 6;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(140, 458);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // ResultText
            // 
            this.ResultText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ResultText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultText.ForeColor = System.Drawing.Color.Maroon;
            this.ResultText.Location = new System.Drawing.Point(12, 390);
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(300, 57);
            this.ResultText.TabIndex = 8;
            this.ResultText.Text = "Result Text";
            this.ResultText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatisticText
            // 
            this.StatisticText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatisticText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatisticText.ForeColor = System.Drawing.Color.Maroon;
            this.StatisticText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StatisticText.Location = new System.Drawing.Point(401, 12);
            this.StatisticText.Name = "StatisticText";
            this.StatisticText.Size = new System.Drawing.Size(192, 304);
            this.StatisticText.TabIndex = 9;
            this.StatisticText.Text = "StatisticText";
            this.StatisticText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMixedBin
            // 
            this.btnMixedBin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMixedBin.Location = new System.Drawing.Point(634, 98);
            this.btnMixedBin.Name = "btnMixedBin";
            this.btnMixedBin.Size = new System.Drawing.Size(154, 50);
            this.btnMixedBin.TabIndex = 10;
            this.btnMixedBin.Text = "Mixed Recycle Bin";
            this.btnMixedBin.UseVisualStyleBackColor = true;
            this.btnMixedBin.Click += new System.EventHandler(this.btnMixedBin_Click);
            // 
            // btnOrganicbin
            // 
            this.btnOrganicbin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrganicbin.Location = new System.Drawing.Point(634, 171);
            this.btnOrganicbin.Name = "btnOrganicbin";
            this.btnOrganicbin.Size = new System.Drawing.Size(154, 50);
            this.btnOrganicbin.TabIndex = 11;
            this.btnOrganicbin.Text = "Organic Recycle Bin";
            this.btnOrganicbin.UseVisualStyleBackColor = true;
            this.btnOrganicbin.Click += new System.EventHandler(this.btnOrganicbin_Click);
            // 
            // btnPapaerBin
            // 
            this.btnPapaerBin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPapaerBin.Location = new System.Drawing.Point(634, 240);
            this.btnPapaerBin.Name = "btnPapaerBin";
            this.btnPapaerBin.Size = new System.Drawing.Size(154, 50);
            this.btnPapaerBin.TabIndex = 12;
            this.btnPapaerBin.Text = "Paper Recycle Bin";
            this.btnPapaerBin.UseVisualStyleBackColor = true;
            this.btnPapaerBin.Click += new System.EventHandler(this.btnPapaerBin_Click);
            // 
            // btnLandFillBin
            // 
            this.btnLandFillBin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLandFillBin.Location = new System.Drawing.Point(634, 313);
            this.btnLandFillBin.Name = "btnLandFillBin";
            this.btnLandFillBin.Size = new System.Drawing.Size(154, 50);
            this.btnLandFillBin.TabIndex = 13;
            this.btnLandFillBin.Text = "Land fill Bin";
            this.btnLandFillBin.UseVisualStyleBackColor = true;
            this.btnLandFillBin.Click += new System.EventHandler(this.btnLandFillBin_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(634, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 83);
            this.label1.TabIndex = 14;
            this.label1.Text = "If incorrect, please select one of below bin for machine learning";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLandFillBin);
            this.Controls.Add(this.btnPapaerBin);
            this.Controls.Add(this.btnOrganicbin);
            this.Controls.Add(this.btnMixedBin);
            this.Controls.Add(this.StatisticText);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.comboBoxCameraType);
            this.Controls.Add(this.imageButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.webCameraControl1);
            this.Name = "MainForm";
            this.Text = "MYOB Recycle Bin Detector  App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private WebEye.Controls.WinForms.WebCameraControl.WebCameraControl webCameraControl1;
        private System.Windows.Forms.ComboBox comboBoxCameraType;
        private System.Windows.Forms.Button imageButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label ResultText;
        private System.Windows.Forms.Label StatisticText;
        private System.Windows.Forms.Button btnMixedBin;
        private System.Windows.Forms.Button btnOrganicbin;
        private System.Windows.Forms.Button btnPapaerBin;
        private System.Windows.Forms.Button btnLandFillBin;
        private System.Windows.Forms.Label label1;
    }
}

