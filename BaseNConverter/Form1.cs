using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaseNConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormulaTxt.ReadOnly = true;
            SecondValue.ReadOnly = true;
        }
        private static string DecimalToBaseN(int value, int n, StringBuilder formula)
        {
            int num = value;
            int basevalue = n;
            StringBuilder sb = new StringBuilder();
            List<int> characterList = new List<int>();
            formula.Append($"Divide {value} to {n} until quotient is 0: \n");
            while (num > 0)
            {
                var q = num / basevalue;
                var r = num - (q * basevalue);
                formula.Append($"{num}/{basevalue} = {q}.{r}\n");
                characterList.Insert(0, r);
                sb.Insert(0, (char)((r > 9 ? '7' : '0') + r));
                num = q;
            }

            formula.Append('\n');
            formula.Append("Read the remainders from bottom to top to get the value: \n");
            formula.Append("result => ");
            formula.Append(string.Join(" ", characterList.Select(x => x.ToString()).ToArray()) + "\n\n");
            if(characterList.Exists(x => x > 9))
            {
                formula.Append("Convert numbers more than 9 to the character code next to it: \n");
                formula.Append("result => ");
                formula.Append(string.Join(" ", characterList.Select(x => ((char)((x > 9 ? '7' : '0') + x)).ToString()).ToArray()) + '\n');
            }
            formula.Append("result => ");
            formula.Append(sb.ToString());
            return sb.ToString();
        }
        private static int BaseNToDecimal(string str, int n, StringBuilder formula)
        {
            List<int> characterList = new List<int>();
            int num = 0;
            for (int i = 0; i < str.Length; i++)
            {
                var currChar = str[i];
                int ConvertedNum = currChar - (char.IsDigit(currChar) ? '0' : 55);
                characterList.Add(ConvertedNum);
                num += ConvertedNum * (int)Math.Pow(n, str.Length - (i + 1));
            }
            if(characterList.Exists(x => x > 9))
            {
                formula.Append("Convert letters back to integer: \n");
                formula.Append("result => ");
                formula.Append(string.Join(" ", characterList.Select(x => x.ToString()).ToArray()) + '\n');
            }
            formula.Append($"Multiply each digit by ({n}^(n-1)) where n is the digit length: \n");
            List<string> tmpstr = new List<string>();
            for(int i = 0; i < characterList.Count; i++)
                tmpstr.Add($"({characterList[i]}*({n}^({characterList.Count - (i + 1)})))");

            formula.Append("result => ");
            formula.Append(string.Join(" + ", tmpstr.ToArray()) + '\n');
            tmpstr.Clear();

            for (int i = 0; i < characterList.Count; i++)
                tmpstr.Add($"({characterList[i]}*{Math.Pow(n, characterList.Count - (i + 1))})");

            formula.Append("result => ");
            formula.Append(string.Join(" + ", tmpstr.ToArray()) + '\n');
            tmpstr.Clear();

            for (int i = 0; i < characterList.Count; i++)
                tmpstr.Add($"{characterList[i] * Math.Pow(n, characterList.Count - (i + 1))}");

            formula.Append("result => ");
            formula.Append(string.Join(" + ", tmpstr.ToArray()) + '\n');
            tmpstr.Clear();

            formula.Append("result => ");
            formula.Append(num);

            return num;
        }

        private bool IsValidBaseN(string chars, int basevalue)
        {
            if (chars.Length == 0) return false;
            bool isValid;
            foreach (var c in chars)
            {
                if (basevalue > 9 && c > '9')
                {
                    isValid = c >= 'A' && c <= ('A' + (basevalue - 11));
                }
                else
                    isValid = c >= '0' && c <= ('0' + (basevalue - 1));

                if (!isValid)
                    return false;
            }
            return true;
        }
        private void DoMagic()
        {
            try
            {
                if (IsValidBaseN(FirstValue.Text, (int)firstBaseN.Value))
                {
                    StringBuilder formula = new StringBuilder();
                    if ((int)firstBaseN.Value == 10)
                        SecondValue.Text = DecimalToBaseN(int.Parse(FirstValue.Text), (int)secondBaseN.Value, formula);
                    else if((int)secondBaseN.Value == 10)
                        SecondValue.Text = BaseNToDecimal(FirstValue.Text, (int)firstBaseN.Value, formula).ToString();
                    else if ((int)firstBaseN.Value == (int)secondBaseN.Value)
                    {
                        formula.Append($"{FirstValue.Text} = {SecondValue.Text} \n");
                        SecondValue.Text = FirstValue.Text;
                    }
                    else
                    {
                        formula.Append($"Convert {FirstValue.Text} to decimal first: \n");
                        int decimalvalue = BaseNToDecimal(FirstValue.Text, (int)firstBaseN.Value, formula);
                        formula.Append($"\n\nThen we convert {decimalvalue} to Base {secondBaseN.Value}: \n");
                        SecondValue.Text = DecimalToBaseN(decimalvalue, (int)secondBaseN.Value, formula);
                    }
                    FormulaTxt.Text = formula.ToString();
                }
                else
                    FormulaTxt.Text = "Invalid input!";
            }
            catch
            {
                FormulaTxt.Text = "Invalid input!";
            }
        }
        private void FirstValue_TextChanged(object sender, EventArgs e)
        {
            DoMagic();
        }

        private void SwapValue_Click(object sender, EventArgs e)
        {
            string secvalue = SecondValue.Text;
            SecondValue.Text = FirstValue.Text;
            FirstValue.Text = secvalue;

            var secondDecimalval = secondBaseN.Value;
            secondBaseN.Value = firstBaseN.Value;
            firstBaseN.Value = secondDecimalval;

        }

        private void firstBaseN_ValueChanged(object sender, EventArgs e)
        {
            DoMagic();
        }

        private void secondBaseN_ValueChanged(object sender, EventArgs e)
        {
            DoMagic();
        }
    }
}
