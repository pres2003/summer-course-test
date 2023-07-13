using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace summer_course_test
{
    public partial class Form1 : Form
    {
        char[] delimiterChars = { ' ', ',', '.', ':', '\t', '(', ')' };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<char> uniclist = new List<char>();
            string[] raw_text_words = raw_text.Text.Split(delimiterChars, System.StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < raw_text_words.Length; i++)
            {
                for (int j = 0; j < raw_text_words[i].Length; j++)
                {
                    bool unic_check = false;
                    for (int k = 0; k < raw_text_words[i].Length; k++)
                    {
                        if (raw_text_words[i][j] == raw_text_words[i][k] && j!=k)
                        {
                            unic_check = false;
                            break;
                        }

                        if (k+1 == raw_text_words[i].Length) 
                        { 
                            unic_check = true;
                        }
                    }

                    if (unic_check)
                    {
                        char kk = raw_text_words[i][j];
                        uniclist.Add(raw_text_words[i][j]);
                        break;
                    }
                }
            }

            for (int j = 0; j < uniclist.Count; j++)
            {
                bool unic_check = false;
                for (int k = 0; k < uniclist.Count; k++)
                {
                    if (uniclist[j] == uniclist[k] && j!=k)
                    {
                        unic_check = false;
                        break;
                    }

                    if (k+1 == uniclist.Count) { unic_check = true; }
                }

                if (unic_check)
                {
                    rez_text.Text = System.Convert.ToString(uniclist[j]);
                    break;
                }
            }
        }
    }
}
