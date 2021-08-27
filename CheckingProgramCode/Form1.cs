using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckingProgramCode
{
    public partial class Form1 : Form
    {
        string code = "";
        List<string> keyWordCSharp = new List<string>();
        List<char> symbolsOfCSharp = new List<char>() { ' ', '+', '/', '*', '-', '{', '}', '\\', '\n', '\t', '\r', '.', '(', ')', '\"', '\'' };
        public Form1()
        {
            InitializeComponent();
            keyWordCSharp.AddRange(Properties.Resources.KeyWordsCSharp.Replace("\r","").Split('\n'));
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = dialog.FileName;
                rtbCode.Text = File.ReadAllText(txtPath.Text);
                foreach(var key in rtbCode.Text.Split(symbolsOfCSharp.ToArray()))
                {
                    if (keyWordCSharp.Contains(key) && !lbxKeyWords.Items.Contains(key))
                    {
                        lbxKeyWords.Items.Add(key);
                    }
                }
            }
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
