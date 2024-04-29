using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using SentimentAnalysis.CustomControl;
using System.IO;

namespace SentimentAnalysis.AppForms
{
    public partial class DetectionScreen : Form
    {

        List<SentimentControl> sentimentControls = new List<SentimentControl>();
        List<string> sentiments = new List<string>();

        

        public DetectionScreen()
        {
            InitializeComponent();
            //InitializeChart(chart1);
            sentimentControls = new List<SentimentControl>() { sentimentControl1, sentimentControl2, sentimentControl3, sentimentControl4, sentimentControl5, sentimentControl6, sentimentControl7};
            sentiments = new List<string>() { "Joy", "Fear", "Anger", "Sadness", "Disgust", "Shame", "Guilt"};


            buttonFile.FitImage($"{AppData.ProjectDirectory}/Icons/file.png", new Size(100,100));
        }

        void SetSentimentData(SentimentControl sentimentControl, int count, string emoji)
        {
            //sentimentControl
        }


        private static void InitializeChart(Chart chart, Dictionary<string, int> sentimentCounts)
        {
           
            chart.Series.Clear();

            var series = new Series();
            series.ChartType = SeriesChartType.Doughnut;
            series["PieLabelStyle"] = "Outside";

            

            series.Points.Add(new DataPoint(0, sentimentCounts["Joy"]) { AxisLabel = "Joy" });
            series.Points.Add(new DataPoint(0, sentimentCounts["Fear"]) { AxisLabel = "Fear" });
            series.Points.Add(new DataPoint(0, sentimentCounts["Anger"]) { AxisLabel = "Anger" });
            series.Points.Add(new DataPoint(0, sentimentCounts["Sadness"]) { AxisLabel = "Sadness" });
            series.Points.Add(new DataPoint(0, sentimentCounts["Disgust"]) { AxisLabel = "Disgust" });
            series.Points.Add(new DataPoint(0, sentimentCounts["Shame"]) { AxisLabel = "Shame" });
            series.Points.Add(new DataPoint(0, sentimentCounts["Guilt"]) { AxisLabel = "Guilt" });

            series.Points[0].Color = Color.Blue;    // Joy
            series.Points[1].Color = Color.Yellow;  // Fear
            series.Points[2].Color = Color.Red;     // Anger
            series.Points[3].Color = Color.Purple;  // Sadness
            series.Points[4].Color = Color.Green;   // Disgust
            series.Points[5].Color = Color.Orange;  // Shame
            series.Points[6].Color = Color.Brown;   // Guilt

            chart.Series.Add(series);
        }
        Random random = new Random();
        private void DetectionScreen_Load(object sender, EventArgs e)
        {

            ApiController.RunAnacondaCmd();

            for (int i = 0; i < sentimentControls.Count; i++)
            {
                Bitmap bitmap = new Bitmap($"{AppData.ProjectDirectory}/Icons/{sentiments[i]}.gif");
                sentimentControls[i].pictureBox.Image = bitmap.DeepClone();
                //sentimentControls[i].Count = random.Next(20, 100);
                sentimentControls[i].Sentiment = (Sentiment)i;
            }

            UpdateUi();

        }

        private async void label1_Click(object sender, EventArgs e)
        {
            InitializeChart(chart1, SentimentAnalyzer.sentimentCounts);

        }



        private void buttonDetect_Click(object sender, EventArgs e)
        {
            SentimentAnalyzer.sentimentCounts = new Dictionary<string, int>
            {
                {"Joy", 0},
                {"Fear", 0},
                {"Anger", 0},
                {"Sadness", 0},
                {"Disgust", 0},
                {"Shame", 0},
                {"Guilt", 0}
            };

            //UpdateUi();
            if (!string.IsNullOrEmpty(richTextBoxFilePreview.Text))
            {
                SentimentAnalyzer.ProcessFile(filePath, chart1, sentimentControls);
            }
            if (!string.IsNullOrEmpty(richTextBoxInput.Text))
            {
                SentimentAnalyzer.ProcessString(richTextBoxInput.Text, chart1, sentimentControls);
            }

            chart1.Visible = false;

            InitializeChart(chart1, SentimentAnalyzer.sentimentCounts);


        }


        void UpdateUi()
        {
            InitializeChart(chart1, SentimentAnalyzer.sentimentCounts);


            foreach (var pair in SentimentAnalyzer.sentimentCounts)
            {
                foreach (SentimentControl control in sentimentControls)
                {
                    if (control.Sentiment.ToString() == pair.Key)
                    {
                        control.Count = pair.Value;
                    }
                }
            }
        }


        string filePath = "";

        public void OpenFileContent()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            openFileDialog.Title = "Select a Text File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                 filePath = openFileDialog.FileName;

                try
                {
                    string fileContent = File.ReadAllText(filePath);
                    richTextBoxFilePreview.Text = fileContent;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error reading the file: {ex.Message}");
                }
            }
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            OpenFileContent();
        }


        static void RemoveTrailingCommas(string filePath)
        {
            // Read the file line by line
            string[] lines = File.ReadAllLines(filePath);

            // Modify each line to remove commas at the end
            for (int i = 0; i < lines.Length; i++)
            {
                // Trim trailing whitespace and commas
                lines[i] = lines[i].TrimEnd(',', ' ');
            }

            // Write modified lines back to the file
            File.WriteAllLines(filePath, lines);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv";
            openFileDialog.Title = "Select a CSV File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    RemoveTrailingCommas(filePath);
                    Console.WriteLine("Commas removed successfully from the end of each line.");
                }
                catch (IOException ex)
                {
                    Console.WriteLine("An error occurred while reading the file:");
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An unexpected error occurred:");
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("No file selected.");
            }
        }
    }
}
