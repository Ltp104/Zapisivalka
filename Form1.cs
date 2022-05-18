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

namespace Oboba327
{
    public partial class Form1 : Form
    {
        private string _textToWrite;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var streamReader = new StreamReader(@"C:\Users\Студент\Desktop\qwerty\1234.txt");
            
            _textToWrite = streamReader.ReadToEnd();

            streamReader.Close();

            _textToWrite += textBox.Text;

            var streamWriter = new StreamWriter(@"C:\Users\Студент\Desktop\qwerty\1234.txt");
            
            streamWriter.Write(_textToWrite);

            streamWriter.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var streamReader = new StreamReader(@"C:\Users\Студент\Desktop\qwerty\1234.txt");

            textBox.Text = streamReader.ReadToEnd();

            streamReader.Close();
        }
    }
}
