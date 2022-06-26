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
    public partial class FormSearch : Form
    {
        public List<Computer> result = new List<Computer>();
        public MainForm data;
        public string prod;
        public string model;

        public FormSearch(MainForm computers)
        {
            InitializeComponent();
            data = computers;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (checkBoxProd.Checked && checkBoxModel.Checked)
            {
                prod = textBoxProd.Text;
                model = textBoxModel.Text;
                if (prod == "")
                    textBoxProd.BackColor = Color.Tomato;
                else
                    textBoxProd.BackColor = Color.White;
                if (model == "")
                    textBoxModel.BackColor = Color.Tomato;
                else
                {
                    textBoxModel.BackColor = Color.White;
                    Search(prod, model);
                }
            }
            else if (checkBoxProd.Checked)
            {
                textBoxModel.Text = "";
                prod = textBoxProd.Text;
                if (prod == "")
                    textBoxProd.BackColor = Color.Tomato;
                else
                {
                    textBoxProd.BackColor = Color.White;
                    Search(prod, null);
                }
            }
            else if (checkBoxModel.Checked)
            {
                textBoxProd.Text = "";
                model = textBoxModel.Text;
                if (model == "")
                    textBoxModel.BackColor = Color.Tomato;
                else
                {
                    textBoxModel.BackColor = Color.White;
                    Search(null, model);
                }
            }
            else
            {
                MessageBox.Show("Выберите категорию поиска!");
            }

        }

        private void Search(string prod, string model)
        {
            result.Clear();
            dataGridViewSearch.Rows.Clear();
            if (prod == null)
            {
                char m = model[0];
                Regex regex = new Regex(@""+m+ @"\w*", RegexOptions.IgnoreCase);
                for (int i = 0; i < data.computers.Count(); i++)
                {
                    Match match = regex.Match(data.computers[i].Processor.Model);
                    if (match.Success)
                    {
                        result.Add(data.computers[i]);
                        Fill(data.computers[i]);
                    }
                }
            }
            else if(model == null)
            {
                char pr = prod[0];
                Regex regex = new Regex(@"" + pr + @"\w*", RegexOptions.IgnoreCase);
                for (int i = 0; i < data.computers.Count(); i++)
                {
                    Match match = regex.Match(data.computers[i].Processor.Producer);
                    if (match.Success)
                    {
                        result.Add(data.computers[i]);
                        Fill(data.computers[i]);
                    }
                }
            }
            else
            {
                char pr = prod[0];
                char m = model[0];
                Regex regexP = new Regex(@"" + pr + @"\w*", RegexOptions.IgnoreCase);
                Regex regexM = new Regex(@"" + m + @"\w*", RegexOptions.IgnoreCase);
                for (int i = 0; i < data.computers.Count(); i++)
                {
                    Match matchP = regexP.Match(data.computers[i].Processor.Producer);
                    Match matchM = regexM.Match(data.computers[i].Processor.Model);
                    if (matchP.Success && matchM.Success)
                    {
                        result.Add(data.computers[i]);
                        Fill(data.computers[i]);
                    }
                }
            }
            
        }
        private void Fill(Computer computer)
        {
            DataGridViewCell type = new DataGridViewTextBoxCell();
            DataGridViewCell prodProc = new DataGridViewTextBoxCell();
            DataGridViewCell modelProc = new DataGridViewTextBoxCell();
            DataGridViewCell freq = new DataGridViewTextBoxCell();
            DataGridViewCell gc = new DataGridViewTextBoxCell();
            DataGridViewCell cost = new DataGridViewTextBoxCell();

            type.Value = computer.TypeOfComputer;
            prodProc.Value = computer.Processor.Producer;
            modelProc.Value = computer.Processor.Model;
            freq.Value = computer.Processor.Frequency;
            gc.Value = computer.GraphicCard.Producer + ", " + computer.GraphicCard.Model;
            cost.Value = computer.Cost;

            DataGridViewRow row = new DataGridViewRow();
            row.Cells.AddRange(type,prodProc,modelProc,freq,gc,cost);
            dataGridViewSearch.Rows.Add(row);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Close();
            data.Show();
        }

        private void textBoxProd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
