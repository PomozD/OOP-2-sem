using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private List<Student> collection;

        private void buttonGenerateCollection_Click(object sender, EventArgs e)
        {
            try
            {
                listViewOne.Clear();
                listViewTwo.Clear();
                if (textBoxSizeOfCollection.Text == "" || textBoxSizeOfCollection.Text == "0")
                {
                    this.collection = null;
                    throw new Exception("Error!\nCollection is empty!");
                }
                else
                {
                    int countOfStudent = int.Parse(textBoxSizeOfCollection.Text);
                    collection = new List<Student>(countOfStudent);
                    Student student;
                    for(int i = 0; i < countOfStudent; i++)
                    {
                        student = new Student();
                        collection.Add(student);
                    }
                    foreach(Student s in collection)
                    {
                        listViewOne.Items.Add($"{s.name}, {s.course} course, {s.group} group;");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonSortAscending_Click(object sender, EventArgs e)
        {
            try
            {
                listViewTwo.Clear();
                if(collection==null || collection.Count == 0)
                {
                    throw new Exception("Error!\nCollection is empty!");
                }
                else
                {
                    collection.Sort();
                    foreach (Student s in collection)
                    {
                        listViewTwo.Items.Add($"{s.name}, {s.course} course, {s.group} group;");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSortDescending_Click(object sender, EventArgs e)
        {
            try
            {
                listViewTwo.Clear();
                if (collection == null || collection.Count == 0)
                {
                    throw new Exception("Error!\nCollection is empty!");
                }
                else
                {
                    collection.Sort();
                    collection.Reverse();
                    foreach (Student s in collection)
                    {
                        listViewTwo.Items.Add($"{s.name}, {s.course} course, {s.group} group;");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonQuery1_Click(object sender, EventArgs e)
        {
            try
            {
                listViewTwo.Clear();
                if (collection == null || collection.Count == 0)
                {
                    throw new Exception("Error!\nCollection is empty!");
                }
                else
                {
                    listViewTwo.Items.Add("Students from 1st course POIT:");
                    var query = collection
                        .Where(p => p.course == 1)
                        .Where(p => p.group >= 4 && p.group <= 6)
                        .Select(p => p);
                    foreach (var s in query)
                    {
                        listViewTwo.Items.Add($"{s.name}, {s.course} course, {s.group} group;");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonQuery2_Click(object sender, EventArgs e)
        {
            try
            {
                listViewTwo.Clear();
                if (collection == null || collection.Count == 0)
                {
                    throw new Exception("Error!\nCollection is empty!");
                }
                else
                {
                    listViewTwo.Items.Add("Students ISiT:");
                    var query = collection
                        .Where(p => p.group >= 1 && p.group <= 3)
                        .Select(p => p);
                    foreach (var s in query)
                    {
                        listViewTwo.Items.Add($"{s.name}, {s.course} course, {s.group} group;");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonQuery3_Click(object sender, EventArgs e)
        {
            try
            {
                listViewTwo.Clear();
                if (collection == null || collection.Count == 0)
                {
                    throw new Exception("Error!\nCollection is empty!");
                }
                else
                {
                    listViewTwo.Items.Add("3 studs, who contain in name 'i':");
                    var query = collection
                        .Where(p => p.name.Contains('i'))
                        .Take(3)
                        .Select(p => p);
                    foreach (var s in query)
                    {
                        listViewTwo.Items.Add($"{s.name}, {s.course} course, {s.group} group;");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}
    }
}
