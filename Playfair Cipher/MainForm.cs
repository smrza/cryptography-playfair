using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playfair_Cipher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ExperimentalForm embeddedForm = new ExperimentalForm();
            embeddedForm.TopLevel = false;
            tabExperimental.Controls.Add(embeddedForm);
            embeddedForm.Show();
        }

        private void CheckBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (textBoxPassword.PasswordChar == '*')
            {
                textBoxPassword.PasswordChar = '\0';
                dataGridPlaceholder.Visible = false;
                dataGridTable.Visible = true;
            }
            else if (textBoxPassword.PasswordChar == '\0')
            {
                textBoxPassword.PasswordChar = '*';
                dataGridTable.Visible = false;
                dataGridPlaceholder.Visible = true;
            }
        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPassword.Text = textBoxPassword.Text.ToUpper();
            textBoxPassword.SelectionStart = textBoxPassword.Text.Length;
            textBoxPassword.SelectionLength = 0;
            labelEnterPassword.Visible = false;

            if (textBoxPassword.Text.Length == 46)
            {
                MessageBox.Show("You have entered too many characters, limit is 45!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Text = textBoxPassword.Text.Remove(textBoxPassword.Text.Length - 1);
                textBoxPassword.SelectionStart = textBoxPassword.Text.Length;
                textBoxPassword.SelectionLength = 0;
            }
            else
            {
                if (Regex.IsMatch(textBoxPassword.Text, "[A-Z]+$") == false)
                {
                    if (textBoxPassword.TextLength > 0)
                    {
                        MessageBox.Show("Password can only contain alphabetical characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxPassword.Text = textBoxPassword.Text.Remove(textBoxPassword.Text.Length - 1);
                        textBoxPassword.SelectionStart = textBoxPassword.Text.Length;
                        textBoxPassword.SelectionLength = 0;
                    }
                }

                if (textBoxPassword.TextLength > 0)
                {
                    if (textBoxPassword.Text.Last() == 'W')
                    {
                        textBoxPassword.Text = textBoxPassword.Text.Remove(textBoxPassword.Text.Length - 1);
                        textBoxPassword.Text += 'V';
                    }
                }

                labelResizer.Text = textBoxPassword.Text;
                textBoxPassword.Size = labelResizer.Size;
            }      
        }

        private void ButtonCreateTable_Click(object sender, EventArgs e)
        {
            dataGridTable.Columns.Clear();
            dataGridTable.Rows.Clear();
            dataGridTable.Refresh();

            StringBuilder password = new StringBuilder(textBoxPassword.Text);
            StringBuilder tableContent = new StringBuilder();
            StringBuilder alphabet = new StringBuilder("ABCDEFGHIJKLMNOPQRSTUVXYZ");
            char[,] arrayTable = new char[5, 5];

            for (int i = 0; i < password.Length; i++)
            {
                if (tableContent.ToString().Contains(password[i]) == false)
                {
                    tableContent.Append(password[i]);
                }
            }

            if (tableContent.Length < 6)
            {
                MessageBox.Show("Enter password with 6 or more unique letters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (tableContent.ToString().Contains(alphabet[i]) == false)
                    {
                        tableContent.Append(alphabet[i]);
                    }
                }

                for (int i = 0; i < arrayTable.GetLength(0); i++)
                {
                    for (int j = 0; j < arrayTable.GetLength(1); j++)
                    {
                        arrayTable[i, j] = Convert.ToChar(tableContent.ToString().Substring(arrayTable.GetLength(0) * i + j, 1));
                    }
                }

                dataGridTable.RowTemplate.MinimumHeight = 40;
                
                dataGridTable.ColumnCount = arrayTable.GetLength(1);
                for (int i = 0; i < arrayTable.GetLength(0); i++)
                {
                    string[] oneRow = new string[arrayTable.GetLength(1)];
                    for (int j = 0; j < arrayTable.GetLength(1); j++)
                    {
                        oneRow[j] = Convert.ToString(arrayTable[i, j]);
                    }
                    dataGridTable.Rows.Add(oneRow);
                }

                foreach (DataGridViewColumn column in dataGridTable.Columns)
                {
                    column.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
                }
            }
        }

        private void ButtonEncrypt_Click(object sender, EventArgs e)
        {
            if(dataGridTable.Rows.Count == 0)
            {
                MessageBox.Show("Encryption table not initialized!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                StringBuilder output = new StringBuilder();
                string input = richTextBoxInput.Text;
                input = StaticMethods.ParseInputEncryption(input);
                richTextBoxParsedInput.Text = input;
                ColourParsedCharacters(sender, e);

                input = StaticMethods.ParseDoubleLetter(input);
                input = StaticMethods.Bigram(input);
                richTextBoxDoubles.Text = input;
                ColourInBetweens(sender, e);

                for (int i = 0; i < input.Length - 1; i += 2)
                {
                    ValueTuple<int, int, int, int> tuple = StaticMethods.EncryptedIndex(ReturnIndex(input[i]).Item2, ReturnIndex(input[i]).Item1, ReturnIndex(input[i + 1]).Item2, ReturnIndex(input[i + 1]).Item1);
                    output.Append(CryptedLetter(tuple.Item1, tuple.Item2));
                    output.Append(CryptedLetter(tuple.Item3, tuple.Item4));
                    i++;
                }

                for (int i = 5; i <= output.Length; i += 5)
                {
                    output = output.Insert(i, " ");
                    i++;
                }

                richTextBoxOutput.Text = output.ToString();                
            }
        }

        private void ButtonDecrypt_Click(object sender, EventArgs e)
        {
            if (dataGridTable.Rows.Count == 0)
            {
                MessageBox.Show("Encryption table not initialized!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                StringBuilder output = new StringBuilder();
                string input = richTextBoxInput.Text;
                input = StaticMethods.ParseInputDecryption(input);
                richTextBoxParsedInput.Text = input;

                for (int i = 0; i < input.Length - 1; i += 2)
                {
                    ValueTuple<int, int, int, int> tuple = StaticMethods.DecryptedIndex(ReturnIndex(input[i]).Item2, ReturnIndex(input[i]).Item1, ReturnIndex(input[i + 1]).Item2, ReturnIndex(input[i + 1]).Item1);
                    output.Append(CryptedLetter(tuple.Item1, tuple.Item2));
                    output.Append(CryptedLetter(tuple.Item3, tuple.Item4));
                }

                richTextBoxDoubles.Text = StaticMethods.DeParseDoubleLetter(output.ToString());
                DeColourParsedCharacters(sender, e);
                richTextBoxOutput.Text = StaticMethods.ReplaceOutput(StaticMethods.DeParseDoubleLetter(output.ToString()));
            }
        }
      
        private (int, int) ReturnIndex(char A)
        {
            foreach (DataGridViewRow row in dataGridTable.Rows)
            {
                for (int i = 0; i < 5; i++)
                {
                    char tmp = Convert.ToChar(row.Cells[i].Value);

                    if (tmp == A)
                    {
                        return (i, row.Index);
                    }
                }
            }

            return (-1, -1);
        }

        private char CryptedLetter(int indexRow, int indexColumn)
        {
            char letter = Convert.ToChar(dataGridTable.Rows[indexRow].Cells[indexColumn].Value);
            return letter;
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabDefault)
            {
                this.ActiveControl = textBoxPassword;
                textBoxPassword.Text = "";
                dataGridTable.Visible = true;
                dataGridTable.Rows.Clear();
                dataGridTable.Columns.Clear();
                dataGridTable.Refresh();
                dataGridPlaceholder.Visible = false;
                checkBoxPassword.Checked = false;
                richTextBoxInput.Text = "INPUT";
                richTextBoxParsedInput.Text = "PARSED INPUT";
                richTextBoxDoubles.Text = "BIGRAM";
                richTextBoxOutput.Text = "OUTPUT";
                labelEnterPassword.Visible = true;
            }
            else if (tabControl.SelectedTab == tabExperimental)
            {
                tabExperimental.Controls.Clear();
                ExperimentalForm embeddedForm = new ExperimentalForm();
                embeddedForm.TopLevel = false;
                tabExperimental.Controls.Add(embeddedForm);
                embeddedForm.Show();
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ColourInBetweens(object sender, EventArgs e)
        {
            for (int i = 0; i < richTextBoxDoubles.Text.Length - 3; i++)
            {
                if (richTextBoxDoubles.Text[i] == richTextBoxDoubles.Text[i + 3])
                {
                    if (richTextBoxDoubles.Text[i+1] == 'X')
                    {
                        richTextBoxDoubles.Select(i + 1, 1);
                        richTextBoxDoubles.SelectionBackColor = Color.Red;
                        richTextBoxDoubles.SelectionColor = Color.Blue;
                    }
                    else if (richTextBoxDoubles.Text[i] == 'X' && richTextBoxDoubles.Text[i+1] == 'Q')
                    {
                        richTextBoxDoubles.Select(i + 1, 1);
                        richTextBoxDoubles.SelectionBackColor = Color.Red;
                        richTextBoxDoubles.SelectionColor = Color.Blue;
                        i += 2;
                    }
                }
            }

            if (richTextBoxDoubles.Text.Length > 0)
            {
                if (richTextBoxDoubles.Text.ToString().Last() == 'X')
                {
                    richTextBoxDoubles.Select(richTextBoxDoubles.Text.Length - 1, 1);
                    richTextBoxDoubles.SelectionBackColor = Color.Red;
                    richTextBoxDoubles.SelectionColor = Color.Blue;
                }
                else if (richTextBoxDoubles.Text.ToString().Last() == 'Q')
                {
                    richTextBoxDoubles.Select(richTextBoxDoubles.Text.Length - 1, 1);
                    richTextBoxDoubles.SelectionBackColor = Color.Red;
                    richTextBoxDoubles.SelectionColor = Color.Blue;
                }
            }
        }
        
        private void ColourParsedCharacters(object sender, EventArgs e)
        {
            for (int i = 0; i < richTextBoxParsedInput.Text.Length - 2; i++)
            {
                if (richTextBoxParsedInput.Text[i] == 'V' && richTextBoxParsedInput.Text[i + 1] == 'B' && richTextBoxParsedInput.Text[i + 2] == 'N')
                {
                    richTextBoxParsedInput.Select(i, 3);
                    richTextBoxParsedInput.SelectionBackColor = Color.Red;
                    richTextBoxParsedInput.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxParsedInput.Text.Length - 4; i++)
            {
                if (richTextBoxParsedInput.Text[i] == 'Z' && richTextBoxParsedInput.Text[i + 1] == 'V' && richTextBoxParsedInput.Text[i + 2] == 'B' && richTextBoxParsedInput.Text[i + 3] == 'Y' && richTextBoxParsedInput.Text[i + 4] == 'P')
                {
                    richTextBoxParsedInput.Select(i, 5);
                    richTextBoxParsedInput.SelectionBackColor = Color.Red;
                    richTextBoxParsedInput.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxParsedInput.Text.Length - 6; i++)
            {
                if (richTextBoxParsedInput.Text[i] == 'Q' && richTextBoxParsedInput.Text[i + 1] == 'T' && richTextBoxParsedInput.Text[i + 2] == 'E' && richTextBoxParsedInput.Text[i + 3] == 'C' && richTextBoxParsedInput.Text[i + 4] == 'K' && richTextBoxParsedInput.Text[i + 5] == 'A' && richTextBoxParsedInput.Text[i + 6] == 'V')
                {
                    richTextBoxParsedInput.Select(i, 7);
                    richTextBoxParsedInput.SelectionBackColor = Color.Red;
                    richTextBoxParsedInput.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxParsedInput.Text.Length - 6; i++)
            {
                if (richTextBoxParsedInput.Text[i] == 'Q' && richTextBoxParsedInput.Text[i + 1] == 'C' && richTextBoxParsedInput.Text[i + 2] == 'A' && richTextBoxParsedInput.Text[i + 3] == 'R' && richTextBoxParsedInput.Text[i + 4] == 'K' && richTextBoxParsedInput.Text[i + 5] == 'A' && richTextBoxParsedInput.Text[i + 6] == 'V')
                {
                    richTextBoxParsedInput.Select(i, 7);
                    richTextBoxParsedInput.SelectionBackColor = Color.Red;
                    richTextBoxParsedInput.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxParsedInput.Text.Length - 8; i++)
            {
                if (richTextBoxParsedInput.Text[i] == 'Q' && richTextBoxParsedInput.Text[i + 1] == 'O' && richTextBoxParsedInput.Text[i + 2] == 'T' && richTextBoxParsedInput.Text[i + 3] == 'A' && richTextBoxParsedInput.Text[i + 4] == 'Z' && richTextBoxParsedInput.Text[i + 5] == 'N' && richTextBoxParsedInput.Text[i + 6] == 'I' && richTextBoxParsedInput.Text[i + 7] == 'K' && richTextBoxParsedInput.Text[i + 8] == 'V')
                {
                    richTextBoxParsedInput.Select(i, 9);
                    richTextBoxParsedInput.SelectionBackColor = Color.Red;
                    richTextBoxParsedInput.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxParsedInput.Text.Length - 10; i++)
            {
                if (richTextBoxParsedInput.Text[i] == 'Q' && richTextBoxParsedInput.Text[i + 1] == 'V' && richTextBoxParsedInput.Text[i + 2] == 'Y' && richTextBoxParsedInput.Text[i + 3] == 'K' && richTextBoxParsedInput.Text[i + 4] == 'R' && richTextBoxParsedInput.Text[i + 5] == 'I' && richTextBoxParsedInput.Text[i + 6] == 'C' && richTextBoxParsedInput.Text[i + 7] == 'N' && richTextBoxParsedInput.Text[i + 8] == 'I' && richTextBoxParsedInput.Text[i + 9] == 'K' && richTextBoxParsedInput.Text[i + 10] == 'V')
                {
                    richTextBoxParsedInput.Select(i, 11);
                    richTextBoxParsedInput.SelectionBackColor = Color.Red;
                    richTextBoxParsedInput.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxParsedInput.Text.Length - 5; i++)
            {
                if (richTextBoxParsedInput.Text[i] == 'Q' && richTextBoxParsedInput.Text[i + 1] == 'L' && richTextBoxParsedInput.Text[i + 2] == 'I' && richTextBoxParsedInput.Text[i + 3] == 'N' && richTextBoxParsedInput.Text[i + 4] == 'E' && richTextBoxParsedInput.Text[i + 5] == 'V')
                {
                    richTextBoxParsedInput.Select(i, 6);
                    richTextBoxParsedInput.SelectionBackColor = Color.Red;
                    richTextBoxParsedInput.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxParsedInput.Text.Length - 4; i++)
            {
                if (richTextBoxParsedInput.Text[i] == 'Q' && richTextBoxParsedInput.Text[i + 1] == 'O' && richTextBoxParsedInput.Text[i + 2] == 'N' && richTextBoxParsedInput.Text[i + 3] == 'E' && richTextBoxParsedInput.Text[i + 4] == 'V')
                {
                    richTextBoxParsedInput.Select(i, 5);
                    richTextBoxParsedInput.SelectionBackColor = Color.Red;
                    richTextBoxParsedInput.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxParsedInput.Text.Length - 4; i++)
            {
                if (richTextBoxParsedInput.Text[i] == 'Q' && richTextBoxParsedInput.Text[i + 1] == 'T' && richTextBoxParsedInput.Text[i + 2] == 'V' && richTextBoxParsedInput.Text[i + 3] == 'O' && richTextBoxParsedInput.Text[i + 4] == 'V')
                {
                    richTextBoxParsedInput.Select(i, 5);
                    richTextBoxParsedInput.SelectionBackColor = Color.Red;
                    richTextBoxParsedInput.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxParsedInput.Text.Length - 6; i++)
            {
                if (richTextBoxParsedInput.Text[i] == 'Q' && richTextBoxParsedInput.Text[i + 1] == 'T' && richTextBoxParsedInput.Text[i + 2] == 'H' && richTextBoxParsedInput.Text[i + 3] == 'R' && richTextBoxParsedInput.Text[i + 4] == 'E' && richTextBoxParsedInput.Text[i + 5] == 'E' && richTextBoxParsedInput.Text[i + 6] == 'V')
                {
                    richTextBoxParsedInput.Select(i, 7);
                    richTextBoxParsedInput.SelectionBackColor = Color.Red;
                    richTextBoxParsedInput.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxParsedInput.Text.Length - 5; i++)
            {
                if (richTextBoxParsedInput.Text[i] == 'Q' && richTextBoxParsedInput.Text[i + 1] == 'F' && richTextBoxParsedInput.Text[i + 2] == 'O' && richTextBoxParsedInput.Text[i + 3] == 'U' && richTextBoxParsedInput.Text[i + 4] == 'R' && richTextBoxParsedInput.Text[i + 5] == 'V')
                {
                    richTextBoxParsedInput.Select(i, 6);
                    richTextBoxParsedInput.SelectionBackColor = Color.Red;
                    richTextBoxParsedInput.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxParsedInput.Text.Length - 5; i++)
            {
                if (richTextBoxParsedInput.Text[i] == 'Q' && richTextBoxParsedInput.Text[i + 1] == 'F' && richTextBoxParsedInput.Text[i + 2] == 'I' && richTextBoxParsedInput.Text[i + 3] == 'V' && richTextBoxParsedInput.Text[i + 4] == 'E' && richTextBoxParsedInput.Text[i + 5] == 'V')
                {
                    richTextBoxParsedInput.Select(i, 6);
                    richTextBoxParsedInput.SelectionBackColor = Color.Red;
                    richTextBoxParsedInput.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxParsedInput.Text.Length - 4; i++)
            {
                if (richTextBoxParsedInput.Text[i] == 'Q' && richTextBoxParsedInput.Text[i + 1] == 'S' && richTextBoxParsedInput.Text[i + 2] == 'I' && richTextBoxParsedInput.Text[i + 3] == 'X' && richTextBoxParsedInput.Text[i + 4] == 'V')
                {
                    richTextBoxParsedInput.Select(i, 5);
                    richTextBoxParsedInput.SelectionBackColor = Color.Red;
                    richTextBoxParsedInput.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxParsedInput.Text.Length - 6; i++)
            {
                if (richTextBoxParsedInput.Text[i] == 'Q' && richTextBoxParsedInput.Text[i + 1] == 'S' && richTextBoxParsedInput.Text[i + 2] == 'E' && richTextBoxParsedInput.Text[i + 3] == 'V' && richTextBoxParsedInput.Text[i + 4] == 'E' && richTextBoxParsedInput.Text[i + 5] == 'N' && richTextBoxParsedInput.Text[i + 6] == 'V')
                {
                    richTextBoxParsedInput.Select(i, 7);
                    richTextBoxParsedInput.SelectionBackColor = Color.Red;
                    richTextBoxParsedInput.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxParsedInput.Text.Length - 6; i++)
            {
                if (richTextBoxParsedInput.Text[i] == 'Q' && richTextBoxParsedInput.Text[i + 1] == 'E' && richTextBoxParsedInput.Text[i + 2] == 'I' && richTextBoxParsedInput.Text[i + 3] == 'G' && richTextBoxParsedInput.Text[i + 4] == 'H' && richTextBoxParsedInput.Text[i + 5] == 'T' && richTextBoxParsedInput.Text[i + 6] == 'V')
                {
                    richTextBoxParsedInput.Select(i, 7);
                    richTextBoxParsedInput.SelectionBackColor = Color.Red;
                    richTextBoxParsedInput.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxParsedInput.Text.Length - 5; i++)
            {
                if (richTextBoxParsedInput.Text[i] == 'Q' && richTextBoxParsedInput.Text[i + 1] == 'N' && richTextBoxParsedInput.Text[i + 2] == 'I' && richTextBoxParsedInput.Text[i + 3] == 'N' && richTextBoxParsedInput.Text[i + 4] == 'E' && richTextBoxParsedInput.Text[i + 5] == 'V')
                {
                    richTextBoxParsedInput.Select(i, 6);
                    richTextBoxParsedInput.SelectionBackColor = Color.Red;
                    richTextBoxParsedInput.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxParsedInput.Text.Length - 5; i++)
            {
                if (richTextBoxParsedInput.Text[i] == 'Q' && richTextBoxParsedInput.Text[i + 1] == 'Z' && richTextBoxParsedInput.Text[i + 2] == 'E' && richTextBoxParsedInput.Text[i + 3] == 'R' && richTextBoxParsedInput.Text[i + 4] == 'O' && richTextBoxParsedInput.Text[i + 5] == 'V')
                {
                    richTextBoxParsedInput.Select(i, 6);
                    richTextBoxParsedInput.SelectionBackColor = Color.Red;
                    richTextBoxParsedInput.SelectionColor = Color.Blue;
                }
            }
        }

        private void DeColourParsedCharacters(object sender, EventArgs e)
        {
            for (int i = 0; i < richTextBoxDoubles.Text.Length - 2; i++)
            {
                if (richTextBoxDoubles.Text[i] == 'V' && richTextBoxDoubles.Text[i + 1] == 'B' && richTextBoxDoubles.Text[i + 2] == 'N')
                {
                    richTextBoxDoubles.Select(i, 3);
                    richTextBoxDoubles.SelectionBackColor = Color.Red;
                    richTextBoxDoubles.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxDoubles.Text.Length - 4; i++)
            {
                if (richTextBoxDoubles.Text[i] == 'Z' && richTextBoxDoubles.Text[i + 1] == 'V' && richTextBoxDoubles.Text[i + 2] == 'B' && richTextBoxDoubles.Text[i + 3] == 'Y' && richTextBoxDoubles.Text[i + 4] == 'P')
                {
                    richTextBoxDoubles.Select(i, 5);
                    richTextBoxDoubles.SelectionBackColor = Color.Red;
                    richTextBoxDoubles.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxDoubles.Text.Length - 6; i++)
            {
                if (richTextBoxDoubles.Text[i] == 'Q' && richTextBoxDoubles.Text[i + 1] == 'T' && richTextBoxDoubles.Text[i + 2] == 'E' && richTextBoxDoubles.Text[i + 3] == 'C' && richTextBoxDoubles.Text[i + 4] == 'K' && richTextBoxDoubles.Text[i + 5] == 'A' && richTextBoxDoubles.Text[i + 6] == 'V')
                {
                    richTextBoxDoubles.Select(i, 7);
                    richTextBoxDoubles.SelectionBackColor = Color.Red;
                    richTextBoxDoubles.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxDoubles.Text.Length - 6; i++)
            {
                if (richTextBoxDoubles.Text[i] == 'Q' && richTextBoxDoubles.Text[i + 1] == 'C' && richTextBoxDoubles.Text[i + 2] == 'A' && richTextBoxDoubles.Text[i + 3] == 'R' && richTextBoxDoubles.Text[i + 4] == 'K' && richTextBoxDoubles.Text[i + 5] == 'A' && richTextBoxDoubles.Text[i + 6] == 'V')
                {
                    richTextBoxDoubles.Select(i, 7);
                    richTextBoxDoubles.SelectionBackColor = Color.Red;
                    richTextBoxDoubles.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxDoubles.Text.Length - 8; i++)
            {
                if (richTextBoxDoubles.Text[i] == 'Q' && richTextBoxDoubles.Text[i + 1] == 'O' && richTextBoxDoubles.Text[i + 2] == 'T' && richTextBoxDoubles.Text[i + 3] == 'A' && richTextBoxDoubles.Text[i + 4] == 'Z' && richTextBoxDoubles.Text[i + 5] == 'N' && richTextBoxDoubles.Text[i + 6] == 'I' && richTextBoxDoubles.Text[i + 7] == 'K' && richTextBoxDoubles.Text[i + 8] == 'V')
                {
                    richTextBoxDoubles.Select(i, 9);
                    richTextBoxDoubles.SelectionBackColor = Color.Red;
                    richTextBoxDoubles.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxDoubles.Text.Length - 10; i++)
            {
                if (richTextBoxDoubles.Text[i] == 'Q' && richTextBoxDoubles.Text[i + 1] == 'V' && richTextBoxDoubles.Text[i + 2] == 'Y' && richTextBoxDoubles.Text[i + 3] == 'K' && richTextBoxDoubles.Text[i + 4] == 'R' && richTextBoxDoubles.Text[i + 5] == 'I' && richTextBoxDoubles.Text[i + 6] == 'C' && richTextBoxDoubles.Text[i + 7] == 'N' && richTextBoxDoubles.Text[i + 8] == 'I' && richTextBoxDoubles.Text[i + 9] == 'K' && richTextBoxDoubles.Text[i + 10] == 'V')
                {
                    richTextBoxDoubles.Select(i, 11);
                    richTextBoxDoubles.SelectionBackColor = Color.Red;
                    richTextBoxDoubles.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxDoubles.Text.Length - 5; i++)
            {
                if (richTextBoxDoubles.Text[i] == 'Q' && richTextBoxDoubles.Text[i + 1] == 'L' && richTextBoxDoubles.Text[i + 2] == 'I' && richTextBoxDoubles.Text[i + 3] == 'N' && richTextBoxDoubles.Text[i + 4] == 'E' && richTextBoxDoubles.Text[i + 5] == 'V')
                {
                    richTextBoxDoubles.Select(i, 6);
                    richTextBoxDoubles.SelectionBackColor = Color.Red;
                    richTextBoxDoubles.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxDoubles.Text.Length - 4; i++)
            {
                if (richTextBoxDoubles.Text[i] == 'Q' && richTextBoxDoubles.Text[i + 1] == 'O' && richTextBoxDoubles.Text[i + 2] == 'N' && richTextBoxDoubles.Text[i + 3] == 'E' && richTextBoxDoubles.Text[i + 4] == 'V')
                {
                    richTextBoxDoubles.Select(i, 5);
                    richTextBoxDoubles.SelectionBackColor = Color.Red;
                    richTextBoxDoubles.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxDoubles.Text.Length - 4; i++)
            {
                if (richTextBoxDoubles.Text[i] == 'Q' && richTextBoxDoubles.Text[i + 1] == 'T' && richTextBoxDoubles.Text[i + 2] == 'V' && richTextBoxDoubles.Text[i + 3] == 'O' && richTextBoxDoubles.Text[i + 4] == 'V')
                {
                    richTextBoxDoubles.Select(i, 5);
                    richTextBoxDoubles.SelectionBackColor = Color.Red;
                    richTextBoxDoubles.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxDoubles.Text.Length - 6; i++)
            {
                if (richTextBoxDoubles.Text[i] == 'Q' && richTextBoxDoubles.Text[i + 1] == 'T' && richTextBoxDoubles.Text[i + 2] == 'H' && richTextBoxDoubles.Text[i + 3] == 'R' && richTextBoxDoubles.Text[i + 4] == 'E' && richTextBoxDoubles.Text[i + 5] == 'E' && richTextBoxDoubles.Text[i + 6] == 'V')
                {
                    richTextBoxDoubles.Select(i, 7);
                    richTextBoxDoubles.SelectionBackColor = Color.Red;
                    richTextBoxDoubles.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxDoubles.Text.Length - 5; i++)
            {
                if (richTextBoxDoubles.Text[i] == 'Q' && richTextBoxDoubles.Text[i + 1] == 'F' && richTextBoxDoubles.Text[i + 2] == 'O' && richTextBoxDoubles.Text[i + 3] == 'U' && richTextBoxDoubles.Text[i + 4] == 'R' && richTextBoxDoubles.Text[i + 5] == 'V')
                {
                    richTextBoxDoubles.Select(i, 6);
                    richTextBoxDoubles.SelectionBackColor = Color.Red;
                    richTextBoxDoubles.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxDoubles.Text.Length - 5; i++)
            {
                if (richTextBoxDoubles.Text[i] == 'Q' && richTextBoxDoubles.Text[i + 1] == 'F' && richTextBoxDoubles.Text[i + 2] == 'I' && richTextBoxDoubles.Text[i + 3] == 'V' && richTextBoxDoubles.Text[i + 4] == 'E' && richTextBoxDoubles.Text[i + 5] == 'V')
                {
                    richTextBoxDoubles.Select(i, 6);
                    richTextBoxDoubles.SelectionBackColor = Color.Red;
                    richTextBoxDoubles.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxDoubles.Text.Length - 4; i++)
            {
                if (richTextBoxDoubles.Text[i] == 'Q' && richTextBoxDoubles.Text[i + 1] == 'S' && richTextBoxDoubles.Text[i + 2] == 'I' && richTextBoxDoubles.Text[i + 3] == 'X' && richTextBoxDoubles.Text[i + 4] == 'V')
                {
                    richTextBoxDoubles.Select(i, 5);
                    richTextBoxDoubles.SelectionBackColor = Color.Red;
                    richTextBoxDoubles.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxDoubles.Text.Length - 6; i++)
            {
                if (richTextBoxDoubles.Text[i] == 'Q' && richTextBoxDoubles.Text[i + 1] == 'S' && richTextBoxDoubles.Text[i + 2] == 'E' && richTextBoxDoubles.Text[i + 3] == 'V' && richTextBoxDoubles.Text[i + 4] == 'E' && richTextBoxDoubles.Text[i + 5] == 'N' && richTextBoxDoubles.Text[i + 6] == 'V')
                {
                    richTextBoxDoubles.Select(i, 7);
                    richTextBoxDoubles.SelectionBackColor = Color.Red;
                    richTextBoxDoubles.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxDoubles.Text.Length - 6; i++)
            {
                if (richTextBoxDoubles.Text[i] == 'Q' && richTextBoxDoubles.Text[i + 1] == 'E' && richTextBoxDoubles.Text[i + 2] == 'I' && richTextBoxDoubles.Text[i + 3] == 'G' && richTextBoxDoubles.Text[i + 4] == 'H' && richTextBoxDoubles.Text[i + 5] == 'T' && richTextBoxDoubles.Text[i + 6] == 'V')
                {
                    richTextBoxDoubles.Select(i, 7);
                    richTextBoxDoubles.SelectionBackColor = Color.Red;
                    richTextBoxDoubles.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxDoubles.Text.Length - 5; i++)
            {
                if (richTextBoxDoubles.Text[i] == 'Q' && richTextBoxDoubles.Text[i + 1] == 'N' && richTextBoxDoubles.Text[i + 2] == 'I' && richTextBoxDoubles.Text[i + 3] == 'N' && richTextBoxDoubles.Text[i + 4] == 'E' && richTextBoxDoubles.Text[i + 5] == 'V')
                {
                    richTextBoxDoubles.Select(i, 6);
                    richTextBoxDoubles.SelectionBackColor = Color.Red;
                    richTextBoxDoubles.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxDoubles.Text.Length - 5; i++)
            {
                if (richTextBoxDoubles.Text[i] == 'Q' && richTextBoxDoubles.Text[i + 1] == 'Z' && richTextBoxDoubles.Text[i + 2] == 'E' && richTextBoxDoubles.Text[i + 3] == 'R' && richTextBoxDoubles.Text[i + 4] == 'O' && richTextBoxDoubles.Text[i + 5] == 'V')
                {
                    richTextBoxDoubles.Select(i, 6);
                    richTextBoxDoubles.SelectionBackColor = Color.Red;
                    richTextBoxDoubles.SelectionColor = Color.Blue;
                }
            }
        }

        private void TextBoxPassword_Enter(object sender, EventArgs e)
        {
            textBoxPassword.SelectAll();
        }

        private void RichTextBoxInput_Enter(object sender, EventArgs e)
        {
            richTextBoxInput.SelectAll();
        }
    }
}
