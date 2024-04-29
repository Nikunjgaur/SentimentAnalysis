using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentimentAnalysis
{
    internal class AppData
    {
        private static string globalProjectDirectory = Environment.CurrentDirectory;
        public static string ProjectDirectory = Directory.GetParent(globalProjectDirectory).Parent.Parent.FullName;
    }
   

    public enum Sentiment
    {
        Joy,
        Fear,
        Anger,
        Sadness,
        Disgust,
        Shame,
        Guilt
    }

}
