using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            labelFrequency.Text += " " + trackBarFreq.Value + " ГГц";
            labelMemory.Text += " " + trackBarMemory.Value + " Гб";
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void trackBarFreq_Scroll(object sender, EventArgs e)
        {
            labelFrequency.Text = "Частота: " + trackBarFreq.Value + " ГГц";
        }

        private void trackBarMemory_Scroll(object sender, EventArgs e)
        {
            labelMemory.Text = "Объем памяти: " + trackBarMemory.Value + " Гб";
        }
    }
}
