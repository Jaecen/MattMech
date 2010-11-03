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

		private void TonnageCombo_SelectedIndexChanged(object sender, EventArgs e)
		{
			//MessageBox.Show("You selected " + TonnageCombo.SelectedItem.ToString());
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			TonnageCombo.Items.Clear();

			for(int tons = 20; tons <= 150; tons += 5)
				TonnageCombo.Items.Add(tons);
		}
    }
}
