using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ThreadSpy
{
    class TextBoxHelper
    {
        static private TextBox textbox;
        public delegate void UpdateTextCallback(char c);

        static private int nbr = 0;

        // 

        /// <summary>
        /// This method will add the char c into the textbox tb
        /// </summary>
        /// <param name="tb"></param> The TextBox where the char will be added
        /// <param name="c"></param> The char to add
        static public void AddChar(TextBox tb, char c, int n)
        {
            textbox = tb;
            nbr = n;
            textbox.Invoke(new UpdateTextCallback(AddCharSave), c);
        }

        static private void AddCharSave(char c)
        {
            textbox.Text += c;
            Console.WriteLine(nbr);
        }
    }
}
