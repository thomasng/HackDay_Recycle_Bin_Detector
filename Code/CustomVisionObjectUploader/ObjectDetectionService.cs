using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction;
using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Training;
using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Training.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;


namespace CustomVisionObjectUploader
{
    public class ObjectDetectionService
    {
        private const string CustomVisionEndpoint = "https://australiaeast.api.cognitive.microsoft.com";
        string TrainingKey = "591691a2ff4d4ba8a4341dcdad99f40c";
        // string PredictionKey = "886438d4063d4d5d9468af434f8efaba";
        Guid CustomVisionProjectId => new Guid("ec74ba50-9f97-4dcc-a201-e1f18171add7");

        private string UploadImageDir => @"C:\Hackday\UploadTagImage";

        public CustomVisionTrainingClient _trainingApi;


        public CustomVisionTrainingClient CreateTrainingApi()
        {
            // Create the Api, passing in the training key
            var trainingApi = new CustomVisionTrainingClient()
            {
                ApiKey = TrainingKey,
                Endpoint = CustomVisionEndpoint
            };
            return trainingApi;
        }

        private double[] GetImageRegion(string fileName)
        {
            return new double[] {0.180147052, 0.239820287, 0.6887255, 0.235294119};
        }

        public void ContinueRun(int noOfseconds)
        {
            do
            {
                Run();
                Thread.Sleep(noOfseconds*1000);
            } while (true);          
        }


        public void Run()
        {
            // Add your training & prediction key from the settings page of the portal
            _trainingApi = CreateTrainingApi();
                     
            // Find the object detection domain
            var domains = _trainingApi.GetDomains();
            var objDetectionDomain = domains.FirstOrDefault(d => d.Type == "ObjectDetection");

            Console.WriteLine($"Loading project: Id = {CustomVisionProjectId.ToString()}");
            //var project = _trainingApi.CreateProject("My New Project", null, objDetectionDomain.Id);
            var project = _trainingApi.GetProject(CustomVisionProjectId);
            if (project == null)
                Console.WriteLine($"Project not found: Id = {CustomVisionProjectId.ToString()}");
            else
                Console.WriteLine($"Project - Name '{project.Name}' is loaded");

            var tags = _trainingApi.GetTags(CustomVisionProjectId).ToList();

            var organicTag = GetTag(project, tags, "organic", true);
            var paperTag = GetTag(project, tags, "paper", true);
            var mixedTag = GetTag(project, tags, "mixed", true);
            var landfillTag = GetTag(project, tags, "landfill", true);

            UploadImageWithTag(project, organicTag, "organic");
            UploadImageWithTag(project, paperTag, "paper");
            UploadImageWithTag(project, mixedTag, "mixed");
            UploadImageWithTag(project, landfillTag, "landfill");

        
        }


        public Tag GetTag(Project project, List<Tag> tags, string tagName, bool createIfNotFound)
        {
            var tag = tags.Find(t => t.Name == tagName);
            if (tag == null && createIfNotFound)
                tag = _trainingApi.CreateTag(project.Id, tagName);

            return tag;
        }

        private void UploadImageWithTag(Project project, Tag tag, string tagDir)
        {

            try
            {
                var imagePath = Path.Combine(UploadImageDir, tagDir);
                var imageFileEntries = new List<ImageFileCreateEntry>();
                var fileNames = Directory.EnumerateFiles(imagePath);

                Console.WriteLine($"Uploading {fileNames.Count()} images with Tag : '{tag.Name}' from {imagePath}...");
                foreach (var fileName in fileNames)
                {
                    var region = GetImageRegion(Path.GetFileNameWithoutExtension(fileName));
                    imageFileEntries.Add(new ImageFileCreateEntry(fileName, File.ReadAllBytes(fileName), null, new List<Region>(new Region[] { new Region(tag.Id, region[0], region[1], region[2], region[3]) })));
                }
                if (imageFileEntries.Count > 0)
                    _trainingApi.CreateImagesFromFiles(project.Id, new ImageFileCreateBatch(imageFileEntries));

                Console.WriteLine($"Uploaded done");

                DeleteUploadedFiles(fileNames);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);             
            }
        }

        private void DeleteUploadedFiles(IEnumerable<string> fileNames)
        {
            foreach (var fileName in fileNames)
            {
                try
                {
                    File.Delete(fileName);
                    Console.WriteLine($"Deleted {fileName}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Fail to delete {fileName}");
                    Console.WriteLine(e);
                }      
            } 
        }

        private Iteration StartTraining(Project project)
        {
            // Now there are images with tags start training the project of current Iteration
            Console.WriteLine("\tTraining start....");
            var startTime = DateTime.Now;
            Iteration iteration = null;
            try
            {
                iteration = _trainingApi.TrainProject(project.Id);

                // The returned iteration will be in progress, and can be queried periodically to see when it has completed
                while (iteration.Status == "Training")
                {
                    Thread.Sleep(1000);

                    // Re-query the iteration to get its updated status
                    iteration = _trainingApi.GetIteration(project.Id, iteration.Id);
                }
                Console.WriteLine($"\tTraining finished. Total Training Time : {(DateTime.Now - startTime).TotalSeconds} seconds");

                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return iteration;
        }


        private void StartPublishing(Project project, Iteration iteration, string publishedModelName)
        {
            // The iteration is now trained. Publish it to the prediction end point.

            var predictionResourceId = "<target prediction resource ID>";
            _trainingApi.PublishIteration(project.Id, iteration.Id, publishedModelName, predictionResourceId);
            Console.WriteLine("Done!\n");
        }
    }
}
