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

namespace AppDataFolderTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly string FilePath =
            System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Test", "test.txt");
        private static readonly string FolderPath =
            System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Test");

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Directory.Exists(FolderPath) == false)
            {
                Directory.CreateDirectory(FolderPath);
            }
            using (var stream = new FileStream(FilePath, FileMode.Create))
            {
                
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textBoxFiles.Clear();
            foreach (var fileName in Directory.GetFiles(FolderPath))
            {
                textBoxFiles.Text += fileName + "\n";
            }
        }
    }
}
