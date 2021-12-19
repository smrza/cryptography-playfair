using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Playfair_Cipher
{
    class StaticMethods
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///DEFAULT
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static string ParseInputEncryption(string input)
        {
            StringBuilder stringBuilderInput = new StringBuilder(input.ToUpper());
            StringBuilder stringBuilderOutput = new StringBuilder();

            for (int i = 0; i < stringBuilderInput.Length; i++)
            {
                if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[A-VX-Z]+$") == true)
                {
                    stringBuilderOutput.Append(stringBuilderInput[i]);
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[W]+$") == true)
                {
                    stringBuilderOutput.Append("VBN");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[ ]+$") == true)
                {
                    stringBuilderOutput.Append("ZVBYP");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[Ě]+$") == true)
                {
                    stringBuilderOutput.Append("E");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[Š]+$") == true)
                {
                    stringBuilderOutput.Append("S");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[Č]+$") == true)
                {
                    stringBuilderOutput.Append("C");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[Ř]+$") == true)
                {
                    stringBuilderOutput.Append("R");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[Ž]+$") == true)
                {
                    stringBuilderOutput.Append("Z");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[Ý]+$") == true)
                {
                    stringBuilderOutput.Append("Y");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[Á]+$") == true)
                {
                    stringBuilderOutput.Append("A");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[Í]+$") == true)
                {
                    stringBuilderOutput.Append("I");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[É]+$") == true)
                {
                    stringBuilderOutput.Append("E");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[Ó]+$") == true)
                {
                    stringBuilderOutput.Append("O");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[Ň]+$") == true)
                {
                    stringBuilderOutput.Append("N");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[Ď]+$") == true)
                {
                    stringBuilderOutput.Append("D");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[Ť]+$") == true)
                {
                    stringBuilderOutput.Append("T");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[Ú]+$") == true)
                {
                    stringBuilderOutput.Append("U");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[Ů]+$") == true)
                {
                    stringBuilderOutput.Append("U");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[Ľ]+$") == true)
                {
                    stringBuilderOutput.Append("L");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[Ĺ]+$") == true)
                {
                    stringBuilderOutput.Append("L");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[Ñ]+$") == true)
                {
                    stringBuilderOutput.Append("N");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[Ü]+$") == true)
                {
                    stringBuilderOutput.Append("U");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[Ä]+$") == true)
                {
                    stringBuilderOutput.Append("A");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[Ï]+$") == true)
                {
                    stringBuilderOutput.Append("I");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[.]+$") == true)
                {
                    stringBuilderOutput.Append("QTECKAV");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[,]+$") == true)
                {
                    stringBuilderOutput.Append("QCARKAV");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[?]+$") == true)
                {
                    stringBuilderOutput.Append("QOTAZNIKV");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[!]+$") == true)
                {
                    stringBuilderOutput.Append("QVYKRICNIKV");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[\\n]+$") == true)
                {
                    stringBuilderOutput.Append("QLINEV");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[1]+$") == true)
                {
                    stringBuilderOutput.Append("QONEV");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[2]+$") == true)
                {
                    stringBuilderOutput.Append("QTVOV");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[3]+$") == true)
                {
                    stringBuilderOutput.Append("QTHREEV");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[4]+$") == true)
                {
                    stringBuilderOutput.Append("QFOURV");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[5]+$") == true)
                {
                    stringBuilderOutput.Append("QFIVEV");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[6]+$") == true)
                {
                    stringBuilderOutput.Append("QSIXV");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[7]+$") == true)
                {
                    stringBuilderOutput.Append("QSEVENV");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[8]+$") == true)
                {
                    stringBuilderOutput.Append("QEIGHTV");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[9]+$") == true)
                {
                    stringBuilderOutput.Append("QNINEV");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[0]+$") == true)
                {
                    stringBuilderOutput.Append("QZEROV");
                }
            }
            return stringBuilderOutput.ToString();
        }

        public static string ParseInputDecryption(string input)
        {
            StringBuilder stringBuilderInput = new StringBuilder(input.ToUpper());
            StringBuilder stringBuilderOutput = new StringBuilder();

            for (int i = 0; i < stringBuilderInput.Length; i++)
            {
                if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[A-VX-Z]+$") == true)
                {
                    stringBuilderOutput.Append(stringBuilderInput[i]);
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[Ě]+$") == true)
                {
                    stringBuilderOutput.Append("E");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[Š]+$") == true)
                {
                    stringBuilderOutput.Append("S");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[Č]+$") == true)
                {
                    stringBuilderOutput.Append("C");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[Ř]+$") == true)
                {
                    stringBuilderOutput.Append("R");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[Ž]+$") == true)
                {
                    stringBuilderOutput.Append("Z");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[Ý]+$") == true)
                {
                    stringBuilderOutput.Append("Y");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[Á]+$") == true)
                {
                    stringBuilderOutput.Append("A");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[Í]+$") == true)
                {
                    stringBuilderOutput.Append("I");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[É]+$") == true)
                {
                    stringBuilderOutput.Append("E");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[Ó]+$") == true)
                {
                    stringBuilderOutput.Append("O");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[Ň]+$") == true)
                {
                    stringBuilderOutput.Append("N");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[Ď]+$") == true)
                {
                    stringBuilderOutput.Append("D");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[Ť]+$") == true)
                {
                    stringBuilderOutput.Append("T");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[Ú]+$") == true)
                {
                    stringBuilderOutput.Append("U");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[Ů]+$") == true)
                {
                    stringBuilderOutput.Append("U");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[Ľ]+$") == true)
                {
                    stringBuilderOutput.Append("L");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[Ĺ]+$") == true)
                {
                    stringBuilderOutput.Append("L");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[Ñ]+$") == true)
                {
                    stringBuilderOutput.Append("N");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[Ü]+$") == true)
                {
                    stringBuilderOutput.Append("U");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[Ä]+$") == true)
                {
                    stringBuilderOutput.Append("A");
                }
                else if (Regex.IsMatch(Convert.ToString(stringBuilderInput[i]), "[Ï]+$") == true)
                {
                    stringBuilderOutput.Append("I");
                }
            }
            return stringBuilderOutput.ToString();
        }

        public static string ReplaceOutput(string input)
        {
            StringBuilder stringBuilderInput = new StringBuilder(input);
            stringBuilderInput = stringBuilderInput.Replace("VBN", "W");
            stringBuilderInput = stringBuilderInput.Replace("ZVBYP", " ");
            stringBuilderInput = stringBuilderInput.Replace("QTECKAV", ".");
            stringBuilderInput = stringBuilderInput.Replace("QCARKAV", ",");
            stringBuilderInput = stringBuilderInput.Replace("QOTAZNIKV", "?");
            stringBuilderInput = stringBuilderInput.Replace("QVYKRICNIKV", "!");
            stringBuilderInput = stringBuilderInput.Replace("QLINEV", "\n");
            stringBuilderInput = stringBuilderInput.Replace("QONEV", "1");
            stringBuilderInput = stringBuilderInput.Replace("QTVOV", "2");
            stringBuilderInput = stringBuilderInput.Replace("QTHREEV", "3");
            stringBuilderInput = stringBuilderInput.Replace("QFOURV", "4");
            stringBuilderInput = stringBuilderInput.Replace("QFIVEV", "5");
            stringBuilderInput = stringBuilderInput.Replace("QSIXV", "6");
            stringBuilderInput = stringBuilderInput.Replace("QSEVENV", "7");
            stringBuilderInput = stringBuilderInput.Replace("QEIGHTV", "8");
            stringBuilderInput = stringBuilderInput.Replace("QNINEV", "9");
            stringBuilderInput = stringBuilderInput.Replace("QZEROV", "0");

            return stringBuilderInput.ToString();
        }

        public static string ParseDoubleLetter(string input)
        {
            StringBuilder stringBuilder = new StringBuilder(input);
            for (int i = 0; i < stringBuilder.Length-1; i++)
            {
                if (stringBuilder[i] == 'X' && stringBuilder[i+1] == 'X')
                {
                    stringBuilder.Insert(i+1, "Q");
                    i++;
                }
                else if (stringBuilder[i] == stringBuilder[i+1])
                {
                    stringBuilder.Insert(i+1, "X");
                    i++;
                }
            }

            if(stringBuilder.Length % 2 == 1)
            {
                if (stringBuilder[stringBuilder.Length-1] == 'X')
                {
                    stringBuilder.Append("Q");
                }
                else
                {
                    stringBuilder.Append("X");
                }
            }

            return stringBuilder.ToString();
        }

        public static string Bigram(string input)
        {
            StringBuilder stringBuilder = new StringBuilder(input);

            for (int i = 2; i <= stringBuilder.Length - 1; i += 2)
            {
                stringBuilder = stringBuilder.Insert(i, " ");
                i++;
            }
            return stringBuilder.ToString();
        }

        public static (int, int, int, int) EncryptedIndex(int indexRowA, int indexColumnA, int indexRowB, int indexColumnB)
        {
            if (indexRowA == indexRowB)
            {
                if (indexColumnA == 4)
                {
                    indexColumnA = 0;
                }
                else
                {
                    indexColumnA += 1;
                }

                if (indexColumnB == 4)
                {
                    indexColumnB = 0;
                }
                else
                {
                    indexColumnB += 1;
                }
            }
            else if (indexColumnA == indexColumnB)
            {
                if (indexRowA == 4)
                {
                    indexRowA = 0;
                }
                else
                {
                    indexRowA += 1;
                }

                if (indexRowB == 4)
                {
                    indexRowB = 0;
                }
                else
                {
                    indexRowB += 1;
                }
            }
            else
            {
                int tmp = indexColumnA;
                indexColumnA = indexColumnB;
                indexColumnB = tmp;
            }

            return (indexRowA, indexColumnA, indexRowB, indexColumnB);
        }

        public static (int, int, int, int) DecryptedIndex(int indexRowA, int indexColumnA, int indexRowB, int indexColumnB)
        {
            if (indexRowA == indexRowB)
            {
                if (indexColumnA == 0)
                {
                    indexColumnA = 4;
                }
                else
                {
                    indexColumnA -= 1;
                }

                if (indexColumnB == 0)
                {
                    indexColumnB = 4;
                }
                else
                {
                    indexColumnB -= 1;
                }
            }
            else if (indexColumnA == indexColumnB)
            {
                if (indexRowA == 0)
                {
                    indexRowA = 4;
                }
                else
                {
                    indexRowA -= 1;
                }

                if (indexRowB == 0)
                {
                    indexRowB = 4;
                }
                else
                {
                    indexRowB -= 1;
                }
            }
            else
            {
                int tmp = indexColumnA;
                indexColumnA = indexColumnB;
                indexColumnB = tmp;
            }

            return (indexRowA, indexColumnA, indexRowB, indexColumnB);
        }

        public static string DeParseDoubleLetter(string input)
        {
            StringBuilder stringBuilder = new StringBuilder(input);

            for (int i = 0; i < stringBuilder.Length-2; i++)
            {
                if (stringBuilder[i] == stringBuilder[i + 2])
                {
                    stringBuilder.Replace($"{stringBuilder[i]}X{stringBuilder[i + 2]}", $"{stringBuilder[i]}{stringBuilder[i]}");
                    stringBuilder.Replace($"XQX", $"XX");
                }
            }

            if (stringBuilder.Length > 0)
            {
                if (stringBuilder.ToString().Last() == 'X')
                {
                    stringBuilder.Remove(stringBuilder.Length - 1, 1);
                }
                else if (stringBuilder.ToString().Last() == 'Q' && stringBuilder.ToString()[stringBuilder.Length - 2] == 'X')
                {
                    stringBuilder.Remove(stringBuilder.Length - 1, 1);
                }
            }

            return stringBuilder.ToString();
        }



        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///EXPERIMENTAL
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public static string RandomPassword()
        {
            //používáli jsme soubor se slovníkem češtiny, který má 190MB, tudíž nelze poslat přes mail
            /*
            string path = $"{System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\Resources\\CZ.txt";
            string[] lines = File.ReadAllLines(path);
            Random random = new Random();
            int randomLineNumber = random.Next(0, lines.Length - 1);
            string password = lines[randomLineNumber];
            return password;
            */
            return "placeholder";
        }

        public static string ParseRandomPassword(string input)
        {
            StringBuilder inputString = new StringBuilder(input.ToUpper());
            StringBuilder outputString = new StringBuilder();

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == 'W')
                {
                    outputString.Append('V');
                }
                if (inputString[i] == 'Á')
                {
                    outputString.Append('A');
                }
                else if (inputString[i] == 'Ě')
                {
                    outputString.Append('E');
                }
                else if (inputString[i] == 'Š')
                {
                    outputString.Append('S');
                }
                else if (inputString[i] == 'Č')
                {
                    outputString.Append('C');
                }
                else if (inputString[i] == 'Ř')
                {
                    outputString.Append('R');
                }
                else if (inputString[i] == 'Ž')
                {
                    outputString.Append('Z');
                }
                else if (inputString[i] == 'Ý')
                {
                    outputString.Append('Y');
                }
                else if (inputString[i] == 'Í')
                {
                    outputString.Append('I');
                }
                else if (inputString[i] == 'É')
                {
                    outputString.Append('E');
                }
                else if (inputString[i] == 'Ú')
                {
                    outputString.Append('U');
                }
                else if (inputString[i] == 'Ů')
                {
                    outputString.Append('U');
                }
                else if (inputString[i] == 'Ó')
                {
                    outputString.Append('O');
                }
                else if (inputString[i] == 'Ť')
                {
                    outputString.Append('T');
                }
                else if (inputString[i] == 'Ň')
                {
                    outputString.Append('N');
                }
                else if (inputString[i] == 'Ď')
                {
                    outputString.Append('D');
                }
                else if (Char.IsLetter(inputString[i]) == true)
                {
                    outputString.Append(input[i]);
                }
            }

            return Convert.ToString(outputString);
        }

        public static string ParseDoubleLetterExperimental(string input)
        {
            StringBuilder stringBuilder = new StringBuilder(input);
            for (int i = 0; i < stringBuilder.Length - 1; i++)
            {
                if (stringBuilder[i] == 'X' && stringBuilder[i + 1] == 'X')
                {
                    stringBuilder.Insert(i + 1, "QYQ");
                    i++;
                }
                else if (stringBuilder[i] == stringBuilder[i + 1])
                {
                    stringBuilder.Insert(i + 1, "XYX");
                    i++;
                }
            }

            if (stringBuilder.Length % 2 == 1)
            {
                if (stringBuilder[stringBuilder.Length - 1] == 'X')
                {
                    stringBuilder.Append("QYQ");
                }
                else
                {
                    stringBuilder.Append("XYX");
                }
            }

            return stringBuilder.ToString();
        }

        public static string DeParseDoubleLetterExperimental(string input)
        {
            StringBuilder stringBuilder = new StringBuilder(input);

            for (int i = 0; i < stringBuilder.Length -4; i++)
            {
                if (stringBuilder[i] == stringBuilder[i + 4])
                {
                    stringBuilder.Replace($"{stringBuilder[i]}XYX{stringBuilder[i + 4]}", $"{stringBuilder[i]}{stringBuilder[i]}");
                    stringBuilder.Replace($"XQYQX", $"XX");
                }
            }

            if (stringBuilder.Length > 2 )
            {
                if (stringBuilder.ToString().Substring(stringBuilder.Length - 3) == "XYX")
                {
                    stringBuilder.Remove(stringBuilder.Length - 3, 3);
                }
                else if (stringBuilder.ToString().Substring(stringBuilder.Length - 3) == "QYQ")
                {
                    stringBuilder.Remove(stringBuilder.Length - 3, 3);
                }
            }

            return stringBuilder.ToString();
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
