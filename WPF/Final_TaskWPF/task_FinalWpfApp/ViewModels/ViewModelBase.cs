using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

//реализуем VM.Чтобы наша VM «автоматически» обновляла View, 
//    требуется реализовать интерфейс INotifyPropertyChange. 
//    Именно посредством него View получает уведомления, 
//    что во VM что-то изменилось и требуется обновить данные.

namespace task_FinalWpfApp.ViewModels
{

    //Делается это следующим образом:

    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
