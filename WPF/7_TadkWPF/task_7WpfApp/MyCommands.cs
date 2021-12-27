using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace task_7WpfApp
{
    internal class MyCommands
    {
        public static RoutedCommand FontWeight { get; set; }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.FontWeight == FontWeights.Normal)
                textBox.FontWeight = FontWeights.Bold;
            else
                textBox.FontWeight = FontWeights.Normal;
        }        
    }
}
