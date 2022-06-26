using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab07
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : UserControl
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void LogIn1_Click(object sender, MouseButtonEventArgs e) // bubbling (поднимающиеся)
        {
            Event2.Text = "";
            Event3.Text = "";
            Event1.Text += "sender: " + sender.ToString() + "\n"+"source: " + e.Source.ToString() + "\n\n";
            Login.Text = "";
            Password.Text = "";
        }

        private void LogIn2_Click(object sender, MouseButtonEventArgs e) // tunneling (опускающиеся/туннельные)
        {
            Event1.Text = "";
            Event3.Text = "";
            Event2.Text += "sender: " + sender.ToString() + "\n" + "source: " + e.Source.ToString() + "\n\n";
            Login.Text = "";
            Password.Text = "";
        }

        private void LogIn3_Click(object sender, MouseButtonEventArgs e)   // direct (прямые)
        {
            Event1.Text = "";
            Event2.Text = "";
            Event3.Text += "sender: " + sender.ToString() + "\n" + "source: " + e.Source.ToString() + "\n\n";
            Login.Text = "";
            Password.Text = "";
        }
    }
    
}
