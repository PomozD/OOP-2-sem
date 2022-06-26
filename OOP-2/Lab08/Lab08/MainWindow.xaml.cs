using Microsoft.Win32;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace Lab08
{
    public partial class MainWindow : Window
    {
        public static string str;
        public static string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        SqlConnection connection;       // для создания канала связи между программой и источником данных 
        SqlCommand command;
        SqlDataAdapter adapter1;        // для заполнения DataSet (образ бд) и обновления БД 
        SqlDataAdapter adapter2;
        DataTable dataComp;             // таблица бд
        DataTable dataProc;
        public string Image;
        public MainWindow()
        {
            InitializeComponent();
            string sqlExpression = "Count_proc";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                Stored_Procedurelabel.Content = "Количество процессоров: " + command.ExecuteScalar().ToString();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                string sqlExpression = "SELECT * FROM Computer";
                dataComp = new DataTable();
                command = new SqlCommand(sqlExpression, connection);
                adapter1 = new SqlDataAdapter(command);
                adapter1.Fill(dataComp);
                dataGridComp.ItemsSource = dataComp.DefaultView;

                string sqlExpression2 = "SELECT * FROM Processor";
                dataProc = new DataTable();
                command = new SqlCommand(sqlExpression2, connection);
                adapter2 = new SqlDataAdapter(command);
                adapter2.Fill(dataProc);
                dataGridProc.ItemsSource = dataProc.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                connection.Close();
            }
        }

        private void UpdateDB()
        {
            SqlCommandBuilder comandbuilder = new SqlCommandBuilder(adapter1);  // автоматич генер-т команды, кот позволяют согласовать изменения, 
            SqlCommandBuilder comandbuilder2 = new SqlCommandBuilder(adapter2); // вносимые в объект dataset, со связанной бд
            adapter1.Update(dataComp);
            adapter2.Update(dataProc);
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            UpdateDB();
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridComp.SelectedItems != null)
            {
                for (int i = 0; i < dataGridComp.SelectedItems.Count; i++)
                {
                    DataRowView datarowView = dataGridComp.SelectedItems[i] as DataRowView;
                    if (datarowView != null)
                    {
                        DataRow dataRow = (DataRow)datarowView.Row;
                        dataRow.Delete();
                    }
                }
            }
            if (dataGridProc.SelectedItems != null)
            {
                for (int i = 0; i < dataGridProc.SelectedItems.Count; i++)
                {
                    DataRowView datarowView = dataGridProc.SelectedItems[i] as DataRowView;
                    if (datarowView != null)
                    {
                        DataRow dataRow = (DataRow)datarowView.Row;
                        dataRow.Delete();
                    }
                }
            }
            UpdateDB();
        }

        private void Script_Click(object sender, RoutedEventArgs e)
        {
            SqlTransaction tx = null;
            try
            {
                if (script != "")
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(script, connection);
                        tx = connection.BeginTransaction();
                        command.Transaction = tx; //Чтобы все операции над объектом SQLCommand выполнялись как одна транзакция, присваиваем объект транзакции его свойству Transaction
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows) // проверяем есть ли данные
                        {
                            str = $"{reader.GetName(1)}\t{reader.GetName(2)}\t{reader.GetName(3)}\t\n"; // запись в строку названий столбцов

                            while (reader.Read()) // считываем данные
                            {
                                object type = reader.GetValue(1);
                                object processor = reader.GetValue(2);
                                object size = reader.GetValue(3);
                                str += $"{type}\t{processor}\t\t{size}\t\n";
                            }
                        }
                        MessageBox.Show(str);
                        reader.Close();

                        tx.Commit(); // Завершение всех операций после их выполнения
                    }
                    MessageBox.Show("Скрипт выполнен");
                }
                else
                {
                    MessageBox.Show("enter script!");
                }
                Window_Loaded(new object(), new RoutedEventArgs());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                //tx.Rollback(); // Если произошла ошибка, то откатываем транзакцию
            }
        }
        
        string script = "";
        private void TxtScript_TextChanged(object sender, TextChangedEventArgs e)
        {
            script = Script.Text;
        }

        private void BtnAddPhotoToComputers_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                var dialog = new OpenFileDialog();
                dialog.ShowDialog();
                Image = dialog.FileName;



            }
            catch
            {
                MessageBox.Show("Выберите корректную фотографию");
            }


        }


        private void AddData_Click(object sender, RoutedEventArgs e)
        {
            SqlTransaction tx = null;
            try
            {

            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                    tx = connection.BeginTransaction();
                    var addComputerCommand = string.Format($"INSERT INTO Computer VALUES(@Type, @ProcessorID, @SizeRAM, @TypeRAM, @SizeHD, @TypeHD, @Image)");

                using (SqlCommand command = new SqlCommand(addComputerCommand, connection))
                {
                    command.Transaction = transaction;

                    command.Parameters.AddWithValue("@Type", Type.Text);
                    command.Parameters.AddWithValue("@ProcessorID", ProcessorIDTextBox.Text);
                    command.Parameters.AddWithValue("@SizeRAM", SizeRAM.Text);
                    command.Parameters.AddWithValue("@TypeRAM", TypeRAM.Text);
                    command.Parameters.AddWithValue("@SizeHD", SizeHD.Text);
                    command.Parameters.AddWithValue("@TypeHD", TypeHD.Text);


                    byte[] imageData;
                    string shortFileName = this.Image.Substring(Image.LastIndexOf('\\') + 1);
                    using (System.IO.FileStream fs = new System.IO.FileStream(Image, FileMode.Open))
                    {
                        imageData = new byte[fs.Length];
                        fs.Read(imageData, 0, imageData.Length);
                    }
                    command.Parameters.AddWithValue("@Image", imageData);

                    command.ExecuteNonQuery();


                    command.CommandText = "INSERT INTO Processor(Producer,Model,CountOfCores) VALUES ('" + Producer.Text + "', '" + Model.Text + "', '" + Countofcores.Text + "')";
                    command.ExecuteNonQuery();
                    tx.Commit();
                    MessageBox.Show("Данные добавлены");
                }
            }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dorequest_Click(object sender, RoutedEventArgs e)
        {
            datagrid.Columns.Clear();
            if (Request1.IsChecked == true)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string req1 = "select Type , SizeRAM , TypeRAM from Computer";
                    dataComp = new DataTable();
                    command = new SqlCommand(req1, connection);
                    adapter1 = new SqlDataAdapter(command);
                    adapter1.Fill(dataComp);
                    datagrid.ItemsSource = dataComp.DefaultView;

                }
            }
            if (Request2.IsChecked == true)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    string req2 = "select Producer, Model, CountOfCores from Processor";
                    dataComp = new DataTable();
                    command = new SqlCommand(req2, connection);
                    adapter1 = new SqlDataAdapter(command);
                    adapter1.Fill(dataComp);
                    datagrid.ItemsSource = dataComp.DefaultView;

                }
            }
            if (Request3.IsChecked == true)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    string req3 = "select  Type, SizeRAM, SizeHD, TypeHD from Computer";
                    dataComp = new DataTable();
                    command = new SqlCommand(req3, connection);
                    adapter1 = new SqlDataAdapter(command);
                    adapter1.Fill(dataComp);
                    datagrid.ItemsSource = dataComp.DefaultView;

                }
            }
        }
    }
        }
    

