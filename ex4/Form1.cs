using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] words = textBox1.Text.Split(' ');
            List<string> res = new List<string>();
            foreach(string word in words)
            {
                char[] c = word.ToCharArray();
                if (word.Length % 2 != 0 && c[0] == 'п' && c[1] == 'о')
                    res.Add(word);
            }
            if (!res.Any())
                textBox2.Text = "В исходной строк нет подходящих слов!";
            else
                foreach (string str in res)
                    textBox2.Text += str + " ";
        }
    }
}
