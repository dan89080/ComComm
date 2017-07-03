using StatFunc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;


namespace ComComm
{
    public partial class ComComm_Page : Form
    {
        public const int BaudRate = 115200;
        public const int DataBits = 8;
        public List<SerialPort> PortList;
        public Color color_green = Color.FromArgb(24, 231, 71);
        public Color color_greenT = Color.FromArgb(102, 24, 231, 71);
        public Color color_yellow = Color.FromArgb(255, 255, 36);
        public Color color_yellowT = Color.FromArgb(153, 255, 255, 36);
        public Color color_blue = Color.FromArgb(60, 40, 255);
        public Color color_blueT = Color.FromArgb(215, 60, 40, 255);
        public Color color_whiteT = Color.FromArgb(102, 255, 255, 255);
        public Color color_red = Color.FromArgb(255, 0, 0);
        public Color color_white = Color.FromArgb(255, 255, 255);
        public Color color_black = Color.FromArgb(0, 0, 0);
        public Font default_font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

        private StatFuncs SF;
        private List<int> theSTR;

        public ComComm_Page()
        {
            InitializeComponent();

            GetPortList();
            PortList = new List<SerialPort>();

            //GetPortLog_1("COM6");
            //GetPortLog_2("COM9");
            textBox_test.Focus();

            Timer_Enable = false;

            //textBox_test.Text = "1";
            T_auto = new System.Timers.Timer();

            //T_auto.Interval = 41;
            T_auto.Interval = 600;
            //try { T_auto.Interval = Convert.ToInt32(textBox1.Text); }
            //catch { T_auto.Interval = 250; }
            T_auto.Elapsed += new ElapsedEventHandler(Timer_Elapsed);
            T_auto.SynchronizingObject = textBox_test;
        }

        private SerialPort comport1;
        private SerialPort comport2;
        
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
            pictureBox_Chart1.BackgroundImage = null;
            pictureBox_Chart2.BackgroundImage = null;
            GetPortList();
            T_auto.Dispose();
        }
        public void GetPortList()
        {
            string[] ports = SerialPort.GetPortNames();
            List<string> listPorts = new List<string>(ports);

            //comboBox_PortList.Items.Clear();
            //comboBox_PortList.Sorted = true;
            //comboBox_PortList.Items.AddRange(listPorts.ToArray());
            //if(comboBox_PortList.Items.Count > 0)
            //    comboBox_PortList.SelectedIndex = 0;

            ///////////////////////////////////////////////////////////////////

            comboBox_PortList1.Items.Clear();
            comboBox_PortList1.Sorted = true;
            comboBox_PortList1.Items.AddRange(listPorts.ToArray());
            if (comboBox_PortList1.Items.Count > 3)
                comboBox_PortList1.SelectedIndex = 1;

            ///////////////////////////////////////////////////////////////////

            comboBox_PortList2.Items.Clear();
            comboBox_PortList2.Sorted = true;
            comboBox_PortList2.Items.AddRange(listPorts.ToArray());
            if (comboBox_PortList2.Items.Count > 5)
                comboBox_PortList2.SelectedIndex = 5;
        }

