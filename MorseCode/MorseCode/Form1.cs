using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseCode
{
    public partial class MorzeForm : Form
    {
        public MorzeForm()
        {
            InitializeComponent();
        }

        char[] characters = new char[] { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ж', 'З', 'И',
                                                        'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 
                                                        'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ы', 'Ь',
                                                        'Э', 'Ю', 'Я', '1', '2', '3', '4', '5', '6', '7',
                                                        '8', '9', '0' };

        string[] codeMorse = new string[] { "*–", "–***", "*––", "––*", 
                                                        "–**", "*", "***–", "––**",
                                                        "**", "*–––", "–*–", "*–**",
                                                        "––", "–*", "–––", "*––*", 
                                                        "*–*", "***", "–", "**–", 
                                                        "**–*", "****", "–*–*",
                                                        "–––*", "––––", "−−*−",
                                                        "−*−−", "−**−", "**−**",
                                                        "**−−", "*−*−", "*−−−−",
                                                        "**−−−", "***−−", "****−",
                                                        "*****", "−****", "−−***",
                                                        "−−−**", "−−−−*", "−−−−−" };

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Ошибка,введите текст", "Ошибка", MessageBoxButtons.OK);
            else
            { 
            string input = textBox1.Text;
            input = input.ToUpper();
            string output = "";
            int index;
            foreach(char c in input)
            {
                if (c != ' ')
                {
                    index = Array.IndexOf(characters, c);
                    output += codeMorse[index] + " ";
                }
            }
            output = output.Remove(output.Length - 1);
            textBox2.Text = output;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Ошибка,введите текст", "Ошибка", MessageBoxButtons.OK);
            else
            {
                string input = textBox3.Text;
            string[] split = input.Split(' ');
            string output = "";
            int index;
            foreach (string s in split)
            {
                index = Array.IndexOf(codeMorse, s);
                output += characters[index] + " ";
            }
            output = output.Remove(output.Length - 1);
            textBox4.Text = output;
            }          
    }   

    }
}
