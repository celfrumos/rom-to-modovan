using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranslateToCyrillic
{
    public partial class ConvertForm : Form
    {

        public ConvertForm()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string inputText = txtBoxInput.Text.Trim();
            txtBoxOriginal.Text = txtBoxInput.Text;

            // Receive text input
            if (txtBoxInput.Text != "")
            {
                // Convert tokens to Cyrillic Letters 
                ConvertString(ref inputText);

            }
            else
            {
                MessageBox.Show("A hole");
            }
            txtBoxInput.Clear();
            txtBoxInput.Focus();

        }

        private void ConvertString(ref string inputText)
        {
            Conversion Conversion = new Conversion();

            // List to hold the characters
            string convertedText;
            List<string> charList = new List<string>();

            string letters;

            // Loop to assign the correct cyrillic text to each letter
            for (int i = 0; i < inputText.Length; i++)
            {
                // Initialize char values to be left alone if no letter corresponding letter is found
                char ch0 = '0';
                char ch;
                char ch2 = '2';

                // index values for other chars
                int h = i - 1;
                int j = i + 1;
                try
                {
                    ch = inputText[i];
                    // if there is a letter after i, set ch2
                    if (j < inputText.Length)
                    {
                        ch2 = inputText[j];
                    }
                    // If there is a letter before i, set ch0
                    if (h >= 0)
                    {
                        ch0 = inputText[h];
                    }

                    // Go do the thing and bring in the cyrillic baby
                    letters = Conversion.Letters(ref ch0, ref ch, ref ch2 );

                    charList.Add(letters);

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
            // 
            convertedText = string.Join("", charList);

            // Display converted text
            txtBoxConverted.Text = convertedText;

        }

        ///// <summary>
        ///// Converts each letter to cyrillic
        ///// </summary>
        ///// <param name="ch"></param>
        ///// <returns></returns>
        //private string ConvertLetters(ref char ch, ref char ch2, ref char ch0)
        //{
        //}

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

