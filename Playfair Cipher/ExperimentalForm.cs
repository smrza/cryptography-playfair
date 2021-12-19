using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playfair_Cipher
{
    public partial class ExperimentalForm : Form
    {
        public ExperimentalForm()
        {
            InitializeComponent();
        }

        string alphabetOriginal = "ABCDEFGHIJKLMNOPQRSTUVXYZ";
        char tmpCell;
        char tmpCell2;
        Table first;
        Table second;
        Table third;
        Table fourth;
        Table fifth;
        string inputSlowmo;
        int slowmoSpeed = 1000;

        private void ExperimentalForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBoxPasswordExperimental;
            dataGridExperimental.RowTemplate.MinimumHeight = 40;

            first = new Table() { row1 = alphabetOriginal[0], row2 = alphabetOriginal[1], row3 = alphabetOriginal[2], row4 = alphabetOriginal[3], row5 = alphabetOriginal[4] };
            second = new Table() { row1 = alphabetOriginal[5], row2 = alphabetOriginal[6], row3 = alphabetOriginal[7], row4 = alphabetOriginal[8], row5 = alphabetOriginal[9] };
            third = new Table() { row1 = alphabetOriginal[10], row2 = alphabetOriginal[11], row3 = alphabetOriginal[12], row4 = alphabetOriginal[13], row5 = alphabetOriginal[14] };
            fourth = new Table() { row1 = alphabetOriginal[15], row2 = alphabetOriginal[16], row3 = alphabetOriginal[17], row4 = alphabetOriginal[18], row5 = alphabetOriginal[19] };
            fifth = new Table() { row1 = alphabetOriginal[20], row2 = alphabetOriginal[21], row3 = alphabetOriginal[22], row4 = alphabetOriginal[23], row5 = alphabetOriginal[24] };

            tableBindingSource.Add(first);
            tableBindingSource.Add(second);
            tableBindingSource.Add(third);
            tableBindingSource.Add(fourth);
            tableBindingSource.Add(fifth);

            foreach (DataGridViewColumn column in dataGridExperimental.Columns)
            {
                column.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
        }

        private void TextBoxPasswordExperimental_TextChanged(object sender, EventArgs e)
        {
            textBoxPasswordExperimental.Text = textBoxPasswordExperimental.Text.ToUpper();
            textBoxPasswordExperimental.SelectionStart = textBoxPasswordExperimental.Text.Length;
            textBoxPasswordExperimental.SelectionLength = 0;

            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxPasswordExperimental.Text, "[A-Z]+$") == false)
            {
                if (textBoxPasswordExperimental.TextLength > 0)
                {
                    MessageBox.Show("Password can only contain alphabetical characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxPasswordExperimental.Text = textBoxPasswordExperimental.Text.Remove(textBoxPasswordExperimental.Text.Length - 1);
                    textBoxPasswordExperimental.SelectionStart = textBoxPasswordExperimental.Text.Length;
                    textBoxPasswordExperimental.SelectionLength = 0;
                }
            }

            if (textBoxPasswordExperimental.TextLength > 0)
            {
                if (textBoxPasswordExperimental.Text.Last() == 'W')
                {
                    textBoxPasswordExperimental.Text = textBoxPasswordExperimental.Text.Remove(textBoxPasswordExperimental.Text.Length - 1);
                    textBoxPasswordExperimental.Text += 'V';
                }
            }

            StringBuilder password = new StringBuilder(textBoxPasswordExperimental.Text);
            StringBuilder tableContent = new StringBuilder();

            for (int i = 0; i < password.Length; i++)
            {
                if (tableContent.ToString().Contains(password[i]) == false)
                {
                    tableContent.Append(password[i]);
                }
            }

            for (int i = 0; i < alphabetOriginal.Length; i++)
            {
                if (tableContent.ToString().Contains(alphabetOriginal[i]) == false)
                {
                    tableContent.Append(alphabetOriginal[i]);
                }
            }

            tableBindingSource.Clear();

            first = new Table() { row1 = tableContent[0], row2 = tableContent[1], row3 = tableContent[2], row4 = tableContent[3], row5 = tableContent[4] };
            second = new Table() { row1 = tableContent[5], row2 = tableContent[6], row3 = tableContent[7], row4 = tableContent[8], row5 = tableContent[9] };
            third = new Table() { row1 = tableContent[10], row2 = tableContent[11], row3 = tableContent[12], row4 = tableContent[13], row5 = tableContent[14] };
            fourth = new Table() { row1 = tableContent[15], row2 = tableContent[16], row3 = tableContent[17], row4 = tableContent[18], row5 = tableContent[19] };
            fifth = new Table() { row1 = tableContent[20], row2 = tableContent[21], row3 = tableContent[22], row4 = tableContent[23], row5 = tableContent[24] };

            tableBindingSource.Add(first);
            tableBindingSource.Add(second);
            tableBindingSource.Add(third);
            tableBindingSource.Add(fourth);
            tableBindingSource.Add(fifth);
        }

        private void ButtonRandomKey_Click(object sender, EventArgs e)
        {
            /*
            string randomPassword = StaticMethods.RandomPassword();
            string parsedPassword = StaticMethods.ParseRandomPassword(randomPassword);
            textBoxPasswordExperimental.Text = parsedPassword;
            */
        }

        private void CheckBoxPasswordExperimental_CheckedChanged(object sender, EventArgs e)
        {
            if (textBoxPasswordExperimental.PasswordChar == '*')
            {
                textBoxPasswordExperimental.PasswordChar = '\0';
                dataGridPlaceholderExperimental.Visible = false;
                dataGridExperimental.Visible = true;
            }
            else if (textBoxPasswordExperimental.PasswordChar == '\0')
            {
                textBoxPasswordExperimental.PasswordChar = '*';
                dataGridExperimental.Visible = false;
                dataGridPlaceholderExperimental.Visible = true;
            }
        }

        private void DataGridExperimental_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            tmpCell = Convert.ToChar(dataGridExperimental.CurrentCell.Value);
        }

        private void DataGridExperimental_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridExperimental.CurrentCell.Value = Convert.ToString(dataGridExperimental.CurrentCell.Value).ToUpper();

            if (System.Text.RegularExpressions.Regex.IsMatch(Convert.ToString(dataGridExperimental.CurrentCell.Value), "[W]+$") == true)
            {
                dataGridExperimental.CurrentCell.Value = "V";
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(Convert.ToString(dataGridExperimental.CurrentCell.Value), "[A-VX-Z]+$") == false)
            {
                dataGridExperimental.CurrentCell.Value = tmpCell;
            }

            tmpCell2 = Convert.ToChar(dataGridExperimental.CurrentCell.Value);
            
            if (tmpCell != tmpCell2)
            {
                foreach (DataGridViewRow row in dataGridExperimental.Rows)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (row.Cells[i].RowIndex == dataGridExperimental.CurrentCell.RowIndex && row.Cells[i].ColumnIndex == dataGridExperimental.CurrentCell.ColumnIndex)
                        {
                            continue;
                        }
                        else
                        {
                            char tmp = Convert.ToChar(row.Cells[i].Value);

                            if (tmp == tmpCell2)
                            {
                                row.Cells[i].Value = tmpCell;
                            }
                        }
                    }
                }
            }
        }
       
        private void DataGridExperimental_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //can be empty to fix the error with empty cell
            //cell gets its original value if left empty
        }

        private void ButtonEncrypt_Click(object sender, EventArgs e)
        {
            StringBuilder output = new StringBuilder();
            string input = richTextBoxInput.Text;
            input = StaticMethods.ParseInputEncryption(input);
            input = StaticMethods.ParseDoubleLetterExperimental(input);
            input = StaticMethods.Bigram(input);

            richTextBoxMiddleStep.Text = input;
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

        private (int, int) ReturnIndex(char A)
        {
            foreach (DataGridViewRow row in dataGridExperimental.Rows)
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
            char letter = Convert.ToChar(dataGridExperimental.Rows[indexRow].Cells[indexColumn].Value);
            return letter;
        }

        private void ButtonDecrypt_Click(object sender, EventArgs e)
        {
            StringBuilder output = new StringBuilder();
            string input = richTextBoxInput.Text;
            input = StaticMethods.ParseInputDecryption(input);

            for (int i = 0; i < input.Length - 1; i += 2)
            {
                ValueTuple<int, int, int, int> tuple = StaticMethods.DecryptedIndex(ReturnIndex(input[i]).Item2, ReturnIndex(input[i]).Item1, ReturnIndex(input[i + 1]).Item2, ReturnIndex(input[i + 1]).Item1);
                output.Append(CryptedLetter(tuple.Item1, tuple.Item2));
                output.Append(CryptedLetter(tuple.Item3, tuple.Item4));
            }

            richTextBoxMiddleStep.Text = StaticMethods.DeParseDoubleLetterExperimental(output.ToString());
            DeColourParsedCharacters(sender, e);
            richTextBoxOutput.Text = StaticMethods.ReplaceOutput(StaticMethods.DeParseDoubleLetterExperimental(output.ToString()));
        }
        
        private void ColourInBetweens(object sender, EventArgs e)
        {
            for (int i = 0; i < richTextBoxMiddleStep.Text.Length - 6; i++)
            {
                if (richTextBoxMiddleStep.Text[i] == richTextBoxMiddleStep.Text[i + 6])
                {
                    if (richTextBoxMiddleStep.Text[i + 1] == 'X' && richTextBoxMiddleStep.Text[i + 3] == 'Y' && richTextBoxMiddleStep.Text[i + 4] == 'X')
                    {
                        richTextBoxMiddleStep.Select(i + 1, 1);
                        richTextBoxMiddleStep.SelectionBackColor = Color.Red;
                        richTextBoxMiddleStep.SelectionColor = Color.Blue;
                        richTextBoxMiddleStep.Select(i + 3, 2);
                        richTextBoxMiddleStep.SelectionBackColor = Color.Red;
                        richTextBoxMiddleStep.SelectionColor = Color.Blue;
                        i += 5;
                    }
                    else if (richTextBoxMiddleStep.Text[i] == 'X' && richTextBoxMiddleStep.Text[i + 1] == 'Q' && richTextBoxMiddleStep.Text[i + 3] == 'Y' && richTextBoxMiddleStep.Text[i + 4] == 'Q')
                    {
                        richTextBoxMiddleStep.Select(i + 1, 1);
                        richTextBoxMiddleStep.SelectionBackColor = Color.Red;
                        richTextBoxMiddleStep.SelectionColor = Color.Blue;
                        richTextBoxMiddleStep.Select(i + 3, 2);
                        richTextBoxMiddleStep.SelectionBackColor = Color.Red;
                        richTextBoxMiddleStep.SelectionColor = Color.Blue;
                        i += 5;
                    }
                    else if (richTextBoxMiddleStep.Text[i + 2] == 'X' && richTextBoxMiddleStep.Text[i + 3] == 'Y' && richTextBoxMiddleStep.Text[i + 5] == 'X')
                    {
                        richTextBoxMiddleStep.Select(i + 2, 2);
                        richTextBoxMiddleStep.SelectionBackColor = Color.Red;
                        richTextBoxMiddleStep.SelectionColor = Color.Blue;
                        richTextBoxMiddleStep.Select(i + 5, 1);
                        richTextBoxMiddleStep.SelectionBackColor = Color.Red;
                        richTextBoxMiddleStep.SelectionColor = Color.Blue;
                        i += 5;
                    }
                    else if (richTextBoxMiddleStep.Text[i] == 'X' && richTextBoxMiddleStep.Text[i + 2] == 'Q' && richTextBoxMiddleStep.Text[i + 3] == 'Y' && richTextBoxMiddleStep.Text[i + 5] == 'Q')
                    {
                        richTextBoxMiddleStep.Select(i + 2, 2);
                        richTextBoxMiddleStep.SelectionBackColor = Color.Red;
                        richTextBoxMiddleStep.SelectionColor = Color.Blue;
                        richTextBoxMiddleStep.Select(i + 5, 1);
                        richTextBoxMiddleStep.SelectionBackColor = Color.Red;
                        richTextBoxMiddleStep.SelectionColor = Color.Blue;
                        i += 5;
                    }
                }
            }

            if (richTextBoxMiddleStep.Text.Length > 3)
            {
                if (richTextBoxMiddleStep.Text.ToString().Substring(richTextBoxMiddleStep.Text.Length - 4) == "X YX")
                {
                    richTextBoxMiddleStep.Select(richTextBoxMiddleStep.Text.Length - 4, 1);
                    richTextBoxMiddleStep.SelectionBackColor = Color.Red;
                    richTextBoxMiddleStep.SelectionColor = Color.Blue;
                    richTextBoxMiddleStep.Select(richTextBoxMiddleStep.Text.Length - 2, 2);
                    richTextBoxMiddleStep.SelectionBackColor = Color.Red;
                    richTextBoxMiddleStep.SelectionColor = Color.Blue;
                }
                else if (richTextBoxMiddleStep.Text.ToString().Substring(richTextBoxMiddleStep.Text.Length - 4) == "Q YQ")
                {
                    richTextBoxMiddleStep.Select(richTextBoxMiddleStep.Text.Length - 4, 1);
                    richTextBoxMiddleStep.SelectionBackColor = Color.Red;
                    richTextBoxMiddleStep.SelectionColor = Color.Blue;
                    richTextBoxMiddleStep.Select(richTextBoxMiddleStep.Text.Length - 2, 2);
                    richTextBoxMiddleStep.SelectionBackColor = Color.Red;
                    richTextBoxMiddleStep.SelectionColor = Color.Blue;
                }
            }
        }

        private async void SlowmoEncrypt(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                control.Enabled = false;
            }
            trackBarSlowmo.Enabled = true;

            int tmpSpace = 0;
            richTextBoxOutput.Text = "";
            dataGridExperimental.ClearSelection();
            StringBuilder output = new StringBuilder();
            inputSlowmo = richTextBoxInput.Text;
            inputSlowmo = StaticMethods.ParseInputEncryption(inputSlowmo);
            inputSlowmo = StaticMethods.ParseDoubleLetterExperimental(inputSlowmo);
            inputSlowmo = StaticMethods.Bigram(inputSlowmo);
            richTextBoxMiddleStep.Text = inputSlowmo;
            ColourInBetweens(sender, e);

            for (int i = 0; i < inputSlowmo.Length - 1; i += 2)
            {
                int indexA1 = ReturnIndex(inputSlowmo[i]).Item2;
                int indexA2 = ReturnIndex(inputSlowmo[i]).Item1;
                int indexB1 = ReturnIndex(inputSlowmo[i + 1]).Item2;
                int indexB2 = ReturnIndex(inputSlowmo[i + 1]).Item1;
                dataGridExperimental.Rows[indexA1].Cells[indexA2].Style.BackColor = Color.Orange;
                dataGridExperimental.Rows[indexB1].Cells[indexB2].Style.BackColor = Color.Lime;
                dataGridExperimental.Rows[indexA1].Cells[indexA2].Style.ForeColor = Color.Blue;
                dataGridExperimental.Rows[indexB1].Cells[indexB2].Style.ForeColor = Color.Blue;

                await Task.Delay(slowmoSpeed);
                dataGridExperimental.Rows[indexA1].Cells[indexA2].Style.BackColor = Color.White;
                dataGridExperimental.Rows[indexB1].Cells[indexB2].Style.BackColor = Color.White;
                dataGridExperimental.Rows[indexA1].Cells[indexA2].Style.ForeColor = Color.Black;
                dataGridExperimental.Rows[indexB1].Cells[indexB2].Style.ForeColor = Color.Black;
                ValueTuple<int, int, int, int> tuple = StaticMethods.EncryptedIndex(indexA1, indexA2, indexB1, indexB2);
                dataGridExperimental.Rows[tuple.Item1].Cells[tuple.Item2].Style.BackColor = Color.OrangeRed;
                dataGridExperimental.Rows[tuple.Item3].Cells[tuple.Item4].Style.BackColor = Color.Green;
                dataGridExperimental.Rows[tuple.Item1].Cells[tuple.Item2].Style.ForeColor = Color.Blue;
                dataGridExperimental.Rows[tuple.Item3].Cells[tuple.Item4].Style.ForeColor = Color.Blue;

                await Task.Delay(slowmoSpeed/2);
                output.Append(CryptedLetter(tuple.Item1, tuple.Item2));
                if ((output.Length - tmpSpace) % 5 == 0)
                {
                    tmpSpace += 1;
                    output.Append(' ');
                }

                output.Append(CryptedLetter(tuple.Item3, tuple.Item4));
                if ((output.Length - tmpSpace) % 5 == 0)
                {
                    tmpSpace += 1;
                    output.Append(' ');
                }

                await Task.Delay(slowmoSpeed);
                dataGridExperimental.Rows[tuple.Item1].Cells[tuple.Item2].Style.BackColor = Color.White;
                dataGridExperimental.Rows[tuple.Item3].Cells[tuple.Item4].Style.BackColor = Color.White;
                dataGridExperimental.Rows[tuple.Item1].Cells[tuple.Item2].Style.ForeColor = Color.Black;
                dataGridExperimental.Rows[tuple.Item3].Cells[tuple.Item4].Style.ForeColor = Color.Black;
                i++;

                richTextBoxOutput.Text = output.ToString();
            }

            foreach (Control control in this.Controls)
            {
                control.Enabled = true;
            }
        }

        private async void SlowmoDecrypt(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                control.Enabled = false;
            }
            trackBarSlowmo.Enabled = true;

            richTextBoxMiddleStep.Text = "";
            richTextBoxOutput.Text = "";
            dataGridExperimental.ClearSelection();
            StringBuilder output = new StringBuilder();
            inputSlowmo = richTextBoxInput.Text;
            inputSlowmo = StaticMethods.ParseInputDecryption(inputSlowmo);

            for (int i = 0; i < inputSlowmo.Length - 1; i += 2)
            {
                int indexA1 = ReturnIndex(inputSlowmo[i]).Item2;
                int indexA2 = ReturnIndex(inputSlowmo[i]).Item1;
                int indexB1 = ReturnIndex(inputSlowmo[i + 1]).Item2;
                int indexB2 = ReturnIndex(inputSlowmo[i + 1]).Item1;
                dataGridExperimental.Rows[indexA1].Cells[indexA2].Style.BackColor = Color.Orange;
                dataGridExperimental.Rows[indexB1].Cells[indexB2].Style.BackColor = Color.Lime;
                dataGridExperimental.Rows[indexA1].Cells[indexA2].Style.ForeColor = Color.Blue;
                dataGridExperimental.Rows[indexB1].Cells[indexB2].Style.ForeColor = Color.Blue;

                await Task.Delay(slowmoSpeed);
                dataGridExperimental.Rows[indexA1].Cells[indexA2].Style.BackColor = Color.White;
                dataGridExperimental.Rows[indexB1].Cells[indexB2].Style.BackColor = Color.White;
                dataGridExperimental.Rows[indexA1].Cells[indexA2].Style.ForeColor = Color.Black;
                dataGridExperimental.Rows[indexB1].Cells[indexB2].Style.ForeColor = Color.Black;
                ValueTuple<int, int, int, int> tuple = StaticMethods.DecryptedIndex(ReturnIndex(inputSlowmo[i]).Item2, ReturnIndex(inputSlowmo[i]).Item1, ReturnIndex(inputSlowmo[i + 1]).Item2, ReturnIndex(inputSlowmo[i + 1]).Item1);
                dataGridExperimental.Rows[tuple.Item1].Cells[tuple.Item2].Style.BackColor = Color.OrangeRed;
                dataGridExperimental.Rows[tuple.Item3].Cells[tuple.Item4].Style.BackColor = Color.Green;
                dataGridExperimental.Rows[tuple.Item1].Cells[tuple.Item2].Style.ForeColor = Color.Blue;
                dataGridExperimental.Rows[tuple.Item3].Cells[tuple.Item4].Style.ForeColor = Color.Blue;

                await Task.Delay(slowmoSpeed/2);
                output.Append(CryptedLetter(tuple.Item1, tuple.Item2));
                output.Append(CryptedLetter(tuple.Item3, tuple.Item4));

                await Task.Delay(slowmoSpeed);
                dataGridExperimental.Rows[tuple.Item1].Cells[tuple.Item2].Style.BackColor = Color.White;
                dataGridExperimental.Rows[tuple.Item3].Cells[tuple.Item4].Style.BackColor = Color.White;
                dataGridExperimental.Rows[tuple.Item1].Cells[tuple.Item2].Style.ForeColor = Color.Black;
                dataGridExperimental.Rows[tuple.Item3].Cells[tuple.Item4].Style.ForeColor = Color.Black;

                richTextBoxMiddleStep.Text = output.ToString();
                DeColourParsedCharacters(sender, e);
                ColourInBetweensDecrypt(sender, e);
            }

            richTextBoxOutput.Text = StaticMethods.ReplaceOutput(StaticMethods.DeParseDoubleLetterExperimental(output.ToString()));

            foreach (Control control in this.Controls)
            {
                control.Enabled = true;
            }
        }

        private void DeColourParsedCharacters(object sender, EventArgs e)
        {
            for (int i = 0; i < richTextBoxMiddleStep.Text.Length - 2; i++)
            {
                if (richTextBoxMiddleStep.Text[i] == 'V' && richTextBoxMiddleStep.Text[i + 1] == 'B' && richTextBoxMiddleStep.Text[i + 2] == 'N')
                {
                    richTextBoxMiddleStep.Select(i, 3);
                    richTextBoxMiddleStep.SelectionBackColor = Color.Red;
                    richTextBoxMiddleStep.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxMiddleStep.Text.Length - 4; i++)
            {
                if (richTextBoxMiddleStep.Text[i] == 'Z' && richTextBoxMiddleStep.Text[i + 1] == 'V' && richTextBoxMiddleStep.Text[i + 2] == 'B' && richTextBoxMiddleStep.Text[i + 3] == 'Y' && richTextBoxMiddleStep.Text[i + 4] == 'P')
                {
                    richTextBoxMiddleStep.Select(i, 5);
                    richTextBoxMiddleStep.SelectionBackColor = Color.Red;
                    richTextBoxMiddleStep.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxMiddleStep.Text.Length - 6; i++)
            {
                if (richTextBoxMiddleStep.Text[i] == 'Q' && richTextBoxMiddleStep.Text[i + 1] == 'T' && richTextBoxMiddleStep.Text[i + 2] == 'E' && richTextBoxMiddleStep.Text[i + 3] == 'C' && richTextBoxMiddleStep.Text[i + 4] == 'K' && richTextBoxMiddleStep.Text[i + 5] == 'A' && richTextBoxMiddleStep.Text[i + 6] == 'V')
                {
                    richTextBoxMiddleStep.Select(i, 7);
                    richTextBoxMiddleStep.SelectionBackColor = Color.Red;
                    richTextBoxMiddleStep.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxMiddleStep.Text.Length - 6; i++)
            {
                if (richTextBoxMiddleStep.Text[i] == 'Q' && richTextBoxMiddleStep.Text[i + 1] == 'C' && richTextBoxMiddleStep.Text[i + 2] == 'A' && richTextBoxMiddleStep.Text[i + 3] == 'R' && richTextBoxMiddleStep.Text[i + 4] == 'K' && richTextBoxMiddleStep.Text[i + 5] == 'A' && richTextBoxMiddleStep.Text[i + 6] == 'V')
                {
                    richTextBoxMiddleStep.Select(i, 7);
                    richTextBoxMiddleStep.SelectionBackColor = Color.Red;
                    richTextBoxMiddleStep.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxMiddleStep.Text.Length - 8; i++)
            {
                if (richTextBoxMiddleStep.Text[i] == 'Q' && richTextBoxMiddleStep.Text[i + 1] == 'O' && richTextBoxMiddleStep.Text[i + 2] == 'T' && richTextBoxMiddleStep.Text[i + 3] == 'A' && richTextBoxMiddleStep.Text[i + 4] == 'Z' && richTextBoxMiddleStep.Text[i + 5] == 'N' && richTextBoxMiddleStep.Text[i + 6] == 'I' && richTextBoxMiddleStep.Text[i + 7] == 'K' && richTextBoxMiddleStep.Text[i + 8] == 'V')
                {
                    richTextBoxMiddleStep.Select(i, 9);
                    richTextBoxMiddleStep.SelectionBackColor = Color.Red;
                    richTextBoxMiddleStep.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxMiddleStep.Text.Length - 10; i++)
            {
                if (richTextBoxMiddleStep.Text[i] == 'Q' && richTextBoxMiddleStep.Text[i + 1] == 'V' && richTextBoxMiddleStep.Text[i + 2] == 'Y' && richTextBoxMiddleStep.Text[i + 3] == 'K' && richTextBoxMiddleStep.Text[i + 4] == 'R' && richTextBoxMiddleStep.Text[i + 5] == 'I' && richTextBoxMiddleStep.Text[i + 6] == 'C' && richTextBoxMiddleStep.Text[i + 7] == 'N' && richTextBoxMiddleStep.Text[i + 8] == 'I' && richTextBoxMiddleStep.Text[i + 9] == 'K' && richTextBoxMiddleStep.Text[i + 10] == 'V')
                {
                    richTextBoxMiddleStep.Select(i, 11);
                    richTextBoxMiddleStep.SelectionBackColor = Color.Red;
                    richTextBoxMiddleStep.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxMiddleStep.Text.Length - 5; i++)
            {
                if (richTextBoxMiddleStep.Text[i] == 'Q' && richTextBoxMiddleStep.Text[i + 1] == 'L' && richTextBoxMiddleStep.Text[i + 2] == 'I' && richTextBoxMiddleStep.Text[i + 3] == 'N' && richTextBoxMiddleStep.Text[i + 4] == 'E' && richTextBoxMiddleStep.Text[i + 5] == 'V')
                {
                    richTextBoxMiddleStep.Select(i, 6);
                    richTextBoxMiddleStep.SelectionBackColor = Color.Red;
                    richTextBoxMiddleStep.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxMiddleStep.Text.Length - 4; i++)
            {
                if (richTextBoxMiddleStep.Text[i] == 'Q' && richTextBoxMiddleStep.Text[i + 1] == 'O' && richTextBoxMiddleStep.Text[i + 2] == 'N' && richTextBoxMiddleStep.Text[i + 3] == 'E' && richTextBoxMiddleStep.Text[i + 4] == 'V')
                {
                    richTextBoxMiddleStep.Select(i, 5);
                    richTextBoxMiddleStep.SelectionBackColor = Color.Red;
                    richTextBoxMiddleStep.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxMiddleStep.Text.Length - 4; i++)
            {
                if (richTextBoxMiddleStep.Text[i] == 'Q' && richTextBoxMiddleStep.Text[i + 1] == 'T' && richTextBoxMiddleStep.Text[i + 2] == 'V' && richTextBoxMiddleStep.Text[i + 3] == 'O' && richTextBoxMiddleStep.Text[i + 4] == 'V')
                {
                    richTextBoxMiddleStep.Select(i, 5);
                    richTextBoxMiddleStep.SelectionBackColor = Color.Red;
                    richTextBoxMiddleStep.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxMiddleStep.Text.Length - 6; i++)
            {
                if (richTextBoxMiddleStep.Text[i] == 'Q' && richTextBoxMiddleStep.Text[i + 1] == 'T' && richTextBoxMiddleStep.Text[i + 2] == 'H' && richTextBoxMiddleStep.Text[i + 3] == 'R' && richTextBoxMiddleStep.Text[i + 4] == 'E' && richTextBoxMiddleStep.Text[i + 5] == 'E' && richTextBoxMiddleStep.Text[i + 6] == 'V')
                {
                    richTextBoxMiddleStep.Select(i, 7);
                    richTextBoxMiddleStep.SelectionBackColor = Color.Red;
                    richTextBoxMiddleStep.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxMiddleStep.Text.Length - 5; i++)
            {
                if (richTextBoxMiddleStep.Text[i] == 'Q' && richTextBoxMiddleStep.Text[i + 1] == 'F' && richTextBoxMiddleStep.Text[i + 2] == 'O' && richTextBoxMiddleStep.Text[i + 3] == 'U' && richTextBoxMiddleStep.Text[i + 4] == 'R' && richTextBoxMiddleStep.Text[i + 5] == 'V')
                {
                    richTextBoxMiddleStep.Select(i, 6);
                    richTextBoxMiddleStep.SelectionBackColor = Color.Red;
                    richTextBoxMiddleStep.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxMiddleStep.Text.Length - 5; i++)
            {
                if (richTextBoxMiddleStep.Text[i] == 'Q' && richTextBoxMiddleStep.Text[i + 1] == 'F' && richTextBoxMiddleStep.Text[i + 2] == 'I' && richTextBoxMiddleStep.Text[i + 3] == 'V' && richTextBoxMiddleStep.Text[i + 4] == 'E' && richTextBoxMiddleStep.Text[i + 5] == 'V')
                {
                    richTextBoxMiddleStep.Select(i, 6);
                    richTextBoxMiddleStep.SelectionBackColor = Color.Red;
                    richTextBoxMiddleStep.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxMiddleStep.Text.Length - 4; i++)
            {
                if (richTextBoxMiddleStep.Text[i] == 'Q' && richTextBoxMiddleStep.Text[i + 1] == 'S' && richTextBoxMiddleStep.Text[i + 2] == 'I' && richTextBoxMiddleStep.Text[i + 3] == 'X' && richTextBoxMiddleStep.Text[i + 4] == 'V')
                {
                    richTextBoxMiddleStep.Select(i, 5);
                    richTextBoxMiddleStep.SelectionBackColor = Color.Red;
                    richTextBoxMiddleStep.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxMiddleStep.Text.Length - 6; i++)
            {
                if (richTextBoxMiddleStep.Text[i] == 'Q' && richTextBoxMiddleStep.Text[i + 1] == 'S' && richTextBoxMiddleStep.Text[i + 2] == 'E' && richTextBoxMiddleStep.Text[i + 3] == 'V' && richTextBoxMiddleStep.Text[i + 4] == 'E' && richTextBoxMiddleStep.Text[i + 5] == 'N' && richTextBoxMiddleStep.Text[i + 6] == 'V')
                {
                    richTextBoxMiddleStep.Select(i, 7);
                    richTextBoxMiddleStep.SelectionBackColor = Color.Red;
                    richTextBoxMiddleStep.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxMiddleStep.Text.Length - 6; i++)
            {
                if (richTextBoxMiddleStep.Text[i] == 'Q' && richTextBoxMiddleStep.Text[i + 1] == 'E' && richTextBoxMiddleStep.Text[i + 2] == 'I' && richTextBoxMiddleStep.Text[i + 3] == 'G' && richTextBoxMiddleStep.Text[i + 4] == 'H' && richTextBoxMiddleStep.Text[i + 5] == 'T' && richTextBoxMiddleStep.Text[i + 6] == 'V')
                {
                    richTextBoxMiddleStep.Select(i, 7);
                    richTextBoxMiddleStep.SelectionBackColor = Color.Red;
                    richTextBoxMiddleStep.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxMiddleStep.Text.Length - 5; i++)
            {
                if (richTextBoxMiddleStep.Text[i] == 'Q' && richTextBoxMiddleStep.Text[i + 1] == 'N' && richTextBoxMiddleStep.Text[i + 2] == 'I' && richTextBoxMiddleStep.Text[i + 3] == 'N' && richTextBoxMiddleStep.Text[i + 4] == 'E' && richTextBoxMiddleStep.Text[i + 5] == 'V')
                {
                    richTextBoxMiddleStep.Select(i, 6);
                    richTextBoxMiddleStep.SelectionBackColor = Color.Red;
                    richTextBoxMiddleStep.SelectionColor = Color.Blue;
                }
            }

            for (int i = 0; i < richTextBoxMiddleStep.Text.Length - 5; i++)
            {
                if (richTextBoxMiddleStep.Text[i] == 'Q' && richTextBoxMiddleStep.Text[i + 1] == 'Z' && richTextBoxMiddleStep.Text[i + 2] == 'E' && richTextBoxMiddleStep.Text[i + 3] == 'R' && richTextBoxMiddleStep.Text[i + 4] == 'O' && richTextBoxMiddleStep.Text[i + 5] == 'V')
                {
                    richTextBoxMiddleStep.Select(i, 6);
                    richTextBoxMiddleStep.SelectionBackColor = Color.Red;
                    richTextBoxMiddleStep.SelectionColor = Color.Blue;
                }
            }
        }

        private void RichTextBoxInput_Enter(object sender, EventArgs e)
        {
            richTextBoxInput.SelectAll();
        }

        private void TextBoxPasswordExperimental_Enter(object sender, EventArgs e)
        {
            textBoxPasswordExperimental.SelectAll();
        }

        private void ColourInBetweensDecrypt(object sender, EventArgs e)
        {
            for (int i = 0; i < richTextBoxMiddleStep.Text.Length - 4; i++)
            {
                if (richTextBoxMiddleStep.Text[i] == richTextBoxMiddleStep.Text[i + 4])
                {
                    if (richTextBoxMiddleStep.Text[i + 1] == 'X' && richTextBoxMiddleStep.Text[i + 2] == 'Y' && richTextBoxMiddleStep.Text[i + 3] == 'X')
                    {
                        richTextBoxMiddleStep.Select(i + 1, 3);
                        richTextBoxMiddleStep.SelectionBackColor = Color.Blue;
                        richTextBoxMiddleStep.SelectionColor = Color.Red;
                    }
                    else if (richTextBoxMiddleStep.Text[i] == 'X' && richTextBoxMiddleStep.Text[i + 1] == 'Q' && richTextBoxMiddleStep.Text[i + 2] == 'Y' && richTextBoxMiddleStep.Text[i + 3] == 'Q')
                    {
                        richTextBoxMiddleStep.Select(i + 1, 3);
                        richTextBoxMiddleStep.SelectionBackColor = Color.Blue;
                        richTextBoxMiddleStep.SelectionColor = Color.Red;
                        i += 3;
                    }
                }
            }
            
            if (richTextBoxMiddleStep.Text.Length > 3)
            {
                if (richTextBoxMiddleStep.Text.ToString().Substring(richTextBoxMiddleStep.Text.Length - 3) == "XYX")
                {
                    richTextBoxMiddleStep.Select(richTextBoxMiddleStep.Text.Length - 3, 3);
                    richTextBoxMiddleStep.SelectionBackColor = Color.Blue;
                    richTextBoxMiddleStep.SelectionColor = Color.Red;
                }
                else if (richTextBoxMiddleStep.Text.ToString().Substring(richTextBoxMiddleStep.Text.Length - 3) == "QYQ")
                {
                    richTextBoxMiddleStep.Select(richTextBoxMiddleStep.Text.Length - 3, 3);
                    richTextBoxMiddleStep.SelectionBackColor = Color.Blue;
                    richTextBoxMiddleStep.SelectionColor = Color.Red;
                }
            }
        }

        private void TrackBarSlowmo_Scroll(object sender, EventArgs e)
        {
            slowmoSpeed = trackBarSlowmo.Value;
        }
    }
}
