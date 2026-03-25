using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CoalOilCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int input = 0;
        int CTC = 0;
        int CoalOil = 0;
        int Bitumen = 0;
        int CrudeOil = 0;
        int CoalGasoline = 0;
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coal Oil Calculator by ADtsd.\nVersion 2", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void toggleValue(String name)
        {
            switch (name)
            {
                case "coalDust":
                    coalDustOption.Checked = true;
                    coalBricketOption.Checked = false;
                    infernalDustOption.Checked = false;
                    infernalBricketOption.Checked = false;
                    ligniteDustOption.Checked = false;
                    ligniteBricketOption.Checked = false;
                    break;
                case "coalBricket":
                    coalDustOption.Checked = false;
                    coalBricketOption.Checked = true;
                    infernalDustOption.Checked = false;
                    infernalBricketOption.Checked = false;
                    ligniteDustOption.Checked = false;
                    ligniteBricketOption.Checked = false;
                    break;
                case "infernalDust":
                    coalDustOption.Checked = false;
                    coalBricketOption.Checked = false;
                    infernalDustOption.Checked = true;
                    infernalBricketOption.Checked = false;
                    ligniteDustOption.Checked = false;
                    ligniteBricketOption.Checked = false;
                    break;
                case "infernalBricket":
                    coalDustOption.Checked = false;
                    coalBricketOption.Checked = false;
                    infernalDustOption.Checked = false;
                    infernalBricketOption.Checked = true;
                    ligniteDustOption.Checked = false;
                    ligniteBricketOption.Checked = false;
                    break;
                case "ligniteDust":
                    coalDustOption.Checked = false;
                    coalBricketOption.Checked = false;
                    infernalDustOption.Checked = false;
                    infernalBricketOption.Checked = false;
                    ligniteDustOption.Checked = true;
                    ligniteBricketOption.Checked = false;
                    break;
                case "ligniteBricket":
                    coalDustOption.Checked = false;
                    coalBricketOption.Checked = false;
                    infernalDustOption.Checked = false;
                    infernalBricketOption.Checked = false;
                    ligniteDustOption.Checked = false;
                    ligniteBricketOption.Checked = true;
                    break;
                case "combinationOven":
                    combinationOvenOption.Checked = true;
                    liquefactionOption.Checked = false;
                    break;
                case "liquefactionMachine":
                    combinationOvenOption.Checked = false;
                    liquefactionOption.Checked = true;
                    break;
                default:
                    MessageBox.Show("I don't think this is supposed to happen.", "What???");
                    break;
            }
        }

        private void dustToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toggleValue("coalDust");
        }

        private void bricketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toggleValue("coalBricket");
        }

        private void infernalDustToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toggleValue("infernalDust");
        }

        private void infernalBricketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toggleValue("infernalBricket");
        }

        private void dustGemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toggleValue("ligniteDust");
        }

        private void bricketToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toggleValue("ligniteBricket");
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                input = Convert.ToInt32(inputNumber.Text.ToString());
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input, dummy!\nOh and, its a FormatException. If it appears when the number is valid, something is wrong with my code...", "Stop being an idiot trying to break things...");
                // MessageBox.Show(Convert.ToString(input)); - helped me realize that I need to use inputNumber.Text.ToString(), not just inputNumber.ToString(). the real VIP of this project huh?
            }
            catch (OverflowException)
            {
                MessageBox.Show("The number is too big for an int32. Why would you even need to process more than 2 billion coal, anyways?!", "What the hell?!");
            }
            finally
            {
                Calculate();
            }
        }

        private void inputNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void combinationOvenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toggleValue("combinationOven");
        }

        private void iLiquefactionMachineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toggleValue("liquefactionMachine");
        }
        private void Calculate()
        {
            CTC = 0;
            CoalOil = 0;
            Bitumen = 0;
            CrudeOil = 0;
            if (liquefactionOption.Checked == true)
            {
                if (coalDustOption.Checked == true)
                {
                    CoalOil = input * 100;
                }
                else if (ligniteDustOption.Checked == true)
                {
                    CoalOil = input * 50;
                }
                else if (infernalDustOption.Checked == true)
                {
                    CoalOil = input * 200;
                }
                else
                {
                    MessageBox.Show("You either chose no input options or you chose the bricket options which are not compatible with liquefaction.", "Just so you know...");
                }
                CoalGasoline = CoalOil / 100 * 30;
                CrudeOil = CoalOil / 100 * 70;
            }
            else if (combinationOvenOption.Checked == true)
            {
                if (coalDustOption.Checked == true)
                {
                    CTC = input * 100;
                }
                else if (coalBricketOption.Checked == true)
                {
                    CTC = input * 150;
                }
                else if (infernalDustOption.Checked == true)
                {
                    CTC = input * 200;
                }
                else if (infernalBricketOption.Checked == true)
                {
                    CTC = input * 300;
                }
                else if (ligniteDustOption.Checked == true)
                {
                    CTC = input * 50;
                }
                else if (ligniteBricketOption.Checked == true)
                {
                    CTC = input * 100;
                }
                else
                {
                    MessageBox.Show("Hey, uh, did you make sure you actually SELECTED a damn input option?", "Just asking 'ya");
                }
                CoalOil = CTC / 100 * 10;
                Bitumen = CTC / 100 * 90;
                CoalGasoline = CoalOil / 100 * 30;
                CrudeOil = CoalOil / 100 * 70;
            }
            else
            {
                MessageBox.Show("I am pretty sure you don't have any processing options selected.", "It's true, though!");
            }
            UpdateValues();
        }
        private void UpdateValues()
        {
            CTCValue.Text = Convert.ToString(CTC);
            CoalOilValue.Text = Convert.ToString(CoalOil);
            BitumenValue.Text = Convert.ToString(Bitumen);
            CrudeOilValue.Text = Convert.ToString(CrudeOil);
            CoalGasolineValue.Text = Convert.ToString(CoalGasoline);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
