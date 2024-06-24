using System.CodeDom.Compiler;
using System.Diagnostics.Eventing.Reader;

namespace Homework7_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        char[,] alphabet =
        {

            {'a','b','c','d','e'},
            {'f','g','h','i','k'},
            {'l','m','n','o','p'},
            {'q','r','s','t','u'},
            {'v','w','x','y','z'}

        };

        string result = "";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToLower();
            
            for(int i = 0; i < textBox1.Text.Length; i++)
            {
                if(textBox1.Text[i] == 'j')
                        {
                    result += "42 ";
                }
                for (int m = 0; m < 5; m++) {
                    for (int n = 0; n < 5; n++) {
                            
                        if (textBox1.Text[i] == alphabet[m,n])
                        {
                            string temp = (n+1).ToString() + (m+1).ToString();
                           
                            result += temp + " ";
                           
                        }
                        
                    }
                    textBox2.Text = result;
                } 
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            result = "";
        }
    }
}