using Algorithms;
using System.Diagnostics;
using System.Text;

namespace UI
{
    public partial class Form1 : Form
    {
        private string _inFilePath = string.Empty;
        private string _outFilePath = string.Empty;
        public Form1()
        {
            InitializeComponent();
            LoadAlgorithms();
            DisableAll();
        }

        private void LoadAlgorithms()
        {
            AlgorithmslstBox.Items.AddRange(new[]
            {
                "Affine Cipher",
                "Caesar Cipher",
                "Columnar Transposition Cipher",
                "Playfair Cipher",
                "Reverse Cipher",
                "Vigenère Cipher",
                "RSA"
            });
        }

        private void Uploadbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileLbl.Text = $"File Path :\n{ofd.FileName}";
                _inFilePath = ofd.FileName;
            }
            else
            {
                MessageBox.Show("PLease select a file", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DisableAll()
        {
            atxtBox.ReadOnly = true;
            btextBox.ReadOnly = true;
            keyTextBox.ReadOnly = true;
            shiftTextBox.ReadOnly = true;
            colKtextbox.ReadOnly = true;
            pTextBox.ReadOnly = true;
            qTextBox.ReadOnly = true;

            atxtBox.BackColor = Color.RosyBrown;
            btextBox.BackColor = Color.RosyBrown;
            keyTextBox.BackColor = Color.RosyBrown;
            shiftTextBox.BackColor = Color.RosyBrown;
            colKtextbox.BackColor = Color.RosyBrown;
            pTextBox.BackColor = Color.RosyBrown;
            qTextBox.BackColor = Color.RosyBrown;

            atxtBox.Text = "";
            btextBox.Text = "";
            keyTextBox.Text = "";
            shiftTextBox.Text = "";
            colKtextbox.Text = "";
            pTextBox.Text = "";
            qTextBox.Text = "";

        }
        private void AlgorithmslstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (AlgorithmslstBox.SelectedItem.ToString())
            {
                case "Affine Cipher":
                    DisableAll();
                    atxtBox.ReadOnly = false;
                    atxtBox.BackColor = Color.White;
                    btextBox.ReadOnly = false;
                    btextBox.BackColor = Color.White;

                    break;
                case "Caesar Cipher":
                    DisableAll();
                    shiftTextBox.ReadOnly = false;
                    shiftTextBox.BackColor = Color.White;
                    break;

                case "Columnar Transposition Cipher":
                    DisableAll();
                    colKtextbox.ReadOnly = false;
                    colKtextbox.BackColor = Color.White;
                    break;

                case "Playfair Cipher":
                case "Vigenère Cipher":
                    DisableAll();
                    keyTextBox.ReadOnly = false;
                    keyTextBox.BackColor = Color.White;
                    break;

                case "RSA":
                    DisableAll();
                    pTextBox.ReadOnly = false;
                    qTextBox.ReadOnly = false;
                    pTextBox.BackColor = Color.White;
                    qTextBox.BackColor = Color.White;
                    break;

                default:
                    DisableAll();
                    break;
            }
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Text Files (*.txt)|*.txt";
            if (sd.ShowDialog() == DialogResult.OK)
            {
                outFileLbl.Text = $"File Path :\n{sd.FileName}";
                _outFilePath = sd.FileName;
            }
            else
                MessageBox.Show("PLease select a location");
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            string errorMsg = ValidateSteps();

            if (errorMsg != String.Empty)
            {
                MessageBox.Show(errorMsg, "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string inText = File.ReadAllText(_inFilePath);
            string outText = string.Empty;

            switch (AlgorithmslstBox.SelectedItem.ToString())
            {
                case "Affine Cipher":

                    int a, b;
                    int.TryParse(atxtBox.Text, out a);
                    int.TryParse(btextBox.Text, out b);

                    if (a <= 0 || b <= 0)
                    {
                        MessageBox.Show("A and B can be integers only and can't be zero");
                        return;
                    }
                    if (encRdbtn.Checked)
                        outText = AffineCipher.Encryption(inText, a, b);
                    else
                        outText = AffineCipher.Decryption(inText, a, b);
                    break;

                case "Caesar Cipher":
                    int shift;
                    int.TryParse(shiftTextBox.Text, out shift);

                    if (shift <= 0)
                    {
                        MessageBox.Show("Shift be integer only and can't be zero");
                        return;
                    }

                    if (encRdbtn.Checked)
                        outText = CaesarCipher.Encryption(inText, int.Parse(shiftTextBox.Text));
                    else
                        outText = CaesarCipher.Decryption(inText, int.Parse(shiftTextBox.Text));
                    break;

                case "Columnar Transposition Cipher":

                    if (!ValidColKey(colKtextbox.Text))
                    {
                        MessageBox.Show("ColKey consists of distinict elements only");
                        return;
                    }

                    if (encRdbtn.Checked)
                        outText = ColumnarTranspositionCipher.Encryption(inText, colKtextbox.Text);
                    else
                        outText = ColumnarTranspositionCipher.Decryption(inText, colKtextbox.Text);
                    break;

                case "Playfair Cipher":
                    if (!CheckKey(keyTextBox.Text))
                    {
                        MessageBox.Show("Key can be chars only");
                        return;
                    }

                    if (encRdbtn.Checked)
                        outText = PlayfairCipher.Encryption(inText, keyTextBox.Text);
                    else
                        outText = PlayfairCipher.Decryption(inText, keyTextBox.Text);
                    break;

                case "Vigenère Cipher":

                    if (!CheckKey(keyTextBox.Text))
                    {
                        MessageBox.Show("Key can be chars only");
                        return;
                    }

                    if (encRdbtn.Checked)
                        outText = VigenèreCipher.Encryption(inText, keyTextBox.Text);
                    else
                        outText = VigenèreCipher.Decryption(inText, keyTextBox.Text);
                    break;

                case "RSA":
                    int p, q;
                    int.TryParse(pTextBox.Text, out p);
                    int.TryParse(qTextBox.Text, out q);

                    if (p <= 0 || q <= 0)
                    {
                        MessageBox.Show("P and Q can be integers only and can't be zero");
                        return;
                    }

                    if (encRdbtn.Checked)
                        outText = RSA.Encryption(inText, p, q);
                    else
                        outText = RSA.Decryption(inText, p, q);

                    break;


                default:

                    if (encRdbtn.Checked)
                        outText = ReverseCipher.Encryption(inText);
                    else
                        outText = ReverseCipher.Decryption(inText);

                    break;
            }

            File.WriteAllText(_outFilePath, outText);
            MessageBox.Show("Succcess", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private string ValidateSteps()
        {
            string errorMsg = String.Empty;

            if (_inFilePath == String.Empty)
                errorMsg += "Please select a file";

            if (AlgorithmslstBox.SelectedIndex == -1)
                errorMsg += "\nSelect an algorithm";

            if (atxtBox.Text == String.Empty && btextBox.Text == String.Empty &&
                shiftTextBox.Text == String.Empty && keyTextBox.Text == String.Empty &&
                colKtextbox.Text == String.Empty && pTextBox.Text == String.Empty &&
                qTextBox.Text == String.Empty &&
                AlgorithmslstBox.SelectedIndex != -1 &&
                AlgorithmslstBox.SelectedItem.ToString() != "Reverse Cipher")
                errorMsg += "\nInput values are missing";

            if (!encRdbtn.Checked && !decRdbtn.Checked)
                errorMsg += "\nSelect the process type (Encryption, Decryption)";

            if (_outFilePath == String.Empty)
                errorMsg += "\nSelect the destination file";

            return errorMsg;
        }

        private bool ValidColKey(string text)
        {
            text = String.Concat(text.OrderBy(c => c));

            for (int i = 0; i + 1 < text.Length; i++)
                if (text[i + 1] == text[i] || !char.IsLetterOrDigit(text[i]) || !char.IsLetterOrDigit(text[i]))
                    return false;

            return true;
        }

        private bool CheckKey(string text)
        {
            foreach (var ch in text)
            {
                if (!char.IsLetter(ch)) return false;
            }
            return true;
        }
    }
}