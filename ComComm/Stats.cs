using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatFunc
{
    public class StatFuncs
    {
        private const int Default_Val = 255;
        static public List<int> TheDatas = new List<int>();
        static public int Min = Default_Val;
        static public int Max = Default_Val;
        static public int Mid = Default_Val;
        static public double Mean = Default_Val;
        static public double Var = Default_Val;

        public string STR;
        public int theINT;
        public List<string> theSTR;

        public StatFuncs(string inputData)
        {
            //TheDatas = inputData;
            theSTR = new List<string>();
            theINT = 127;
            try
            {
                char[] delimiterChars = { ':', '\n', ' ', '\t', '\r' };
                string[] words = inputData.Split(delimiterChars);
                //STR = "0:" + words[0] + "\n1:" + words[1] + "\n2:" + words[2] + "\n3:" + words[3];
                STR = "";
                foreach(string s in words)
                {
                    if(s!="")
                    {
                        STR += s + "/\\";
                        theSTR.Add(s);
                    }
                }
            }
            catch { STR = ""; }

            try
            {
                int temp = Convert.ToInt32(theSTR[3]);
                theINT = temp;
                TheDatas.Add(temp);
            }
            catch { }
        }

        static public string CalcStats(List<int> inputData)
        {
            Min = inputData.Min();
            Max = inputData.Max();
            Mid = inputData[inputData.Count / 2];
            Mean = (double)inputData.Sum() / (double)inputData.Count;
            Mean = Math.Round(Mean, 3);


            Var = GetVariance(inputData);
            Var = Math.Round(Var, 3);
            return string.Format("Min:{0} Max:{1} Mean:{2} Var:{3}",Min, Max, Mean, Var);
        }

        static public string CalcStats()
        {
            int Min = TheDatas.Min();
            int Max = TheDatas.Max();
            int Mid = TheDatas[TheDatas.Count / 2];
            int Mean = TheDatas.Sum() / TheDatas.Count;

            double Var = GetVariance(TheDatas);
            Var = Math.Round(Var, 3);
            return string.Format("Min:{0} Max:{1} Mean:{2} Var:{3}", Min, Max, Mean, Var);
        }
        static private double GetVariance(List<int> val)
        {
            double avg = AVG(val);
            //double _result = 0;
            //foreach (double d in val) _result += Math.Pow(d - avg, 2);
            double _result = (from a in val
                              select Math.Pow(a - avg, 2)).Sum();
            double _sum = _result / (double)(val.Count);
            double _Sqrt = Math.Sqrt(_sum);
            return _Sqrt;
        }
        static private double AVG(List<int> val)
        {
            double _avg = SUM(val) / (double)val.Count;
            return _avg;
        }
        static private double SUM(List<int> val)
        {
            var _sum = (from g in val
                        select g).Sum();
            return _sum;
        }

    }
}
