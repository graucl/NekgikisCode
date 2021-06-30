using System;
using System.Windows.Forms;

namespace NekgikisCode
{
    public partial class frmNekgikis : Form
    {
        public frmNekgikis()
        {
            InitializeComponent();
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            var decoder = new Decoder();
            var cleanSentence = decoder.cleanString(labelMessage.Text);
            var dictionary = decoder.BuildDictionary(labelNumbers.Text, cleanSentence);
        }
    }
}
