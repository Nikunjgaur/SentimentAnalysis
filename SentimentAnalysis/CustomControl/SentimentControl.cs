using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SentimentAnalysis.CustomControl
{
    public partial class SentimentControl : UserControl
    {


        private Sentiment _sentiment = Sentiment.Joy;

        public Sentiment Sentiment { get { return _sentiment; } 
            set 
            {
                _sentiment = value;
                labelSentimentName.Text = _sentiment.ToString();
            }
        }

        private int _count = 0;

        public int Count { get { return _count; } set { _count = value; labelCount.Text = _count.ToString(); } }

        public SentimentControl()
        {
            InitializeComponent();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
