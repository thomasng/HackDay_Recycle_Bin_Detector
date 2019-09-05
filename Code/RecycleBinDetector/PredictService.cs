using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction;
using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Training;
using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Training.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using RecycleApp.Properties;
using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction.Models;

namespace RecycleApp
{
    public class PredictService
    {
        /*
        private const string RegionEndpoint = "https://australiaeast.api.cognitive.microsoft.com";
        string trainingKey = "591691a2ff4d4ba8a4341dcdad99f40c";
        string predictionKey = "886438d4063d4d5d9468af434f8efaba";
        Guid projectId => new Guid("ec74ba50-9f97-4dcc-a201-e1f18171add7");*/


        private const string RegionEndpoint = "https://australiaeast.api.cognitive.microsoft.com";
        string trainingKey = "591691a2ff4d4ba8a4341dcdad99f40c";
        string predictionKey = "886438d4063d4d5d9468af434f8efaba";

        // Main
        //Guid projectId => new Guid("8316abab-6877-4f3c-a724-5db2ec942b93");
        Guid projectId => new Guid("ec74ba50-9f97-4dcc-a201-e1f18171add7");

        public CustomVisionTrainingClient _trainingApi;


        public CustomVisionTrainingClient CreateTrainingApi()
        {
            // Create the Api, passing in the training key
            var trainingApi = new CustomVisionTrainingClient()
            {
                ApiKey = trainingKey,
                Endpoint = RegionEndpoint
            };
            return trainingApi;
        }

        public Dictionary<string, double> Predict(string imageFile)
        {
        
            // Now there is a trained endpoint, it can be used to make a prediction
            var publishedName = Settings.Default.PublishedPredictionName;

            // Create a prediction endpoint, passing in the obtained prediction key
            var endpoint = new CustomVisionPredictionClient()
            {
                ApiKey = predictionKey,
                Endpoint = RegionEndpoint
            };

            // Make a prediction against the new project
            Console.WriteLine("Making a prediction:");
         
            var result = endpoint.DetectImage(projectId, publishedName, File.OpenRead(imageFile));

            return CalculateRating(result.Predictions.ToList());

            //return result.Predictions.OrderByDescending(a => a.Probability).FirstOrDefault();      

        }

        private Dictionary<string, double> CalculateRating(List<PredictionModel> result)
        {
            var tagResults = new Dictionary<string, double>();
            foreach (var model in result)
            {
                if (tagResults.ContainsKey(model.TagName))
                    tagResults[model.TagName] += model.Probability;
                else
                    tagResults.Add(model.TagName, model.Probability);
            }

            return tagResults;
        }



    }
}
