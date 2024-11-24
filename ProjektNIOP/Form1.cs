using System;
using System.Windows.Forms;

namespace OscillationAndMassApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculatePeriod_Click(object sender, EventArgs e)
        {
            try
            {
                double frequency = Convert.ToDouble(txtFrequency.Text);
                if (frequency <= 0)
                {
                    MessageBox.Show("Frequency must be positive.");
                    return;
                }
                double period = 1 / frequency;
                lblPeriod.Text = $"Oscillation period: {period} s";
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid frequency.");
            }
        }

        private void btnCalculateMass_Click(object sender, EventArgs e)
        {
            try
            {
                double density = Convert.ToDouble(txtDensity.Text);
                double height = Convert.ToDouble(txtHeight.Text);
                double width = Convert.ToDouble(txtWidth.Text);
                double length = Convert.ToDouble(txtLength.Text);

                if (density <= 0 || height <= 0 || width <= 0 || length <= 0)
                {
                    MessageBox.Show("All parameters must be positive.");
                    return;
                }

                double volume = height * width * length;
                double mass = density * volume;
                lblMass.Text = $"Object mass: {mass} kg";
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid data.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFrequency.Clear();
            lblPeriod.Text = "Oscillation period: ";
            txtDensity.Clear();
            txtHeight.Clear();
            txtWidth.Clear();
            txtLength.Clear();
            lblMass.Text = "Object mass: ";
        }

        private void rbtnFrequency_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFrequency.Checked)
            {
                panelFrequency.Visible = true;
                panelMass.Visible = false;
            }
        }

        private void rbtnMass_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnMass.Checked)
            {
                panelFrequency.Visible = false;
                panelMass.Visible = true;
            }
        }
    }
}
