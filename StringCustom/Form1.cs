using StringCustom.Character;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StringCustom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strSouce = getStringSouce();
            int strLength = int.Parse(tboxLength.Text);
            string str = "";
            if (strSouce.Length > 0)
            {
                Random random = new Random();
                for (int i = 0; i < strLength; i++) { 
                    str += strSouce.Substring(random.Next(0, strSouce.Length), 1);
                }
                textBox2.Text = str;
            }
        }

        private string getStringSouce()
        {
            string temp = "";
            if (cboxAlpha.Checked)
                temp += MyAlphabet.strs;
            if (cboxNum.Checked)
                temp += MyNum.strs;
            if (cboxMark.Checked)
                temp += MyMark.strs;
            if (cboxChinese.Checked)
                temp += MyChinese.strs;
            return temp;
        }
    }
}
