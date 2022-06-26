using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class FormProcessor : Form
    {
        MainForm refMainForm;
        int bit;
        
        public FormProcessor(MainForm mainForm)
        {
            refMainForm = mainForm;
            InitializeComponent();
            buttonOK.Enabled = false;
            textBoxProducer.Tag = false;
            textBoxSeries.Tag = false;
            textBoxModel.Tag = false;
            labelFrequency.Text += " " + trackBarFreq.Value + " ГГц";
            labelMaxFrequency.Text += " " + trackBarMaxFreq.Value + " ГГц";
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            refMainForm.processor.Producer = textBoxProducer.Text;
            refMainForm.processor.Series = textBoxSeries.Text;
            refMainForm.processor.Model = textBoxModel.Text;
            refMainForm.processor.CountOfCores = (int)numericUpDownCores.Value;
            refMainForm.processor.Frequency = trackBarFreq.Value;
            refMainForm.processor.MaxFrequency = trackBarMaxFreq.Value;
            if (radioButton32bit.Checked) bit = int.Parse(radioButton32bit.Text);
            else bit = int.Parse(radioButton64bit.Text);
            refMainForm.processor.BitArchitecture = bit;
            refMainForm.processor.CacheL1 = (int)numericUpDownL1.Value;
            refMainForm.processor.CacheL2 = (int)numericUpDownL2.Value;
            refMainForm.processor.CacheL3 = (int)numericUpDownL3.Value;

            Close();
            refMainForm.Show();
        }

        private void textBoxEmpty_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.Red;
                tb.Tag = false;
            }
            else
            {
                tb.BackColor = SystemColors.Window;
                tb.Tag = true;
            }
            ValidateOK();
        }

        private void ValidateOK()
        {
            buttonOK.Enabled = ((bool)textBoxProducer.Tag &&
                (bool)textBoxSeries.Tag &&
                (bool)textBoxModel.Tag);
        }

        private void trackBarFreq_Scroll(object sender, EventArgs e)
        {
            labelFrequency.Text ="Частота: "+ trackBarFreq.Value + " ГГц";
        }

        private void trackBarMaxFreq_Scroll(object sender, EventArgs e)
        {
            labelMaxFrequency.Text ="Максимальная частота: "+ trackBarMaxFreq.Value + " ГГц";
        }

        private void textBoxProducer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxModel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxSeries_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ')
                e.Handled = true;
        }
    }
}
