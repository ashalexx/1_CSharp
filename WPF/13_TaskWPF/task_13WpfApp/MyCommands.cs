using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace task_9WpfApp
{
    internal class MyCommands
    {
        public static RoutedCommand B { get; set; }
        public static RoutedCommand I { get; set; }
        public static RoutedCommand U { get; set; }
        public static RoutedCommand Foreground1 { get; set; }
        public static RoutedCommand Foreground2 { get; set; }

        static MyCommands()
        {
            B = new RoutedCommand();
            I = new RoutedCommand();
            U = new RoutedCommand();
            Foreground1 = new RoutedCommand();
            Foreground2 = new RoutedCommand();
        }

    }
}