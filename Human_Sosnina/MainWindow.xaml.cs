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
using System.Windows.Threading;

namespace Human_Sosnina
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MediaPlayer MediaPlayer = new MediaPlayer();

        private Classes.Russian Russian = new Classes.Russian("Александр", @"D:\хуйня\w\Human_Sosnina\Human_Sosnina\Images\ic_russian.png");

        private Classes.English English = new Classes.English("Alexander", @"D:\\хуйня\\w\\Human_Sosnina\\Human_Sosnina\\Images\\ic_english.png");


        private Elements.Item ItemRussian;
        private Elements.Item ItemEnglish;

        DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();


            ItemRussian = new Elements.Item(Russian);
            ItemEnglish = new Elements.Item(English);



            Parent.Children.Add(new Elements.Item(Russian));
            Parent.Children.Add(new Elements.Item(English));

            timer.Interval = TimeSpan.FromMilliseconds(2000);
            timer.Tick += Timer_Tick;

        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            Russian.Speak(ItemRussian.lText);

            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();

            English.Speak(ItemEnglish.lText);
        }
    }
}
