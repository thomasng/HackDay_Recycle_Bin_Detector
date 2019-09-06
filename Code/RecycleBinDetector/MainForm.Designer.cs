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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // webCameraControl1
            // 
            this.webCameraControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webCameraControl1.Location = new System.Drawing.Point(12, 12);
            this.webCameraControl1.Name = "webCameraControl1";
            this.webCameraControl1.Size = new System.Drawing.Size(755, 425);
            this.webCameraControl1.TabIndex = 1;
            // 
            // comboBoxCameraType
            // 
            this.comboBoxCameraType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCameraType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCameraType.FormattingEnabled = true;
            this.comboBoxCameraType.Location = new System.Drawing.Point(840, 647);
            this.comboBoxCameraType.Name = "comboBoxCameraType";
            this.comboBoxCameraType.Size = new System.Drawing.Size(87, 21);
            this.comboBoxCameraType.TabIndex = 4;
            this.comboBoxCameraType.SelectedIndexChanged += new System.EventHandler(this.comboBoxCameraType_SelectedIndexChanged);
            // 
            // imageButton
            // 
            this.imageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.imageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imageButton.BackgroundImage")));
            this.imageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageButton.Enabled = false;
            this.imageButton.Location = new System.Drawing.Point(11, 455);
            this.imageButton.Margin = new System.Windows.Forms.Padding(2);
            this.imageButton.Name = "imageButton";
            this.imageButton.Size = new System.Drawing.Size(232, 213);
            this.imageButton.TabIndex = 7;
            this.imageButton.Text = "Capture";
            this.imageButton.UseVisualStyleBackColor = true;
            this.imageButton.Click += new System.EventHandler(this.imageButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(985, 647);
            this.stopButton.Margin = new System.Windows.Forms.Padding(2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(49, 23);
            this.stopButton.TabIndex = 6;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(932, 647);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(49, 23);
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
            this.ResultText.Location = new System.Drawing.Point(507, 507);
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(301, 105);
            this.ResultText.TabIndex = 8;
            this.ResultText.Text = "Result Text";
            this.ResultText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatisticText
            // 
            this.StatisticText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StatisticText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatisticText.ForeColor = System.Drawing.Color.Maroon;
            this.StatisticText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StatisticText.Location = new System.Drawing.Point(860, 538);
            this.StatisticText.Name = "StatisticText";
            this.StatisticText.Size = new System.Drawing.Size(163, 97);
            this.StatisticText.TabIndex = 9;
            this.StatisticText.Text = "StatisticText";
            this.StatisticText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StatisticText.Click += new System.EventHandler(this.StatisticText_Click);
            // 
            // btnMixedBin
            // 
            this.btnMixedBin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMixedBin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMixedBin.BackgroundImage")));
            this.btnMixedBin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMixedBin.Location = new System.Drawing.Point(773, 12);
            this.btnMixedBin.Name = "btnMixedBin";
            this.btnMixedBin.Size = new System.Drawing.Size(129, 205);
            this.btnMixedBin.TabIndex = 10;
            this.btnMixedBin.UseVisualStyleBackColor = true;
            this.btnMixedBin.Click += new System.EventHandler(this.btnMixedBin_Click);
            // 
            // btnOrganicbin
            // 
            this.btnOrganicbin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrganicbin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOrganicbin.BackgroundImage")));
            this.btnOrganicbin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOrganicbin.Location = new System.Drawing.Point(908, 12);
            this.btnOrganicbin.Name = "btnOrganicbin";
            this.btnOrganicbin.Size = new System.Drawing.Size(129, 205);
            this.btnOrganicbin.TabIndex = 11;
            this.btnOrganicbin.UseVisualStyleBackColor = true;
            this.btnOrganicbin.Click += new System.EventHandler(this.btnOrganicbin_Click);
            // 
            // btnPapaerBin
            // 
            this.btnPapaerBin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPapaerBin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPapaerBin.BackgroundImage")));
            this.btnPapaerBin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPapaerBin.Location = new System.Drawing.Point(773, 223);
            this.btnPapaerBin.Name = "btnPapaerBin";
            this.btnPapaerBin.Size = new System.Drawing.Size(129, 214);
            this.btnPapaerBin.TabIndex = 12;
            this.btnPapaerBin.UseVisualStyleBackColor = true;
            this.btnPapaerBin.Click += new System.EventHandler(this.btnPapaerBin_Click);
            // 
            // btnLandFillBin
            // 
            this.btnLandFillBin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLandFillBin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLandFillBin.BackgroundImage")));
            this.btnLandFillBin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLandFillBin.Location = new System.Drawing.Point(908, 223);
            this.btnLandFillBin.Name = "btnLandFillBin";
            this.btnLandFillBin.Size = new System.Drawing.Size(129, 214);
            this.btnLandFillBin.TabIndex = 13;
            this.btnLandFillBin.UseVisualStyleBackColor = true;
            this.btnLandFillBin.Click += new System.EventHandler(this.btnLandFillBin_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(860, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 83);
            this.label1.TabIndex = 14;
            this.label1.Text = "Did I get it right? Select the correct bin above";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(262, 455);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(572, 213);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1045, 681);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLandFillBin);
            this.Controls.Add(this.btnPapaerBin);
            this.Controls.Add(this.btnOrganicbin);
            this.Controls.Add(this.btnMixedBin);
            this.Controls.Add(this.StatisticText);
            this.Controls.Add(this.comboBoxCameraType);
            this.Controls.Add(this.imageButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.webCameraControl1);
            this.Name = "MainForm";
            this.Text = "MYOB AI Recycle Bin Detector";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

