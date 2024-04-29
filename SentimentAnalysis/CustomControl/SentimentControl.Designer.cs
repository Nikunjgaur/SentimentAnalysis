namespace SentimentAnalysis.CustomControl
{
    partial class SentimentControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCount = new System.Windows.Forms.Label();
            this.labelSentimentName = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCount
            // 
            this.labelCount.BackColor = System.Drawing.Color.White;
            this.labelCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCount.ForeColor = System.Drawing.Color.Black;
            this.labelCount.Location = new System.Drawing.Point(0, 173);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(241, 53);
            this.labelCount.TabIndex = 11;
            this.labelCount.Text = "00";
            this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSentimentName
            // 
            this.labelSentimentName.BackColor = System.Drawing.Color.White;
            this.labelSentimentName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelSentimentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSentimentName.ForeColor = System.Drawing.Color.Black;
            this.labelSentimentName.Location = new System.Drawing.Point(0, 226);
            this.labelSentimentName.Name = "labelSentimentName";
            this.labelSentimentName.Size = new System.Drawing.Size(241, 52);
            this.labelSentimentName.TabIndex = 13;
            this.labelSentimentName.Text = "Sentiment";
            this.labelSentimentName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(241, 173);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 14;
            this.pictureBox.TabStop = false;
            // 
            // SentimentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelSentimentName);
            this.Name = "SentimentControl";
            this.Size = new System.Drawing.Size(241, 278);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label labelCount;
        public System.Windows.Forms.Label labelSentimentName;
        public System.Windows.Forms.PictureBox pictureBox;
    }
}
