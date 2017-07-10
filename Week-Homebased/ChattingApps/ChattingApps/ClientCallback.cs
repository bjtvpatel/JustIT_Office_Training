using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ChattingInterfaces;
using System.Windows;

namespace ChattingApps
{
    [CallbackBehavior(ConcurrencyMode=ConcurrencyMode.Multiple)]
    class ClientCallback:IClient
    {
        //public  void PlaceHolder()
        // {
        //     throw new NotImplementedException();
        // }


        public void  GetMessage(string message, string userName)
        {
            ((MainWindow)(Application.Current.MainWindow)).TakeMessage(message, userName);

        }

        public void GetUpdate(int value, string userName)
        {
            switch(value)
            { 
                case 0:
                ((MainWindow)Application.Current.MainWindow).AddUserToList(userName);
                break;

                case 1:
                ((MainWindow)Application.Current.MainWindow).RemoveUserFromList(userName);
                break;
            
            }

        }
    }
}
