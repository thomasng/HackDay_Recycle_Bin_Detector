using System;

namespace CustomVisionObjectUploader
{
    class Program
    {
        static void Main(string[] args)
        {
            new ObjectDetectionService().ContinueRun(120);

            Console.WriteLine("Press a key to exit program...");
            Console.ReadKey();
        }
    }
}