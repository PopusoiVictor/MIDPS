using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
     public partial class Calculator : Form
     {
          double number01;
          double number02;
          int plusButtonCounter = 0;
          int minusButtonCounter = 0;
          int multButtonCounter = 0;
          int divideButtonCounter = 0;
          int xyButtonCounter = 0;
          int clickCounter = 0;
          public Calculator()
          {
               InitializeComponent();
               plusButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
               plusButton.FlatAppearance.BorderSize = 0;
               equalButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
               equalButton.FlatAppearance.BorderSize = 0;
               minusButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
               minusButton.FlatAppearance.BorderSize = 0;
               multButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
               multButton.FlatAppearance.BorderSize = 0;
               divideButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
               divideButton.FlatAppearance.BorderSize = 0;
               button0.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
               button0.FlatAppearance.BorderSize = 0;
               button1.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
               button1.FlatAppearance.BorderSize = 0;
               button2.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
               button2.FlatAppearance.BorderSize = 0;
               button3.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
               button3.FlatAppearance.BorderSize = 0;
               button4.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
               button4.FlatAppearance.BorderSize = 0;
               button5.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
               button5.FlatAppearance.BorderSize = 0;
               button6.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
               button6.FlatAppearance.BorderSize = 0;
               button7.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
               button7.FlatAppearance.BorderSize = 0;
               button8.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
               button8.FlatAppearance.BorderSize = 0;
               button9.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
               button9.FlatAppearance.BorderSize = 0;
               buttonPlusMinus.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
               buttonPlusMinus.FlatAppearance.BorderSize = 0;
               buttonPunct.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
               buttonPunct.FlatAppearance.BorderSize = 0;
               buttonProcent.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
               buttonProcent.FlatAppearance.BorderSize = 0;
               buttonRadical.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
               buttonRadical.FlatAppearance.BorderSize = 0;
               buttonPutere.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
               buttonPutere.FlatAppearance.BorderSize = 0;
               buttonCE.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
               buttonCE.FlatAppearance.BorderSize = 0;
               buttonC.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
               buttonC.FlatAppearance.BorderSize = 0;
               buttonx_y.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
               buttonx_y.FlatAppearance.BorderSize = 0;
               buttonDelete.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
               buttonDelete.FlatAppearance.BorderSize = 0; 
          }

          private void numberTextBox_TextChanged(object sender, EventArgs e){}
          private void textBoxShow_TextChanged(object sender, EventArgs e){}

          private void plusButton_Click(object sender, EventArgs e)
          {
               number01 = double.Parse(textBoxShow.Text);
               numberTextBox.Text += textBoxShow.Text + " + ";
               textBoxShow.Text = "";
               plusButtonCounter++;
          }

          private void equalButton_Click(object sender, EventArgs e)
          {
               number02 = double.Parse(textBoxShow.Text);
               if (plusButtonCounter == 1)
               {
                    numberTextBox.Text = "";
                    textBoxShow.Text = "" + (number01 + number02);
                    plusButtonCounter = 0;
               }
               else if (minusButtonCounter == 1)
               {
                    numberTextBox.Text = "";
                    textBoxShow.Text = "" + (number01 - number02);
                    minusButtonCounter = 0;
               }
               else if (multButtonCounter == 1)
               {
                    numberTextBox.Text = "";
                    textBoxShow.Text = "" + (number01 * number02);
                    multButtonCounter = 0;
               }
               else if (divideButtonCounter == 1)
               {
                    if(number02 == 0)
                    {
                         MessageBox.Show("Numitorul nu poate fi 0","Error");
                    }
                    else
                    {
                         numberTextBox.Text = "";
                         textBoxShow.Text = "" + (number01 / number02);
                         divideButtonCounter = 0;
                    }
               }
               else if (xyButtonCounter == 1)
               {
                    textBoxShow.Text = Math.Pow(number01, number02).ToString();
                    xyButtonCounter = 0;
               }
          }

          private void minusButton_Click(object sender, EventArgs e)
          {
               number01 = double.Parse(textBoxShow.Text);
               numberTextBox.Text += textBoxShow.Text + " - ";
               textBoxShow.Text = "";
               minusButtonCounter++;
          }

          private void multButton_Click(object sender, EventArgs e)
          {
               number01 = double.Parse(textBoxShow.Text);
               numberTextBox.Text += textBoxShow.Text + " * ";
               textBoxShow.Text = "";
               multButtonCounter++;
          }

          private void divideButton_Click(object sender, EventArgs e)
          {
               number01 = double.Parse(textBoxShow.Text);
               numberTextBox.Text += textBoxShow.Text + " / ";
               textBoxShow.Text = "";
               divideButtonCounter++;
          }

          private void button9_Click(object sender, EventArgs e)
          {
               clickCounter++;
               if (clickCounter == 1)
               {
                    textBoxShow.Text = "9";
               }
               else 
               {
                    
                    textBoxShow.Text += "9";
               }
               
          }
          private void button8_Click(object sender, EventArgs e)
          {
               clickCounter++;
               if (clickCounter == 1)
               {
                    textBoxShow.Text = "8";
               }
               else
               {
                    textBoxShow.Text += "8";
               }
          }

          private void button7_Click(object sender, EventArgs e)
          {
               clickCounter++;
               if (clickCounter == 1)
               {
                    textBoxShow.Text = "7";
               }
               else
               {
                    textBoxShow.Text += "7";
               }
          }

          private void button6_Click(object sender, EventArgs e)
          {
               clickCounter++;
               if (clickCounter == 1)
               {
                    textBoxShow.Text = "6";
               }
               else
               {
                    textBoxShow.Text += "6";
               }
          }

          private void button5_Click(object sender, EventArgs e)
          {
               clickCounter++;
               if (clickCounter == 1)
               {
                    textBoxShow.Text = "5";
               }
               else
               {
                    textBoxShow.Text += "5";
               }
          }

          private void button4_Click(object sender, EventArgs e)
          {
               clickCounter++;
               if (clickCounter == 1)
               {
                    textBoxShow.Text = "4";
               }
               else
               {
                    textBoxShow.Text += "4";
               }
          }

          private void button3_Click(object sender, EventArgs e)
          {
               clickCounter++;
               if (clickCounter == 1)
               {
                    textBoxShow.Text = "3";
               }
               else
               {
                    textBoxShow.Text += "3";
               }
          }

          private void button2_Click(object sender, EventArgs e)
          {
               clickCounter++;
               if (clickCounter == 1)
               {
                    textBoxShow.Text = "2";
               }
               else
               {
                    textBoxShow.Text += "2";
               }
          }

          private void button1_Click(object sender, EventArgs e)
          {
               clickCounter++;
               if (clickCounter == 1)
               {
                    textBoxShow.Text = "1";
               }
               else
               {
                    textBoxShow.Text += "1";
               }
          }

          private void button0_Click(object sender, EventArgs e)
          {
               if(textBoxShow.Text != "0")
               {
                    textBoxShow.Text += "0";
               }
          }

          private void buttonDelete_Click(object sender, EventArgs e)
          {
               textBoxShow.Text = textBoxShow.Text.Substring(0, textBoxShow.Text.Length - 1);
          }

          private void buttonC_Click(object sender, EventArgs e)
          {
               textBoxShow.Text = "";
               numberTextBox.Text = "";
          }

          private void buttonPutere_Click(object sender, EventArgs e)
          {
               number01 = double.Parse(textBoxShow.Text);
               textBoxShow.Text = "" + (number01*number01);
          }

          private void buttonRadical_Click(object sender, EventArgs e)
          {
               number01 = double.Parse(textBoxShow.Text);
               textBoxShow.Text = "" + Math.Sqrt(number01);
          }

          private void buttonPunct_Click(object sender, EventArgs e)
          {
               if (textBoxShow.Text.Contains("."))
               {
                    textBoxShow.Text = textBoxShow.Text;
               }
               else
               {
                    textBoxShow.Text += ".";
               }

          }

          private void buttonProcent_Click(object sender, EventArgs e)
          {
               number02 = double.Parse(textBoxShow.Text);
               textBoxShow.Text = Convert.ToString(number02 / 100);
          }

          private void buttonPlusMinus_Click(object sender, EventArgs e)
          {
               if (textBoxShow.Text.StartsWith("-"))
               {
                    textBoxShow.Text = textBoxShow.Text.Substring(1);
               }
               else if (!string.IsNullOrEmpty(textBoxShow.Text) && decimal.Parse(textBoxShow.Text) != 0)
               {  
                    textBoxShow.Text = "-" + textBoxShow.Text;
               }
          }

          private void buttonCE_Click(object sender, EventArgs e)
          {
               textBoxShow.Text = "";
          }

          private void buttonx_y_Click(object sender, EventArgs e)
          {
               number01 = double.Parse(textBoxShow.Text);
               textBoxShow.Text = "";
               xyButtonCounter++;
          }
          private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
          {
               MessageBox.Show(" Calculator v1.0 \n A elaborat st.gr. TI-154 Popusoi Victor","About");
          }

          private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
          {
               System.Windows.Forms.Application.Exit();
          }
     }
}