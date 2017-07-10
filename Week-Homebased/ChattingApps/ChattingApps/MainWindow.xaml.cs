using ChattingInterfaces;
using System.ServiceModel;
using System.Windows;
using System.Collections.Generic;

namespace ChattingApps
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static IChattingService Server;
        public static DuplexChannelFactory<IChattingService> _channelFactory;
        public MainWindow()
        {
            InitializeComponent();
            _channelFactory = new DuplexChannelFactory<IChattingService>(new ClientCallback(), "ChattingServiceEndPoint");
            Server = _channelFactory.CreateChannel();           

        }

        public void TakeMessage(string message, string username)
        {
            TextDisplayTextbox.Text += username + ": " + message + "\n";
            TextDisplayTextbox.ScrollToEnd();
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageTextbox.Text.Length == 0)
            {
                return;
            }
            Server.SendMessageToAll(MessageTextbox.Text, UsernameTextbox.Text);
            TakeMessage(MessageTextbox.Text, "You");
            MessageTextbox.Text = "";
            
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            WelcomeLabel.Content = "Welcome " + UsernameTextbox.Text + "!";
            int returnValue = Server.Login(UsernameTextbox.Text);
            if(returnValue==1)
            {
                MessageBox.Show("You are already Logged in. Try Again");
           }
            else if( returnValue == 0)
            {
                
                MessageBox.Show("You Logged in!");
                UsernameTextbox.IsEnabled = false;
                LoginButton.IsEnabled = false;

                LoadUserList(Server.GetCurrentUsers());

            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Server.Logout();
        }

        //Testing purpose
        //private void button_Click(object sender, RoutedEventArgs e)
        //{
        //    Server.Test("Hello World!");
        //}

        public void AddUserToList(string userName)
        {
            if (UserlistBox.Items.Contains(userName))
            {
                return;
            }
            UserlistBox.Items.Add(userName);
        }

        public void RemoveUserFromList(string userName)
        {
            if (UserlistBox.Items.Contains(userName))
            {
                UserlistBox.Items.Remove(userName);
            }
            
        }

        public void LoadUserList(List<string> users)
        {
            foreach(var user in users)
            {
                AddUserToList(user);
            }
        }
    }
}
