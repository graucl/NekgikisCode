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
            var cleanSentence = decoder.CleanString(labelMessage.Text);
            var dictionary = decoder.BuildDictionary(labelNumbers.Text, cleanSentence);
            var url = decoder.GenerateURL(dictionary);

            MessageBox.Show("Message decoded!\nThe URL is:\n" + url);

            var ok = decoder.ConnectionTestURL(url);

            if (ok == true)
            {
                MessageBox.Show("La URL és correcta");
            }
            else
            {
                MessageBox.Show("La URL és incorrecta");
            }
        }
    }
}
