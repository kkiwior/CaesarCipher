using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CaesarCipher
{
    public partial class CaesarCipher : Form
    {
        private bool clicked = false;
        protected List<string> Words;

        public CaesarCipher()
        {
            InitializeComponent();
        }

        private void EncDecForm_Load(object sender, EventArgs e)
        {
            var file = File.ReadAllLines("slowa.txt");
            Words = new List<string>(file);
        }

        private void szyfr1_TextChanged(object sender, EventArgs e)
        {
            if (clicked || String.IsNullOrEmpty(caesarEncrypt.Text))
            {
                clicked = false;
                return;
            }

            Encrypt(key.Text);
        }

        private void klucz_TextChanged(object sender, EventArgs e)
        {
            Encrypt(key.Text);
        }

        private void bruteForce_Click(object sender, EventArgs e)
        {
            clicked = true;
            string bf = "";
            for (int i = 0; i < 25; ++i)
            {
                bf += Shift(caesarDecrypt.Text, i + 1) + Environment.NewLine;
            }

            caesarEncrypt.Text = bf;
        }

        private void Encrypt(string keyShift)
        {
            try
            {
                caesarDecrypt.Text = Shift(caesarEncrypt.Text, Convert.ToInt32(keyShift));
            }
            catch (Exception e)
            {
                caesarDecrypt.Text = e.Message;
            }
        }

        private string Shift(string str, int keyShift)
        {
            string ret = "";
            foreach (var s in str)
            {
                int c = keyShift + s;
                ret += Convert.ToChar(Char.IsLower(s) ? (c - 'a') % ('z' - 'a' + 1) + 'a' :
                    Char.IsUpper(s) ? (c - 'A') % ('z' - 'a' + 1) + 'A' : s);
            }

            return ret;
        }

        private void tryDecode_Click(object sender, EventArgs e)
        {
            clicked = true;
            for (int i = 0; i < 26; ++i)
            {
                var sh = Shift(caesarDecrypt.Text, i + 1);
                var searchWord = sh.Split(' ')[0].ToLower();
                var res = Words.BinarySearch(searchWord);
                if (res >= 0)
                {
                    caesarEncrypt.Text = sh;
                    return;
                }
            }
        }
    }
}
