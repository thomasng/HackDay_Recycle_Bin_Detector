﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction.Models;
using RecycleApp.Properties;
using WebEye.Controls.WinForms.WebCameraControl;

namespace RecycleApp
{
    public partial class MainForm : Form
    {

        private string _currentCaptureImageFile;
        public MainForm()
        {
            InitializeComponent();
        }

        private void comboBoxCameraType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtons();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CleanupResult();
            LoadCameraList();
        }


        private void UpdateButtons()
        {
            startButton.Enabled = comboBoxCameraType.SelectedItem != null;
            stopButton.Enabled = webCameraControl1.IsCapturing;
            imageButton.Enabled = webCameraControl1.IsCapturing;
        }

        private void LoadCameraList()
        {
            foreach (WebCameraId camera in webCameraControl1.GetVideoCaptureDevices())
                comboBoxCameraType.Items.Add(new ComboBoxItem(camera));

            if (comboBoxCameraType.Items.Count > 0)
            {
                comboBoxCameraType.SelectedItem = comboBoxCameraType.Items[0];
                startButton_Click(null, null);
            }
        }

 
        private void startButton_Click(object sender, EventArgs e)
        {
            var i = (ComboBoxItem)comboBoxCameraType.SelectedItem;

            try
            {
                webCameraControl1.StartCapture(i.Id);
            }
            finally
            {
                UpdateButtons();
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            webCameraControl1.StopCapture();
            UpdateButtons();
        }

        private void CleanupResult()
        {
            StatisticText.Text = string.Empty;
            ResultText.Text = string.Empty;
        }

        private void imageButton_Click(object sender, EventArgs e)
        {
            try
            {
                CleanupResult();
             

                var fileName = DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss") + ".jpg";
                var capturefileName = Path.Combine(Settings.Default.ImageCaptureLocation, fileName);
                webCameraControl1.GetCurrentImage().Save(capturefileName, ImageFormat.Jpeg);

                var predictModels = new PredictService().Predict(capturefileName);
               
                DisplayResult(predictModels);

                _currentCaptureImageFile = capturefileName;
            }
            catch (Exception exception)
            {
                LogError(exception.Message);
            }             
        }

        private void DisplayResult(Dictionary<string, double> results)
        {
            var orderedPredictModels = results.OrderByDescending(a => a.Value).ToList();

            if (orderedPredictModels.Count == 0)
                ResultText.Text = "No sure. Please click one of option on the right";
            else
                ResultText.Text = $"Please put in '{orderedPredictModels[0].Key}' recycle bin !";

            var tagResults = new Dictionary<string, double>();

            var statisticText = "Analysis:" + Environment.NewLine;
            foreach (var predictModel in orderedPredictModels)
            {
                statisticText += $"{predictModel.Key} ({GetDisplayProbability(predictModel.Value)}%)" + Environment.NewLine;
            }

            StatisticText.Text = statisticText;
        }

    private string GetDisplayProbability(double probability)
    {
        return (probability * 100).ToString("0.##");
    }

        private void LogError(string message)
        {
            MessageBox.Show(message);
        }

        private void btnMixedBin_Click(object sender, EventArgs e)
        {
            CopyFileToUploadLoation("mixed");
        }

        private void btnOrganicbin_Click(object sender, EventArgs e)
        {
            CopyFileToUploadLoation("organic");
        }

        private void btnPapaerBin_Click(object sender, EventArgs e)
        {
            CopyFileToUploadLoation("paper");
        }

        private void btnLandFillBin_Click(object sender, EventArgs e)
        {
            CopyFileToUploadLoation("landfill");
        }


        private void CopyFileToUploadLoation(string tag)
        {
            if (string.IsNullOrEmpty(_currentCaptureImageFile)) return;
            if (File.Exists(_currentCaptureImageFile))
            {
                if (!Directory.Exists(Settings.Default.LearningUploadLoation))
                    Directory.CreateDirectory(Settings.Default.LearningUploadLoation);

                var dest = Path.Combine(Settings.Default.LearningUploadLoation, tag);

                if (!Directory.Exists(dest))
                    Directory.CreateDirectory(dest);

                dest = Path.Combine(dest, Path.GetFileName(_currentCaptureImageFile));
                File.Copy(_currentCaptureImageFile, dest);

                MessageBox.Show($"Image is copied to '{tag}' location for future machine learning");
            }
        }
    }
}