using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using SentimentAnalysis.CustomControl;
using System.Threading;
using System.Threading.Tasks;
namespace SentimentAnalysis
{
    public static class SentimentAnalyzer
    {
        public static Dictionary<string, int> sentimentCounts;

        static SentimentAnalyzer()
        {
            sentimentCounts = new Dictionary<string, int>
            {
                {"Joy", 0},
                {"Fear", 0},
                {"Anger", 0},
                {"Sadness", 0},
                {"Disgust", 0},
                {"Shame", 0},
                {"Guilt", 0}
            };
        }

        

        public static void UpdateSentimentCount(string sentiment, List<SentimentControl> sentimentControls)
        {
            if (sentimentCounts.ContainsKey(sentiment))
            {
                sentimentCounts[sentiment]++;

                foreach (SentimentControl control in sentimentControls)
                {
                    control.Invoke(new Action(() => {

                        if (control.Sentiment.ToString() == sentiment)
                        {
                            control.Count = sentimentCounts[sentiment];
                            control.Invalidate();
                            control.Refresh();
                        }
                    }));
                    
                }
            }
        }

        public static async Task ProcessFile(string filePath, Chart chart, List<SentimentControl> sentimentControls)
        {
            await Task.Delay(1);

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {

                Task.Run(async () => 
                {
                    await Task.Delay(600);
                    string sentiment = ApiController.GetSentiment(line);
                    UpdateSentimentCount(sentiment, sentimentControls);
                    Enum.TryParse(sentiment, out Sentiment s);
                    await Task.Delay(600);

                    UpdateChart(s, chart);

                });



            }

            chart.Visible = true;

        }

        public static async Task ProcessString(string input, Chart chart, List<SentimentControl> sentimentControls)
        {

            await Task.Delay(1);
            string[] sentences = input.Split(new char[] { '.', '!', '?' });

            foreach (string sentence in sentences)
            {
                Task.Run(async () =>
                {
                    await Task.Delay(600);
                    string sentiment = ApiController.GetSentiment(sentence);
                    UpdateSentimentCount(sentiment, sentimentControls);
                    Enum.TryParse(sentiment, out Sentiment s);
                    await Task.Delay(600);
                    UpdateChart(s, chart);
                });

            }

            chart.Visible = true;

        }


        static Color[] Colors = new Color[] { Color.Blue, Color.Yellow, Color.Red, Color.Purple, Color.Green, Color.Orange, Color.Brown };

        private static void UpdateChart(Sentiment sentiment, Chart chart)
        {
            
                chart.Invoke(new Action(() =>
                {

                    int index = Convert.ToInt32(sentiment);
                    int seriesIndex = chart.Series.Count - 1;
                    chart.Series[seriesIndex].Points[index].YValues[0] = sentimentCounts[sentiment.ToString()];
                    chart.Series[seriesIndex].Points[index].Color = Colors[index];
                }));


        }

        public static void DisplaySentimentCounts()
        {



            //foreach (var pair in SentimentAnalyzer.sentimentCounts)
            //{
            //    foreach (SentimentControl control in sentimentControls)
            //    {
            //        if (control.Sentiment.ToString() == pair.Key)
            //        {
            //            control.Count = pair.Value;
            //        }
            //    }
            //}
            foreach (var pair in sentimentCounts)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }

}
