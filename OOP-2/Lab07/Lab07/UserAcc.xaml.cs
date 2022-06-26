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
    /// Логика взаимодействия для UserAcc.xaml
    /// </summary>
    public partial class UserAcc : UserControl
    {
        public UserAcc()
        {
            InitializeComponent();
        }
        public ImageSource userImage
        {
            get { return UserImage.Source; }
            set { UserImage.Source = value; }
        }
        public string userName
        {
            get { return UserName.Text; }
            set { UserName.Text = value; }
        }
        public string userTitle
        {
            get { return UserTitle.Text; }
            set { UserTitle.Text = value; }
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Чтобы зайти на чужой аккаунт, Вам нужно авторизоваться!", "Но-но-но");
        }
    }

    public class CustomCommand
    {
        private static RoutedUICommand newCommand;
        static CustomCommand()
        {
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.P, ModifierKeys.Control, "Ctrl + P"));
            newCommand = new RoutedUICommand("NeW", "NeW", typeof(CustomCommand), inputs);
        }
        public static RoutedUICommand NewCommand
        {
            get { return newCommand; }
        }
    }
}

