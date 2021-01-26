using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BaseConverter
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }
        private String strValue = null;
        private void changeValues(int baseNum)
        {
            List<TextBox> tbValsList = new List<TextBox>();

            tbValsList.Add(tbBin);
            tbValsList.Add(tbTern);
            tbValsList.Add(tbQuatern);
            tbValsList.Add(tbQuin);
            tbValsList.Add(tbSen);
            tbValsList.Add(tbSepten);
            tbValsList.Add(tbOct);
            tbValsList.Add(tbNon);
            tbValsList.Add(tbDec);
            tbValsList.Add(tbUndec);
            tbValsList.Add(tbDuodec);
            tbValsList.Add(tbTridec);
            tbValsList.Add(tbTetradec);
            tbValsList.Add(tbPentadec);
            tbValsList.Add(tbHexadec);

            if (strValue != null)
            {
                //calculate value of base 10 from new value
                decimal sum = 0;
                int assignedNum = strValue.Length - 1;
                if(baseNum != 10)
                {
                    for (int ix = 0; ix < strValue.Length; ix++)
                    {
                        int asciiVal = (int)strValue[ix];
                        int val = asciiVal - 48;
                        if (asciiVal >= 48 && asciiVal <= 57)
                        {
                            sum += val * (decimal)Math.Pow(baseNum, assignedNum);
                        }
                        else if (asciiVal >= 65 && asciiVal <= 70)
                        {
                            sum += (asciiVal - 55) * (decimal)Math.Pow(baseNum, assignedNum);
                        }
                        assignedNum--;
                    }
                    tbDec.Text = decimal.Round(sum, 2).ToString();
                }
  
                //update all values based on decimal value
                decimal.TryParse(tbDec.Text, out decimal num);
                decimal quotient;
                decimal newQuotient;
                List<decimal> result = new List<decimal>();
                baseNum = 2;
                while (baseNum <= 16)
                {
                    if (baseNum != 10)
                    {
                        newQuotient = num;
                        do
                        {
                            quotient = Math.Truncate(newQuotient / baseNum);
                            result.Add(newQuotient % baseNum);
                            newQuotient = quotient;
                        }
                        while (newQuotient >= baseNum);
                        result.Add(newQuotient);
                        String strResult = null;
                        for (int ix = result.Count-1; ix >= 0; ix--)
                        {
                            if (result[ix] > 9)
                            {
                                strResult = String.Concat(strResult, (char)(result[ix] + 55));
                            }
                            else
                            {
                                strResult = String.Concat(strResult, result[ix]);
                            }
                        }
                        tbValsList[baseNum - 2].Text = strResult;
                        result.Clear();
                    }
                    baseNum++;
                }
            }
        }
        private void tbBin_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                strValue = tbBin.Text;
                changeValues(2);
            }
        }
        private void tbTern_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                strValue = tbTern.Text;
                changeValues(3);
            }
        }
        private void tbQuatern_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                strValue = tbQuatern.Text;
                changeValues(4);
            }
        }
        private void tbQuin_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                strValue = tbQuin.Text;
                changeValues(5);
            }
        }
        private void tbSen_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                strValue = tbSen.Text;
                changeValues(6);
            }
        }
        private void tbSepten_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                strValue = tbSepten.Text;
                changeValues(7);
            }
        }
        private void tbOct_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                strValue = tbOct.Text;
                changeValues(8);
            }
        }

        private void tbNon_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                strValue = tbNon.Text;
                changeValues(9);
            }
        }

        private void tbDec_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                strValue = tbDec.Text;
                changeValues(10);
            }
        }
        private void tbUndec_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                strValue = tbUndec.Text;
                changeValues(11);
            }
        }
        private void tbDuodec_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                strValue = tbDuodec.Text;
                changeValues(12);
            }
        }
        private void tbTridec_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                strValue = tbTridec.Text;
                changeValues(13);
            }
        }
        private void tbTetradec_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                strValue = tbTetradec.Text;
                changeValues(14);
            }
        }
        private void tbPentadec_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                strValue = tbPentadec.Text;
                changeValues(15);
            }
        }
        private void tbHexadec_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                strValue = tbHexadec.Text;
                changeValues(16);
            }
        }
    }
}