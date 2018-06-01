using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MC50UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PreviewButton_Click(object sender, EventArgs e)
        {
            string s = RTBMainText.Rtf;
            MessageBox.Show(s);
        }

        private void BtnBold_Click(object sender, EventArgs e)
        {
            RTBMainText.SelectionFont = new Font(RTBMainText.SelectionFont, FontStyle.Bold);
        }

        private void BtnSetContent_Click(object sender, EventArgs e)
        {
            string fn = @"C:\Users\User\Documents\보통 글자.rtf";
            string towrite = "";
            StreamReader sr = new StreamReader(fn);
            while (sr.Peek() >= 0)
            {
                towrite += sr.ReadLine() + " ";
            }
            sr.Close();
            MessageBox.Show(towrite);
            RTBMainText.Rtf = towrite;

            /*RTBMainText.Rtf = @"{\rtf1\ansi\deff0 {\fonttbl {\f0 Times;}}
\fs25
{\pard
Alice grew {\charscalex150 bigger} {\charscalex200 and bigger} {\charscalex250 and bigger}!
Then she grew {\charscalex75 smaller} {\charscalex50 and smaller} {\charscalex25 and smaller}.
\par}
}";*/


        }
    }
}
