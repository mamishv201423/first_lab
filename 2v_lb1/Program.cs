using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.IO;

namespace _2v_lb1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
     
        static void Main(string[] args)
        {
            
            string Filename = "text.txt";
            //Metodth.WriteRandomNumber(Filename);
           
            //Metodth.Swap(Filename);
            
            //Metodth.ReadFile(Filename);            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }


        public static class Metodth
        {
            public static double getRandomNumber(this Random rnd, double _min, double _max)
            {
                return rnd.NextDouble() * (_max - _min) + _min;
            }

            public static void WriteNumbers(string _filename, double[] _str)
            {
                using (StreamWriter writer = File.CreateText(_filename))
                {

                    for (int i = 0; i < 10; i++)
                    {
                        writer.WriteLine(_str[i]);
                    }
                }
            }

           public  static void WriteRandomNumber(string _filename)
            {
                using (StreamWriter writer = File.CreateText(_filename))
                {
                    Random rnd = new Random();
                    for (int i = 0; i < 10; i++)
                    {
                        writer.WriteLine(getRandomNumber(rnd, -5.00, 5.00));
                        
                    }             
                }
            }

            //public static string ReadFile(string _filename)
            //{
            //    using (StreamReader reader = File.OpenText(_filename))
            //    {
            //        string line = null;
            //        do
            //        {
            //            line = reader.ReadLine();
                        
            //        }
            //        while (line != null);
            //    return line;
            //    }                
            //}

            public static void Swap(string _filename)
            {
                double[] number = new double[10];
                double max, min;
                using (StreamReader reader = File.OpenText(_filename))
                {
                    for (int i = 0; i < 10; i++)
                    {
                        number[i] = Convert.ToDouble(reader.ReadLine());
                    }

                }
                int index_max = 0, index_min = 0;
                max = number[0]; min = number[0];
                for (int i = 1; i < 10; i++)
                {
                    if (number[i] < min)
                    {
                        min = number[i];
                        index_min = i;
                    }
                    else if (number[i] > max)
                    {
                        max = number[i];
                        index_max = i;
                    }
                }
                double swap = number[index_max];
                number[index_max] = number[index_min];
                number[index_min] = swap;
                WriteNumbers(_filename, number);
            }

            
        }
    }

