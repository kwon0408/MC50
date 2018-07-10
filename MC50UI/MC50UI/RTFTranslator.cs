using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DCSoft.RTF;

namespace MC50UI
{
    public class RTFTranslator
    {
        public RTFTranslator()
        {

        }

        public static void RtfToDomTree(string rtf)
        {
            RTFDomDocument doc = new RTFDomDocument();
            doc.LoadRTFText(rtf);

            // MessageBox.Show(doc.InnerText); // convert to plain text
            MessageBox.Show(doc.ToDomString());


        }

        public static string PacketToRtf(byte[] packet)
        {
            string rtf = "";

            return rtf;
        }

        // TODO
        public static byte[] RtfToPacket(string rtf, bool useBlackMark = false)
        {
            byte[] packet = { };

            RTFReader reader = new RTFReader();
            reader.LoadReader(new StringReader(rtf));
            reader.LoadRTFText(rtf);

            reader.Close();
            return packet;
        }

        public static string PacketToString(byte[] packet)
        {
            string r = "";
            foreach (byte b in packet)
            {
                r += String.Format("{0:X} ", b);
            }

            return r;
        }
    }

}
