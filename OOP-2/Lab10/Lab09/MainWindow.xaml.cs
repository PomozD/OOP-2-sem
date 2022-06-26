using Lab09.Model;
using System;
using System.Linq;
using System.Windows;

namespace Lab09
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dgUsers.ItemsSource = null;
            dgActors.ItemsSource = null;
            dgUsers.ItemsSource = unitOfWork.Users.Get();
            dgActors.ItemsSource = unitOfWork.Actors.Get();
        }
        
        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            User user1 = null;
            if (txt_Name.Text.Length != 0 && txt_Role.Text.Length != 0)
            {
                user1 = new User { Name = txt_Name.Text };
                Actor actor1 = new Actor { Role = txt_Role.Text, User = user1 };
                unitOfWork.Actors.Create(actor1);
            }
            else { MessageBox.Show("Enter in all textboxes");}

            Window_Loaded(new object(), new RoutedEventArgs());
            txt_Role.Text = "";
            txt_Name.Text = "";

        }
        
        private void btn_find_Click(object sender, RoutedEventArgs e)
        {
            string str = "";
            if (txt_Role.Text.Length != 0)
            {
                try
                {
                    var actor = unitOfWork.Actors.Get(ac => ac.Role == txt_Role.Text);
                    Actor[] el = new Actor[actor.Count()];
                    int i = 0;
                    foreach (Actor act in actor)
                    {
                        el[i] = unitOfWork.Actors.FindById(act.Id);
                        str += el[i].Id + " " + el[i].Role + " " + el[i].User.Name + "\n";
                        i++;
                    }
                    MessageBox.Show(str);
                }
                catch
                {
                    MessageBox.Show("Not found");
                }

            }
            if (txt_Name.Text.Length != 0)
            {
                try
                {
                    var user = unitOfWork.Users.Get(ac => ac.Name == txt_Name.Text);
                    User[] el = new User[user.Count()];
                    int i = 0;
                    foreach (User us in user)
                    {
                        el[i] = unitOfWork.Users.FindById(us.Id);
                        str += el[i].Id + " " + el[i].Name + "\n";
                        i++;
                    }
                    MessageBox.Show(str);
                }
                catch
                {
                    MessageBox.Show("Not found");
                }
            }
            txt_Role.Text = "";
            txt_Name.Text = "";
        }

        private void btn_update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dgActors.SelectedItems.Count > 0)
                {
                    for (int i = 0; i < dgActors.SelectedItems.Count; i++)
                    {
                        Actor actor = dgActors.SelectedItems[i] as Actor;
                        int id = actor.Id;
                        if (actor != null)
                        {
                            Actor a = unitOfWork.Actors.FindById(id);
                            a.Role = txt_Role.Text;
                            unitOfWork.Actors.Update(a);
                        }
                    }
                }
                if (dgUsers.SelectedItems.Count > 0)
                {
                    for (int i = 0; i < dgUsers.SelectedItems.Count; i++)
                    {
                        User user = dgUsers.SelectedItems[i] as User;
                        int id = user.Id;
                        if (user != null)
                        {
                            User u = unitOfWork.Users.FindById(id);
                            u.Name = txt_Name.Text;
                            unitOfWork.Users.Update(u);
                        }
                    }
                }
                Window_Loaded(new object(), new RoutedEventArgs());
                txt_Role.Text = "";
                txt_Name.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_del_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dgActors.SelectedItems.Count > 0)
                {
                    for (int i = 0; i < dgActors.SelectedItems.Count; i++)
                    {
                        Actor actor = dgActors.SelectedItems[i] as Actor;
                        int id = actor.Id;
                        Actor a = unitOfWork.Actors.FindById(id);
                        unitOfWork.Actors.Remove(a);
                    }
                }

                if (dgUsers.SelectedItems.Count > 0)
                {
                    for (int i = 0; i < dgUsers.SelectedItems.Count; i++)
                    {
                        User user = dgUsers.SelectedItems[i] as User;
                        int id = user.Id;
                        User u = unitOfWork.Users.FindById(id);
                        unitOfWork.Users.Remove(u);
                    }
                }
                Window_Loaded(new object(), new RoutedEventArgs());
                txt_Role.Text = "";
                txt_Name.Text = "";
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_transact_Click(object sender, RoutedEventArgs e)
        {
            using (var transaction = unitOfWork.Users.Transaction())
            {
                try
                {
                    User user = unitOfWork.Users.Get(p => p.Name == "Daniil").Single();
                    MessageBox.Show(user.Name);
                    txt_Role.Text = "tran";
                    txt_Name.Text = "saction";
                    transaction.Commit();
                }
                catch
                {
                    MessageBox.Show("rollback");
                    transaction.Rollback();
                }
            }

        }
    }
}
