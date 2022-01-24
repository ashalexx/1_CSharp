﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace task_9WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<string> style = new List<string>() { "Светлая тема", "Темная тема" };           
            Box.ItemsSource = style;
            Box.SelectionChanged += ThemeChange;
            Box.SelectedIndex = 0;
            
        }

        private void ThemeChange(object sender, SelectionChangedEventArgs e)
        {
            int styleIndex = Box.SelectedIndex;
            // определяем путь к файлу ресурсов
            Uri uri = new Uri("Light.xaml", UriKind.Relative);
            if(styleIndex == 1)
            {
                uri = new Uri("Dark.xaml", UriKind.Relative);
            }
            // загружаем словарь ресурсов
            ResourceDictionary resource = Application.LoadComponent(uri) as ResourceDictionary;
            // очищаем коллекцию ресурсов приложения
            Application.Current.Resources.Clear();
            // добавляем загруженный словарь ресурсов
            Application.Current.Resources.MergedDictionaries.Add(resource);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fountName = (sender as ComboBox).SelectedItem as string;
            if (textBox != null)
            {
                textBox.FontFamily = new FontFamily(fountName);
            }
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            string fount = (sender as ComboBox).SelectedItem as string;
            if (textBox != null)
            {
                textBox.FontSize = Convert.ToDouble(fount);
            }
        }
        private void BExecuted(object sender, RoutedEventArgs e)
        {
            if (textBox.FontWeight == FontWeights.Normal)
                textBox.FontWeight = FontWeights.Bold;
            else
                textBox.FontWeight = FontWeights.Normal;
        }

        private void IExecuted(object sender, RoutedEventArgs e)
        {
            if (textBox.FontStyle == FontStyles.Normal)
                textBox.FontStyle = FontStyles.Italic;
            else
                textBox.FontStyle = FontStyles.Normal;
        }

        private void UExecuted(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
                if (textBox.TextDecorations != TextDecorations.Baseline)
                    textBox.TextDecorations = TextDecorations.Baseline;
                else
                    textBox.TextDecorations = null;
        }
        private void Foreground1Executed(object sender, RoutedEventArgs e)
        {
            if (textBox != null)                
                textBox.Foreground = new SolidColorBrush(Colors.Black);            
        }

        private void Foreground2Executed(object sender, RoutedEventArgs e)
        {
            if (textBox != null)                
                textBox.Foreground = new SolidColorBrush(Colors.Red);            
        }

        private void OpenExecuted(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовый файл(*.txt)|*.txt|Все файлы(*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
                textBox.Text = File.ReadAllText(openFileDialog.FileName);
        }

        private void SaveExecuted(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовый файл(*.txt)|*.txt|Все файлы(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, textBox.Text);
        }

        private void ExitExecuted(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
