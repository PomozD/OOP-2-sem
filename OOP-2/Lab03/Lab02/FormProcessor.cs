using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            labelFrequency.Text += " " + trackBarFreq.Value + " ГГц";
            labelMaxFrequency.Text += " " + trackBarMaxFreq.Value + " ГГц";
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag = true;
                Regex regP = new Regex(@"[A-ZА-Я]*[a-zа-я]");
                Regex regS = new Regex(@"\w{4}");
                Regex regM = new Regex(@"\w{2}");
                if (!regP.IsMatch(textBoxProducer.Text))
                {
                    epProd.SetError(textBoxProducer, "Неверный формат, строка должна начинаться с заглавной буквы");
                    flag = false;
                }
                else
                    epProd.SetError(textBoxProducer, null);
                if (!regS.IsMatch(textBoxSeries.Text))
                {
                    epSeries.SetError(textBoxSeries, "Неверный формат, строка должна содержать минимум 4 символа");
                    flag = false;
                }
                else
                    epSeries.SetError(textBoxSeries, null);
                if (!regM.IsMatch(textBoxModel.Text))
                {
                    epModel.SetError(textBoxModel, "Неверный формат, строка должна содержать минимум 2 символа");
                    flag = false;
                }
                else
                    epModel.SetError(textBoxModel, null);
                if (flag)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void trackBarFreq_Scroll(object sender, EventArgs e)
        {
            labelFrequency.Text ="Частота: "+ trackBarFreq.Value + " ГГц";
        }

        private void trackBarMaxFreq_Scroll(object sender, EventArgs e)
        {
            labelMaxFrequency.Text ="Максимальная частота: "+ trackBarMaxFreq.Value + " ГГц";
        }

    }
}
