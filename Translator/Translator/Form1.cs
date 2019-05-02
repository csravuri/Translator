using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Translator.FullLogic;

namespace Translator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TranslateButton_Click(object sender, EventArgs e)
        {
            TranslateText translator = new TranslateText();
            this.translateLabel.Text = translator.Translate(this.SourceTextBox.Text, "en|te");
        }
    }
}
