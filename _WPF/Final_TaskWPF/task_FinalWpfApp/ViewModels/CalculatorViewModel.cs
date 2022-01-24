using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;
using task_FinalWpfApp.Commands;
using task_FinalWpfApp.Models;

// 

namespace task_FinalWpfApp.ViewModels
{
    public class CalculatorViewModel : ViewModelBase // наследуем 
    {
        private Models.CalculatorModel calculation;

        private DelegateCommand<string> digitButtonPressCommand;
        private DelegateCommand<string> operationButtonPressCommand;        

        private string lastOperation;
        private bool newDisplayRequired = false;
        private string fullExpression;
        private string display;

        public CalculatorViewModel()
        {
            this.calculation = new CalculatorModel();
            this.display = "0";
            this.FirstOperand = string.Empty;
            this.SecondOperand = string.Empty;
            this.Operation = string.Empty;
            this.lastOperation = string.Empty;
            this.fullExpression = string.Empty;
        }

        public string FirstOperand
        {
            get => calculation.FirstOperand; 
            set { calculation.FirstOperand = value; }
        }

        public string SecondOperand
        {
            get => calculation.SecondOperand; 
            set { calculation.SecondOperand = value; }
        }

        public string Operation
        {
            get => calculation.Operation; 
            set { calculation.Operation = value; }
        }

        public string LastOperation
        {
            get => lastOperation; 
            set { lastOperation = value; }
        }

        public string Result
        {
            get => calculation.Result; 
        }

        public string Display
        {
            get => display; 
            set
            {
                display = value;
                OnPropertyChanged("Display");
            }
        }

        public string FullExpression
        {
            get => fullExpression; 
            set
            {
                fullExpression = value;
                OnPropertyChanged("FullExpression");
            }
        }

        public ICommand OperationButtonPressCommand
        {
            get
            {
                if (operationButtonPressCommand == null)
                {
                    operationButtonPressCommand = new DelegateCommand<string>(
                        OperationButtonPress, CanOperationButtonPress);
                }
                return operationButtonPressCommand;
            }
        }

        private static bool CanOperationButtonPress(string number)
        {
            return true;
        }

        //public ICommand SingularOperationButtonPressCommand
        //{
        //    get
        //    {
        //        if (singularOperationButtonPressCommand == null)
        //        {
        //            singularOperationButtonPressCommand = new DelegateCommand<string>(
        //                 SingularOperationButtonPress, CanSingularOperationButtonPress);
        //        }
        //        return singularOperationButtonPressCommand;
        //    }
        //}

        private static bool CanSingularOperationButtonPress(string number)
        {
            return true;
        }

        public ICommand DigitButtonPressCommand
        {
            get
            {
                if (digitButtonPressCommand == null)
                {
                    digitButtonPressCommand = new DelegateCommand<string>(
                        DigitButtonPress, CanDigitButtonPress);
                }
                return digitButtonPressCommand;
            }
        }

        private static bool CanDigitButtonPress(string button)
        {
            return true;
        }


        //deals with button inputs and sorts out the display accordingly
        public void DigitButtonPress(string button)
        {
            switch (button)
            {
                case "C":
                    Display = "0";
                    FirstOperand = string.Empty;
                    SecondOperand = string.Empty;
                    Operation = string.Empty;
                    LastOperation = string.Empty;
                    FullExpression = string.Empty;
                    break;
                case "Del":
                    if (display.Length > 1)
                        Display = display.Substring(0, display.Length - 1);
                    else Display = "0";
                    break;
                case "+/-":
                    if (display.Contains("-") || display == "0")
                    {
                        Display = display.Remove(display.IndexOf("-"), 1);
                    }
                    else Display = "-" + display;
                    break;
                case ".":
                    if (newDisplayRequired)
                    {
                        Display = "0.";
                    }
                    else
                    {
                        if (!display.Contains("."))
                        {
                            Display = display + ".";
                        }
                    }
                    break;
                default:
                    if (display == "0" || newDisplayRequired)
                        Display = button;
                    else
                        Display = display + button;
                    break;
            }
            newDisplayRequired = false;
        }

        //for operations with 2 operands
        public void OperationButtonPress(string operation)
        {
            try
            {
                if (FirstOperand == string.Empty || LastOperation == "=")
                {
                    FirstOperand = display;
                    LastOperation = operation;
                }
                else
                {
                    SecondOperand = display;
                    Operation = lastOperation;
                    calculation.CalculateResult();

                    FullExpression = Math.Round(Convert.ToDouble(FirstOperand), 10) + " " + Operation + " "
                                    + Math.Round(Convert.ToDouble(SecondOperand), 10) + " = "
                                    + Math.Round(Convert.ToDouble(Result), 10);

                    LastOperation = operation;
                    Display = Result;
                    FirstOperand = display;
                }
                newDisplayRequired = true;
            }
            catch (Exception ex)
            {
                Display = Result == string.Empty ? "Error - see event log" : Result;
                LogExceptionInformation(ex);
            }
        }

        ////for sin,cos,tan
        //public void SingularOperationButtonPress(string operation)
        //{
        //    try
        //    {
        //        FirstOperand = Display;
        //        Operation = operation;
        //        calculation.CalculateResult();

        //        FullExpression = Operation + "(" + Math.Round(Convert.ToDouble(FirstOperand), 10) + ") = "
        //            + Math.Round(Convert.ToDouble(Result), 10);

        //        LastOperation = "=";
        //        Display = Result;
        //        FirstOperand = display;
        //        newDisplayRequired = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        Display = Result == string.Empty ? "Error - see event log" : Result;
        //        LogExceptionInformation(ex);
        //    }
        //}

        //Write the full exception to the eventlog
        private static void LogExceptionInformation(Exception ex)
        {
            //Note: I commented out this bit because I was getting annoying Security exceptions
            //Note: but the idea was to throw exceptions from the Model to be caught and logged in the ViewModel

            //string source = "WPF Calculator";
            //string log = "Application";
            //string message = ex.ToString();

            //if (!EventLog.SourceExists(source))
            //    EventLog.CreateEventSource(source, log);

            //EventLog.WriteEntry(source, message, EventLogEntryType.Error);
        }
    }
}
