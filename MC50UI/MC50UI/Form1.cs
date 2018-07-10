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
        private Printer printer;
        private string bottomMsg;

        public Form1()
        {
            InitializeComponent();
            printer = Printer.Instance();
            bottomMsg = "준비";
        }

        private void PreviewButton_Click(object sender, EventArgs e)
        {
            string s = RTBMainText.Rtf;
            StatusLabel.Text = "메시지 창 띄워짐";
            MessageBox.Show(s);
            StatusLabel.Text = bottomMsg;
        }

        private void BtnBold_Click(object sender, EventArgs e)
        {
            RTBMainText.SelectionFont = new Font(RTBMainText.SelectionFont, FontStyle.Bold);
        }

        private void BtnSetContent_Click(object sender, EventArgs e)
        {
            //string fn = @"C:\Users\User\Documents\보통 글자.rtf";
            //string towrite = "";
            //StreamReader sr = new StreamReader(fn);
            //while (sr.Peek() >= 0)
            //{
            //    towrite += sr.ReadLine() + " ";
            //}
            //sr.Close();
            //MessageBox.Show(towrite);
            //RTBMainText.Rtf = towrite;

            //            RTBMainText.Rtf = 
            //                @"{\rtf1\ansi\deff0 {\fonttbl {\f0 D2Coding;}}
            //\fs25
            //{\pard
            //Alice grew {\charscalex150 bigger} {\charscalex200 and bigger} {\charscalex250 and bigger}!
            //Then she grew {\charscalex75 smaller} {\charscalex50 and smaller} {\charscalex25 and smaller}.
            //\par}
            //}";
            // byte[] packet = RTFTranslator.RtfToPacket(RTBMainText.Rtf);
            // MessageBox.Show(RTFTranslator.PacketToString(packet));

            RTBMainText.Rtf =
                @"{\rtf1\ansi\deff0 {\fonttbl {\f0 D2Coding;}}
\fs24
{\pard
12345678901234567890123456789012\par
Normal width restricted to 32 B.\par
{\charscalex200 [ Double Width ]}\par
Normal width again\par
inline {\charscalex200 double} width\par
}
}";

        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (printer.IsConnected)
            {
                printer.Disconnect();
                BtnConnect.Text = "연결";
                bottomMsg = "준비";
                StatusLabel.Text = bottomMsg;
            }
            else
            {
                printer.Connect((int)NUDPortNum.Value);
                BtnConnect.Text = "연결 끊기";
                bottomMsg = "연결됨";
                StatusLabel.Text = bottomMsg; 
            }
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            RTFTranslator.RtfToDomTree(RTBMainText.Rtf);
        }

        private void TsbBold_Click(object sender, EventArgs e)
        {
            Font font = RTBMainText.SelectionFont;
            RTBMainText.SelectionFont = new Font(font, (font.Style == FontStyle.Bold ? FontStyle.Regular : FontStyle.Bold));            
        }

        private void TsbWideChar_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(RTBMainText.SelectedRtf);
            MessageBox.Show(RTBMainText.SelectedText);

        }
    }
}
