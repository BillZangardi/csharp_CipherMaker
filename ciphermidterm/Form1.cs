using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CipherMidterm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblResult.Text = "";
            lblResultHeader.Text = "";
        }
        string enteredWord;
        string result;
        string letterShift;
        Cipher cipher = new Cipher();

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            enteredWord=txtWord.Text;
            letterShift=txtLetterShift.Text;
            result = cipher.EncryptWord(enteredWord, letterShift);
            lblResultHeader.Text = "Your Encrypted Word is:";
            lblResult.Text = result;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            enteredWord = txtWord.Text;
            letterShift = txtLetterShift.Text;
            result = cipher.DecryptWord(enteredWord, letterShift);
            lblResultHeader.Text = "Your Decrypted Word is:";
            lblResult.Text = result;
        }
    }
}
