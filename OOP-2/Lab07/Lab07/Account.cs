using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lab07
{
    public class Account : DependencyObject
    {
        public static readonly DependencyProperty UserNameProperty;
        public static readonly DependencyProperty PasswordProperty;

        static Account()
        {
            FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata();
            metadata.CoerceValueCallback = new CoerceValueCallback(CorrectValue);

            UserNameProperty = DependencyProperty.Register("UserName", typeof(string), typeof(Account));
            PasswordProperty = DependencyProperty.Register("Password", typeof(int), typeof(Account),
                metadata, new ValidateValueCallback(ValidateValue));
        }
        private static object CorrectValue(DependencyObject d, object baseValue)
        {
            int currentValue = (int)baseValue;
            if (currentValue > 9999999 || currentValue < 9999)  // если больше 1000, возвращаем 1000
                return 123456789;
            return currentValue; // иначе возвращаем текущее значение
        }
        private static bool ValidateValue(object value)
        {
            int currentValue = (int)value;
            if (currentValue >= 0)
                return true;
            return false;
        }

        public string UserName
        {
            get { return (string)GetValue(UserNameProperty); }
            set { SetValue(UserNameProperty, value); }
        }
        public int Password
        {
            get { return (int)GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value); }
        }
    }
}
