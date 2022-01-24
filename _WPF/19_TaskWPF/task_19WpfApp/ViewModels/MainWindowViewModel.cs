using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using task_19WpfApp.Models;

namespace task_19WpfApp.ViewModels
{
    // реализуем VM. Чтобы наша VM «автоматически» обновляла View //

    class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        //public RelayCommand NumberCommand { get; set; }

        void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        #region Свойства

        //private int _Number1;
        //public int Number1
        //{
        //    get => _Number1; // возвращаем начение закрытого поля
        //    set
        //    {
        //        _Number1 = value; // присваем закрытому полю value, которое передали
        //        OnPropertyChanged();
        //    }
        //}

        //private int _Number2;
        //public int Number2
        //{
        //    get => _Number2;
        //    set
        //    {
        //        _Number2 = value;
        //        OnPropertyChanged();
        //    }
        //}



        private string _Display;
        public string Display
        {
            get => _Display;
            set
            {
                _Display = value;
                OnPropertyChanged();
            }
        }
        #endregion        

        #region Команды

        #region Сложение
        public ICommand PlusCommand { get; }
        private void OnPlusCommandExecute(object p)
        {
            Display += "+";
        }
        private bool CanPlusCommandExecuted(object p)
        {
            return true;
        }
        #endregion

        #region Вычитание
        public ICommand MinusCommand { get; }
        private void OnMinusCommandExecute(object p)
        {
            Display += "-";
        }
        private bool CanMinusCommandExecuted(object p)
        {
            return true;
        }
        #endregion

        #region Умножение
        public ICommand MultiplyCommand { get; }
        private void OnMultiplyCommandExecute(object p)
        {
            Display += "*";
        }
        private bool CanMultiplyCommandExecuted(object p)
        {
            return true;
        }
        #endregion

        #region Деление
        public ICommand DivideCommand { get; }
        private void OnDivideCommandExecute(object p)
        {
            Display += "/";
        }
        private bool CanDivideCommandExecuted(object p)
        {
            return true;
        }
        #endregion

        #region Удаление по одному символу из дисплея
        public ICommand DelitCommand { get; }
        private void OnDelitCommandExecute(object p)
        {
            if (Display.Length > 1)
                Display = Display.Substring(0, Display.Length - 1);
            else Display = ""; // не забываем про заглавные буквы !!!!
        }
        private bool CanDelitCommandExecuted(object p)
        {
            return true;
        }
        #endregion

        #region Кнопка точка
        public ICommand DotCommand { get; }
        private void OnDotCommandCommandExecute(object p)
        {
            Display += ".";
        }
        private bool CanDotCommandCommandExecuted(object p)
        {
            return true;
        }
        #endregion

        #region Кнопки_Цифры

        #region Кнопка_1
        public ICommand Btn_1_Command { get; }
        private void OnBtn_1_CommandExecute(object p)
        {
            Display += 1;
        }
        private bool CanBtn_1_CommandExecuted(object p)
        {
            return true;
        }
        #endregion
        #region Кнопка_2
        public ICommand Btn_2_Command { get; }
        private void OnBtn_2_CommandExecute(object p)
        {
            Display += 2;
        }
        private bool CanBtn_2_CommandExecuted(object p)
        {
            return true;
        }
        #endregion
        #region Кнопка_3
        public ICommand Btn_3_Command { get; }
        private void OnBtn_3_CommandExecute(object p)
        {
            Display += 3;
        }
        private bool CanBtn_3_CommandExecuted(object p)
        {
            return true;
        }
        #endregion
        #region Кнопка_4
        public ICommand Btn_4_Command { get; }
        private void OnBtn_4_CommandExecute(object p)
        {
            Display += 4;
        }
        private bool CanBtn_4_CommandExecuted(object p)
        {
            return true;
        }
        #endregion
        #region Кнопка_5
        public ICommand Btn_5_Command { get; }
        private void OnBtn_5_CommandExecute(object p)
        {
            Display += 5;
        }
        private bool CanBtn_5_CommandExecuted(object p)
        {
            return true;
        }
        #endregion
        #region Кнопка_6
        public ICommand Btn_6_Command { get; }
        private void OnBtn_6_CommandExecute(object p)
        {
            Display += 6;
        }
        private bool CanBtn_6_CommandExecuted(object p)
        {
            return true;
        }
        #endregion
        #region Кнопка_7
        public ICommand Btn_7_Command { get; }
        private void OnBtn_7_CommandExecute(object p)
        {
            Display += 7;
        }
        private bool CanBtn_7_CommandExecuted(object p)
        {
            return true;
        }
        #endregion
        #region Кнопка_8
        public ICommand Btn_8_Command
        {
            get;
        }
        private void OnBtn_8_CommandExecute(object p)
        {
            Display += 8;
        }
        private bool CanBtn_8_CommandExecuted(object p)
        {
            return true;
        }
        #endregion
        #region Кнопка_9
        public ICommand Btn_9_Command { get; }
        private void OnBtn_9_CommandExecute(object p)
        {
            Display += 9;
        }
        private bool CanBtn_9_CommandExecuted(object p)
        {
            return true;
        }
        #endregion
        #region Кнопка_0
        public ICommand Btn_0_Command { get; }
        private void OnBtn_0_CommandExecute(object p)
        {
            Display += 0;
        }
        private bool CanBtn_0_CommandExecuted(object p)
        {
            return true;
        }
        #endregion
        #endregion

