using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MC50UI
{
    class Printer
    {
        private static Printer printer;

        private bool connected;
        private SerialPort serialPort;

        private const byte CMD_PRINT_STRING = 0x40;
        private const int CARRY_DIVIDER = 256;

        protected Printer()
        {
            connected = false;
        }

        public static Printer Instance()
        {
            if (printer is null)
                printer = new Printer();

            return printer;
        }

        public bool IsConnected => connected;

        public int Connect(int port)
        {
            if (connected)
                return -1;

            connected = true;

            try
            {
                serialPort = new SerialPort("COM" + port, 9600);
                serialPort.Open();
                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return -1;
            }

            
        }

        public int Disconnect()
        {
            if (!connected)
                return -1;

            connected = false;

            try
            {           
                serialPort.Close();
                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return -1;
            }
        }

        public byte[] PrintTextUnformatted(string text)
        {
            byte[] print_header = { 0x01, 0x02, 0x00, 0x00, 0x40 };
            IEnumerable<byte> print_body = Encoding.GetEncoding("EUC-KR").GetBytes(text).Concat(new byte[] { 0x0d, 0x0a });
            IEnumerable<byte> packet = print_header.Concat(print_body);

            byte[] r = packet.ToArray();
            r[2] = (byte)(print_body.Count() / 256);
            r[3] = (byte)(print_body.Count() % 256);

            return r;
        }

        public byte[] PrintText(string rtf)
        {
            // TODO
            return PrintTextUnformatted(rtf);
        }

    }
}
