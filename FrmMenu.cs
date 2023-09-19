using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Convert_App
{
    public partial class FrmMenu : Form
    {

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnMass_Click(object sender, EventArgs e)
        {
            bunifuPage1.SetPage(massPage);
            
        }

        private void btnLength_Click(object sender, EventArgs e)
        {
            bunifuPage1.SetPage(lengthPage);
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            bunifuPage1.SetPage(timePage);
        }

        private void btnTemperature_Click(object sender, EventArgs e)
        {
            bunifuPage1.SetPage(tempPage);
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            bunifuPage1.SetPage(dataPage);
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string value1 = comboBox1.SelectedItem.ToString();
            string value2 = comboBox2.SelectedItem.ToString();

            double num = double.Parse(btnTextbox.Text);
            double hasil = 0;
            string[] units = { "KM", "HM", "DAM", "M", "DM", "CM", "MM" };
            double[] multipliers = { 1, 10, 100, 1000, 10000, 100000, 1000000 };

            int indexValue1 = Array.IndexOf(units, value1);
            int indexValue2 = Array.IndexOf(units, value2);
            
            if (indexValue1 >= 0 && indexValue2 >= 0)
            {
                hasil = num * (multipliers[indexValue2] / multipliers[indexValue1]);
            }
            btnAnvers.Text = $"{hasil}{value2}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnConvertMass_Click(object sender, EventArgs e)
        {
            string value1 = listBox.SelectedItem.ToString();
            string value2 = listBox1.SelectedItem.ToString();

            double num = double.Parse(textbox.Text);
            double hasil = 0;
            string[] units = { "KG", "HG", "DAG", "G", "DG", "CG", "MG" };
            double[] multipliers = { 1, 10, 100, 1000, 10000, 100000, 1000000 };

            int indexValue1 = Array.IndexOf(units, value1);
            int indexValue2 = Array.IndexOf(units, value2);

            if (indexValue1 >= 0 && indexValue2 >= 0)
            {
                hasil = num * (multipliers[indexValue2] / multipliers[indexValue1]);
            }
            btnHasil.Text = $"{hasil}{value2}";
        }

        private void btnConvertTime_Click(object sender, EventArgs e)
        {
            string value5 = list1.SelectedItem.ToString();
            string value6 = list2.SelectedItem.ToString();

            double num = double.Parse(textBo.Text);
            double hasil2 = 0;

            string[] unitsTime = { "S", "HOUR", "MIN" };
            double[] multipliersTime = { 1, 60, 3600 };

            int indexValue5 = Array.IndexOf(unitsTime, value5);
            int indexValue6 = Array.IndexOf(unitsTime, value6);

            if (indexValue5 >= 0 && indexValue6 >= 0)
            {
                hasil2 = num * (multipliersTime[indexValue6] / multipliersTime[indexValue5]);
            }

            textHasil.Text = $"{hasil2}{value6}";
        }

        private void btnConvertTemp_Click(object sender, EventArgs e)
        {
            string value7 = tempList1.SelectedItem.ToString();
            string value8 = tempList2.SelectedItem.ToString();

            double num = double.Parse(textinput.Text);
            double hasil3 = 0;

            if (value7 == "`C")
            {
                if (value8 == "`F")
                {
                    hasil3 = (1.8 * num) + 32;
                }
                else if (value8 == "`K")
                {
                    hasil3 = num + 273;
                }
                else if (value8 == "`R")
                {
                    hasil3 = 0.8 * num;
                }

            }
            if (value7 == "`F")
            {
                if (value8 == "`C")
                {
                    hasil3 = (5 / 9 * num) - 32;
                }

                else if (value8 == "`R")
                {
                    hasil3 = (4 / 9 * num) - 32;
                }

            }
            if (value7 == "`K")
            {
                if (value8 == "`C")
                {
                    hasil3 = num - 273;
                }

                else if (value8 == "`R")
                {
                    hasil3 = (4 / 5 * num) - 273;
                }

            }
            if (value7 == "`R")
            {
                if (value8 == "`C")
                {
                    hasil3 = (4 / 5) * num;
                }
                else if (value8 == "`F")
                {
                    hasil3 = (9 / 4 * num) + 32;
                }
                else if (value8 == "`K")
                {
                    hasil3 = (5 / 4 * num) + 273;
                }

            }

            textHasilTemp.Text = $"{hasil3}{value8}";
        }

        private void btnConvertData_Click(object sender, EventArgs e)
        {
            string value9 = listtt1.SelectedItem.ToString();
            string value10 = listttt2.SelectedItem.ToString();

            double num = double.Parse(btninputData.Text);
            double hasil4 = 0;

            string[] unitsData = { "GB", "MB", "KB" };
            double[] multipliersData = { 1, 1000, 1000000 };

            int indexValue9 = Array.IndexOf(unitsData, value9);
            int indexValue10 = Array.IndexOf(unitsData, value10);

            if (indexValue9 >= 0 && indexValue10 >= 0)
            {
                hasil4 = num * (multipliersData[indexValue10] / multipliersData[indexValue9]);
            }

            hasilData.Text = $"{hasil4}{value10}";
        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTextbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void bunifuPage1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;

        }

        private void btninputData_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;

        }

        private void textBo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;

        }

        private void textinput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;

        }
    }
}
