using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ComComm
{
    public partial class ComComm_Page : Form
    {
        public const int BaudRate = 115200;
        public const int DataBits = 8;
        public List<SerialPort> PortList;
        public Color color_green = Color.FromArgb(24, 231, 71);
        public Color color_yellow = Color.FromArgb(255, 255, 36);
        public Color color_blue = Color.FromArgb(60, 40, 255);
        public Color color_red = Color.FromArgb(255, 0, 0);
        public Color color_white = Color.FromArgb(255, 255, 255);
        public Color color_black = Color.FromArgb(0, 0, 0);
        public Font default_font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

        public ComComm_Page()
        {
            InitializeComponent();

            GetPortList();
            PortList = new List<SerialPort>();

            //GetPortLog_1("COM6");
            //GetPortLog_2("COM9");
            comboBox_PortList.Focus();
        }

        private SerialPort comport1;
        private SerialPort comport2;
        private void button1_Click(object sender, EventArgs e)
        {
            //comport1 = new SerialPort("COM4", BaudRate, Parity.None, DataBits, StopBits.One);
            //comport2 = new SerialPort("COM4", BaudRate, Parity.None, DataBits, StopBits.One);
            comport1 = new SerialPort("COM4", BaudRate);
            comport2 = new SerialPort("COM4", BaudRate);
            OpenOnePort(comport1);
            OpenOnePort(comport2);

            foreach(SerialPort sp in PortList)
            {
                OpenOnePort(sp);
            }
        }

        private void OpenOnePort(SerialPort comport)
        {
            try
            {
                if (!comport.IsOpen)
                    comport.Open();
                else
                    MessageBox.Show("Port " + comport.PortName + " is opened.");
            }
            catch(Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void button_RefreshPortList_Click(object sender, EventArgs e)
        {
            GetPortList();
        }
        public void GetPortList()
        {
            string[] ports = SerialPort.GetPortNames();
            List<string> listPorts = new List<string>(ports);

            comboBox_PortList.Items.Clear();
            comboBox_PortList.Sorted = true;
            comboBox_PortList.Items.AddRange(listPorts.ToArray());
            if(comboBox_PortList.Items.Count > 0)
                comboBox_PortList.SelectedIndex = 0;

            ///////////////////////////////////////////////////////////////////

            comboBox_PortList1.Items.Clear();
            comboBox_PortList1.Sorted = true;
            comboBox_PortList1.Items.AddRange(listPorts.ToArray());
            if (comboBox_PortList1.Items.Count > 3)
                comboBox_PortList1.SelectedIndex = 3;

            ///////////////////////////////////////////////////////////////////

            comboBox_PortList2.Items.Clear();
            comboBox_PortList2.Sorted = true;
            comboBox_PortList2.Items.AddRange(listPorts.ToArray());
            if (comboBox_PortList2.Items.Count > 5)
                comboBox_PortList2.SelectedIndex = 5;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            List<string> listPorts = new List<string>(ports);

            richTextBox1.Text = "";
            foreach(string s in listPorts)
            {
                SerialPort sp = new SerialPort(s, BaudRate);
                if (!sp.IsOpen)
                    richTextBox1.Text += "not open.\n";
                else
                    richTextBox1.Text += "is open.\n";
            }

            /*int handle = CreateFileA(
                "\\\\.\\COM%d",
                GENERIC_READ | GENERIC_WRITE,
                FILE_SHARE_READ | FILE_SHARE_WRITE,
                NULL,
                OPEN_EXISTING,
                FILE_FLAG_OVERLAPPED,
                NULL);*/
        }
        /*public int CreateFileA(
            LPCSTR lpFileName,
            DWORD dwDesiredAccess,
            DWORD dwShareMode,
            LPSECURITY_ATTRIBUTES lpSecurityAttributes,
            DWORD dwCreationDisposition,
            DWORD dwFlagsAndAttributes,
            int hTemplateFile)
        {

        }*/


        private void button_GetPortLog1_Click(object sender, EventArgs e)
        {
            string thePort = comboBox_PortList1.SelectedItem.ToString();            
            GetPortLog_1(thePort);
        }
        private void button_GetPortLog2_Click(object sender, EventArgs e)
        {
            string thePort = comboBox_PortList2.SelectedItem.ToString();
            GetPortLog_2(thePort);
        }
        private void GetPortLog_1(string thePort)
        {
            try
            {
                comport1 = new SerialPort(thePort, BaudRate, Parity.None, 8, StopBits.One);
                comport1.Encoding = Encoding.Default;
                comport1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler_1);
                OpenOnePort(comport1);
            }
            catch
            {
                MessageBox.Show("Cannot open selected port.");
            }
        }
        private void GetPortLog_2(string thePort)
        {
            try
            {
                comport2 = new SerialPort(thePort, BaudRate, Parity.None, 8, StopBits.One);
                comport2.Encoding = Encoding.Default;
                comport2.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler_2);
                OpenOnePort(comport2);
            }
            catch
            {
                MessageBox.Show("Cannot open selected port.");
            }
        }
        private void DataReceivedHandler_1(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            richTextBox1.Invoke((MethodInvoker)delegate
            {
                richTextBox1.SelectionColor = color_white;
                richTextBox1.SelectionFont = default_font;
                richTextBox1.AppendText(indata);
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                richTextBox1.ScrollToCaret();
                richTextBox1.Font = default_font;
            });
            button_GetPortLog1.Invoke((MethodInvoker)delegate
            {
                button_GetPortLog1.Focus();
            });
        }
        private void DataReceivedHandler_2(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            richTextBox2.Invoke((MethodInvoker)delegate
            {
                richTextBox2.SelectionColor = color_white;
                richTextBox2.SelectionFont = default_font;
                richTextBox2.AppendText(indata);
                richTextBox2.SelectionStart = richTextBox2.Text.Length;
                richTextBox2.ScrollToCaret();
                richTextBox2.Font = default_font;
            });
            button_GetPortLog2.Invoke((MethodInvoker)delegate
            {
                button_GetPortLog2.Focus();
            });
        }
        private void button_StopLog1_Click(object sender, EventArgs e)
        {
            if (comport1.IsOpen)
                comport1.Close();
        }
        private void button_StopLog2_Click(object sender, EventArgs e)
        {
            if (comport2.IsOpen)
                comport2.Close();
        }
        private void button_ClrLog1_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Invoke((MethodInvoker)delegate
                {
                    richTextBox1.Text = "";
                });
            } catch { }
        }
        private void button_ClrLog2_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox2.Invoke((MethodInvoker)delegate
                {
                    richTextBox2.Text = "";
                });
            } catch { }
        }

        

    }
}
