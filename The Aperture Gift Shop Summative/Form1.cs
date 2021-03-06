using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Threading;
using System.Media;


namespace The_Aperture_Gift_Shop_Summative
{
    public partial class Form1 : Form
    {
        //Global Variables to store necessary values used many times

        int itemCompanionCube1 = 0;
        int itemTurrets1 = 0;
        int itemPersonalityCores1 = 0;

        double costCompanionCube1 = 10.50;
        double costTurrets1 = 5.50;
        double costPersonalityCores1 = 15.99;

        double calculateCompanion = 0;
        double calculateTurret = 0;
        double calculateCores = 0;

        double subTotal = 0;
        double taxAmount = 0;
        double total = 0;

        double amountTendered = 0;
        double changeOwed = 0;

        //Initates Sounds

        SoundPlayer click = new SoundPlayer(Properties.Resources.buttonClick);
        SoundPlayer print = new SoundPlayer(Properties.Resources.receiptPrint);

        public Form1()
        {
            InitializeComponent();
            //Disables/hides everything that gets revealed overtime

            buttonChange.Enabled = false;
            buttonReceipt.Enabled = false;
            clearButton.Enabled = false;

            clearButton.Visible = false;

          

            receiptLabel.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
        }

        private void inputNumCubes_TextChanged(object sender, EventArgs e)
        {
            //Sees if the input is whole numbers for the amount of cubes
            
            try
            {
                itemCompanionCube1 = Convert.ToInt16(inputNumCubes.Text);
                calculateCompanion = itemCompanionCube1 * costCompanionCube1;
                costCube.Text = calculateCompanion.ToString("C");
                
            }
            catch
            {
                inputNumCubes.Text = " ";
                costCube.Text = "0";
            }
        }

        private void inputNumTurrets_TextChanged(object sender, EventArgs e)
        {
            //Same as above, but for turrets
           
            try
            {
                itemTurrets1 = Convert.ToInt16(inputNumTurrets.Text);
                calculateTurret = itemTurrets1 * costTurrets1;

                costTurrets.Text = calculateTurret.ToString("C");
            }
            catch
            {
                inputNumTurrets.Text = " ";
                costTurrets.Text = "0";
            }
        }

        private void inputNumCores_TextChanged(object sender, EventArgs e)
        {
            //Same as turrets/cubes, but for personality cores
           
            try
            {
                itemPersonalityCores1 = Convert.ToInt16(inputNumCores.Text);
                calculateCores = itemPersonalityCores1 * costPersonalityCores1;

                costPersonalityCores.Text = calculateCores.ToString("C");
            }
            catch
            {
                inputNumCores.Text = " ";
                costPersonalityCores.Text = "0";
            }
        }

        private void calculateTotalsButton_Click(object sender, EventArgs e)
        {
            //Calculates the total and if the value is more than 0, it reveals the other buttons and displays the change button
            
            subTotal = calculateCompanion + calculateCores + calculateTurret;
            click.Play();

            if (subTotal == 0)
            {
                outputSubtotal.Text = "Put a value more than 1 into at least one of the text boxes";
            }
            else
            {
                outputSubtotal.Text = subTotal.ToString("C");

                taxAmount = subTotal * 0.13;
                outputTax.Text = taxAmount.ToString("C");

                total = subTotal + taxAmount;
                outputTotal.Text = total.ToString("C");

                buttonChange.Enabled = true;
                buttonChange.Visible = true;
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {

            //Checks if the amount entered is vaild. Otherwise, it displays how much change is owed and reveals the receipt
            try
            {
                amountTendered = Convert.ToDouble(tenderedInput.Text);
            }
            catch
            {
                tenderedInput.Clear();
            }
          
            click.Play();

            if ((amountTendered - total) < 0)
            {
                outputChange.Text = "ERROR! YOU DO NOT HAVE ENOUGH OR ENTERED A LETTER! TRY AGAIN";
            }
            else
            {
                changeOwed = amountTendered - total;
                outputChange.Text = changeOwed.ToString("C");

                buttonReceipt.Enabled = true;
                buttonReceipt.Visible = true;
            }
        }

        private void buttonReceipt_Click(object sender, EventArgs e)
        {
            //Displays the information provided by the user in the receipt
            
            string tab = "      ";
            receiptLabel.Visible = true;
            
            receiptLabel.Text += $"  Aperture Gift Shop\n";
            receiptLabel.Refresh();

            print.Play();

            receiptLabel.Text += $"\n{tab}Companion Cubes x{itemCompanionCube1} @{costCompanionCube1.ToString("C")}";
            Thread.Sleep(800);
            receiptLabel.Refresh();

            receiptLabel.Text += $"\n{tab}Turrets x{itemTurrets1} @{costCompanionCube1.ToString("C")}";
            Thread.Sleep(800);
            receiptLabel.Refresh();

            receiptLabel.Text += $"\n{tab}Personality Cores x{itemCompanionCube1} @{costPersonalityCores1.ToString("C")}\n";
            Thread.Sleep(800);
            receiptLabel.Refresh();

            receiptLabel.Text += $"\n{tab}Subtotal:{tab}{subTotal.ToString("C")}";
            Thread.Sleep(800);
            receiptLabel.Refresh();

            receiptLabel.Text += $"\n{tab}Tax:{tab}     {taxAmount.ToString("C")}";
            Thread.Sleep(800);
            receiptLabel.Refresh();

            receiptLabel.Text += $"\n{tab}Total:{tab}   {total.ToString("C")}\n";
            Thread.Sleep(800);
            receiptLabel.Refresh();

            receiptLabel.Text += $"\n{tab}Tendered:{tab}{amountTendered.ToString("C")}";
            Thread.Sleep(800);
            receiptLabel.Refresh();

            receiptLabel.Text += $"\n{tab}Change owed:    {changeOwed.ToString("C")}\n";
            Thread.Sleep(800);
            receiptLabel.Refresh();

            receiptLabel.Text += $"\nHave a nice day and remember:\n\nthere is always cake at the end and it is not a lie!";
            Thread.Sleep(800);
            receiptLabel.Refresh();

            clearButton.Visible = true;
            clearButton.Enabled = true;

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clears everything, restarting everything

            receiptLabel.Text = "";
            receiptLabel.Visible = false;

            clearButton.Enabled = false;
            clearButton.Visible = false;

            buttonChange.Visible = false;
            buttonChange.Enabled = false;

            buttonReceipt.Enabled = false;
            buttonReceipt.Visible = false;

            inputNumCores.Clear();
            inputNumTurrets.Clear();
            inputNumCubes.Clear();

            tenderedInput.Clear();

            outputSubtotal.Text = "    ";
            outputSubtotal.BackColor = Color.White;

            outputTax.Text = "    ";
            outputTax.BackColor = Color.White;

            outputTotal.Text = "    ";
            outputTotal.BackColor = Color.White;

            outputChange.Text = "    ";
            outputChange.BackColor = Color.White;

            //Resets Variables to 0

            subTotal = 0;
            taxAmount = 0;
            total = 0;

            itemCompanionCube1 = 0;
            itemPersonalityCores1 = 0;
            itemTurrets1 = 0;

            amountTendered = 0;
            changeOwed = 0;

            calculateCompanion = 0;
            calculateCores = 0;
            calculateTurret = 0;


        }
    }
}