        private void button_test_Click(object sender, EventArgs e)
        {
            try
            {
                int cnt = Convert.ToInt32(textBox_test.Text);
                List<int> yoSTR = new List<int>();

                for (int i = 0; i < cnt; i++)
                    yoSTR.Add(theSTR[i]);

                StatFuncs.CalcStats(yoSTR);
                ShowStats_test(yoSTR);
                ShowAmpCnts(yoSTR);
            }
            catch (Exception E)
            { Console.WriteLine(E.ToString()); }
        }
        /*string[] ports = SerialPort.GetPortNames();
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

            int handle = CreateFileA(
                "\\\\.\\COM%d",
                GENERIC_READ | GENERIC_WRITE,
                FILE_SHARE_READ | FILE_SHARE_WRITE,
                NULL,
                OPEN_EXISTING,
                FILE_FLAG_OVERLAPPED,
                NULL);
        public int CreateFileA(
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
            try
            {
                string thePort = comboBox_PortList1.SelectedItem.ToString();
                GetPortLog_1(thePort);
            }
            catch { }
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

            richTextBox2.Invoke((MethodInvoker)delegate
            {
                SF = new StatFuncs(indata);
                //richTextBox2.Text += SF.theINT + "\n\n";
            });

            button_test.Invoke((MethodInvoker)delegate
            {
                //button_test.PerformClick();
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

        private void button_stats1_Click(object sender, EventArgs e)
        {
            //button_StopLog1.PerformClick();

            try
            {
                char[] delimiterChars = { ':', '\n', ' ', '\t', '\r' };
                string[] words = richTextBox1.Text.Split(delimiterChars);
                //STR = "0:" + words[0] + "\n1:" + words[1] + "\n2:" + words[2] + "\n3:" + words[3];
                theSTR = new List<int>();
                foreach (string s in words)
                {
                    if (s != "")
                    {
                        int temp = Convert.ToInt32(s);
                        theSTR.Add(temp);
                    }
                }
                //button_stats1.Text = StatFuncs.CalcStats();
                button_stats1.Text = StatFuncs.CalcStats(theSTR);
                ShowStats(theSTR);


            }
            catch (Exception E) { button_stats1.Text = E.Message; }
        }

        public void ShowStats(List<int> inputData)
        {
            Image my_grid = new Bitmap(pictureBox_Chart1.Width, pictureBox_Chart1.Height);
            List<int> DataCounting = new List<int>();
            int inMin = inputData.Min();
            int inMax = inputData.Max();
            for (int i = inMin; i <= inMax; i++)
                DataCounting.Add(0);
            for (int i = 0; i < inputData.Count; i++)
                DataCounting[inputData[inputData.Count - i - 1] - inMin]++;
            float PicGap_Wd = pictureBox_Chart1.Width / (DataCounting.Count - 1);
            float PicGap_Ht = pictureBox_Chart1.Height * 0.9F / DataCounting.Max();

            using (Graphics g = Graphics.FromImage(my_grid))
            {
                PointF now = new Point();
                now.X = 0 * PicGap_Wd;
                now.Y = pictureBox_Chart1.Height - DataCounting[0] * PicGap_Ht;
                g.DrawEllipse(new Pen(color_blue, 1.6F), now.X-3, now.Y-3, 6, 6);
                for (int i = 1; i < DataCounting.Count; i++)
                {
                    PointF next = new Point();
                    next.X = i * PicGap_Wd;
                    next.Y = pictureBox_Chart1.Height - DataCounting[i] * PicGap_Ht;
                    g.DrawLine(new Pen(color_yellow, 1.2F), now, next);
                    //g.DrawEllipse(new Pen(color_blue, 1.6F), next.X - 3, next.Y - 3, 6, 6);

                    now.X = next.X;
                    now.Y = next.Y;
                }
                for (int i = 1; i < DataCounting.Count; i++)
                {
                    PointF next = new Point();
                    next.X = i * PicGap_Wd;
                    next.Y = pictureBox_Chart1.Height - DataCounting[i] * PicGap_Ht;
                    //g.DrawLine(new Pen(color_yellow, 1.2F), now, next);
                    g.DrawEllipse(new Pen(color_blue, 2.8F), next.X - 1.5F, next.Y - 1.5F, 3, 3);

                    now.X = next.X;
                    now.Y = next.Y;
                }

            }
            pictureBox_Chart1.BackgroundImage = my_grid;

            richTextBox_Stat1_1.Text = string.Format("Total  : {0}\nRange  : {1} ~ {2}\nMax Cnt: {3}\nMin Cnt: {4}",
                DataCounting.Sum(), inputData.Min(), inputData.Max(), DataCounting.Max(), DataCounting.Min());
            richTextBox_Stat1_2.Text = string.Format("Min : {0}\nMax : {1}\nMean: {2}\nVar :   {3}",
                StatFuncs.Min, StatFuncs.Max, StatFuncs.Mean, StatFuncs.Var);
        }

        public void ShowStats_test(List<int> inputData)
        {
            Image my_grid = new Bitmap(pictureBox_Chart2.Width, pictureBox_Chart2.Height);
            List<int> DataCounting = new List<int>();
            int inMin = inputData.Min();
            int inMax = inputData.Max();
            for (int i = inMin; i <= inMax; i++)
                DataCounting.Add(0);
            for (int i = 0; i < inputData.Count; i++)
                DataCounting[inputData[inputData.Count - i - 1] - inMin]++;
            float PicGap_Wd = pictureBox_Chart2.Width / (DataCounting.Count - 1);
            float PicGap_Ht = pictureBox_Chart2.Height * 0.9F / DataCounting.Max();

            using (Graphics g = Graphics.FromImage(my_grid))
            {
                PointF now = new Point();
                now.X = 0 * PicGap_Wd;
                now.Y = pictureBox_Chart2.Height - DataCounting[0] * PicGap_Ht;
                g.DrawEllipse(new Pen(color_blue, 1.6F), now.X - 3, now.Y - 3, 6, 6);
                for (int i = 1; i < DataCounting.Count; i++)
                {
                    PointF next = new Point();
                    next.X = i * PicGap_Wd;
                    next.Y = pictureBox_Chart2.Height - DataCounting[i] * PicGap_Ht;
                    g.DrawLine(new Pen(color_yellow, 1.2F), now, next);
                    //g.DrawEllipse(new Pen(color_blue, 1.6F), next.X - 3, next.Y - 3, 6, 6);

                    now.X = next.X;
                    now.Y = next.Y;
                }
                for (int i = 1; i < DataCounting.Count; i++)
                {
                    PointF next = new Point();
                    next.X = i * PicGap_Wd;
                    next.Y = pictureBox_Chart2.Height - DataCounting[i] * PicGap_Ht;
                    //g.DrawLine(new Pen(color_yellow, 1.2F), now, next);
                    g.DrawEllipse(new Pen(color_blue, 2.8F), next.X - 1.5F, next.Y - 1.5F, 3, 3);

                    now.X = next.X;
                    now.Y = next.Y;
                }

            }
            pictureBox_Chart2.BackgroundImage = my_grid;

            richTextBox_Stat2_1.Text = string.Format("Total  : {0}\nRange  : {1} ~ {2}\nMax Cnt: {3}\nMin Cnt: {4}",
                DataCounting.Sum(), inputData.Min(), inputData.Max(), DataCounting.Max(), DataCounting.Min());
            richTextBox_Stat2_2.Text = string.Format("Min : {0}\nMax : {1}\nMean: {2}\nVar :   {3}",
                StatFuncs.Min, StatFuncs.Max, StatFuncs.Mean, StatFuncs.Var);
        }
        public void ShowAmpCnts(List<int> inputData)
        {
            Image my_grid = new Bitmap(pictureBox_Chart4.Width, pictureBox_Chart4.Height);
            List<int> DataCounting = new List<int>();
            int Cnt = Convert.ToInt32(textBox_AmpCnt.Text);
            float PicGap_Ht = pictureBox_Chart2.Height / (inputData.Max() - inputData.Min() + 1); ;
            float PicGap_Wd = my_grid.Width / 2;
            using (Graphics g = Graphics.FromImage(my_grid))
            {
                PointF A = new Point((int)PicGap_Wd, 0);
                PointF B = new Point((int)PicGap_Wd, my_grid.Height - 1);
                g.DrawLine(new Pen(color_yellowT, 0.8F), A, B);
                //for (int i = 1; i <= inputData.Max() - inputData.Min() + 2; i++)
                for (int i = inputData.Max() - inputData.Min() + 2; i > 0; i--)
                {
                    double ht = pictureBox_Chart2.Height - (i - 0.5) * PicGap_Ht;
                    PointF C = new Point(0, (int)ht);
                    PointF D = new Point(my_grid.Width, (int)ht);
                    if ((i) % 5 != 0)
                        g.DrawLine(new Pen(color_blueT, 1.2F), C, D);
                    else
                        g.DrawLine(new Pen(color_greenT, 1.2F), C, D);
                }

                if (inputData.Count < Cnt)
                    Cnt = inputData.Count;

                PointF now = new Point();
                now.X = PicGap_Wd;
                for (int i = inputData.Count - Cnt; i < inputData.Count; i++)
                //for (int i = inputData.Count - 1; i >= inputData.Count - Cnt; i--)
                {
                    now.Y = pictureBox_Chart2.Height - (inputData[i] - inputData.Min() + 0.5F) * PicGap_Ht;
                    g.DrawEllipse(new Pen(color_whiteT, 1.6F), now.X - 3, now.Y - 3, 6, 6);
                }
                g.DrawEllipse(new Pen(color_red, 1.6F), now.X - 3, now.Y - 3, 6, 6);
            }
            pictureBox_Chart4.BackgroundImage = my_grid;

        }


        private void textBox_test_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //button_test.PerformClick();
            }
        }
        private void textBox_test_TextChanged(object sender, EventArgs e)
        {
            button_test.PerformClick();
        }

        private void textBox_test_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                int cnt = Convert.ToInt32(textBox_test.Text);
                //switch (e.)
                //{
                //    case 
                //        cnt++;
                //        break;
                //    case Keys.Down:
                //        cnt--;
                //        break;
                //    default:
                //        break;
                //}
            }
            catch (Exception E) { }
        }

        private void button_auto_Click(object sender, EventArgs e)
        {
            

            Timer_Enable = !Timer_Enable;

            if (Timer_Enable)
            {
                T_auto.Start();
                button_auto.Text = "stop";
            }
            else
            {
                button_auto.Text = "auto";
                T_auto.Stop();
            }
            
            

        }
        bool Timer_Enable;
        System.Timers.Timer T_auto;
        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            try
            {
                int cnt = Convert.ToInt32(textBox_test.Text) + 1;
                if (cnt > Convert.ToInt32(textBox_auto.Text) || cnt > theSTR.Count || Timer_Enable == false)
                {
                    T_auto.Stop();
                    return;
                }
                textBox_test.Text = cnt.ToString();
            }
            catch(Exception E) { }
        }




    }
}
