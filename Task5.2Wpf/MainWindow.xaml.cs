using Microsoft.Win32;
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
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task5._2Wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Color color = Colors.Black;

        private void Violet_Click(object sender, RoutedEventArgs e)
        {
            color = Colors.Violet;
            inkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            inkCanvas.DefaultDrawingAttributes.Color = color;

        }
        private void Black_Click(object sender, RoutedEventArgs e)
        {
            color = Colors.Black;
            inkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            inkCanvas.DefaultDrawingAttributes.Color = color;
        }

        private void Gray_Click(object sender, RoutedEventArgs e)
        {
            color = Colors.Gray;
            inkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            inkCanvas.DefaultDrawingAttributes.Color = color;
        }

        private void Red_Click(object sender, RoutedEventArgs e)
        {
            color = Colors.Red;
            inkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            inkCanvas.DefaultDrawingAttributes.Color = color;
        }

        private void Orange_Click(object sender, RoutedEventArgs e)
        {
            color = Colors.Orange;
            inkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            inkCanvas.DefaultDrawingAttributes.Color = color;
        }

        private void Yellow_Click(object sender, RoutedEventArgs e)
        {
            color = Colors.Yellow;
            inkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            inkCanvas.DefaultDrawingAttributes.Color = color;
        }

        private void Green_Click(object sender, RoutedEventArgs e)
        {
            color = Colors.Green;
            inkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            inkCanvas.DefaultDrawingAttributes.Color = color;
        }

        private void Blue_Click(object sender, RoutedEventArgs e)
        {
            color = Colors.Blue;
            inkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            inkCanvas.DefaultDrawingAttributes.Color = color;
        }


        private void Paint_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            inkCanvas.DefaultDrawingAttributes.Color = color;

        }

        private void Erase_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas.EditingMode = InkCanvasEditingMode.EraseByPoint;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Inkcanvas Format (*.sandy)|*.sandy|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                var fs = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate);
                StrokeCollection strokes = new StrokeCollection(fs);
                inkCanvas.Strokes = strokes;
            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "InkCanvas Format (*.sandy)|*.sandy|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == true)
            {
                FileStream fs = File.Open(saveFileDialog.FileName, FileMode.OpenOrCreate);
                inkCanvas.Strokes.Save(fs);
                fs.Close();
            }
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

