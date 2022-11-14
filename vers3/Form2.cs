using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vers3
{
   
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }
        
        private void Calculate_Click(object sender, EventArgs e)
        {
            double Square = Convert.ToDouble(SquareNumericUpDown.Value);
            double TariffMajorRepairs = Convert.ToDouble(TariffMajorRepairsNumericUpDown.Value);
            double TariffHeating = Convert.ToDouble(TariffHeatingcNumericUpDown.Value);
            double TariffElectricity = Convert.ToDouble(TariffElectricityNumericUpDown.Value);
            double TariffHotWater = Convert.ToDouble(TariffHotWaterNumericUpDown.Value);
            double TariffColdWater = Convert.ToDouble(TariffColdWaterNumericUpDown.Value); ;
            double IndicationsElectricity = Convert.ToDouble(IndicationsElectricityLabelNumericUpDown.Value);
            double IndicationsHotWater = Convert.ToDouble(IndicationsHotWaterNumericUpDown.Value);
            double IndicationsColdWater = Convert.ToDouble(IndicationsColdWateNumericUpDown.Value);
            Gun gun = new Gun(Square, TariffElectricity,TariffHotWater,TariffColdWater, 
                TariffMajorRepairs,TariffHeating,IndicationsElectricity,IndicationsHotWater,IndicationsColdWater);
            ConclusionTextBox.Text = gun.Print();
        }

        private void SquareNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            ConclusionTextBox.Clear();
            foreach (NumericUpDown up in this.Controls.OfType<NumericUpDown>())
                up.Value = 0;
        }
    }
}
