using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _2v_lb1
{
    public partial class Form1 : Form
    {
        string line;
        string Filename = "text.txt";

        public Form1()
        {
            InitializeComponent();
        }
                 
        private void button1_Click_1(object sender, EventArgs e)
        {
            
            Metodth.WriteRandomNumber(Filename);  
            //textBox1.Text = Metodth.ReadFile(Filename);
            //label1.Text = Metodth.ReadFile(Filename);
            using (StreamReader sr = new StreamReader("text.txt"))
            {
                line = sr.ReadToEnd();
                textBox1.Text = line;                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            Metodth.Swap(Filename);
            using (StreamReader sr = new StreamReader("text.txt"))
            {
                line = sr.ReadToEnd();
                textBox1.Text = line;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
