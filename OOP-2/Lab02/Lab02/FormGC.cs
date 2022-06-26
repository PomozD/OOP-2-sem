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
    public partial class FormGC : Form
    {
        MainForm refMainForm;
        bool diret;

        public FormGC(MainForm mainForm)
        {
            refMainForm = mainForm;
            InitializeComponent();
            buttonOK.Enabled = false;
            textBoxProducer.Tag = false;
            textBoxSeries.Tag = false;
            textBoxModel.Tag = false;
            labelFrequency.Text += " " + trackBarFreq.Value + " ГГц";
            labelMemory.Text += " " + trackBarMemory.Value + " Гб";
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            refMainForm.graphicCard.Producer = textBoxProducer.Text;
            refMainForm.graphicCard.Series = textBoxSeries.Text;
            refMainForm.graphicCard.Model = textBoxModel.Text;
            refMainForm.graphicCard.Frequency = trackBarFreq.Value;
            if (radioButtonYes.Checked) diret = true;
            else diret = false;
            refMainForm.graphicCard.DiretX11 = diret;
            refMainForm.graphicCard.Memory = trackBarMemory.Value;

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
            labelFrequency.Text = "Частота: " + trackBarFreq.Value + " ГГц";
        }

        private void trackBarMemory_Scroll(object sender, EventArgs e)
        {
            labelMemory.Text = "Объем памяти: " + trackBarMemory.Value + " Гб";
        }

        private void textBoxProducer_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBoxModel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