        #region Результат
        public ICommand RezultCommand { get; }
        private void OnRezultCommandCommandExecute(object p)
        {
            Display = Convert.ToString(new DataTable().Compute(Display,""));
        }
        private bool CanRezultCommandCommandExecuted(object p)
        {
            return true;
        }
        #endregion

        #region AC
        public ICommand AcCommand { get; }
        private void OnAcCommandCommandExecute(object p)
        {
            Display = null;
        }
        private bool CanAcCommandCommandExecuted(object p)
        {
            return true;
        }
        #endregion

        #endregion

        public MainWindowViewModel()
        {
            // создаем команды внитри конструктора

            #region Команды
            // создаем объект команды
            DelitCommand = new RelayCommand(OnDelitCommandExecute, CanDelitCommandExecuted); // удаление по одному символу из дисплея
            PlusCommand = new RelayCommand(OnPlusCommandExecute, CanPlusCommandExecuted);
            MinusCommand = new RelayCommand(OnMinusCommandExecute, CanMinusCommandExecuted);
            MultiplyCommand = new RelayCommand(OnMultiplyCommandExecute, CanMultiplyCommandExecuted);
            DivideCommand = new RelayCommand(OnDivideCommandExecute, CanDivideCommandExecuted);
            Btn_1_Command = new RelayCommand(OnBtn_1_CommandExecute, CanBtn_1_CommandExecuted);
            Btn_2_Command = new RelayCommand(OnBtn_2_CommandExecute, CanBtn_2_CommandExecuted);
            Btn_3_Command = new RelayCommand(OnBtn_3_CommandExecute, CanBtn_3_CommandExecuted);
            Btn_4_Command = new RelayCommand(OnBtn_4_CommandExecute, CanBtn_4_CommandExecuted);
            Btn_5_Command = new RelayCommand(OnBtn_5_CommandExecute, CanBtn_5_CommandExecuted);
            Btn_6_Command = new RelayCommand(OnBtn_6_CommandExecute, CanBtn_6_CommandExecuted);
            Btn_7_Command = new RelayCommand(OnBtn_7_CommandExecute, CanBtn_7_CommandExecuted);
            Btn_8_Command = new RelayCommand(OnBtn_8_CommandExecute, CanBtn_8_CommandExecuted);
            Btn_9_Command = new RelayCommand(OnBtn_9_CommandExecute, CanBtn_9_CommandExecuted);
            Btn_0_Command = new RelayCommand(OnBtn_0_CommandExecute, CanBtn_0_CommandExecuted);
            RezultCommand = new RelayCommand(OnRezultCommandCommandExecute, CanRezultCommandCommandExecuted);
            AcCommand = new RelayCommand(OnAcCommandCommandExecute, CanAcCommandCommandExecuted);
            DotCommand = new RelayCommand(OnDotCommandCommandExecute, CanDotCommandCommandExecuted);
            #endregion
        }

    }
}
