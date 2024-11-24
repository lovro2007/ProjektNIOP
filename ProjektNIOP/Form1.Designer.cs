using System;
using System.Windows.Forms;

namespace OscillationAndMassApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.rbtnFrequency = new System.Windows.Forms.RadioButton();
            this.rbtnMass = new System.Windows.Forms.RadioButton();
            this.panelFrequency = new System.Windows.Forms.Panel();
            this.txtFrequency = new System.Windows.Forms.TextBox();
            this.btnCalculatePeriod = new System.Windows.Forms.Button();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.panelMass = new System.Windows.Forms.Panel();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtDensity = new System.Windows.Forms.TextBox();
            this.btnCalculateMass = new System.Windows.Forms.Button();
            this.lblMass = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.panelFrequency.SuspendLayout();
            this.panelMass.SuspendLayout();
            this.SuspendLayout();
            this.rbtnFrequency.AutoSize = true;
            this.rbtnFrequency.Location = new System.Drawing.Point(12, 12);
            this.rbtnFrequency.Name = "rbtnFrequency";
            this.rbtnFrequency.Size = new System.Drawing.Size(95, 17);
            this.rbtnFrequency.TabIndex = 0;
            this.rbtnFrequency.TabStop = true;
            this.rbtnFrequency.Text = "Frequency/Period";
            this.rbtnFrequency.UseVisualStyleBackColor = true;
            this.rbtnFrequency.CheckedChanged += new System.EventHandler(this.rbtnFrequency_CheckedChanged);
            this.rbtnMass.AutoSize = true;
            this.rbtnMass.Location = new System.Drawing.Point(12, 35);
            this.rbtnMass.Name = "rbtnMass";
            this.rbtnMass.Size = new System.Drawing.Size(77, 17);
            this.rbtnMass.TabIndex = 1;
            this.rbtnMass.TabStop = true;
            this.rbtnMass.Text = "Mass of the object";
            this.rbtnMass.UseVisualStyleBackColor = true;
            this.rbtnMass.CheckedChanged += new System.EventHandler(this.rbtnMass_CheckedChanged);
            this.panelFrequency.Controls.Add(this.txtFrequency);
            this.panelFrequency.Controls.Add(this.btnCalculatePeriod);
            this.panelFrequency.Controls.Add(this.lblPeriod);
            this.panelFrequency.Location = new System.Drawing.Point(12, 58);
            this.panelFrequency.Name = "panelFrequency";
            this.panelFrequency.Size = new System.Drawing.Size(300, 100);
            this.panelFrequency.TabIndex = 2;
            this.panelFrequency.Visible = false;
            this.txtFrequency.Location = new System.Drawing.Point(3, 15);
            this.txtFrequency.Name = "txtFrequency";
            this.txtFrequency.Size = new System.Drawing.Size(100, 20);
            this.txtFrequency.TabIndex = 0;
            this.txtFrequency.Text = "Enter frequency";
            this.txtFrequency.ForeColor = System.Drawing.Color.Gray;
            this.txtFrequency.Enter += new System.EventHandler(this.txt_Enter);
            this.txtFrequency.Leave += new System.EventHandler(this.txt_Leave);
            this.btnCalculatePeriod.Location = new System.Drawing.Point(3, 41);
            this.btnCalculatePeriod.Name = "btnCalculatePeriod";
            this.btnCalculatePeriod.Size = new System.Drawing.Size(75, 23);
            this.btnCalculatePeriod.TabIndex = 1;
            this.btnCalculatePeriod.Text = "Calculate";
            this.btnCalculatePeriod.UseVisualStyleBackColor = true;
            this.btnCalculatePeriod.Click += new System.EventHandler(this.btnCalculatePeriod_Click);
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(3, 67);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(95, 13);
            this.lblPeriod.TabIndex = 2;
            this.lblPeriod.Text = "Oscillation period: ";
            this.panelMass.Controls.Add(this.txtLength);
            this.panelMass.Controls.Add(this.txtWidth);
            this.panelMass.Controls.Add(this.txtHeight);
            this.panelMass.Controls.Add(this.txtDensity);
            this.panelMass.Controls.Add(this.btnCalculateMass);
            this.panelMass.Controls.Add(this.lblMass);
            this.panelMass.Location = new System.Drawing.Point(12, 58);
            this.panelMass.Name = "panelMass";
            this.panelMass.Size = new System.Drawing.Size(300, 150);
            this.panelMass.TabIndex = 3;
            this.panelMass.Visible = false;
            this.txtLength.Location = new System.Drawing.Point(3, 15);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 0;
            this.txtLength.Text = "Enter length";
            this.txtLength.ForeColor = System.Drawing.Color.Gray;
            this.txtLength.Enter += new System.EventHandler(this.txt_Enter);
            this.txtLength.Leave += new System.EventHandler(this.txt_Leave);
            this.txtWidth.Location = new System.Drawing.Point(109, 15);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 1;
            this.txtWidth.Text = "Enter width";
            this.txtWidth.ForeColor = System.Drawing.Color.Gray;
            this.txtWidth.Enter += new System.EventHandler(this.txt_Enter);
            this.txtWidth.Leave += new System.EventHandler(this.txt_Leave);
            this.txtHeight.Location = new System.Drawing.Point(215, 15);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 2;
            this.txtHeight.Text = "Enter height";
            this.txtHeight.ForeColor = System.Drawing.Color.Gray;
            this.txtHeight.Enter += new System.EventHandler(this.txt_Enter);
            this.txtHeight.Leave += new System.EventHandler(this.txt_Leave);
            this.txtDensity.Location = new System.Drawing.Point(3, 41);
            this.txtDensity.Name = "txtDensity";
            this.txtDensity.Size = new System.Drawing.Size(100, 20);
            this.txtDensity.TabIndex = 3;
            this.txtDensity.Text = "Enter density";
            this.txtDensity.ForeColor = System.Drawing.Color.Gray;
            this.txtDensity.Enter += new System.EventHandler(this.txt_Enter);
            this.txtDensity.Leave += new System.EventHandler(this.txt_Leave);
            this.btnCalculateMass.Location = new System.Drawing.Point(3, 67);
            this.btnCalculateMass.Name = "btnCalculateMass";
            this.btnCalculateMass.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateMass.TabIndex = 4;
            this.btnCalculateMass.Text = "Calculate";
            this.btnCalculateMass.UseVisualStyleBackColor = true;
            this.btnCalculateMass.Click += new System.EventHandler(this.btnCalculateMass_Click);
            this.lblMass.AutoSize = true;
            this.lblMass.Location = new System.Drawing.Point(3, 93);
            this.lblMass.Name = "lblMass";
            this.lblMass.Size = new System.Drawing.Size(67, 13);
            this.lblMass.TabIndex = 5;
            this.lblMass.Text = "Mass of the object: ";
            this.btnReset.Location = new System.Drawing.Point(12, 220);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.panelFrequency);
            this.Controls.Add(this.panelMass);
            this.Controls.Add(this.rbtnMass);
            this.Controls.Add(this.rbtnFrequency);
            this.Name = "Form1";
            this.Text = "Oscillation and Mass";
            this.panelFrequency.ResumeLayout(false);
            this.panelFrequency.PerformLayout();
            this.panelMass.ResumeLayout(false);
            this.panelMass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private void txt_Enter(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            if (textBox.ForeColor == System.Drawing.Color.Gray)
            {
                textBox.Text = "";
                textBox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.ForeColor = System.Drawing.Color.Gray;
                textBox.Text = "Enter ...";
            }
        }

        private System.Windows.Forms.RadioButton rbtnFrequency;
        private System.Windows.Forms.RadioButton rbtnMass;
        private System.Windows.Forms.Panel panelFrequency;
        private System.Windows.Forms.TextBox txtFrequency;
        private System.Windows.Forms.Button btnCalculatePeriod;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Panel panelMass;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtDensity;
        private System.Windows.Forms.Button btnCalculateMass;
        private System.Windows.Forms.Label lblMass;
        private System.Windows.Forms.Button btnReset;

    }
}
