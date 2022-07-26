using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Speech.Synthesis;

namespace TextToSpeech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text.Equals(""))
            {
                MessageBox.Show("Input is required.");
            }
            else
            {
                Thread.Sleep(1000);
                button1.Text = "Speaking ...";
                textConvertor(richTextBox1.Text);
                button1.Text = "SPEAK";
            }
        }
        private void textConvertor(String text)
        {
            SpeechSynthesizer speech = new SpeechSynthesizer();
            speech.Speak(text);
        }

    }
}
