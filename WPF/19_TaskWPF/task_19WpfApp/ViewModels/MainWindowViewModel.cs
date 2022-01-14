using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using task_19WpfApp.Models;

namespace task_19WpfApp.ViewModels
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        private int number1;
        public int Number1
        {
            get => number1; // возвращаем начение закрытого поля
            set
            {
                number1 = value; // присваем закрытому полю value, которое передали
                OnPropertyChanged();
            }
        }

        private double number3;
        public double Number3
        {
            get => number3; // возвращаем начение закрытого поля
            set
            {
                number3 = value; // присваем закрытому полю value, которое передали
                OnPropertyChanged();
            }
        }

        public ICommand AddCommand { get; }
        private void OnAddCommandExecute(object p)
        {
            Number3 = Ariph.Add(Number1);
        }
        private bool CanAddCommandExecuted(object p)
        {
            if (Number1 != 0)
                return true;
            else
                return false;
        }
        public MainWindowViewModel()
        {
            AddCommand = new RelayCommand(OnAddCommandExecute, CanAddCommandExecuted);
        }
    }
}
