using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Battletech
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

		private void LightMechRadio_CheckedChanged(object sender, EventArgs e)
		{
			if(!LightMechRadio.Checked)
				return;

			SetMechTonnageRange(20, 35);
		}

		private void MediumMechRadio_CheckedChanged(object sender, EventArgs e)
		{
			if(!MediumMechRadio.Checked)
				return;

			SetMechTonnageRange(40, 55);
		}

		private void HeavyMechRadio_CheckedChanged(object sender, EventArgs e)
		{
			if(!HeavyMechRadio.Checked)
				return;

			SetMechTonnageRange(60, 75);
		}

		private void AssualtMechRadio_CheckedChanged(object sender, EventArgs e)
		{
			if(!AssualtMechRadio.Checked)
				return;

			SetMechTonnageRange(80, 100);
		}

		protected void SetMechTonnageRange(int min, int max)
		{
			MechTonnageUpDown.Enabled = true;
			MechTonnageUpDown.Minimum = min;
			MechTonnageUpDown.Maximum = max;
		}

		private void YearRatingCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			YearRatingGroupBox.Enabled = YearRatingCheckBox.Checked;
		}

		private void FactionCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			FactionGroupBox.Enabled = FactionCheckBox.Checked;
		}
	}
}
