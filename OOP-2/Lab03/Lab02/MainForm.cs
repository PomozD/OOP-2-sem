using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Lab02
{
    public partial class MainForm : Form
    {
        public Computer computer = new Computer();
        public Processor processor = new Processor();
        public GraphicCard graphicCard = new GraphicCard();
        public List<Computer> computers = new List<Computer>();
        public List<Computer> search = new List<Computer>();
        public List<Computer> sortProc = new List<Computer>();
        public List<Computer> sortRAM = new List<Computer>();

        public MainForm()
        {
            InitializeComponent();
            comboBoxRAM.Items.AddRange(Computer.listOfRAM);
            comboBoxHardDrive.Items.AddRange(Computer.listOfHD);
            labelSizeRAM.Text += " " + trackBarSizeRAM.Value + " Гб";
            labelSizeHardDrive.Text += " " + trackBarSizeHardDrive.Value + " Тб";
            comboBoxRAM.Text = comboBoxRAM.Items[0].ToString();
            comboBoxHardDrive.Text = comboBoxHardDrive.Items[0].ToString();
            computer.TypeOfComputer = radioButton1.Text;
            computer.SizeRAM = trackBarSizeRAM.Value;
            computer.SizeHD = trackBarSizeHardDrive.Value;
            computer.TypeOfRAM = comboBoxRAM.Text;
            computer.TypeOfHD = comboBoxHardDrive.Text;
            computer.PurchaseDate = dateTimePicker.Value.ToString("dd-MM-yyyy");
            toolStripContainer1.LeftToolStripPanel.Controls.Add(toolStrip1);
            timer.Start();
        }

        #region Lab02
        private void buttonInfoProcessor_Click(object sender, EventArgs e)
        {
            try
            {
                FormProcessor proc = new FormProcessor(this);
                proc.ShowDialog();
                computer.Processor = processor;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonInfoGraphicsCard_Click(object sender, EventArgs e)
        {
            try
            {
                FormGC gc = new FormGC(this);
                gc.ShowDialog();
                computer.GraphicCard = graphicCard;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxInformation.Text = computer.ShowAllInformation();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"\nВозможно, вы забыли ввести информацию!");
            }
        }

        private void trackBarSizeRAM_Scroll(object sender, EventArgs e)
        {
            labelSizeRAM.Text = "Размер: " + trackBarSizeRAM.Value + " Гб";
            computer.SizeRAM = trackBarSizeRAM.Value;
        }

        private void trackBarSizeHardDrive_Scroll(object sender, EventArgs e)
        {
            labelSizeHardDrive.Text = "Размер: " + trackBarSizeHardDrive.Value + " Тб";
            computer.SizeHD = trackBarSizeHardDrive.Value;
        }

        private void radioButtonTypeOfComputer_Changed(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
                computer.TypeOfComputer = radioButton.Text;
        }

        private void comboBoxRAM_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            computer.TypeOfRAM = comboBox.Text;
        }

        private void comboBoxHardDrive_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            computer.TypeOfHD = comboBox.Text;
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            computer.PurchaseDate = dateTimePicker.Value.ToString("dd-MM-yyyy");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxInformation.Text = "";
        }

        private void buttonSaveXML_Click(object sender, EventArgs e)
        {
            try
            {
                if(computer.GraphicCard == null || computer.Processor == null)
                {
                    throw new Exception("Возможно, вы забыли ввести информацию!");
                }
                computers.Add(computer);
                XmlSerializer formatter = new XmlSerializer(typeof(List<Computer>));
                using (FileStream fs = new FileStream("computers.xml", FileMode.Create))
                {
                    formatter.Serialize(fs, computers);
                }
                textBoxInformation.Text = "";
                computer = new Computer();
                labelSizeRAM.Text = "Размер: " + trackBarSizeRAM.Value + " Гб";
                labelSizeHardDrive.Text = "Размер: " + trackBarSizeHardDrive.Value + " Тб";
                comboBoxRAM.Text = comboBoxRAM.Items[0].ToString();
                comboBoxHardDrive.Text = comboBoxHardDrive.Items[0].ToString();
                computer.TypeOfComputer = radioButton1.Text;
                computer.SizeRAM = trackBarSizeRAM.Value;
                computer.SizeHD = trackBarSizeHardDrive.Value;
                computer.TypeOfRAM = comboBoxRAM.Text;
                computer.TypeOfHD = comboBoxHardDrive.Text;
                computer.PurchaseDate = dateTimePicker.Value.ToString("dd-MM-yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nОшибка сериализации!");
            }
        }

        private void buttonShowXML_Click(object sender, EventArgs e)
        {
            try
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<Computer>));
                using (FileStream fs = new FileStream("computers.xml", FileMode.OpenOrCreate))
                {
                    computers = (List<Computer>)formatter.Deserialize(fs);
                }
                textBoxInformation.Text = "";
                foreach (var comp in computers)
                    textBoxInformation.Text += comp.ShowAllInformation();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"\nОшибка десериализации!");
            }
        }
        #endregion
        
        private void toolStripMenuItemSaveSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (search.Count == 0)
                {
                    throw new Exception("Возможно, результатов поиска не обнаружено!");
                }
                else
                {
                    using (FileStream fs = new FileStream("search.xml", FileMode.Create))
                    {
                        XmlSerializer formatter = new XmlSerializer(typeof(List<Computer>));
                        formatter.Serialize(fs, search);
                    }
                    MessageBox.Show("Результаты поиска сохранены");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nОшибка сериализации!");
            }
        }

        private void toolStripMenuItemSaveSort_Click(object sender, EventArgs e)
        {
            try
            {
                if (sortProc.Count != 0)
                {
                    using (FileStream fs = new FileStream("sortProc.xml", FileMode.Create))
                    {
                        XmlSerializer formatter = new XmlSerializer(typeof(List<Computer>));
                        formatter.Serialize(fs, sortProc);
                    }
                }
                else
                {
                    throw new Exception("Возможно, результатов сортировки по частоте процессора не обнаружено!");
                }
                if (sortRAM.Count != 0)
                {
                    using (FileStream fs = new FileStream("sortRAM.xml", FileMode.Create))
                    {
                        XmlSerializer formatter = new XmlSerializer(typeof(List<Computer>));
                        formatter.Serialize(fs, sortRAM);
                    }
                }
                else
                {
                    throw new Exception("Возможно, результатов сортировки по объему ОЗУ не обнаружено!");
                }
                MessageBox.Show("Результаты сортировки сохранены");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nОшибка сериализации!");
            }
        }

        private void toolStripMenuItemAboutProgramm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Версия 1.0\nРазработчик: Помоз Д.С.", "О программе");
        }

        private void ToolStripMenuItemSort1_Click(object sender, EventArgs e)
        {
            

            sortProc.Clear();
            textBoxInformation.Text = "";
            var result = computers
                .OrderBy(p => p.Processor.Frequency)
                .Select(p => p);
            int i = 1;
            foreach (Computer comp in result)
            {
                textBoxInformation.Text += i+") ";
                sortProc.Add(comp);
                textBoxInformation.Text += comp.ShowShortInfo();
                i++;
            }
        }

        private void ToolStripMenuItemSort2_Click(object sender, EventArgs e)
        {
            sortRAM.Clear();
            textBoxInformation.Text = "";
            var result = computers
                .OrderBy(p => p.SizeRAM)
                .Select(p => p);
            int i = 1;
            foreach (Computer comp in result)
            {
                textBoxInformation.Text += i + ") ";
                sortRAM.Add(comp);
                textBoxInformation.Text += comp.ShowShortInfo();
                i++;
            }
        }

        private void toolStripMenuItemSearch_Click(object sender, EventArgs e)
        {
            FormSearch formSearch = new FormSearch(this);
            formSearch.ShowDialog();
            if(formSearch.result != null)
            {
                search = formSearch.result;
            }
        }

        #region status
        private void button_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Нажмите для ввода дополнительной информации";
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "";
        }

        private void buttonShow_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Вывод текущего объекта";
        }

        private void buttonClear_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Очистить окно вывода";
        }

        private void buttonSaveXML_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Сохранить текущий объект";
        }

        private void buttonShowXML_MouseHover(object sender, EventArgs e)
        {

            toolStripStatusLabel.Text = "Вывод всей информации из файла";

            XmlSerializer formatter = new XmlSerializer(typeof(List<Computer>));
            using (FileStream fs = new FileStream("computers.xml", FileMode.OpenOrCreate))
            {
                computers = (List<Computer>)formatter.Deserialize(fs);
            }


            int i = 1;
            foreach (var comp in computers)
            {
                toolStripStatusCountObjects.Text = "Количество объектов: ";
                toolStripStatusCountObjects.Text += i;
                i++;
                /*var lastitem = computers.Last();
                toolStripStatusCountObjects.Text = lastitem.ToString();*/
            }
        }
        #endregion

        
        private void timer_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void toolStripButtonSort_Click(object sender, EventArgs e)
        {

        }

        private void CountOfObjects(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Computer>));
            using (FileStream fs = new FileStream("computers.xml", FileMode.OpenOrCreate))
            {
                computers = (List<Computer>)formatter.Deserialize(fs);
            }


            int i = 1;
            foreach (var comp in computers)
            {
                toolStripStatusCountObjects.Text += i + ")" + comp.TypeOfComputer + "\n";
                i++;
            }


        }
    }
}
