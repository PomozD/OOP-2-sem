using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Lab02
{
    public partial class MainForm : Form
    {
        public Computer computer = new Computer();
        public Processor processor = new Processor();
        public GraphicCard graphicCard = new GraphicCard();
        public List<Computer> computers = new List<Computer>();

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
        }
        
        private void buttonInfoProcessor_Click(object sender, EventArgs e)
        {
            try
            {
                FormProcessor proc = new FormProcessor(this);
                proc.ShowDialog();
                computer.Processor = processor;
            }
            catch(Exception ex)
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
            if (dateTimePicker.Value >= DateTime.Now)
            {
                MessageBox.Show("Вы ввели некорректиную дату");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxInformation.Text = "";
        }

        private void buttonSaveXML_Click(object sender, EventArgs e)
        {
            try
            {
                computers.Add(computer);
                XmlSerializer formatter = new XmlSerializer(typeof(List<Computer>)); // передаем в конструктор тип класса computer
                using (FileStream fs = new FileStream("computers.xml", FileMode.Create)) // получаем поток, куда записывается сериализованный объект
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
                XmlSerializer formatter = new XmlSerializer(typeof(List<Computer>)); // передаем в конструктор тип класса computer
                using (FileStream fs = new FileStream("computers.xml", FileMode.OpenOrCreate)) // получаем поток, откуда записывается сериализованный объект
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
        
    }
}
