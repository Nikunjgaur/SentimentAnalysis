namespace SentimentAnalysis.AppForms
{
    partial class DetectionScreen
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.sentimentControl1 = new SentimentAnalysis.CustomControl.SentimentControl();
            this.sentimentControl7 = new SentimentAnalysis.CustomControl.SentimentControl();
            this.sentimentControl2 = new SentimentAnalysis.CustomControl.SentimentControl();
            this.sentimentControl3 = new SentimentAnalysis.CustomControl.SentimentControl();
            this.sentimentControl4 = new SentimentAnalysis.CustomControl.SentimentControl();
            this.sentimentControl5 = new SentimentAnalysis.CustomControl.SentimentControl();
            this.sentimentControl6 = new SentimentAnalysis.CustomControl.SentimentControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonDetect = new System.Windows.Forms.Button();
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.richTextBoxFilePreview = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFile = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(106)))), ((int)(((byte)(200)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1894, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sentiment Detection Form";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1894, 502);
            this.panel1.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.sentimentControl1);
            this.flowLayoutPanel1.Controls.Add(this.sentimentControl7);
            this.flowLayoutPanel1.Controls.Add(this.sentimentControl2);
            this.flowLayoutPanel1.Controls.Add(this.sentimentControl3);
            this.flowLayoutPanel1.Controls.Add(this.sentimentControl4);
            this.flowLayoutPanel1.Controls.Add(this.sentimentControl5);
            this.flowLayoutPanel1.Controls.Add(this.sentimentControl6);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 239);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1892, 261);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // sentimentControl1
            // 
            this.sentimentControl1.BackColor = System.Drawing.Color.White;
            this.sentimentControl1.Count = 0;
            this.sentimentControl1.Location = new System.Drawing.Point(3, 3);
            this.sentimentControl1.Margin = new System.Windows.Forms.Padding(3, 3, 27, 3);
            this.sentimentControl1.Name = "sentimentControl1";
            this.sentimentControl1.Sentiment = SentimentAnalysis.Sentiment.Joy;
            this.sentimentControl1.Size = new System.Drawing.Size(240, 240);
            this.sentimentControl1.TabIndex = 0;
            // 
            // sentimentControl7
            // 
            this.sentimentControl7.BackColor = System.Drawing.Color.White;
            this.sentimentControl7.Count = 0;
            this.sentimentControl7.Location = new System.Drawing.Point(273, 3);
            this.sentimentControl7.Margin = new System.Windows.Forms.Padding(3, 3, 27, 3);
            this.sentimentControl7.Name = "sentimentControl7";
            this.sentimentControl7.Sentiment = SentimentAnalysis.Sentiment.Joy;
            this.sentimentControl7.Size = new System.Drawing.Size(240, 240);
            this.sentimentControl7.TabIndex = 0;
            // 
            // sentimentControl2
            // 
            this.sentimentControl2.BackColor = System.Drawing.Color.White;
            this.sentimentControl2.Count = 0;
            this.sentimentControl2.Location = new System.Drawing.Point(543, 3);
            this.sentimentControl2.Margin = new System.Windows.Forms.Padding(3, 3, 27, 3);
            this.sentimentControl2.Name = "sentimentControl2";
            this.sentimentControl2.Sentiment = SentimentAnalysis.Sentiment.Joy;
            this.sentimentControl2.Size = new System.Drawing.Size(240, 240);
            this.sentimentControl2.TabIndex = 0;
            // 
            // sentimentControl3
            // 
            this.sentimentControl3.BackColor = System.Drawing.Color.White;
            this.sentimentControl3.Count = 0;
            this.sentimentControl3.Location = new System.Drawing.Point(813, 3);
            this.sentimentControl3.Margin = new System.Windows.Forms.Padding(3, 3, 27, 3);
            this.sentimentControl3.Name = "sentimentControl3";
            this.sentimentControl3.Sentiment = SentimentAnalysis.Sentiment.Joy;
            this.sentimentControl3.Size = new System.Drawing.Size(240, 240);
            this.sentimentControl3.TabIndex = 0;
            // 
            // sentimentControl4
            // 
            this.sentimentControl4.BackColor = System.Drawing.Color.White;
            this.sentimentControl4.Count = 0;
            this.sentimentControl4.Location = new System.Drawing.Point(1083, 3);
            this.sentimentControl4.Margin = new System.Windows.Forms.Padding(3, 3, 27, 3);
            this.sentimentControl4.Name = "sentimentControl4";
            this.sentimentControl4.Sentiment = SentimentAnalysis.Sentiment.Joy;
            this.sentimentControl4.Size = new System.Drawing.Size(240, 240);
            this.sentimentControl4.TabIndex = 0;
            // 
            // sentimentControl5
            // 
            this.sentimentControl5.BackColor = System.Drawing.Color.White;
            this.sentimentControl5.Count = 0;
            this.sentimentControl5.Location = new System.Drawing.Point(1353, 3);
            this.sentimentControl5.Margin = new System.Windows.Forms.Padding(3, 3, 27, 3);
            this.sentimentControl5.Name = "sentimentControl5";
            this.sentimentControl5.Sentiment = SentimentAnalysis.Sentiment.Joy;
            this.sentimentControl5.Size = new System.Drawing.Size(240, 240);
            this.sentimentControl5.TabIndex = 0;
            // 
            // sentimentControl6
            // 
            this.sentimentControl6.BackColor = System.Drawing.Color.White;
            this.sentimentControl6.Count = 0;
            this.sentimentControl6.Location = new System.Drawing.Point(1623, 3);
            this.sentimentControl6.Name = "sentimentControl6";
            this.sentimentControl6.Sentiment = SentimentAnalysis.Sentiment.Joy;
            this.sentimentControl6.Size = new System.Drawing.Size(240, 240);
            this.sentimentControl6.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.buttonDetect);
            this.panel2.Controls.Add(this.richTextBoxInput);
            this.panel2.Controls.Add(this.richTextBoxFilePreview);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.buttonFile);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1892, 239);
            this.panel2.TabIndex = 2;
            // 
            // buttonDetect
            // 
            this.buttonDetect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.buttonDetect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDetect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetect.Location = new System.Drawing.Point(1124, 168);
            this.buttonDetect.Name = "buttonDetect";
            this.buttonDetect.Size = new System.Drawing.Size(127, 37);
            this.buttonDetect.TabIndex = 3;
            this.buttonDetect.Text = "Detect";
            this.buttonDetect.UseVisualStyleBackColor = false;
            this.buttonDetect.Click += new System.EventHandler(this.buttonDetect_Click);
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.BackColor = System.Drawing.Color.White;
            this.richTextBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxInput.Location = new System.Drawing.Point(1002, 26);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(371, 133);
            this.richTextBoxInput.TabIndex = 2;
            this.richTextBoxInput.Text = "";
            // 
            // richTextBoxFilePreview
            // 
            this.richTextBoxFilePreview.BackColor = System.Drawing.Color.White;
            this.richTextBoxFilePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxFilePreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxFilePreview.Location = new System.Drawing.Point(611, 29);
            this.richTextBoxFilePreview.Name = "richTextBoxFilePreview";
            this.richTextBoxFilePreview.ReadOnly = true;
            this.richTextBoxFilePreview.Size = new System.Drawing.Size(371, 133);
            this.richTextBoxFilePreview.TabIndex = 2;
            this.richTextBoxFilePreview.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(719, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "File Data Preview";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(467, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select File";
            // 
            // buttonFile
            // 
            this.buttonFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFile.Location = new System.Drawing.Point(451, 29);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(130, 130);
            this.buttonFile.TabIndex = 0;
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // chart1
            // 
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(223)))), ((int)(((byte)(243)))));
            chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 544);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1894, 487);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 59);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DetectionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1894, 1031);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "DetectionScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetectionScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DetectionScreen_Load);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private CustomControl.SentimentControl sentimentControl7;
        private CustomControl.SentimentControl sentimentControl6;
        private CustomControl.SentimentControl sentimentControl5;
        private CustomControl.SentimentControl sentimentControl4;
        private CustomControl.SentimentControl sentimentControl3;
        private CustomControl.SentimentControl sentimentControl2;
        private CustomControl.SentimentControl sentimentControl1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.RichTextBox richTextBoxFilePreview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxInput;
        private System.Windows.Forms.Button buttonDetect;
        private System.Windows.Forms.Button button1;
    }
}