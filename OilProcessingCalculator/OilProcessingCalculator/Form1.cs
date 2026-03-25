using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OilProcessingCalculator
{
    public partial class Form1 : Form
    {
        int input = 0;
        int crackedOil = 0;
        int heavyOil = 0;
        int lightOil = 0;
        int petroleumGas = 0;
        int naphtha = 0;
        int sulfur = 0;
        int aromaticHydrocarbons = 0;
        int unsaturatedHydrocarbons = 0;
        int crackedNaphtha = 0;
        int crackedLightOil = 0;
        int petroleumGasCracked = 0;
        int crackOilTar = 0;
        int desulfurizedLightOil = 0;
        int desulfurizedNaphtha = 0;
        int heavyOilDesulfurized = 0;
        int unsaturatedHydrocarbonsDesulfurized = 0;
        int parrafinWax = 0;
        int desulfurizedOil = 0;
        int sourGas = 0;
        int desulfurizedCrackedOil = 0;
        int desulfurizedLightOilCrack = 0;
        int desulfurizedNaphthaCrack = 0;
        int aromaticHydrocarbonsDesCrack = 0;
        int unsaturatedHydrocarbonsDesCrack = 0;
        int paraffinWaxDesCrack = 0;
        int petroleumGasDesCrack = 0;
        int vacuumLightOil = 0;
        int vacuumHeavyOil = 0;
        int reformate = 0;
        int sourGasVacuum = 0;
        int vacuumLightOilDes = 0;
        int vacuumHeavyOilDes = 0;
        int reformateDes = 0;
        int reformateGas = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oil Processing Calculator by ADtsd.\nVersion 1\n \"Now with more math than ever!™\"", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Calculate()
        {
            heavyOil = input / 1000 * 500;
            naphtha = input / 1000 * 250;
            lightOil = input / 1000 * 150;
            petroleumGas = input / 1000 * 100;
            sulfur = input / 1000;

            crackedOil = input / 100 * 80;
            petroleumGasCracked = input / 100 * 20;
            crackedNaphtha = crackedOil / 1000 * 400;
            crackedLightOil = crackedOil / 1000 * 300;
            aromaticHydrocarbons = crackedOil / 1000 * 150;
            unsaturatedHydrocarbons = crackedOil / 1000 * 150;
            crackOilTar = crackedOil / 1000;

            desulfurizedOil = input / 1000 * 900;
            sourGas = input / 1000 * 150;
            desulfurizedLightOil = desulfurizedOil / 1000 * 200;
            desulfurizedNaphtha = desulfurizedOil / 1000 * 350;
            heavyOilDesulfurized = desulfurizedOil / 1000 * 300;
            unsaturatedHydrocarbonsDesulfurized = desulfurizedOil / 1000 * 150;
            parrafinWax = desulfurizedOil / 1000;

            desulfurizedCrackedOil = desulfurizedOil / 100 * 80;
            petroleumGasDesCrack = desulfurizedOil / 100 * 20;
            desulfurizedNaphthaCrack = desulfurizedOil / 1000 * 350;
            desulfurizedLightOilCrack = desulfurizedOil / 1000 * 350;
            aromaticHydrocarbonsDesCrack = desulfurizedOil / 1000 * 150;
            unsaturatedHydrocarbonsDesCrack = desulfurizedOil / 1000 * 150;
            paraffinWaxDesCrack = desulfurizedOil / 1000;

            vacuumHeavyOil = input / 1000 * 400;
            vacuumLightOil = input / 1000 * 200;
            reformate = input / 1000 * 250;
            sourGasVacuum = input / 1000 * 150;

            vacuumHeavyOilDes = desulfurizedOil / 1000 * 400;
            vacuumLightOilDes = desulfurizedOil / 1000 * 200;
            reformateDes = desulfurizedOil / 1000 * 250;
            reformateGas = desulfurizedOil / 1000 * 150;

            applyChanges();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                input = Convert.ToInt32(inputNumber.Text.ToString());
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input, dummy!\nOh and, its a FormatException. If it appears when the number is valid, something is wrong with my code...", "Stop being an idiot trying to break things...");
            }
            catch (OverflowException)
            {
                MessageBox.Show("The number is too big for an int32. Why would you even need to process more than 2 milibuckets of crude oil, anyways?!", "What the hell?!");
            }
            finally
            {
                Calculate();
            }
        }
        private void applyChanges()
        {
            heavyOilValue.Text = Convert.ToString(heavyOil);
            naphthaValue.Text = Convert.ToString(naphtha);
            lightOilValue.Text = Convert.ToString(lightOil);
            petroleumGasValue.Text = Convert.ToString(petroleumGas);
            sulfurValue.Text = Convert.ToString(sulfur);

            crackedNaphthaValue.Text = Convert.ToString(crackedNaphtha);
            crackedLightOilValue.Text = Convert.ToString(crackedLightOil);
            aromaticHydrocarbonsValue.Text = Convert.ToString(aromaticHydrocarbons);
            unsaturatedHydrocarbonsValue.Text = Convert.ToString(unsaturatedHydrocarbons);
            crackOilTarValue.Text = Convert.ToString(crackOilTar);
            petroleumGasCrackedValue.Text = Convert.ToString(petroleumGasCracked);
            crackedOilValue.Text = Convert.ToString(crackedOil);

            heavyOilDesulfurizedValue.Text = Convert.ToString(heavyOilDesulfurized);
            desulfurizedLightOilValue.Text = Convert.ToString(desulfurizedLightOil);
            desulfurizedNaphthaValue.Text = Convert.ToString(desulfurizedNaphtha);
            parrafinWaxValue.Text = Convert.ToString(parrafinWax);
            unsaturatedHydrocarbonsDesulfurizedValue.Text = Convert.ToString(unsaturatedHydrocarbonsDesulfurized);
            desulfurizedOilValue.Text = Convert.ToString(desulfurizedOil);
            sourGasValue.Text = Convert.ToString(sourGas);

            desulfurizedNaphthaCrackValue.Text = Convert.ToString(desulfurizedNaphthaCrack);
            desulfurizedLightOilCrackValue.Text = Convert.ToString(desulfurizedLightOilCrack);
            aromaticHydrocarbonsDesCrackValue.Text = Convert.ToString(aromaticHydrocarbonsDesCrack);
            unsaturatedHydrocarbonsDesCrackValue.Text = Convert.ToString(unsaturatedHydrocarbonsDesCrack);
            paraffinWaxDesCrackValue.Text = Convert.ToString(paraffinWaxDesCrack);
            desulfurizedCrackedOilValue.Text = Convert.ToString(desulfurizedCrackedOil);
            petroleumGasDesCrackValue.Text = Convert.ToString(petroleumGasDesCrack);

            vacuumHeavyOilValue.Text = Convert.ToString(vacuumHeavyOil);
            vacuumLightOilValue.Text = Convert.ToString(vacuumLightOil);
            reformateValue.Text = Convert.ToString(reformate);
            sourGasVacuumValue.Text = Convert.ToString(sourGasVacuum);

            vacuumHeavyOilDesValue.Text = Convert.ToString(vacuumHeavyOilDes);
            vacuumLightOilDesValue.Text = Convert.ToString(vacuumLightOilDes);
            reformateDesValue.Text = Convert.ToString(reformateDes);
            reformateGasValue.Text = Convert.ToString(reformateGas);
        }

        private void label26_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Okay, you know what I HATE? \"Sour Gas\", is NOT actually sour whatsoever. Like what the hell is this false advertisement?!", "What the hell?! (secret)");
        }
    }
}
