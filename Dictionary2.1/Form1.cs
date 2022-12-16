using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            {
                // Create a new dictionary to hold English-Turkish translations
                Dictionary<string, string> dictionary = new Dictionary<string, string>();

                // Add some translations to the dictionary
                dictionary.Add("book", "kitap".ToLower());
                dictionary.Add("pen", "kalem".ToLower());
                dictionary.Add("computer", "bilgisayar".ToLower());
                dictionary.Add("dog", "köpek".ToLower());
                dictionary.Add("merhaba", "Hello".ToLower());
                dictionary.Add("nasılsın", "How are you".ToLower());
                dictionary.Add("nerelisin", "Where you from".ToLower());
                dictionary.Add("nerede oturuyorsun", "where do you live".ToLower());
                dictionary.Add("nasıl gidiyor", "how's it going".ToLower());
                dictionary.Add("naber", "What's Up?".ToLower());
                dictionary.Add("hi", "selam".ToLower());

                // Get the word from the text box
                string word = textBox1.Text;

                // Look up the word in the dictionary and print the translation
                if (dictionary.ContainsKey(word))
                {
                    MessageBox.Show("Translation: " + dictionary[word]);
                }
                else
                {
                    MessageBox.Show("Sorry, that word is not in the dictionary.");
                }
                textBox1.Clear();
            }

          
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //enter' a basıldığında buraya girer.
                textBox1.Text = textBox1.Text.ToLower();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
