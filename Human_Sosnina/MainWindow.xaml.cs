using System;
using System.Collections.Generic;
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

namespace Human_Sosnina
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MediaPlayer MediaPlayer = new MediaPlayer();

        private Classes.Russian Russian = new Classes.Russian("Александр", @"D:\хуйня\w\Human_Sosnina\Human_Sosnina\Images\ic_russian.png");

        public MainWindow()
        {
            InitializeComponent();
            Parent.Children.Add(new Elements.Item(Russian));
        }
    }
}
